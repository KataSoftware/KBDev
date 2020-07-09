import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { unProxySettingModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';
//import swal from 'sweetalert';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'unProxySetting-list',
  templateUrl: './unProxySetting-list.page.html',
  styleUrls: ['./unProxySetting-list.page.scss'],
})
export class unProxySettingListPage extends AppListBaseTypedPage<unProxySettingModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.unProxySettingListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.unProxySettingListCustom = _import["unProxySettingListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidUnProxySettingCell') public GuidUnProxySettingCell: TemplateRef<any>;

	@ViewChild('SMTPServerCell') public SMTPServerCell: TemplateRef<any>;

	@ViewChild('SMTPSSLEnabledCell') public SMTPSSLEnabledCell: TemplateRef<any>;

	@ViewChild('SMTPUserCell') public SMTPUserCell: TemplateRef<any>;

	@ViewChild('SMTPPasswordCell') public SMTPPasswordCell: TemplateRef<any>;

	@ViewChild('SMTPFromNameCell') public SMTPFromNameCell: TemplateRef<any>;

	@ViewChild('SMTPPortCell') public SMTPPortCell: TemplateRef<any>;

	@ViewChild('SMTPFromEmailCell') public SMTPFromEmailCell: TemplateRef<any>;

	@ViewChild('AzureBlobStorageConnectionCell') public AzureBlobStorageConnectionCell: TemplateRef<any>;

	@ViewChild('SaveBlobInAzureStorageCell') public SaveBlobInAzureStorageCell: TemplateRef<any>;

	@ViewChild('SaveBlobInDataBaseCell') public SaveBlobInDataBaseCell: TemplateRef<any>;

	@ViewChild('UserNameGeoNamesCell') public UserNameGeoNamesCell: TemplateRef<any>;

	@ViewChild('EngineURLCell') public EngineURLCell: TemplateRef<any>;

	@ViewChild('ENGINE_API_KEYCell') public ENGINE_API_KEYCell: TemplateRef<any>;

	@ViewChild('MAMBU_URLCell') public MAMBU_URLCell: TemplateRef<any>;

	@ViewChild('MAMBU_USERCell') public MAMBU_USERCell: TemplateRef<any>;

	@ViewChild('MAMBU_PWDCell') public MAMBU_PWDCell: TemplateRef<any>;

	@ViewChild('KM_MAXIMOCell') public KM_MAXIMOCell: TemplateRef<any>;

	@ViewChild('MAP_KEYCell') public MAP_KEYCell: TemplateRef<any>;

	@ViewChild('ENGINE_OAUTH_CLIENT_IDCell') public ENGINE_OAUTH_CLIENT_IDCell: TemplateRef<any>;

	@ViewChild('ENGINE_OAUTH_LOGIN_URLCell') public ENGINE_OAUTH_LOGIN_URLCell: TemplateRef<any>;

	@ViewChild('ENGINE_OAUTH_USERNAMECell') public ENGINE_OAUTH_USERNAMECell: TemplateRef<any>;

	@ViewChild('ENGINE_OAUTH_PASSWORDCell') public ENGINE_OAUTH_PASSWORDCell: TemplateRef<any>;

	@ViewChild('ENGINE_OAUTH_CLIENT_SECRETCell') public ENGINE_OAUTH_CLIENT_SECRETCell: TemplateRef<any>;

	@ViewChild('ENGINE_DEFINITION_IDCell') public ENGINE_DEFINITION_IDCell: TemplateRef<any>;

	@ViewChild('CONTAINER_DATOS_CLIENTE_IDCell') public CONTAINER_DATOS_CLIENTE_IDCell: TemplateRef<any>;

	@ViewChild('CONTAINER_DOCUMENTOS_IDCell') public CONTAINER_DOCUMENTOS_IDCell: TemplateRef<any>;

	@ViewChild('CONTAINER_DIRECCION_IDCell') public CONTAINER_DIRECCION_IDCell: TemplateRef<any>;

	@ViewChild('CONTAINER_DATOS_FINANCIEROS_IDCell') public CONTAINER_DATOS_FINANCIEROS_IDCell: TemplateRef<any>;

	@ViewChild('CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_IDCell') public CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_IDCell: TemplateRef<any>;

	@ViewChild('CONTAINER_BENEFICIARIOS_IDCell') public CONTAINER_BENEFICIARIOS_IDCell: TemplateRef<any>;

	@ViewChild('CONTAINER_CONTRATOS_IDCell') public CONTAINER_CONTRATOS_IDCell: TemplateRef<any>;

	@ViewChild('CONTAINER_APROBACION_IDCell') public CONTAINER_APROBACION_IDCell: TemplateRef<any>;

	@ViewChild('MAMBU_CONTRATO_TEMPLATEIDCell') public MAMBU_CONTRATO_TEMPLATEIDCell: TemplateRef<any>;

	@ViewChild('MAMBU_CARATULA_TEMPLATEIDCell') public MAMBU_CARATULA_TEMPLATEIDCell: TemplateRef<any>;

	@ViewChild('MAMBU_PAGARE_TEMPLATEIDCell') public MAMBU_PAGARE_TEMPLATEIDCell: TemplateRef<any>;

	@ViewChild('MAMBU_REFERENCIASPAGO_TEMPLATEIDCell') public MAMBU_REFERENCIASPAGO_TEMPLATEIDCell: TemplateRef<any>;

	@ViewChild('MATI_AUTH_HEADERCell') public MATI_AUTH_HEADERCell: TemplateRef<any>;

	@ViewChild('WEBBHOOK_MATI_KEYCell') public WEBBHOOK_MATI_KEYCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	unProxySettingListCustom:any = null;
	customClass = 'unProxySetting-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new unProxySettingModel();
		//this.title = "unProxySettings";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: unProxySettingModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(unProxySettingModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.unProxySettingListCustom = p["unProxySettingListCustom"];
    if (this.unProxySettingListCustom != null && this.unProxySettingListCustom["OnShowing"] != null){
      this.unProxySettingListCustom["OnShowing"](this);
    }
	  }).catch(error=> {
		console.log(error);
    });*/

  }

  async ionViewWillEnter() {
    let navData = this.sfsService.GetNavigationData();
        console.log("ionViewWillEnter navData", navData);
        if (navData != null ){
            if (navData.RefreshData == true ){
                if (this.loadingData == false) { 
                    await this.bindData({ RestartPaging: navData.RestartPaging }); 
                }
            }else if (navData.ItemUpdated != null){
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, unProxySettingModel._EntitySetName, Object.getOwnPropertyNames(unProxySettingModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.unProxySettingListCustom != null && this.unProxySettingListCustom["OnItems"] != null) {
						this.unProxySettingListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:unProxySettingModel = null;
  refreshFilter(){
    this.itemFilter = new unProxySettingModel();
    this.serviceData.Query = "";
    this.bindData();
  }

  showFilter(){
    if (this.hideFilter == true) {
      this.hideFilter = false;
    } else{
        this.hideFilter = true;
    }
  }


   ngOnInit() {
   console.log("ubiCustomer ngOnInit");
  //this.userData = await this.userService.getUserData();
  //let query: string;

	
     this.getColumns();
    
	this.setOrder( { Name: "GuidUnProxySetting" } );
   
    
	   this.setOrder({ Name: "SMTPServer" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.unProxySettingListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.unProxySettingListCustom = _import["unProxySettingListCustom"];
              if (this.unProxySettingListCustom != null) {
                this.unProxySettingListCustom["OnShowing"](this);
				this.externalCustomFileChecked = true;
                this.bindDisplayColumns();
                this.bindData();
            }
            }).catch((error)=> {
				this.externalCustomFileChecked = true;
				console.log("error userData", error);
            });
          
		
            }).catch(error=> {
			  this.externalCustomFileChecked= true;
              console.log("error", error);
			  this.bindDisplayColumns();
              this.bindData();
            });
       }
       

		

}
bindDisplayColumns(){
  this.displayedColumns = [];
  for (let column of this.tableColumns) { this.displayedColumns.push(column.prop); }

}
routeAdd:string="unProxySetting/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidUnProxySettingCell,
    name: '',
    prop: unProxySettingModel.PropertyNames.GuidUnProxySetting,
	sortBy: "GuidUnProxySetting",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.SMTPServerCell,
    name: unProxySettingModel.PropertyNames.SMTPServer,
    prop: unProxySettingModel.PropertyNames.SMTPServer,
	sortBy: "SMTPServer",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.SMTPSSLEnabledCell,
    name: unProxySettingModel.PropertyNames.SMTPSSLEnabled,
    prop: unProxySettingModel.PropertyNames.SMTPSSLEnabled,
	sortBy: "SMTPSSLEnabled",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.SMTPUserCell,
    name: unProxySettingModel.PropertyNames.SMTPUser,
    prop: unProxySettingModel.PropertyNames.SMTPUser,
	sortBy: "SMTPUser",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.SMTPPasswordCell,
    name: unProxySettingModel.PropertyNames.SMTPPassword,
    prop: unProxySettingModel.PropertyNames.SMTPPassword,
	sortBy: "SMTPPassword",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.SMTPFromNameCell,
    name: unProxySettingModel.PropertyNames.SMTPFromName,
    prop: unProxySettingModel.PropertyNames.SMTPFromName,
	sortBy: "SMTPFromName",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.SMTPPortCell,
    name: unProxySettingModel.PropertyNames.SMTPPort,
    prop: unProxySettingModel.PropertyNames.SMTPPort,
	sortBy: "SMTPPort",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.SMTPFromEmailCell,
    name: unProxySettingModel.PropertyNames.SMTPFromEmail,
    prop: unProxySettingModel.PropertyNames.SMTPFromEmail,
	sortBy: "SMTPFromEmail",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.AzureBlobStorageConnectionCell,
    name: unProxySettingModel.PropertyNames.AzureBlobStorageConnection,
    prop: unProxySettingModel.PropertyNames.AzureBlobStorageConnection,
	sortBy: "AzureBlobStorageConnection",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.SaveBlobInAzureStorageCell,
    name: unProxySettingModel.PropertyNames.SaveBlobInAzureStorage,
    prop: unProxySettingModel.PropertyNames.SaveBlobInAzureStorage,
	sortBy: "SaveBlobInAzureStorage",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.SaveBlobInDataBaseCell,
    name: unProxySettingModel.PropertyNames.SaveBlobInDataBase,
    prop: unProxySettingModel.PropertyNames.SaveBlobInDataBase,
	sortBy: "SaveBlobInDataBase",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UserNameGeoNamesCell,
    name: unProxySettingModel.PropertyNames.UserNameGeoNames,
    prop: unProxySettingModel.PropertyNames.UserNameGeoNames,
	sortBy: "UserNameGeoNames",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.EngineURLCell,
    name: unProxySettingModel.PropertyNames.EngineURL,
    prop: unProxySettingModel.PropertyNames.EngineURL,
	sortBy: "EngineURL",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.ENGINE_API_KEYCell,
    name: unProxySettingModel.PropertyNames.ENGINE_API_KEY,
    prop: unProxySettingModel.PropertyNames.ENGINE_API_KEY,
	sortBy: "ENGINE_API_KEY",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.MAMBU_URLCell,
    name: unProxySettingModel.PropertyNames.MAMBU_URL,
    prop: unProxySettingModel.PropertyNames.MAMBU_URL,
	sortBy: "MAMBU_URL",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.MAMBU_USERCell,
    name: unProxySettingModel.PropertyNames.MAMBU_USER,
    prop: unProxySettingModel.PropertyNames.MAMBU_USER,
	sortBy: "MAMBU_USER",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.MAMBU_PWDCell,
    name: unProxySettingModel.PropertyNames.MAMBU_PWD,
    prop: unProxySettingModel.PropertyNames.MAMBU_PWD,
	sortBy: "MAMBU_PWD",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.KM_MAXIMOCell,
    name: unProxySettingModel.PropertyNames.KM_MAXIMO,
    prop: unProxySettingModel.PropertyNames.KM_MAXIMO,
	sortBy: "KM_MAXIMO",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.MAP_KEYCell,
    name: unProxySettingModel.PropertyNames.MAP_KEY,
    prop: unProxySettingModel.PropertyNames.MAP_KEY,
	sortBy: "MAP_KEY",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.ENGINE_OAUTH_CLIENT_IDCell,
    name: unProxySettingModel.PropertyNames.ENGINE_OAUTH_CLIENT_ID,
    prop: unProxySettingModel.PropertyNames.ENGINE_OAUTH_CLIENT_ID,
	sortBy: "ENGINE_OAUTH_CLIENT_ID",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.ENGINE_OAUTH_LOGIN_URLCell,
    name: unProxySettingModel.PropertyNames.ENGINE_OAUTH_LOGIN_URL,
    prop: unProxySettingModel.PropertyNames.ENGINE_OAUTH_LOGIN_URL,
	sortBy: "ENGINE_OAUTH_LOGIN_URL",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.ENGINE_OAUTH_USERNAMECell,
    name: unProxySettingModel.PropertyNames.ENGINE_OAUTH_USERNAME,
    prop: unProxySettingModel.PropertyNames.ENGINE_OAUTH_USERNAME,
	sortBy: "ENGINE_OAUTH_USERNAME",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.ENGINE_OAUTH_PASSWORDCell,
    name: unProxySettingModel.PropertyNames.ENGINE_OAUTH_PASSWORD,
    prop: unProxySettingModel.PropertyNames.ENGINE_OAUTH_PASSWORD,
	sortBy: "ENGINE_OAUTH_PASSWORD",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.ENGINE_OAUTH_CLIENT_SECRETCell,
    name: unProxySettingModel.PropertyNames.ENGINE_OAUTH_CLIENT_SECRET,
    prop: unProxySettingModel.PropertyNames.ENGINE_OAUTH_CLIENT_SECRET,
	sortBy: "ENGINE_OAUTH_CLIENT_SECRET",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.ENGINE_DEFINITION_IDCell,
    name: unProxySettingModel.PropertyNames.ENGINE_DEFINITION_ID,
    prop: unProxySettingModel.PropertyNames.ENGINE_DEFINITION_ID,
	sortBy: "ENGINE_DEFINITION_ID",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CONTAINER_DATOS_CLIENTE_IDCell,
    name: unProxySettingModel.PropertyNames.CONTAINER_DATOS_CLIENTE_ID,
    prop: unProxySettingModel.PropertyNames.CONTAINER_DATOS_CLIENTE_ID,
	sortBy: "CONTAINER_DATOS_CLIENTE_ID",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CONTAINER_DOCUMENTOS_IDCell,
    name: unProxySettingModel.PropertyNames.CONTAINER_DOCUMENTOS_ID,
    prop: unProxySettingModel.PropertyNames.CONTAINER_DOCUMENTOS_ID,
	sortBy: "CONTAINER_DOCUMENTOS_ID",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CONTAINER_DIRECCION_IDCell,
    name: unProxySettingModel.PropertyNames.CONTAINER_DIRECCION_ID,
    prop: unProxySettingModel.PropertyNames.CONTAINER_DIRECCION_ID,
	sortBy: "CONTAINER_DIRECCION_ID",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CONTAINER_DATOS_FINANCIEROS_IDCell,
    name: unProxySettingModel.PropertyNames.CONTAINER_DATOS_FINANCIEROS_ID,
    prop: unProxySettingModel.PropertyNames.CONTAINER_DATOS_FINANCIEROS_ID,
	sortBy: "CONTAINER_DATOS_FINANCIEROS_ID",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_IDCell,
    name: unProxySettingModel.PropertyNames.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID,
    prop: unProxySettingModel.PropertyNames.CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID,
	sortBy: "CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CONTAINER_BENEFICIARIOS_IDCell,
    name: unProxySettingModel.PropertyNames.CONTAINER_BENEFICIARIOS_ID,
    prop: unProxySettingModel.PropertyNames.CONTAINER_BENEFICIARIOS_ID,
	sortBy: "CONTAINER_BENEFICIARIOS_ID",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CONTAINER_CONTRATOS_IDCell,
    name: unProxySettingModel.PropertyNames.CONTAINER_CONTRATOS_ID,
    prop: unProxySettingModel.PropertyNames.CONTAINER_CONTRATOS_ID,
	sortBy: "CONTAINER_CONTRATOS_ID",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CONTAINER_APROBACION_IDCell,
    name: unProxySettingModel.PropertyNames.CONTAINER_APROBACION_ID,
    prop: unProxySettingModel.PropertyNames.CONTAINER_APROBACION_ID,
	sortBy: "CONTAINER_APROBACION_ID",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.MAMBU_CONTRATO_TEMPLATEIDCell,
    name: unProxySettingModel.PropertyNames.MAMBU_CONTRATO_TEMPLATEID,
    prop: unProxySettingModel.PropertyNames.MAMBU_CONTRATO_TEMPLATEID,
	sortBy: "MAMBU_CONTRATO_TEMPLATEID",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.MAMBU_CARATULA_TEMPLATEIDCell,
    name: unProxySettingModel.PropertyNames.MAMBU_CARATULA_TEMPLATEID,
    prop: unProxySettingModel.PropertyNames.MAMBU_CARATULA_TEMPLATEID,
	sortBy: "MAMBU_CARATULA_TEMPLATEID",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.MAMBU_PAGARE_TEMPLATEIDCell,
    name: unProxySettingModel.PropertyNames.MAMBU_PAGARE_TEMPLATEID,
    prop: unProxySettingModel.PropertyNames.MAMBU_PAGARE_TEMPLATEID,
	sortBy: "MAMBU_PAGARE_TEMPLATEID",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.MAMBU_REFERENCIASPAGO_TEMPLATEIDCell,
    name: unProxySettingModel.PropertyNames.MAMBU_REFERENCIASPAGO_TEMPLATEID,
    prop: unProxySettingModel.PropertyNames.MAMBU_REFERENCIASPAGO_TEMPLATEID,
	sortBy: "MAMBU_REFERENCIASPAGO_TEMPLATEID",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.MATI_AUTH_HEADERCell,
    name: unProxySettingModel.PropertyNames.MATI_AUTH_HEADER,
    prop: unProxySettingModel.PropertyNames.MATI_AUTH_HEADER,
	sortBy: "MATI_AUTH_HEADER",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.WEBBHOOK_MATI_KEYCell,
    name: unProxySettingModel.PropertyNames.WEBBHOOK_MATI_KEY,
    prop: unProxySettingModel.PropertyNames.WEBBHOOK_MATI_KEY,
	sortBy: "WEBBHOOK_MATI_KEY",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
    
{
	
	cellTemplate: this.actionsTmpl,
    name: '',
    prop: "actions",
    sortable: false,
    cellClass: 'actions',
    headerClass: 'actions',
	
},
    ];

	}
