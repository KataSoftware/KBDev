import { bizAppService } from 'src/app/services/business/business.service';
import { KstWorkTimeModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KstWorkTimeFormFields } from './KstWorkTime-form.fields';

@Component({
  selector: 'KstWorkTime-form',
  templateUrl: './KstWorkTime-form.page.html',
  styleUrls: ['./KstWorkTime-form.page.scss'],
})
export class KstWorkTimeFormPage extends AppFormBasePage implements OnInit {
  item: KstWorkTimeModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstWorkTimeFormCustom:any = null;
  customClass = 'KstWorkTime-form.custom';
  setForm() {
    this.fields = KstWorkTimeFormFields.GetFields();
    if (this.KstWorkTimeFormCustom != null ){
      this.KstWorkTimeFormCustom["OnShowing"](this);
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
    this.title = "KstWorkTime";
	
    

    this.defaultHref = 'KstWorkTime/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = KstWorkTimeFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.KstWorkTimeFormCustom = _import["KstWorkTimeFormCustom"];
        if (this.KstWorkTimeFormCustom != null) {
           if (this.KstWorkTimeFormCustom["OnShowing"] != null ){
            this.KstWorkTimeFormCustom["OnShowing"](this);
          }
          if (this.KstWorkTimeFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.KstWorkTimeFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File KstWorkTime",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, KstWorkTimeModel._EntitySetName, Object.getOwnPropertyNames(KstWorkTimeModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidWorkTime;


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
	     this.item = new  KstWorkTimeModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidWorkTime = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, KstWorkTimeModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, KstWorkTimeModel._EntitySetName);
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

