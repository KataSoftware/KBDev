import { bizAppService } from 'src/app/services/business/business.service';
import { KstProxyGeoCountryModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KstProxyGeoCountryFormFields } from './KstProxyGeoCountry-form.fields';

@Component({
  selector: 'KstProxyGeoCountry-form',
  templateUrl: './KstProxyGeoCountry-form.page.html',
  styleUrls: ['./KstProxyGeoCountry-form.page.scss'],
})
export class KstProxyGeoCountryFormPage extends AppFormBasePage implements OnInit {
  item: KstProxyGeoCountryModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstProxyGeoCountryFormCustom:any = null;
  customClass = 'KstProxyGeoCountry-form.custom';
  setForm() {
    this.fields = KstProxyGeoCountryFormFields.GetFields();
    if (this.KstProxyGeoCountryFormCustom != null ){
      this.KstProxyGeoCountryFormCustom["OnShowing"](this);
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
    this.title = "KstProxyGeoCountry";
	
    

    this.defaultHref = 'KstProxyGeoCountry/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = KstProxyGeoCountryFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.KstProxyGeoCountryFormCustom = _import["KstProxyGeoCountryFormCustom"];
        if (this.KstProxyGeoCountryFormCustom != null) {
           if (this.KstProxyGeoCountryFormCustom["OnShowing"] != null ){
            this.KstProxyGeoCountryFormCustom["OnShowing"](this);
          }
          if (this.KstProxyGeoCountryFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.KstProxyGeoCountryFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File KstProxyGeoCountry",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, KstProxyGeoCountryModel._EntitySetName, Object.getOwnPropertyNames(KstProxyGeoCountryModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidCountry;


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
	     this.item = new  KstProxyGeoCountryModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidCountry = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, KstProxyGeoCountryModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, KstProxyGeoCountryModel._EntitySetName);
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

