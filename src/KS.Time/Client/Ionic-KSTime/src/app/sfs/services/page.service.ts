import { Injectable } from '@angular/core';
import { HttpService, DataService, EntityWrapper, ApiResponse, ServiceData, IGeoData, TableColumn } from 'sfscommon';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { ServiceDataOptions } from './sfs.service';
import { SeparatorSettings, FieldSettings, ControlTypes, FieldTypes } from '../models/common/page.model';
import { bizAppService } from './business.service';
import { table } from 'console';
@Injectable({ providedIn: 'root' })
export class PageService {
  constructor(public http: HttpService, public dataService: DataService, public bizAppService: bizAppService) {
    //this.url = http.generateUrl();
  }
  temp: Array<FormlyFieldConfig> = null;
  fieldsBack: Array<FormlyFieldConfig> = null;

  private colsSum = 0;
  public isFilter: boolean = false;
  public isFilterRange: boolean = false;
  rowGroup: Array<FormlyFieldConfig> = null
  setSeparator(settings: SeparatorSettings, fields: Array<FormlyFieldConfig>) {
    if (this.fieldsBack == null) {
      this.fieldsBack = fields;
    }
    if (this.temp == null) {
      this.temp = new Array<FormlyFieldConfig>();
    }
    this.temp.push({ template: settings.Content });
  }
  public async addRelatedData(settings: FieldSettings, field: FormlyFieldConfig) {
    //
    let serviceData: ServiceDataOptions = { EntityModel: settings.EntityModel, Fields: `${settings.DataValue},${settings.DataText}` };
    if (settings.DataQuery != null) {
      serviceData.Query = settings.DataQuery;
    }
    if (settings.Data == null) {
      let response = await this.bizAppService.Get(serviceData);
      if (response.isSuccess() == true) {
        settings.Data = response.data;
      }


    } else {
      // settings.Data 
      if (settings.Data != null && Array.isArray(settings.Data) && (settings.DataValue == null && settings.DataText == null)) {
        // data si hay, pero no propiedades
        field.templateOptions.options = settings.Data;
        let dataArray: Array<any> = [];
        for (let index = 0; index < settings.Data.length; index++) {
          const element = settings.Data[index];
          dataArray.push({ value: element, text: element });
        }

        settings.Data = dataArray;
        settings.DataValue = "value";
        settings.DataText = "text";
      } else {
        // hay datos y propiedades

      }

    }

    field.templateOptions.options = settings.Data;
    field.templateOptions.valueProp = settings.DataValue;
    field.templateOptions.labelProp = settings.DataText;



  }
  visibleFields: Array<string> = [];
  propertyChanges: Array<string> = [];
  propertiesForUpdate: Array<string> = [];

