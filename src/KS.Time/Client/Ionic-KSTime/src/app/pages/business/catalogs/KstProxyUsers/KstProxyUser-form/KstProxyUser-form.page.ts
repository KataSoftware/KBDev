import { bizAppService } from 'src/app/services/business/business.service';
import { KstProxyUserModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KstProxyUserFormFields } from './KstProxyUser-form.fields';

@Component({
  selector: 'KstProxyUser-form',
  templateUrl: './KstProxyUser-form.page.html',
  styleUrls: ['./KstProxyUser-form.page.scss'],
})
export class KstProxyUserFormPage extends AppFormBasePage implements OnInit {
  item: KstProxyUserModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstProxyUserFormCustom:any = null;
  customClass = 'KstProxyUser-form.custom';
  setForm() {
    this.fields = KstProxyUserFormFields.GetFields();
    if (this.KstProxyUserFormCustom != null ){
      this.KstProxyUserFormCustom["OnShowing"](this);
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
    this.title = "KstProxyUser";
	
    

    this.defaultHref = 'KstProxyUser/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = KstProxyUserFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.KstProxyUserFormCustom = _import["KstProxyUserFormCustom"];
        if (this.KstProxyUserFormCustom != null) {
           if (this.KstProxyUserFormCustom["OnShowing"] != null ){
            this.KstProxyUserFormCustom["OnShowing"](this);
          }
          if (this.KstProxyUserFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.KstProxyUserFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File KstProxyUser",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, KstProxyUserModel._EntitySetName, Object.getOwnPropertyNames(KstProxyUserModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidUser;


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
	     this.item = new  KstProxyUserModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidUser = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, KstProxyUserModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, KstProxyUserModel._EntitySetName);
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

