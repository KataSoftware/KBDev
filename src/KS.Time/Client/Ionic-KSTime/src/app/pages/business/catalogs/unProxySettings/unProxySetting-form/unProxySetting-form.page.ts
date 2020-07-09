import { bizAppService } from 'src/app/services/business/business.service';
import { unProxySettingModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { unProxySettingFormFields } from './unProxySetting-form.fields';

@Component({
  selector: 'unProxySetting-form',
  templateUrl: './unProxySetting-form.page.html',
  styleUrls: ['./unProxySetting-form.page.scss'],
})
export class unProxySettingFormPage extends AppFormBasePage implements OnInit {
  item: unProxySettingModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  unProxySettingFormCustom:any = null;
  customClass = 'unProxySetting-form.custom';
  setForm() {
    this.fields = unProxySettingFormFields.GetFields();
    if (this.unProxySettingFormCustom != null ){
      this.unProxySettingFormCustom["OnShowing"](this);
    }
    this.showForm();

  }
  constructor(
    public injector: Injector,

    public storage: StorageService,
    public userService: UserService,
	public sfsService: sfsService
  ) {

    super(injector);
    this.title = "unProxySetting";
	
    

    this.defaultHref = 'unProxySetting/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = unProxySettingFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.unProxySettingFormCustom = _import["unProxySettingFormCustom"];
        if (this.unProxySettingFormCustom != null) {
           if (this.unProxySettingFormCustom["OnShowing"] != null ){
            this.unProxySettingFormCustom["OnShowing"](this);
          }
          if (this.unProxySettingFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.unProxySettingFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File unProxySetting",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, unProxySettingModel._EntitySetName, Object.getOwnPropertyNames(unProxySettingModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidUnProxySetting;


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
	     this.item = new  unProxySettingModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidUnProxySetting = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, unProxySettingModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, unProxySettingModel._EntitySetName);
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

