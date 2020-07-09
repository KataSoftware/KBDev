import { bizAppService } from 'src/app/services/business/business.service';
import { KstProxyGeoCityModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KstProxyGeoCityFormFields } from './KstProxyGeoCity-form.fields';

@Component({
  selector: 'KstProxyGeoCity-form',
  templateUrl: './KstProxyGeoCity-form.page.html',
  styleUrls: ['./KstProxyGeoCity-form.page.scss'],
})
export class KstProxyGeoCityFormPage extends AppFormBasePage implements OnInit {
  item: KstProxyGeoCityModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstProxyGeoCityFormCustom:any = null;
  customClass = 'KstProxyGeoCity-form.custom';
  setForm() {
    this.fields = KstProxyGeoCityFormFields.GetFields();
    if (this.KstProxyGeoCityFormCustom != null ){
      this.KstProxyGeoCityFormCustom["OnShowing"](this);
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
    this.title = "KstProxyGeoCity";
	
    

    this.defaultHref = 'KstProxyGeoCity/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = KstProxyGeoCityFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.KstProxyGeoCityFormCustom = _import["KstProxyGeoCityFormCustom"];
        if (this.KstProxyGeoCityFormCustom != null) {
           if (this.KstProxyGeoCityFormCustom["OnShowing"] != null ){
            this.KstProxyGeoCityFormCustom["OnShowing"](this);
          }
          if (this.KstProxyGeoCityFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.KstProxyGeoCityFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File KstProxyGeoCity",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, KstProxyGeoCityModel._EntitySetName, Object.getOwnPropertyNames(KstProxyGeoCityModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidCity;


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
	     this.item = new  KstProxyGeoCityModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidCity = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, KstProxyGeoCityModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, KstProxyGeoCityModel._EntitySetName);
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

