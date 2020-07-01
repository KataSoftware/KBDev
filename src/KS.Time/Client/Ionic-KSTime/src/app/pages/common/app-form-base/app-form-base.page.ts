//import { FieldSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { ModalPage } from './../modal/modal.page';
import { ServiceDataOptions, sfsService } from './../../../services/common/sfs.service';
import { BasePage, DataService } from 'sfscommon';
import { OnInit, Injector, Component } from '@angular/core';
import swal from 'sweetalert';
import { FormGroup, AbstractControl } from '@angular/forms';
import { FormlyFieldConfig, FormlyTemplateOptions } from '@ngx-formly/core';
import { Observable } from 'rxjs';
import { bizAppService } from 'src/app/services/business/business.service';
import { Button } from 'protractor';

@Component({
  selector: 'app-app-form-base',
  templateUrl: './app-form-base.page.html',
  styleUrls: ['./app-form-base.page.scss'],
})
export class AppFormBasePage extends BasePage implements OnInit {


  private _bizAppService: bizAppService;

  public get bizAppService(): bizAppService {
    if (!this._bizAppService) {

      this._bizAppService = this.injector.get(bizAppService);
    }

    return this._bizAppService;
  }
  // private _sfsService: sfsService;

  // public get sfsService(): sfsService {
  //   if (!this._sfsService) {

  //     this._sfsService = this.injector.get(sfsService);
  //   }

  //   return this._sfsService;
  // }

  public set bizAppService(value: bizAppService) { this._bizAppService = value; }

  constructor(public injector: Injector) {
    super(injector);

    this.form = new FormGroup({});
  }
  fields: Array<FormlyFieldConfig> = [];
  public loadingData: boolean = true;
  public guidItem: string = null;
  public form: FormGroup;

  public activatingText: string = 'Guardar';
  public disabledButton: boolean = false;
  public textoModal: string = "ssdsfs";
  public defaultHref: string;

  public getControl(name: string): AbstractControl {
    return <AbstractControl>this.form.get(name);
  }
  public getFormGroup(name: string): FormGroup {
    return <FormGroup>this.form.get(name);
  }

  public savingStart() {
    this.activatingText = 'Guardando...';
    this.disabledButton = true;
    this.loadingData = true;
  }
  public savingEnd() {
    this.loadingData = false;
    this.activatingText = 'Guardado';
    this.disabledButton = false;
    this.loadingData = true;
  }


  async showDialog(settings?: DialogSettings) {
    let message = settings.Message;
    let title = settings.Title;
    let buttons = settings.Buttons;
    let typeClass = settings.Type;//== ""

    if ((message != null && message.indexOf("<") != -1) || settings.Type == "form") {

      let typeIcon = "check_circle_outline";
      if (settings.Type == "warning") {
        typeIcon = "error_outline";


      } else if (settings.Type == "form") {

      }
      let htmlIcon = null;
      let layout = null;
      if (settings.Type != "form") {
        htmlIcon = `<i class="material-icons">${typeIcon}</i>`;
        layout = ` <div class="dialog-header">   <div class="dialog-icon">${htmlIcon}</div> <div class="dialog-title">${title}</div> </div> <div class="dialog-message">${message}</div>`;

      }

      if (settings.Buttons == null) {
        let button: DialogButton = {
          Text: "Continuar",
          ActionKey: "continue",
          CssClass: "sfs-button primary modal-continuar-button",
          Click: (modalPage, button) => {
            modalPage["modalCtrl"]["dismiss"](button);

            console.log("click continuar d43", button);
            if (settings.OnClose != null) {
              settings.OnClose(null, this);
            }
          }
        };

        settings.Buttons = [];
        settings.Buttons.push(button);
      }else{

      }
      let modal = await this.modalCtrl.create({ component: ModalPage, componentProps: { title: settings.Title, contentHtml: layout, buttons: settings.Buttons, fields: settings.Fields, primaryButtonText:settings.PrimaryButtonText, hideCancel: settings.HideCancel, item: settings.Data, dialogType: settings.Type }, cssClass: 'swal-ok-modal custom-modal ' + settings.CssClass });
      modal.onDidDismiss().then((data) => {
        if (settings.OnClose != null && data != null) {
          settings.OnClose(data.data, this);
        }
        return data;
      });
      await modal.present();




    } else {
      let result = await swal({
        title: title != null ? title : 'Registro exitoso',
        className: 'swal-ok-modal',
        text: message,
        buttons: buttons != null ? buttons : {
          confirmar: {
            text: 'Continuar',
            value: true,
            visible: true,
            className: 'modal-continuar-button',
            closeModal: true
          }
        }
      });

      return result;
    }
  }
  public async showOk(title?: string, message?: string, buttons?: Array<any>) {
    return await this.showDialog({ Message: message, Title: title, Buttons: buttons, Type: "ok" });
  }
  public async showWarning(title?: string, message?: string, buttons?: Array<any>) {
    return await this.showDialog({ Message: message, Title: title, Buttons: buttons, Type: "warning" });
  }
  public async showConfirm(message?: string): Promise<Boolean> {
    const modalResponse = await swal({
      title: 'Advertencia',
      className: 'swal-danger-modal',
      text: message,
      closeOnClickOutside: false,
      buttons: {
        cancelar: {
          text: 'Cancelar',
          value: false,
          visible: true,
          className: 'modal-cancelar-button',
          closeModal: false,
        },
        confirmar: {
          text: 'Continuar',
          value: true,
          visible: true,
          className: 'modal-continuar-button',
          closeModal: false
        }
      }
    });
    return modalResponse;
  }
  ngOnInit(): void {

  }
  temp: Array<FormlyFieldConfig> = null;
  fieldsBack: Array<FormlyFieldConfig> = null;

