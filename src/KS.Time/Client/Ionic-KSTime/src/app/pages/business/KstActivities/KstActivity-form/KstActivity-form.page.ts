import { bizAppService } from 'src/app/services/business/business.service';
import { KstActivityModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KstActivityFormFields } from './KstActivity-form.fields';

@Component({
  selector: 'KstActivity-form',
  templateUrl: './KstActivity-form.page.html',
  styleUrls: ['./KstActivity-form.page.scss'],
})
export class KstActivityFormPage extends AppFormBasePage implements OnInit {
  item: KstActivityModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstActivityFormCustom:any = null;
  customClass = 'KstActivity-form.custom';
  setForm() {
    this.fields = KstActivityFormFields.GetFields();
    if (this.KstActivityFormCustom != null ){
      this.KstActivityFormCustom["OnShowing"](this);
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
    this.title = "KstActivity";
	
    

    this.defaultHref = 'KstActivity/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = KstActivityFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.KstActivityFormCustom = _import["KstActivityFormCustom"];
        if (this.KstActivityFormCustom != null) {
           if (this.KstActivityFormCustom["OnShowing"] != null ){
            this.KstActivityFormCustom["OnShowing"](this);
          }
          if (this.KstActivityFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.KstActivityFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File KstActivity",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, KstActivityModel._EntitySetName, Object.getOwnPropertyNames(KstActivityModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidActivity;


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
	     this.item = new  KstActivityModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidActivity = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, KstActivityModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, KstActivityModel._EntitySetName);
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

