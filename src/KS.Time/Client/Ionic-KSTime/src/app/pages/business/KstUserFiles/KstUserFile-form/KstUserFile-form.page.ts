import { bizAppService } from 'src/app/services/business/business.service';
import { KstUserFileModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KstUserFileFormFields } from './KstUserFile-form.fields';

@Component({
  selector: 'KstUserFile-form',
  templateUrl: './KstUserFile-form.page.html',
  styleUrls: ['./KstUserFile-form.page.scss'],
})
export class KstUserFileFormPage extends AppFormBasePage implements OnInit {
  item: KstUserFileModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstUserFileFormCustom:any = null;
  customClass = 'KstUserFile-form.custom';
  setForm() {
    this.fields = KstUserFileFormFields.GetFields();
    if (this.KstUserFileFormCustom != null ){
      this.KstUserFileFormCustom["OnShowing"](this);
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
    this.title = "KstUserFile";
	
    

    this.defaultHref = 'KstUserFile/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = KstUserFileFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.KstUserFileFormCustom = _import["KstUserFileFormCustom"];
        if (this.KstUserFileFormCustom != null) {
           if (this.KstUserFileFormCustom["OnShowing"] != null ){
            this.KstUserFileFormCustom["OnShowing"](this);
          }
          if (this.KstUserFileFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.KstUserFileFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File KstUserFile",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, KstUserFileModel._EntitySetName, Object.getOwnPropertyNames(KstUserFileModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidUserFile;


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
	     this.item = new  KstUserFileModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidUserFile = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, KstUserFileModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, KstUserFileModel._EntitySetName);
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

