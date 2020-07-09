import { bizAppService } from 'src/app/services/business/business.service';
import { unProxyBusinessObjectModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { unProxyBusinessObjectFormFields } from './unProxyBusinessObject-form.fields';

@Component({
  selector: 'unProxyBusinessObject-form',
  templateUrl: './unProxyBusinessObject-form.page.html',
  styleUrls: ['./unProxyBusinessObject-form.page.scss'],
})
export class unProxyBusinessObjectFormPage extends AppFormBasePage implements OnInit {
  item: unProxyBusinessObjectModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  unProxyBusinessObjectFormCustom:any = null;
  customClass = 'unProxyBusinessObject-form.custom';
  setForm() {
    this.fields = unProxyBusinessObjectFormFields.GetFields();
    if (this.unProxyBusinessObjectFormCustom != null ){
      this.unProxyBusinessObjectFormCustom["OnShowing"](this);
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
    this.title = "unProxyBusinessObject";
	
    

    this.defaultHref = 'unProxyBusinessObject/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = unProxyBusinessObjectFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.unProxyBusinessObjectFormCustom = _import["unProxyBusinessObjectFormCustom"];
        if (this.unProxyBusinessObjectFormCustom != null) {
           if (this.unProxyBusinessObjectFormCustom["OnShowing"] != null ){
            this.unProxyBusinessObjectFormCustom["OnShowing"](this);
          }
          if (this.unProxyBusinessObjectFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.unProxyBusinessObjectFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File unProxyBusinessObject",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, unProxyBusinessObjectModel._EntitySetName, Object.getOwnPropertyNames(unProxyBusinessObjectModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidBusinessObject;


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
	     this.item = new  unProxyBusinessObjectModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidBusinessObject = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, unProxyBusinessObjectModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, unProxyBusinessObjectModel._EntitySetName);
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

