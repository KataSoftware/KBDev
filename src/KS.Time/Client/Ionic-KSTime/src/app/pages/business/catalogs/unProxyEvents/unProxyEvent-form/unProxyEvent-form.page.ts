import { bizAppService } from 'src/app/services/business/business.service';
import { unProxyEventModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { unProxyEventFormFields } from './unProxyEvent-form.fields';

@Component({
  selector: 'unProxyEvent-form',
  templateUrl: './unProxyEvent-form.page.html',
  styleUrls: ['./unProxyEvent-form.page.scss'],
})
export class unProxyEventFormPage extends AppFormBasePage implements OnInit {
  item: unProxyEventModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  unProxyEventFormCustom:any = null;
  customClass = 'unProxyEvent-form.custom';
  setForm() {
    this.fields = unProxyEventFormFields.GetFields();
    if (this.unProxyEventFormCustom != null ){
      this.unProxyEventFormCustom["OnShowing"](this);
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
    this.title = "unProxyEvent";
	
    

    this.defaultHref = 'unProxyEvent/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = unProxyEventFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.unProxyEventFormCustom = _import["unProxyEventFormCustom"];
        if (this.unProxyEventFormCustom != null) {
           if (this.unProxyEventFormCustom["OnShowing"] != null ){
            this.unProxyEventFormCustom["OnShowing"](this);
          }
          if (this.unProxyEventFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.unProxyEventFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File unProxyEvent",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, unProxyEventModel._EntitySetName, Object.getOwnPropertyNames(unProxyEventModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidUnProxyEvent;


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
	     this.item = new  unProxyEventModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidUnProxyEvent = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, unProxyEventModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, unProxyEventModel._EntitySetName);
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

