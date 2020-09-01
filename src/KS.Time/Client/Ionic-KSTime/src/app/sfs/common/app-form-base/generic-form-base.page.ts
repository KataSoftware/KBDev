import { sfsService } from './../../services/sfs.service';
import { Component, OnInit, Injector, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { FormlyFormOptions, FormlyFieldConfig } from '@ngx-formly/core';
import { ActivatedRoute } from '@angular/router';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { AppFormBasePage } from '../../common/app-form-base/app-form-base.page';
import { BackToListSettings } from '../../models/common/page.model';

export class GenericFormBasePage extends AppFormBasePage implements OnInit {
  // @Input() entityName: string;
  @Input() filterProperties: Array<string>;
  @Input() item: any = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstEmailTemplateFormCustom: any = null;
  customClass = 'KstEmailTemplate-form.custom';
  @Input() entityName: string;
  entityModel: any = null;
  textSave:string= "Guardar";
  constructor(
    public injector: Injector,
    public activatedRoute: ActivatedRoute,
    public storage: StorageService,
    public userService: UserService,
    public sfsService: sfsService

  ) {

    super(injector);


    if (this.activatedRoute.snapshot.paramMap.get('catalog') != null) {
      this.entityName = this.activatedRoute.snapshot.paramMap.get('catalog');
    }




    this.guidItem = this.route.snapshot.paramMap.get("id");
  }



  switchFilterRange(event: any) {
    //setTimeout(function(){
    console.log(event);
  
    this.isFilterRange = event.detail.checked;
    
    this.pageService.isFilterRange = this.isFilterRange;
    this.pageService.fieldsBack = this.entityModel.GetFields();
    this.fields = [];
    this.pageService.temp = null;
    this.showForm();

//  }, 500);


  
 
  }
  async ngOnInit() {
    this.pageService.isFilter = this.isFilter;
    this.title = this.entityName;
    this.defaultHref = 'catalog/' + this.entityName;
    console.log("---entityName----", this.entityName);

    if (this.isFilter == true ){
     // this.isX = true;
      this.title = "Filtro";
      this.textSave = "Aplicar";
    if (this.item != null){
      let props = Object.getOwnPropertyNames(this.item);
      if (props.find(p=> p.startsWith("__")) != null ){
        this.isFilterRange = true;
      }
    }
  }
    import(
               /* webpackMode: "lazy" */
          /* webpackPrefetch: true */
          /* webpackInclude: /\.ts$/ */
          /* webpackPreload: true */


      `../../models/codegen/${this.entityName}.model`).then((_model) => {
        this.entityModel = _model[this.entityName + "Model"]
        this.pageService.fieldsBack = this.entityModel.GetFields();
        this.pageService.temp = null;
        if (this.isFilter == true && this.item != null) {
          console.log("data open filter", this.item);
        } else {
          //console.log("new item", this.item);
            //if (this.isFilter == true ){
              if (this.guidItem == null ){
                this.item = new this.entityModel();
              }
           //}
        }
        import(
                  /* webpackMode: "eager" */
          /* webpackPrefetch: true */
          /* webpackInclude: /\.ts$/ */
          /* webpackPreload: true */

          `../../../pages/catalogs/${this.entityName}Form.custom`).then(async (_import) => {
            this.KstEmailTemplateFormCustom = _import[this.entityName + "FormCustom"];
            if (this.KstEmailTemplateFormCustom != null) {
              if (this.KstEmailTemplateFormCustom["OnShowing"] != null) {
                this.KstEmailTemplateFormCustom["OnShowing"](this);
              }
              if (this.KstEmailTemplateFormCustom["OnShowingAsync"] != null) {
                await (<Promise<void>>(this.KstEmailTemplateFormCustom["OnShowingAsync"](this)));
              }
            }
            this.showForm();
            this.getData();
          }).catch((error) => {
            console.log("error load partial File", error);
            this.showForm();
            this.getData();
          });

      }).catch((error) => {
        //  this.externalCustomFileChecked = true;
        console.log("error ", error);
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, this.entityModel._EntitySetName, Object.getOwnPropertyNames(this.entityModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.Id;


        if (this.item != null) {



        }
      }
    }
  }
  async goBack(settings?: BackToListSettings) {
    if (this.isFilter == true) {
      this.close();

    } else {
      if (settings == null) {
        settings = new BackToListSettings();
        settings.RefreshData = false;
        settings.RestartPaging = false;
        settings.Route = this.defaultHref;
      }
      this.sfsService.SetNavigationData(settings);
      this.navCtrl.navigateBack(settings.Route, { animated: true });
    }
  }
  async close() {
    this.modalCtrl.dismiss();
  }
  async delete() {
    if (this.isFilter == true) {
      this.modalCtrl.dismiss({ delete:true });
    } else {

      let modalResponse = await this.showConfirm({

        onOk: async () => {
          let response = await this.bizAppService.Delete([this.guidItem], this.entityModel._EntitySetName);

        }
      });

    }
  }
  async saveData() {

    if (this.isFilter) {
      if (this.item == null) {
        this.item = new this.entityModel();
      }
      Object.assign(this.item, this.form.value);
      this.modalCtrl.dismiss({ query: this.pageService.getQueryFilter(this.item, this.entityModel.GetFields(), this.isFilterRange), itemFilter: this.item });

    } else {
      this.savingStart();
      if (this.form.valid == true) {

        // this.item = this.form.value;
        if (this.item == null) {
          this.item = new this.entityModel();
        }
        Object.assign(this.item, this.form.value);
        //this.item.Id = this.guidItem;

        let apiResponse: ApiResponse<any> = null;
        console.log("after create or save", this.guidItem);
        if (this.guidItem != null) {
          apiResponse = await this.bizAppService.Update(this.item, this.entityModel._EntitySetName, this.visibleFields.join(","));
        } else {
          apiResponse = await this.bizAppService.Create(this.item, this.entityModel._EntitySetName);
        }
        if (apiResponse.status == 'success') {
          this.savingEnd();
          // let result = await this.showOk();
          // if (result == true) {
          if (this.guidItem == null) {
            this.goBack({ RestartPaging: true, RefreshData: true, Route: this.defaultHref });
          } else {
            this.goBack({ RestartPaging: false, RefreshData: false, ItemUpdated: this.item, Route: this.defaultHref });
          }
          // }
        }
      }
    }
  }
}
