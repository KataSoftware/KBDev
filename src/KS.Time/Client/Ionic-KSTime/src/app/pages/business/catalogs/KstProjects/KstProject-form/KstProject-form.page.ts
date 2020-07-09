import { bizAppService } from 'src/app/services/business/business.service';
import { KstProjectModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KstProjectFormFields } from './KstProject-form.fields';

@Component({
  selector: 'KstProject-form',
  templateUrl: './KstProject-form.page.html',
  styleUrls: ['./KstProject-form.page.scss'],
})
export class KstProjectFormPage extends AppFormBasePage implements OnInit {
  item: KstProjectModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstProjectFormCustom:any = null;
  customClass = 'KstProject-form.custom';
  setForm() {
    this.fields = KstProjectFormFields.GetFields();
    if (this.KstProjectFormCustom != null ){
      this.KstProjectFormCustom["OnShowing"](this);
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
    this.title = "KstProject";
	
    

    this.defaultHref = 'KstProject/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = KstProjectFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.KstProjectFormCustom = _import["KstProjectFormCustom"];
        if (this.KstProjectFormCustom != null) {
           if (this.KstProjectFormCustom["OnShowing"] != null ){
            this.KstProjectFormCustom["OnShowing"](this);
          }
          if (this.KstProjectFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.KstProjectFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File KstProject",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, KstProjectModel._EntitySetName, Object.getOwnPropertyNames(KstProjectModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidProject;


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
	     this.item = new  KstProjectModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidProject = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, KstProjectModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, KstProjectModel._EntitySetName);
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

