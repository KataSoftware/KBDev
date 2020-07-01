import { Injectable } from '@angular/core';
import { HttpService, DataService, EntityWrapper, ApiResponse, ServiceData } from 'sfscommon';
import { ServiceDataOptions } from '../common/sfs.service';
import { SeparatorSettings, FieldSettings, ControlTypes, FieldTypes } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { FormlyFieldConfig } from '@ngx-formly/core';

@Injectable({ providedIn: 'root' })
export class bizAppService {
  url: string;
  constructor(public http: HttpService, public dataService: DataService) {
    this.url = http.generateUrl();
  }
  public getColor(zone: string): string {
    let result: string = null;

    switch (zone) {
      case "exactpoint":
        result = "#a127d8";
        break;
      case "insurgentes":
        result = "#e81744";
        break;
      case "santa-fe":
          result = "#262cd9";
        break;
      case "lomas-altas":
          result = "#e1981e";
        break;
      case "lomas-palmas":
          result = "#3cc3b3";
        break;
      case "bosques":
          result = "#b96946";
        break;
      case "interlomas":
          result = "#70a659";
        break;

      case "periferico-sur":
          result = "#636c9c";
        break;

      case "norte":
          result = "#d827a5";
        break;
      case "polanco":
          result = "#1180ee";
        break;
    }

    return result;
  }
  public async  Create(entity: any, setName: any) {

    return this.dataService.create({ EntitySet: setName, RestServiceAppKey: "KSTime", Item: entity });
  }
  public async  Delete(ItemKeys: Array<string>, setName: any) {

    return this.dataService.delete({ EntitySet: setName, RestServiceAppKey: "KSTime", ItemKeys: ItemKeys });
  }
  public async  Update(entity: any, setName: any, fields?: any, usemode?:string) {

    return this.dataService.update({ EntitySet: setName, Usemode:usemode,  RestServiceAppKey: "KSTime", Item: entity, Fields: fields });
  }
  public async  GetCount(serviceData: ServiceDataOptions) {


    if (serviceData.EntitySet == null) {
      serviceData.EntitySet = serviceData.EntityModel["_EntitySetName"];
    }
    return this.dataService.getCount(serviceData);

  }
  public async  Get(serviceData: ServiceDataOptions) {

    if (serviceData.Fields == null) {
      serviceData.Fields = Object.getOwnPropertyNames(serviceData.EntityModel["PropertyNames"]).join(",");
    }
    if (serviceData.EntitySet == null) {
      serviceData.EntitySet = serviceData.EntityModel["_EntitySetName"];
    }
    return this.dataService.get(serviceData);

  }

  public async  GetItem(id: any, setName: any, fields?: string) {

    let result = await this.dataService.get({ EntitySet: setName, AllFields: true, Fields: fields, RestServiceAppKey: "KSTime", ItemKey: id });
    if (result.isSuccess() == true) {
      if (Array.isArray(result.data) == true && result.data.length == 1) {
        result.data = result.data[0];
      }
    }
    return result;

  }




  public async  CustomMethod(params?: any, setName?: string, actionMethod?: string) {

    const requestParams = await this.http.generateFullParamsRequest();

    requestParams.data.Params = params;

    const response = await this.http.post(`${requestParams.url}/KSTime/${setName}/${actionMethod}`, requestParams.data, requestParams.headers);

    return response;
  }



  setSeparator(page: any, settings: SeparatorSettings) {
    if (page.fieldsBack == null) {
      page.fieldsBack = page.fields;
    }
    if (page.temp == null) {
      page.temp = new Array<FormlyFieldConfig>();
    }
    page.temp.push({ template: settings.Content });

  }
  private async addRelatedData(settings: FieldSettings, field: FormlyFieldConfig) {
    let response = await this.Get({ EntityModel: settings.EntityModel });
    if (response.isSuccess() == true) {
      settings.Data = response.data;
    }

    field.templateOptions.options = settings.Data;
    field.templateOptions.valueProp = settings.DataValue;
    field.templateOptions.labelProp = settings.DataText;



  }

