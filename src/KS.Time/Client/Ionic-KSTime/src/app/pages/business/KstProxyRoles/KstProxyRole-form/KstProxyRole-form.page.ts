import { bizAppService } from 'src/app/services/business/business.service';
import { KstProxyRoleModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KstProxyRoleFormFields } from './KstProxyRole-form.fields';

@Component({
  selector: 'KstProxyRole-form',
  templateUrl: './KstProxyRole-form.page.html',
  styleUrls: ['./KstProxyRole-form.page.scss'],
})
export class KstProxyRoleFormPage extends AppFormBasePage implements OnInit {
  item: KstProxyRoleModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstProxyRoleFormCustom:any = null;
  customClass = 'KstProxyRole-form.custom';
  setForm() {
    this.fields = KstProxyRoleFormFields.GetFields();
    if (this.KstProxyRoleFormCustom != null ){
      this.KstProxyRoleFormCustom["OnShowing"](this);
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
    this.title = "KstProxyRole";
	
    

    this.defaultHref = 'KstProxyRole/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = KstProxyRoleFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.KstProxyRoleFormCustom = _import["KstProxyRoleFormCustom"];
        if (this.KstProxyRoleFormCustom != null) {
           if (this.KstProxyRoleFormCustom["OnShowing"] != null ){
            this.KstProxyRoleFormCustom["OnShowing"](this);
          }
          if (this.KstProxyRoleFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.KstProxyRoleFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File KstProxyRole",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, KstProxyRoleModel._EntitySetName, Object.getOwnPropertyNames(KstProxyRoleModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidRole;


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
	     this.item = new  KstProxyRoleModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidRole = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, KstProxyRoleModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, KstProxyRoleModel._EntitySetName);
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