existsPendingReport:boolean=false;
public async bindData(settings?: BindListSettings) {
  try {
  
			let restartPaging: Boolean = true;
            if (settings != null) {
                restartPaging = settings.RestartPaging;
            }
			 await this.configurePagination(this.serviceData);
                this.pagination.pageIndex = 0;
	this.data = await this.getData(this.pagination);

  }
  catch (error) { this.logError(error); }
  finally { this.loadingData = false; }
}
onGetData(data:any){
  console.log("onGetData", data);
  
 
    data.forEach((p)=>{
      p['_actions'] = this.getActions(p);
    });

    if (this.unProxySettingListCustom != null && this.unProxySettingListCustom["OnItems"] != null){
      this.unProxySettingListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.unProxySettingListCustom != null && this.unProxySettingListCustom["OnCustomActionExecute"] != null){
      this.unProxySettingListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:unProxySettingModel){
  if (this.unProxySettingListCustom != null && this.unProxySettingListCustom["OnForm"] != null){
    this.unProxySettingListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:unProxySettingModel){
	let route =  `${this.routeAdd}/${row.GuidUnProxySetting}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.unProxySettingListCustom != null && this.unProxySettingListCustom["OnForm"] != null){
    this.unProxySettingListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:unProxySettingModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidUnProxySetting }) => GuidUnProxySetting), unProxySettingModel._EntitySetName);
       //swal.close();
       this.selection.clear();
 
       this.bindData();
   }else{
     //swal.close();
   }
 }

}

