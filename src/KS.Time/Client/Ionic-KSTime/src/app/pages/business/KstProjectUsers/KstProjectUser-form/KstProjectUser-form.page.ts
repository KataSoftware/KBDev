import { bizAppService } from 'src/app/services/business/business.service';
import { KstProjectUserModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KstProjectUserFormFields } from './KstProjectUser-form.fields';

@Component({
  selector: 'KstProjectUser-form',
  templateUrl: './KstProjectUser-form.page.html',
  styleUrls: ['./KstProjectUser-form.page.scss'],
})
export class KstProjectUserFormPage extends AppFormBasePage implements OnInit {
  item: KstProjectUserModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstProjectUserFormCustom:any = null;
  customClass = 'KstProjectUser-form.custom';
  setForm() {
    this.fields = KstProjectUserFormFields.GetFields();
    if (this.KstProjectUserFormCustom != null ){
      this.KstProjectUserFormCustom["OnShowing"](this);
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
    this.title = "KstProjectUser";
	
    

    this.defaultHref = 'KstProjectUser/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = KstProjectUserFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.KstProjectUserFormCustom = _import["KstProjectUserFormCustom"];
        if (this.KstProjectUserFormCustom != null) {
           if (this.KstProjectUserFormCustom["OnShowing"] != null ){
            this.KstProjectUserFormCustom["OnShowing"](this);
          }
          if (this.KstProjectUserFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.KstProjectUserFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File KstProjectUser",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, KstProjectUserModel._EntitySetName, Object.getOwnPropertyNames(KstProjectUserModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidProjectUser;


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
	     this.item = new  KstProjectUserModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidProjectUser = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, KstProjectUserModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, KstProjectUserModel._EntitySetName);
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

