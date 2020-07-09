import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { KstProxyGeoCityModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';
//import swal from 'sweetalert';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'KstProxyGeoCity-list',
  templateUrl: './KstProxyGeoCity-list.page.html',
  styleUrls: ['./KstProxyGeoCity-list.page.scss'],
})
export class KstProxyGeoCityListPage extends AppListBaseTypedPage<KstProxyGeoCityModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.KstProxyGeoCityListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.KstProxyGeoCityListCustom = _import["KstProxyGeoCityListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidCityCell') public GuidCityCell: TemplateRef<any>;

	@ViewChild('NameCell') public NameCell: TemplateRef<any>;

	@ViewChild('IsDeletedCell') public IsDeletedCell: TemplateRef<any>;

	@ViewChild('GuidStateCell') public GuidStateCell: TemplateRef<any>;

	@ViewChild('GuidParentCell') public GuidParentCell: TemplateRef<any>;

	@ViewChild('KstProxyGeoCity1Cell') public KstProxyGeoCity1Cell: TemplateRef<any>;

	@ViewChild('KstProxyGeoCity2Cell') public KstProxyGeoCity2Cell: TemplateRef<any>;

	@ViewChild('KstProxyGeoStateCell') public KstProxyGeoStateCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	KstProxyGeoCityListCustom:any = null;
	customClass = 'KstProxyGeoCity-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new KstProxyGeoCityModel();
		//this.title = "KstProxyGeoCities";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: KstProxyGeoCityModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(KstProxyGeoCityModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.KstProxyGeoCityListCustom = p["KstProxyGeoCityListCustom"];
    if (this.KstProxyGeoCityListCustom != null && this.KstProxyGeoCityListCustom["OnShowing"] != null){
      this.KstProxyGeoCityListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, KstProxyGeoCityModel._EntitySetName, Object.getOwnPropertyNames(KstProxyGeoCityModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.KstProxyGeoCityListCustom != null && this.KstProxyGeoCityListCustom["OnItems"] != null) {
						this.KstProxyGeoCityListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:KstProxyGeoCityModel = null;
  refreshFilter(){
    this.itemFilter = new KstProxyGeoCityModel();
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
    
	this.setOrder( { Name: "GuidCity" } );
   
    
	   this.setOrder({ Name: "Name" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.KstProxyGeoCityListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.KstProxyGeoCityListCustom = _import["KstProxyGeoCityListCustom"];
              if (this.KstProxyGeoCityListCustom != null) {
                this.KstProxyGeoCityListCustom["OnShowing"](this);
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
routeAdd:string="KstProxyGeoCity/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidCityCell,
    name: '',
    prop: KstProxyGeoCityModel.PropertyNames.GuidCity,
	sortBy: "GuidCity",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.NameCell,
    name: KstProxyGeoCityModel.PropertyNames.Name,
    prop: KstProxyGeoCityModel.PropertyNames.Name,
	sortBy: "Name",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.GuidStateCell,
    name: KstProxyGeoCityModel.PropertyNames.GuidState,
    prop: KstProxyGeoCityModel.PropertyNames.GuidState,
	sortBy: "GuidState",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.GuidParentCell,
    name: KstProxyGeoCityModel.PropertyNames.GuidParent,
    prop: KstProxyGeoCityModel.PropertyNames.GuidParent,
	sortBy: "GuidParent",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.KstProxyGeoCity2Cell,
    name: KstProxyGeoCityModel.PropertyNames.KstProxyGeoCity2,
    prop: `Fk${KstProxyGeoCityModel.PropertyNames.KstProxyGeoCity2}Text`,
	sortBy: "KstProxyGeoCity.Name",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.KstProxyGeoStateCell,
    name: KstProxyGeoCityModel.PropertyNames.KstProxyGeoState,
    prop: `Fk${KstProxyGeoCityModel.PropertyNames.KstProxyGeoState}Text`,
	sortBy: "KstProxyGeoState.Name",
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

    if (this.KstProxyGeoCityListCustom != null && this.KstProxyGeoCityListCustom["OnItems"] != null){
      this.KstProxyGeoCityListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.KstProxyGeoCityListCustom != null && this.KstProxyGeoCityListCustom["OnCustomActionExecute"] != null){
      this.KstProxyGeoCityListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:KstProxyGeoCityModel){
  if (this.KstProxyGeoCityListCustom != null && this.KstProxyGeoCityListCustom["OnForm"] != null){
    this.KstProxyGeoCityListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:KstProxyGeoCityModel){
	let route =  `${this.routeAdd}/${row.GuidCity}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.KstProxyGeoCityListCustom != null && this.KstProxyGeoCityListCustom["OnForm"] != null){
    this.KstProxyGeoCityListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:KstProxyGeoCityModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidCity }) => GuidCity), KstProxyGeoCityModel._EntitySetName);
       //swal.close();
       this.selection.clear();
 
       this.bindData();
   }else{
     //swal.close();
   }
 }

}