  private setOrderForRange(settings: FieldSettings, fieldName: string, fields: Array<FormlyFieldConfig>) {
    //this.setOrder(settings, fields, true);

    // agregar dos nuevos campos
    // start


    let field = fields.find(p => p.key == fieldName);
    if (settings.Label == null) {
      settings.Label = settings.Name;
    }
    this.setOrder({
      Content: settings.Label, Columns: 12
    }, fields, true);

    let startField = JSON.parse(JSON.stringify(field));  //Object.assign({}, field);
    let startSettings: FieldSettings = JSON.parse(JSON.stringify(settings));//Object.assign({}, settings);
    startField.key = "__start" + startField.key;
    if (startField.templateOptions != null) {
      startField.templateOptions.label = "Desde";

    }
    this.fieldsBack.push(startField);
    //startSettings.PlaceHolder = startSettings.PlaceHolder + " (from)";
    startSettings.Columns = 6;
    startSettings.Name = startField.key;
    startSettings.Label = "Desde";
    this.setOrder(startSettings, fields, true);

    // end
    let endField = JSON.parse(JSON.stringify(field));
    let endSettings: FieldSettings = JSON.parse(JSON.stringify(settings));
    endField.key = "__end" + endField.key;
    if (endField.templateOptions != null) {
      endField.templateOptions.label = "Hasta";
      // endField.expressionProperties = { 'templateOptions.datepickerOptions.min': 'model.__startDueDate', };
    }
    this.fieldsBack.push(endField);
    //endSettings.PlaceHolder = endSettings.PlaceHolder + " (to)";
    endSettings.Name = endField.key;
    // endSettings.ExpressionProperties = { 'templateOptions.datepickerOptions.min': 'model.__startDueDate', };
    endSettings.Label = "Hasta";
    endSettings.Columns = 6;
    this.setOrder(endSettings, fields, true);
  }
  setOrder(settings: FieldSettings, fields: Array<FormlyFieldConfig>, preventFilterSettings?: boolean) {

    let addField: boolean = true;
    if (preventFilterSettings != true) {
      if (this.isFilter == true && this.isFilterRange == true) {


        const fieldFinded = this.fieldsBack.find(p => p.key == settings.Name);
        if (fieldFinded.templateOptions != null) {
          fieldFinded.templateOptions.required = false;
        }


        if ((fieldFinded.templateOptions != null &&
          fieldFinded.templateOptions.type == "number"
        ) || fieldFinded.type == "datepicker"

        ) {
          addField = false;
          this.setOrderForRange(settings, fieldFinded.key, this.fieldsBack);

        }

      }
    }

    if (addField == true) {
      if (settings.Id == null) {
        settings.Id = settings.Name;
      }

      //console.log("currentMediaQuery: ", this.currentMediaQuery);

      if (window.innerWidth < 570) {
        if (this.isFilter == false || (this.isFilter == true && !settings.Name?.startsWith("__start") && !settings.Name?.startsWith("__end"))) {
          settings.Columns = 12;
        }
      }


      // verificar si termina una fila
      // si el colsSum anterior es menor a 12, se entiende que sí

      let isMultiColumn = false;
      if (this.colsSum >= 12) {
        this.colsSum = 0;
      }
      if (settings.Columns != null && settings.Columns != 12) {
        this.colsSum = this.colsSum + settings.Columns;
        // let futureCols = this.colsSum +  settings.Columns;
        // if (futureCols <= 12){

        // }
        if (this.colsSum < 12 && this.rowGroup == null) {
          this.rowGroup = new Array<FormlyFieldConfig>();
        }
      } else {
        settings.Columns = 12;
        this.colsSum = 12;
        //if (this.colsSum == 12){
        this.rowGroup = new Array<FormlyFieldConfig>();
        //}
      }

      if (this.rowGroup == null) {
        this.rowGroup = new Array<FormlyFieldConfig>();
      }
      if (this.fieldsBack == null) {
        this.fieldsBack = settings.Fields == null ? fields : settings.Fields;
      }

      if (this.temp == null) {
        this.temp = new Array<FormlyFieldConfig>();
      }



      if (settings.Name != null) {
        //propertiesForUpdate
        this.visibleFields.push(settings.Name);
        this.propertiesForUpdate.push(settings.Name);
        let finded = this.fieldsBack.find(p => p.key == settings.Name);
        if (finded != null) {
          this.applySettingsField(settings, finded);
          //this.temp.push(finded);
          this.rowGroup.push(finded);
        }
      } else {
        let field: FormlyFieldConfig = { className: '', template: settings.Content };
        this.applySettingsField(settings, field);
        this.rowGroup.push(field);
      }

      if (this.colsSum == 12) {
        let classNames = "";
        if (settings.ClassNameGroup != null) {
          classNames = settings.ClassNameGroup;
        }
        this.temp.push({ fieldGroupClassName: 'row ' + classNames, fieldGroup: this.rowGroup });
        this.rowGroup = null;
      }
    }
  }

  public showForm(fields: Array<FormlyFieldConfig>): Array<any> {
    //this.propertiesForUpdate. = this.visibleFields;

    if (this.temp == null) {
      //this.temp = this.fieldsBack;

      if (this.fieldsBack != null) {
        this.fieldsBack.forEach(element => {
          this.setOrder({ Name: element.key, Columns: 12 }, fields);
        });
      }
    }

    if (this.temp != null) {
      fields = this.temp;
      fields["type"] = "flex-layout";
      fields["templateOptions"] = {
        fxLayout: 'row',
      };
    }


    return fields;
  }
  public resetFieldsForm(fields: Array<FormlyFieldConfig>): Array<any> {
    this.temp = null;
    this.colsSum = 0;
    if (this.fieldsBack != null) {
      fields = this.fieldsBack;
    }
    return fields;
  }

