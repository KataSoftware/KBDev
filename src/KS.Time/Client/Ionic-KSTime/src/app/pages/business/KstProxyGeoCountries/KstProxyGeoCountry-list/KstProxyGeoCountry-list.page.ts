import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { KstProxyGeoCountryModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';

import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'KstProxyGeoCountry-list',
  templateUrl: './KstProxyGeoCountry-list.page.html',
  styleUrls: ['./KstProxyGeoCountry-list.page.scss'],
})
export class KstProxyGeoCountryListPage extends AppListBaseTypedPage<KstProxyGeoCountryModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.KstProxyGeoCountryListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.KstProxyGeoCountryListCustom = _import["KstProxyGeoCountryListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidCountryCell') public GuidCountryCell: TemplateRef<any>;

	@ViewChild('NameCell') public NameCell: TemplateRef<any>;

	@ViewChild('IsDeletedCell') public IsDeletedCell: TemplateRef<any>;

	@ViewChild('KstProxyGeoStatesCell') public KstProxyGeoStatesCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	KstProxyGeoCountryListCustom:any = null;
	customClass = 'KstProxyGeoCountry-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new KstProxyGeoCountryModel();
		//this.title = "KstProxyGeoCountries";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: KstProxyGeoCountryModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(KstProxyGeoCountryModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.KstProxyGeoCountryListCustom = p["KstProxyGeoCountryListCustom"];
    if (this.KstProxyGeoCountryListCustom != null && this.KstProxyGeoCountryListCustom["OnShowing"] != null){
      this.KstProxyGeoCountryListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, KstProxyGeoCountryModel._EntitySetName, Object.getOwnPropertyNames(KstProxyGeoCountryModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.KstProxyGeoCountryListCustom != null && this.KstProxyGeoCountryListCustom["OnItems"] != null) {
						this.KstProxyGeoCountryListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:KstProxyGeoCountryModel = null;
  refreshFilter(){
    this.itemFilter = new KstProxyGeoCountryModel();
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
    
	this.setOrder( { Name: "GuidCountry" } );
   
    
	   this.setOrder({ Name: "Name" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.KstProxyGeoCountryListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.KstProxyGeoCountryListCustom = _import["KstProxyGeoCountryListCustom"];
              if (this.KstProxyGeoCountryListCustom != null) {
                this.KstProxyGeoCountryListCustom["OnShowing"](this);
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
routeAdd:string="KstProxyGeoCountry/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidCountryCell,
    name: '',
    prop: KstProxyGeoCountryModel.PropertyNames.GuidCountry,
	sortBy: "GuidCountry",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.NameCell,
    name: KstProxyGeoCountryModel.PropertyNames.Name,
    prop: KstProxyGeoCountryModel.PropertyNames.Name,
	sortBy: "Name",
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

    if (this.KstProxyGeoCountryListCustom != null && this.KstProxyGeoCountryListCustom["OnItems"] != null){
      this.KstProxyGeoCountryListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.KstProxyGeoCountryListCustom != null && this.KstProxyGeoCountryListCustom["OnCustomActionExecute"] != null){
      this.KstProxyGeoCountryListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:KstProxyGeoCountryModel){
  if (this.KstProxyGeoCountryListCustom != null && this.KstProxyGeoCountryListCustom["OnForm"] != null){
    this.KstProxyGeoCountryListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:KstProxyGeoCountryModel){
	let route =  `${this.routeAdd}/${row.GuidCountry}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.KstProxyGeoCountryListCustom != null && this.KstProxyGeoCountryListCustom["OnForm"] != null){
    this.KstProxyGeoCountryListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:KstProxyGeoCountryModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidCountry }) => GuidCountry), KstProxyGeoCountryModel._EntitySetName);
       
       this.selection.clear();
 
       this.bindData();
   }else{
     
   }
 }

}

