import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { KstProxyGeoStateModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';
//import swal from 'sweetalert';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'KstProxyGeoState-list',
  templateUrl: './KstProxyGeoState-list.page.html',
  styleUrls: ['./KstProxyGeoState-list.page.scss'],
})
export class KstProxyGeoStateListPage extends AppListBaseTypedPage<KstProxyGeoStateModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.KstProxyGeoStateListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.KstProxyGeoStateListCustom = _import["KstProxyGeoStateListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidStateCell') public GuidStateCell: TemplateRef<any>;

	@ViewChild('NameCell') public NameCell: TemplateRef<any>;

	@ViewChild('IsDeletedCell') public IsDeletedCell: TemplateRef<any>;

	@ViewChild('GuidCountryCell') public GuidCountryCell: TemplateRef<any>;

	@ViewChild('KstProxyGeoCitiesCell') public KstProxyGeoCitiesCell: TemplateRef<any>;

	@ViewChild('KstProxyGeoCountryCell') public KstProxyGeoCountryCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	KstProxyGeoStateListCustom:any = null;
	customClass = 'KstProxyGeoState-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new KstProxyGeoStateModel();
		//this.title = "KstProxyGeoStates";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: KstProxyGeoStateModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(KstProxyGeoStateModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.KstProxyGeoStateListCustom = p["KstProxyGeoStateListCustom"];
    if (this.KstProxyGeoStateListCustom != null && this.KstProxyGeoStateListCustom["OnShowing"] != null){
      this.KstProxyGeoStateListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, KstProxyGeoStateModel._EntitySetName, Object.getOwnPropertyNames(KstProxyGeoStateModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.KstProxyGeoStateListCustom != null && this.KstProxyGeoStateListCustom["OnItems"] != null) {
						this.KstProxyGeoStateListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:KstProxyGeoStateModel = null;
  refreshFilter(){
    this.itemFilter = new KstProxyGeoStateModel();
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
    
	this.setOrder( { Name: "GuidState" } );
   
    
	   this.setOrder({ Name: "Name" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.KstProxyGeoStateListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.KstProxyGeoStateListCustom = _import["KstProxyGeoStateListCustom"];
              if (this.KstProxyGeoStateListCustom != null) {
                this.KstProxyGeoStateListCustom["OnShowing"](this);
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
routeAdd:string="KstProxyGeoState/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidStateCell,
    name: '',
    prop: KstProxyGeoStateModel.PropertyNames.GuidState,
	sortBy: "GuidState",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.NameCell,
    name: KstProxyGeoStateModel.PropertyNames.Name,
    prop: KstProxyGeoStateModel.PropertyNames.Name,
	sortBy: "Name",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.GuidCountryCell,
    name: KstProxyGeoStateModel.PropertyNames.GuidCountry,
    prop: KstProxyGeoStateModel.PropertyNames.GuidCountry,
	sortBy: "GuidCountry",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.KstProxyGeoCountryCell,
    name: KstProxyGeoStateModel.PropertyNames.KstProxyGeoCountry,
    prop: `Fk${KstProxyGeoStateModel.PropertyNames.KstProxyGeoCountry}Text`,
	sortBy: "KstProxyGeoCountry.Name",
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

    if (this.KstProxyGeoStateListCustom != null && this.KstProxyGeoStateListCustom["OnItems"] != null){
      this.KstProxyGeoStateListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.KstProxyGeoStateListCustom != null && this.KstProxyGeoStateListCustom["OnCustomActionExecute"] != null){
      this.KstProxyGeoStateListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:KstProxyGeoStateModel){
  if (this.KstProxyGeoStateListCustom != null && this.KstProxyGeoStateListCustom["OnForm"] != null){
    this.KstProxyGeoStateListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:KstProxyGeoStateModel){
	let route =  `${this.routeAdd}/${row.GuidState}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.KstProxyGeoStateListCustom != null && this.KstProxyGeoStateListCustom["OnForm"] != null){
    this.KstProxyGeoStateListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:KstProxyGeoStateModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidState }) => GuidState), KstProxyGeoStateModel._EntitySetName);
       //swal.close();
       this.selection.clear();
 
       this.bindData();
   }else{
     //swal.close();
   }
 }

}