  public getFieldsForm(fields: Array<FormlyFieldConfig>) {
    if (this.rowGroup != null && this.temp != null) {
      this.temp.push({ fieldGroupClassName: 'row', fieldGroup: this.rowGroup });
      this.rowGroup = null;
    }
    if (this.temp != null) {
      fields = this.temp;
      fields["type"] = "flex-layout";
      fields["templateOptions"] = {
        fxLayout: 'row',
      };
    }

    return fields;
  }
  private applySettingsField(settings: FieldSettings, field: FormlyFieldConfig) {
    if (settings.Columns != null) {
      field.className = field.className + " col-" + settings.Columns;
    }
    if (settings.ClassName != null) {
      field.className = field.className + " " + settings.ClassName;
    }

    if (settings.ControlType == ControlTypes.Custom) {
      field.type = settings.CustomControl;
      field["templateOptions"] = null;

    } else {

      if (settings.ControlType != null) {
        if (settings.ControlType == ControlTypes.Checkbox) {
          field.type = "checkbox";
        } else {
          field.type = settings.ControlType.toString();

          //console.log("number xsz" , field.type);
        }

      }

      if (settings.TemplateOptions != null) {

        field["templateOptions"] = settings.TemplateOptions;

      } else {

        if (field["templateOptions"] == null) {
          field["templateOptions"] = {};
        }
        if (settings.Label != null) {
          field["templateOptions"]["label"] = settings.Label;
        }
        if (settings.Type != null) {
          if (settings.Type == FieldTypes.Password) {
            field["templateOptions"]["type"] = "password";
          } else if (settings.Type == FieldTypes.Time) {
            field["templateOptions"]["type"] = "time";
          } else if (settings.Type == FieldTypes.Number) {
            field["templateOptions"]["type"] = "number";

          }

        }

        if (field["templateOptions"]["type"] == "number") {
          if (settings.Min != null) {
            field["templateOptions"]["min"] = settings.Min;
          }
          if (settings.Max != null) {
            field["templateOptions"]["max"] = settings.Max;
          }

        }

        if (field.type == "datepicker") {
          field["templateOptions"]["type"] = "text";
        }
        if (settings.OnChange != null) {
          field["templateOptions"]["change"] = settings.OnChange;
        }
        if (settings.OnKeyUp != null) {
          field["templateOptions"]["keyup"] = settings.OnKeyUp;
        }
        if (settings.LabelHtml != null) {
          field["templateOptions"]["labelHtml"] = [settings.LabelHtml];
        }
        if (settings.ReadOnly != null)
          field["templateOptions"]["readonly"] = settings.ReadOnly;

        if (settings.MinLength != null) {
          field["templateOptions"]["minLength"] = settings.MinLength;
        }
      }
      if (settings.IsMultiLine == true) {
        field.type = "textarea";
      }
      if (settings.PlaceHolder != null) {
        field.templateOptions.placeholder = settings.PlaceHolder;

      }
      if (settings.Required != null && this.isFilter == false) {
        field.templateOptions.required = settings.Required;
      }



      if (settings.ExpressionProperties != null) {
        field["expressionProperties"] = settings.ExpressionProperties;
      }
      if (settings.HideExpression != null) {
        field["hideExpression"] = settings.HideExpression;
      }


      if (settings.Validators != null) {
        field["validators"] = settings.Validators;
      }
      if (settings.Hooks != null) {
        field["hooks"] = settings.Hooks;
      }
      if (settings.AsyncValidators != null) {
        field["asyncValidators"] = settings.AsyncValidators;
      }
      if (settings.EntityModel != null || (settings.Data != null)) {
        field.type = "select";
        this.addRelatedData(settings, field);
      } else {
        if (field.templateOptions != null && field.templateOptions["relation"] != null) {

          settings.EntityModel = field.templateOptions["relation"].EntityModel;
          if (settings.DataValue == null) {
            settings.DataValue = field.templateOptions["relation"].DataValue;
          }
          if (settings.DataText == null) {
            settings.DataText = field.templateOptions["relation"].DataText;
          }
          this.addRelatedData(settings, field);


        }
      }

    }

    if (settings.Wrapper != null) {
      field["wrappers"] = [settings.Wrapper];
    }
  }
  setOrderFields(fieldNames: Array<string>, fields: Array<FormlyFieldConfig>) {
    let temp: Array<FormlyFieldConfig> = [];

    fieldNames.forEach(element => {
      let finded = fields.find(p => p.name == element);

      temp.push()
    });

  }
  public getPrimaryColumn(tableColumns: Array<any>, defaultProperty?: string): any {
    let result = tableColumns[0];
    if (defaultProperty != null) {
      result = tableColumns.find(p => p.prop == defaultProperty);
    }
    return result;
  }
  public getValueColumn(tableColumns: Array<any>, valueColumn: string): any {

    let result = null;

    result = tableColumns.find(p => p.prop == valueColumn);
    return result;
  }

