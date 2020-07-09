import { bizAppService } from 'src/app/services/business/business.service';
import { KstWorkTimeFileModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KstWorkTimeFileFormFields } from './KstWorkTimeFile-form.fields';

@Component({
  selector: 'KstWorkTimeFile-form',
  templateUrl: './KstWorkTimeFile-form.page.html',
  styleUrls: ['./KstWorkTimeFile-form.page.scss'],
})
export class KstWorkTimeFileFormPage extends AppFormBasePage implements OnInit {
  item: KstWorkTimeFileModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstWorkTimeFileFormCustom:any = null;
  customClass = 'KstWorkTimeFile-form.custom';
  setForm() {
    this.fields = KstWorkTimeFileFormFields.GetFields();
    if (this.KstWorkTimeFileFormCustom != null ){
      this.KstWorkTimeFileFormCustom["OnShowing"](this);
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
    this.title = "KstWorkTimeFile";
	
    

    this.defaultHref = 'KstWorkTimeFile/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = KstWorkTimeFileFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.KstWorkTimeFileFormCustom = _import["KstWorkTimeFileFormCustom"];
        if (this.KstWorkTimeFileFormCustom != null) {
           if (this.KstWorkTimeFileFormCustom["OnShowing"] != null ){
            this.KstWorkTimeFileFormCustom["OnShowing"](this);
          }
          if (this.KstWorkTimeFileFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.KstWorkTimeFileFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File KstWorkTimeFile",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, KstWorkTimeFileModel._EntitySetName, Object.getOwnPropertyNames(KstWorkTimeFileModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidWorkTimeFile;


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
	     this.item = new  KstWorkTimeFileModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidWorkTimeFile = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, KstWorkTimeFileModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, KstWorkTimeFileModel._EntitySetName);
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

