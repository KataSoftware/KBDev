import { Injectable } from '@angular/core';
import { HttpService, DataService, EntityWrapper, ApiResponse, ServiceData, IGeoData } from 'sfscommon';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { ServiceDataOptions } from './sfs.service';
import { SeparatorSettings, FieldSettings, ControlTypes, FieldTypes } from '../models/common/page.model';
import { bizAppService } from './business.service';
@Injectable({ providedIn: 'root' })
export class PageService {
  constructor(public http: HttpService, public dataService: DataService, public bizAppService:bizAppService) {
    //this.url = http.generateUrl();
  }
  temp: Array<FormlyFieldConfig> = null;
  fieldsBack: Array<FormlyFieldConfig> = null;

  private colsSum = 0;

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
      if (settings.Data != null && Array.isArray(settings.Data)  && (settings.DataValue == null && settings.DataText == null)){
        // data si hay, pero no propiedades
        field.templateOptions.options = settings.Data;
        let dataArray:Array<any> =[];
        for (let index = 0; index < settings.Data.length; index++) {
          const element = settings.Data[index];
          dataArray.push({ value: element, text: element});
        }
        
        settings.Data = dataArray;
        settings.DataValue = "value";
        settings.DataText = "text";
      }else{
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
  setOrder(settings: FieldSettings, fields: Array<FormlyFieldConfig>) {
    if (settings.Id == null ){
      settings.Id = settings.Name;
    }
    
    //console.log("currentMediaQuery: ", this.currentMediaQuery);

    if (window.innerWidth < 570){
      settings.Columns = 12;
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

  public showForm(fields: Array<FormlyFieldConfig>) {
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



  }
  public resetFieldsForm(fields: Array<FormlyFieldConfig>) {
    this.temp = null;
    this.colsSum = 0;
    if (this.fieldsBack != null) {
      fields = this.fieldsBack;
    }
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

    return  fields;
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
          }else if (settings.Type == FieldTypes.Number) {
            field["templateOptions"]["type"] = "number";
           
          }

        }

        if (field["templateOptions"]["type"] == "number"){
          if (settings.Min != null ){
            field["templateOptions"]["min"] = settings.Min;
          }
          if (settings.Max != null ){
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
      if (settings.Required != null) {
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
      if (settings.EntityModel != null || (settings.Data != null))  {
        field.type = "select";
        this.addRelatedData(settings, field);
      } else {
        if (field.templateOptions != null && field.templateOptions["relation"] != null) {

          settings.EntityModel = field.templateOptions["relation"].EntityModel;
          if (settings.DataValue == null ){
            settings.DataValue = field.templateOptions["relation"].DataValue;
          }
          if (settings.DataText ==  null){
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

  public getColumnsFromFields(fields: Array<FormlyFieldConfig>):Array<any>{
    let result:Array<any> = [];

    fields.forEach(element => {
      result.push(
        {
          name: element.key,
          prop: element.key,
          sortable: element.key,
          headerClass: 'title-cell'
        }
      );
    });
    
    return result;
  }
}

