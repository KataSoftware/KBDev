import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KstEmailTemplateFormFields } from './generic-form.fields';
import { ActivatedRoute } from '@angular/router';
import { AppFormBasePage } from '../../common/app-form-base/app-form-base.page';
import { sfsService } from '../../services/sfs.service';
import { BackToListSettings } from '../../models/common/page.model';

@Component({
  selector: 'generic-form',
  templateUrl: './generic-form.page.html',
  styleUrls: ['./generic-form.page.scss'],
})
export class GenericFormPage extends AppFormBasePage implements OnInit {
  item:any = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstEmailTemplateFormCustom:any = null;
  customClass = 'KstEmailTemplate-form.custom';
  entityName:string=null;
  entityModel:any=null;
  setForm() {
    this.fields = KstEmailTemplateFormFields.GetFields();
    if (this.KstEmailTemplateFormCustom != null ){
      this.KstEmailTemplateFormCustom["OnShowing"](this);
    }
    this.showForm();

  }
  constructor(
    public injector: Injector,
    private activatedRoute: ActivatedRoute,
    public storage: StorageService,
    public userService: UserService,
	public sfsService: sfsService
  ) {

    super(injector);
    this.title = "KstEmailTemplate";
    this.entityName = this.activatedRoute.snapshot.paramMap.get('catalog');

    

    this.defaultHref = 'KstEmailTemplate/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	  this.fieldsBack = KstEmailTemplateFormFields.GetFields();
   
	import(
                /* webpackChunkName: "KstProjectFormCustom" */
                /* webpackMode: "eager" */
                /* webpackPrefetch: true */
                /* webpackInclude: /\.ts$/ */
                /* webpackPreload: true */   
    `./${this.customClass}`).then( async (_import)=> {
        this.KstEmailTemplateFormCustom = _import[ this.entityName + "FormCustom"];
        if (this.KstEmailTemplateFormCustom != null) {
           if (this.KstEmailTemplateFormCustom["OnShowing"] != null ){
            this.KstEmailTemplateFormCustom["OnShowing"](this);
          }
          if (this.KstEmailTemplateFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.KstEmailTemplateFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File KstEmailTemplate",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, this.entityModel._EntitySetName, Object.getOwnPropertyNames(this.entityModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidEmailTemplate;


        if (this.item != null) {
        
     

        }
      }
    }
  }
   async goBack(settings?:BackToListSettings) {
    if (settings == null ){
      settings = new BackToListSettings();
      settings.RefreshData= false;
      settings.RestartPaging = false;
      settings.Route = this.defaultHref;
    }
    this.sfsService.SetNavigationData(settings);
    this.navCtrl.navigateBack(settings.Route, { animated: true });
  }
 
  async saveData() {
    this.savingStart();
    if (this.form.valid == true) {
    
       // this.item = this.form.value;
	  if (this.item == null ){
	     this.item = new  this.entityModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidEmailTemplate = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, this.entityModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, this.entityModel._EntitySetName);
      }
      if (apiResponse.status == 'success') {
        this.savingEnd();
        let result = await this.showOk();
        if (result == true){
              if (this.guidItem == null ){
                    this.goBack({ RestartPaging: true, RefreshData: true,  Route: this.defaultHref });
               }else{
                    this.goBack({ RestartPaging: false, RefreshData: false, ItemUpdated: this.item,  Route:  this.defaultHref });
               }
        }
      }
    }
  }

}

