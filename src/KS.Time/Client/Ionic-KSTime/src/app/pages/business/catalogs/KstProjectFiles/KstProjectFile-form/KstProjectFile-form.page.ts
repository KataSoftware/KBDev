import { bizAppService } from 'src/app/services/business/business.service';
import { KstProjectFileModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KstProjectFileFormFields } from './KstProjectFile-form.fields';

@Component({
  selector: 'KstProjectFile-form',
  templateUrl: './KstProjectFile-form.page.html',
  styleUrls: ['./KstProjectFile-form.page.scss'],
})
export class KstProjectFileFormPage extends AppFormBasePage implements OnInit {
  item: KstProjectFileModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstProjectFileFormCustom:any = null;
  customClass = 'KstProjectFile-form.custom';
  setForm() {
    this.fields = KstProjectFileFormFields.GetFields();
    if (this.KstProjectFileFormCustom != null ){
      this.KstProjectFileFormCustom["OnShowing"](this);
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
    this.title = "KstProjectFile";
	
    

    this.defaultHref = 'KstProjectFile/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = KstProjectFileFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.KstProjectFileFormCustom = _import["KstProjectFileFormCustom"];
        if (this.KstProjectFileFormCustom != null) {
           if (this.KstProjectFileFormCustom["OnShowing"] != null ){
            this.KstProjectFileFormCustom["OnShowing"](this);
          }
          if (this.KstProjectFileFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.KstProjectFileFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File KstProjectFile",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, KstProjectFileModel._EntitySetName, Object.getOwnPropertyNames(KstProjectFileModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidProjectFile;


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
	     this.item = new  KstProjectFileModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidProjectFile = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, KstProjectFileModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, KstProjectFileModel._EntitySetName);
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