  private getDateValue(date:Date, startOrEnd?:string){
    let result:Array<string> = [];
    result.push("Date(");
    result.push(date.getFullYear().toString()+ ",");

    result.push((date.getMonth() + 1).toString() + ",");
    if (startOrEnd ==null || startOrEnd == "start"){
      result.push(date.getDate().toString() + ",0,0,0");
    }else{
      result.push(date.getDate().toString() + ",23,59,59");
    }
    result.push(")");

    return result.join("");
  }
  public getQueryFilter(itemFilter: any, fields?: Array<FormlyFieldConfig>, withRange?:boolean) {
    let queryBuilder: Array<string> = [];

    // Asegurarse que las propiedades simples existen
    for (const prop in itemFilter) {
      if (prop.startsWith("__start") || prop.startsWith("__end")){
        itemFilter[prop.replace("__start","").replace("__end", "")] = null ;
      }
    }

    for (const prop in itemFilter) {
      if (prop != "IsDeleted" &&
      (!prop.startsWith("__start") && !prop.startsWith("__end"))
      ) {
        let fieldFinded:FormlyFieldConfig = fields.find(p=> p.key == prop);
        let fieldType:string;
        if (fieldFinded.type.indexOf("date") != -1){
          fieldType = "date";
        }else if (fieldFinded.templateOptions != null && fieldFinded.templateOptions.type == "number"){
          fieldType = "number";
        }

        if (withRange ==  true) {
            
          let queryRange:Array<string>=[];
          //queryBuilder.push("(");
          let existStart:boolean = false;
          // verificamos tipo
        
          if (itemFilter["__start" + prop] != null && itemFilter["__start" + prop] != ""){
            // start si tiene
            existStart = true;
            if (fieldType == "number") {
              queryRange.push(`${prop} >=  ${itemFilter["__start" + prop]}`);
            } else if (fieldType == "date") {
              queryRange.push(`${prop} >= ${this.getDateValue(itemFilter["__start" + prop], 'start')}`);
            }
          }
          // if (existStart == true ){
          //   queryBuilder.push(" AND ");
          // }
          if (itemFilter["__end" + prop] != null && itemFilter["__end" + prop] != ""){
            // start si tiene
            if (fieldType == "number") {
              queryRange.push(`${prop} <=  ${itemFilter["__end" + prop]}`);
            } else if (fieldType == "date") {
              queryRange.push(`${prop} <= ${this.getDateValue(itemFilter["__end" + prop], 'end')}`);
            }
          }
          if (queryRange.length > 0){
            queryBuilder.push("(" + queryRange.join(" AND ") + ")");
          }
         // queryBuilder.push(")");
        } else {
          if (fieldType == "number") {
            queryBuilder.push(`${prop} =  ${itemFilter[prop]}`);
          } else if (fieldType == "date") {
            queryBuilder.push(`${prop} =  ${this.getDateValue(itemFilter[prop], 'start')}`);
          }else{
            queryBuilder.push(`${prop}.Contains("${itemFilter[prop]}")`);
          }
        }
      }
    }


    return queryBuilder.join(" AND ");
  }

  public getColumnsFromFields(fields: Array<FormlyFieldConfig>): Array<any> {
    let result: Array<any> = [];

    fields.forEach(element => {
      let isFk = false;
      let prop = element.key;

      if (element.templateOptions != null && element.templateOptions.relation != null) {
        isFk = true;
        prop = `Fk${element.templateOptions.relation.PropertyRelationName}Text`;
      }
      result.push(
        {
          name: element.key,
          prop: prop,
          sortable: element.key,
          isFk: isFk,

          headerClass: 'title-cell'
        }
      );
    });

    return result;
  }
}