  setOrder(page: any, allFields: Array<FormlyFieldConfig>, orderedFields: Array<FormlyFieldConfig>, settings: FieldSettings) {

    if (page["colSum"] == null) {
      page["colSum"] = 0;
    }
    // verificar si termina una fila
    // si el colsSum anterior es menor a 12, se entiende que sí

    let isMultiColumn = false;
    if (page.colsSum >= 12) {
      page.colsSum = 0;
    }
    if (settings.Columns != null && settings.Columns != 12) {
      page.colsSum = page.colsSum + settings.Columns;
      // let futureCols = this.colsSum +  settings.Columns;
      // if (futureCols <= 12){

      // }
      if (page.colsSum < 12 && page.rowGroup == null) {
        page.rowGroup = new Array<FormlyFieldConfig>();
      }
    } else {
      settings.Columns = 12;
      page.colsSum = 12;
      //if (this.colsSum == 12){
      page.rowGroup = new Array<FormlyFieldConfig>();
      //}
    }

    if (page.rowGroup == null) {
      page.rowGroup = new Array<FormlyFieldConfig>();
    }
    if (page.fieldsBack == null) {
      page.fieldsBack = settings.Fields == null ? page.fields : settings.Fields;
    }

    if (page.temp == null) {
      page.temp = new Array<FormlyFieldConfig>();
    }



    if (settings.Name != null) {

      let finded = page.fields.find(p => p.key == settings.Name);
      if (finded != null) {
        this.applySettingsField(settings, finded);
        //this.temp.push(finded);
        page.rowGroup.push(finded);
      }
    } else {
      let field: FormlyFieldConfig = { className: '', template: settings.Content };
      this.applySettingsField(settings, field);
      page.rowGroup.push(field);
    }

    if (page.colsSum == 12) {
      let classNames = "";
      if (settings.ClassNameGroup != null) {
        classNames = settings.ClassNameGroup;
      }
      page.temp.push({ fieldGroupClassName: 'row ' + classNames, fieldGroup: page.rowGroup });
      page.rowGroup = null;
    }
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
        }

      }
      if (settings.Label != null) {
        field["templateOptions"]["label"] = settings.Label;
      }
      if (settings.Type != null) {
        if (settings.Type == FieldTypes.Password) {
          field["templateOptions"]["type"] = "password";
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

      
      if (settings.LabelHtml != null) {
        field["templateOptions"]["labelHtml"] = [settings.LabelHtml];
      }
      if (settings.MinLength != null) {
        field["templateOptions"]["minLength"] = settings.MinLength;
      }
      if (settings.Validators != null) {
        field["validators"] = settings.Validators;
      }
      if (settings.AsyncValidators != null) {
        field["asyncValidators"] = settings.AsyncValidators;
      }
      if (settings.EntityModel != null) {
        field.type = "select";
        this.addRelatedData(settings, field);
      }else{
        if (field.templateOptions != null && field.templateOptions["relation"] != null ){
          
            settings.EntityModel = field.templateOptions["relation"].EntityModel;
            settings.DataValue = field.templateOptions["relation"].DataValue;
            settings.DataText = field.templateOptions["relation"].DataText;
            this.addRelatedData(settings, field);
          
         
        }
      }

    }

    if (settings.Wrapper != null) {
      field["wrappers"] = [settings.Wrapper];
    }
  }
  setOrderFields(page: any, fieldNames: Array<string>) {
    let temp: Array<FormlyFieldConfig> = [];

    fieldNames.forEach(element => {
      let finded = page.fields.find(p => p.name == element);

      temp.push()
    });

  }

  public showForm(page: any) {
    if (page.temp != null) {
      page.fields = page.temp;
      page.fields["type"] = "flex-layout";
      page.fields["templateOptions"] = {
        fxLayout: 'row',
      };
    }



  }

}