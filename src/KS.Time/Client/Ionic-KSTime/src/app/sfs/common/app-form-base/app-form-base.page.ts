//import { FieldSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { ModalPage } from './../modal/modal.page';
import { ServiceDataOptions, sfsService } from './../../services/sfs.service';
import { BasePage, DataService } from 'sfscommon';
import { OnInit, Injector, Component, Input } from '@angular/core';

import { FormGroup, AbstractControl } from '@angular/forms';
import { FormlyFieldConfig, FormlyTemplateOptions } from '@ngx-formly/core';
import { Observable } from 'rxjs';
import { bizAppService } from '../../services/business.service';
import { Button } from 'protractor';
import { PageService } from '../../services/page.service';
import { DialogSettings, DialogButton, SeparatorSettings, FieldSettings } from '../../models/common/page.model';
 
export class AppFormBasePage extends BasePage implements OnInit {

  @Input() public isFilter:boolean=false;
  public isFilterRange:boolean=false;

  private _bizAppService: bizAppService;

  public get bizAppService(): bizAppService {
    if (!this._bizAppService) {

      this._bizAppService = this.injector.get(bizAppService);
    }

    return this._bizAppService;
  }
  private _pageService: PageService;

  public get pageService(): PageService {
    if (!this._pageService) {

      this._pageService = this.injector.get(PageService);
    }

    return this._pageService;
  }


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
     
      let ress = await this.showOk("ok");
      
    }
  }
  public async showOk(title?: string, message?: string, buttons?: Array<any>) {
    return await this.showConfirm();
  }
  public async showWarning(title?: string, message?: string, buttons?: Array<any>) {
    return await this.showDialog({ Message: message, Title: title, Buttons: buttons, Type: "warning" });
  }
  public async showConfirm(message?: string): Promise<Boolean> {
    return true;
    
  }
  ngOnInit(): void {

  }
  temp: Array<FormlyFieldConfig> = null;
  fieldsBack: Array<FormlyFieldConfig> = null;

  private colsSum = 0;
  visibleFields: Array<string> = [];
  propertyChanges: Array<string> = [];
  propertiesForUpdate: Array<string> = [];

  rowGroup: Array<FormlyFieldConfig> = null;

  setSeparator(settings: SeparatorSettings) {
    this.pageService.setSeparator(settings, this.fields);
  }
  private async addRelatedData(settings: FieldSettings, field: FormlyFieldConfig) {
    this.pageService.addRelatedData(settings, field);
  }

  private setOrderForRange(settings: FieldSettings, fieldName:string){
    this.pageService.setOrder(settings, this.fields);
    
    // agregar dos nuevos campos
    // start
    let field = this.fields.find(p=> p.key == fieldName);
    let startField = Object.assign({}, field);
    let startSettings = Object.assign({}, settings);
    startField.key = "__start" + startField.name;
    this.pageService.fieldsBack.push(startField);
    
    this.pageService.setOrder(startSettings, this.fields);
    // let endField = Object.assign({}, field);
    // this.fields.push(endField);
    // endField.key = "__end" + startField.name;
    // this.pageService.setOrder(settings, this.fields);
    
    // // agregar settings

    // settings.Name = "__start" + settings.Name;
  }
  setOrder(settings: FieldSettings) {
    // settings.IsFilter = this.isFilter;
    
   
    // if (settings.IsFilterRange == true ){

    // }else{
      this.pageService.setOrder(settings, this.fields);

    //}
  }
  public showForm() {
    this.fields = this.pageService.showForm(this.fields);
  }

  public resetFieldsForm() {
    this.fields = this.pageService.resetFieldsForm(this.fields);
  }

  public getFieldsForm() {
    this.fields = this.pageService.getFieldsForm(this.fields);
  }

  public setOrderFields(fieldNames: Array<string>) {
    this.pageService.setOrderFields(fieldNames, this.fields);
  }



  

}
