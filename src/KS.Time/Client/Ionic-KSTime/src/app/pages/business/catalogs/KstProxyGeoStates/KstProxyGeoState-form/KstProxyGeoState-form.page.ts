import { bizAppService } from 'src/app/services/business/business.service';
import { KstProxyGeoStateModel } from 'src/app/models/business/models';
import { Component, OnInit, Injector } from '@angular/core';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { sfsService } from 'src/app/services/common/sfs.service';
import { AppFormBasePage, BackToListSettings } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { StorageService, UserService, ApiResponse } from 'sfscommon';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KstProxyGeoStateFormFields } from './KstProxyGeoState-form.fields';

@Component({
  selector: 'KstProxyGeoState-form',
  templateUrl: './KstProxyGeoState-form.page.html',
  styleUrls: ['./KstProxyGeoState-form.page.scss'],
})
export class KstProxyGeoStateFormPage extends AppFormBasePage implements OnInit {
  item: KstProxyGeoStateModel = null;
  guidItem: string = null;
  fields: Array<FormlyFieldConfig> = [];
  KstProxyGeoStateFormCustom:any = null;
  customClass = 'KstProxyGeoState-form.custom';
  setForm() {
    this.fields = KstProxyGeoStateFormFields.GetFields();
    if (this.KstProxyGeoStateFormCustom != null ){
      this.KstProxyGeoStateFormCustom["OnShowing"](this);
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
    this.title = "KstProxyGeoState";
	
    

    this.defaultHref = 'KstProxyGeoState/list';
    this.guidItem = this.route.snapshot.paramMap.get("Id");

   }

  ngOnInit() {
	this.fieldsBack = KstProxyGeoStateFormFields.GetFields();
   
	import(`./${this.customClass}`).then( async (_import)=> {
        this.KstProxyGeoStateFormCustom = _import["KstProxyGeoStateFormCustom"];
        if (this.KstProxyGeoStateFormCustom != null) {
           if (this.KstProxyGeoStateFormCustom["OnShowing"] != null ){
            this.KstProxyGeoStateFormCustom["OnShowing"](this);
          }
          if (this.KstProxyGeoStateFormCustom["OnShowingAsync"] != null){
            await (<Promise<void>>(this.KstProxyGeoStateFormCustom["OnShowingAsync"](this)));
          }
        }
        this.showForm();
        this.getData();
      }).catch((error)=> {
        console.log("error load partial File KstProxyGeoState",  error);
        this.showForm();
        this.getData();
      });
  }

  async getData() {
    if (this.guidItem != null) {
      let result = await this.bizAppService.GetItem(this.guidItem, KstProxyGeoStateModel._EntitySetName, Object.getOwnPropertyNames(KstProxyGeoStateModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","));
      if (result.status == "success") {
        this.item = result.data;
        this.guidItem = this.item.GuidState;


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
	     this.item = new  KstProxyGeoStateModel();
	  }
	  Object.assign(this.item, this.form.value);
      this.item.GuidState = this.guidItem;
      
      let apiResponse: ApiResponse<any> = null;
      console.log("after create or save", this.guidItem);
      if (this.guidItem != null) {
        apiResponse = await  this.bizAppService.Update(this.item, KstProxyGeoStateModel._EntitySetName, this.visibleFields.join(","));
      } else {
        apiResponse = await  this.bizAppService.Create(this.item, KstProxyGeoStateModel._EntitySetName);
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