  private colsSum = 0;

  rowGroup: Array<FormlyFieldConfig> = null;

  setSeparator(settings: SeparatorSettings) {
    if (this.fieldsBack == null) {
      this.fieldsBack = this.fields;
    }
    if (this.temp == null) {
      this.temp = new Array<FormlyFieldConfig>();
    }
    this.temp.push({ template: settings.Content });

  }
  private async addRelatedData(settings: FieldSettings, field: FormlyFieldConfig) {
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
  setOrder(settings: FieldSettings) {
    if (settings.Id == null ){
      settings.Id = settings.Name;
    }
    
    console.log("currentMediaQuery: ", this.currentMediaQuery);

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
      this.fieldsBack = settings.Fields == null ? this.fields : settings.Fields;
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

  public showForm() {
    //this.propertiesForUpdate. = this.visibleFields;

    if (this.temp == null) {
      //this.temp = this.fieldsBack;

      if (this.fieldsBack != null) {
        this.fieldsBack.forEach(element => {
          this.setOrder({ Name: element.key, Columns: 12 });
        });
      }
    }

    if (this.temp != null) {
      this.fields = this.temp;
      this.fields["type"] = "flex-layout";
      this.fields["templateOptions"] = {
        fxLayout: 'row',
      };
    }



  }
  public resetFieldsForm() {
    this.temp = null;
    this.colsSum = 0;
    if (this.fieldsBack != null) {
      this.fields = this.fieldsBack;
    }
  }
  public getFieldsForm() {
    if (this.rowGroup != null && this.temp != null) {
      this.temp.push({ fieldGroupClassName: 'row', fieldGroup: this.rowGroup });
      this.rowGroup = null;
    }
    if (this.temp != null) {
      this.fields = this.temp;
      this.fields["type"] = "flex-layout";
      this.fields["templateOptions"] = {
        fxLayout: 'row',
      };
    }

    return this.fields;
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
  setOrderFields(fieldNames: Array<string>) {
    let temp: Array<FormlyFieldConfig> = [];

    fieldNames.forEach(element => {
      let finded = this.fields.find(p => p.name == element);

      temp.push()
    });

  }

}

export enum FieldTypes {
  Password = "password",
  Currency = "currency",
  String = "string",
  Time = "time",
  Number = "number"
}
export enum ControlTypes {
  Input = "input",
  Checkbox = "checkbox",
  Custom = "custom",
  Hidden = "hidden",
  

}
export class FieldSettings {
  public Fields?: Array<FormlyFieldConfig> = null;
  public Id?: string = null;
  public Name?: string = null;
  public Content?: string = null;
  public ClassName?: string = null;
  public HideExpression?: any = null;
  public ClassNameGroup?: string = null;
  public TemplateOptions?: any = null;
  public ReadOnly?: boolean = null;
  public ExpressionProperties?: any = null;
  public Type?: FieldTypes = null;
  public IsMultiLine?: boolean = false;
  public ControlType?: ControlTypes = null;
  public CustomControl?: string = null;
  public Validators?: any = null;
  public AsyncValidators?: any = null;
  public Required?: boolean | any = false;
  public Columns?: number = 12;
  public Percent?: number;
  public Label?: string;
  public LabelHtml?: string;
  public Hooks?: any;

  public OnChange?= (field, event) => { };
  public OnKeyUp?= (field, event) => { }
  public PlaceHolder?: string;
  public EntityModel?: any = null;
  public DataQuery?: string = null;
  public Data?: any[] | Observable<any[]>;
  public DataValue?: string = null;
  public DataText?: string = null;
  public MinLength?: number = null;
  public MaxLength?: number = null;
  public Min?: number = null;
  public Max?: number = null;
  public Wrapper?: string = null;
}

export class SeparatorSettings {
  public Title?: string = null;
  public Content?: string = null;
}
export class DialogButton {
  CssClass?: string;
  ActionKey?: string;
  Text?: string;
  Click = (modalPage: any, action: string) => { };
}
export class DialogSettings {
  /**
   *
   */
  constructor() {


  }
  Title?: string;
  Message?: string;
  HideCancel?:boolean=false;
  PrimaryButtonText?:string=null;
  Data?: any = null;
  OnClose?= (data, event) => { };
  CssClass?:string;
  Fields?: Array<FieldSettings> = [];
  Type?: string;
  Buttons?: Array<DialogButton> | any;
  SetField?= (field: FieldSettings) => {
    this.Fields.push(field);
  }
}


export class BackToListSettings {
  RestartPaging?: Boolean = false;
  ItemUpdated?: any = null;
  Route?: string = null;
  RefreshData?: boolean = false;
}