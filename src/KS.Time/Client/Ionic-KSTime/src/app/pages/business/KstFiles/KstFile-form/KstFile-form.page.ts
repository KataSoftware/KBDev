import { bizAppService } from 'src/app/services/business/business.service';
import { KstFileModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KstFileFormFields } from './KstFile-form.fields';

@Component({
  selector: 'KstFile-form',
  templateUrl: './KstFile-form.page.html',
  styleUrls: ['./KstFile-form.page.scss'],
})
export class KstFileFormPage extends AppFormBasePage implements OnInit {
  item: KstFileModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstFileFormCustom:any = null;
  customClass = 'KstFile-form.custom';
  setForm() {
    this.fields = KstFileFormFields.GetFields();
    if (this.KstFileFormCustom != null ){
      this.KstFileFormCustom["OnShowing"](this);
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
    this.title = "KstFile";
	
    

    this.defaultHref = 'KstFile/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = KstFileFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.KstFileFormCustom = _import["KstFileFormCustom"];
        if (this.KstFileFormCustom != null) {
           if (this.KstFileFormCustom["OnShowing"] != null ){
            this.KstFileFormCustom["OnShowing"](this);
          }
          if (this.KstFileFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.KstFileFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File KstFile",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, KstFileModel._EntitySetName, Object.getOwnPropertyNames(KstFileModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidFile;


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
	     this.item = new  KstFileModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidFile = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, KstFileModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, KstFileModel._EntitySetName);
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

