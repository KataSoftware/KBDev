import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { unProxyEventModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';

import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'unProxyEvent-list',
  templateUrl: './unProxyEvent-list.page.html',
  styleUrls: ['./unProxyEvent-list.page.scss'],
})
export class unProxyEventListPage extends AppListBaseTypedPage<unProxyEventModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.unProxyEventListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.unProxyEventListCustom = _import["unProxyEventListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidUnProxyEventCell') public GuidUnProxyEventCell: TemplateRef<any>;

	@ViewChild('TitleCell') public TitleCell: TemplateRef<any>;

	@ViewChild('MessageCell') public MessageCell: TemplateRef<any>;

	@ViewChild('TypeEventCell') public TypeEventCell: TemplateRef<any>;

	@ViewChild('IsExceptionCell') public IsExceptionCell: TemplateRef<any>;

	@ViewChild('UpdatedDateCell') public UpdatedDateCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	unProxyEventListCustom:any = null;
	customClass = 'unProxyEvent-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new unProxyEventModel();
		//this.title = "unProxyEvents";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: unProxyEventModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(unProxyEventModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.unProxyEventListCustom = p["unProxyEventListCustom"];
    if (this.unProxyEventListCustom != null && this.unProxyEventListCustom["OnShowing"] != null){
      this.unProxyEventListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, unProxyEventModel._EntitySetName, Object.getOwnPropertyNames(unProxyEventModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.unProxyEventListCustom != null && this.unProxyEventListCustom["OnItems"] != null) {
						this.unProxyEventListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:unProxyEventModel = null;
  refreshFilter(){
    this.itemFilter = new unProxyEventModel();
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
    
	this.setOrder( { Name: "GuidUnProxyEvent" } );
   
    
	   this.setOrder({ Name: "Title" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.unProxyEventListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.unProxyEventListCustom = _import["unProxyEventListCustom"];
              if (this.unProxyEventListCustom != null) {
                this.unProxyEventListCustom["OnShowing"](this);
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
routeAdd:string="unProxyEvent/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidUnProxyEventCell,
    name: '',
    prop: unProxyEventModel.PropertyNames.GuidUnProxyEvent,
	sortBy: "GuidUnProxyEvent",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.TitleCell,
    name: unProxyEventModel.PropertyNames.Title,
    prop: unProxyEventModel.PropertyNames.Title,
	sortBy: "Title",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.MessageCell,
    name: unProxyEventModel.PropertyNames.Message,
    prop: unProxyEventModel.PropertyNames.Message,
	sortBy: "Message",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.TypeEventCell,
    name: unProxyEventModel.PropertyNames.TypeEvent,
    prop: unProxyEventModel.PropertyNames.TypeEvent,
	sortBy: "TypeEvent",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.IsExceptionCell,
    name: unProxyEventModel.PropertyNames.IsException,
    prop: unProxyEventModel.PropertyNames.IsException,
	sortBy: "IsException",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedDateCell,
    name: unProxyEventModel.PropertyNames.UpdatedDate,
    prop: unProxyEventModel.PropertyNames.UpdatedDate,
	sortBy: "UpdatedDate",
    sortable: true,
    
    headerClass: 'updated',
	cellClass: 'updated',
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

    if (this.unProxyEventListCustom != null && this.unProxyEventListCustom["OnItems"] != null){
      this.unProxyEventListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.unProxyEventListCustom != null && this.unProxyEventListCustom["OnCustomActionExecute"] != null){
      this.unProxyEventListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:unProxyEventModel){
  if (this.unProxyEventListCustom != null && this.unProxyEventListCustom["OnForm"] != null){
    this.unProxyEventListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:unProxyEventModel){
	let route =  `${this.routeAdd}/${row.GuidUnProxyEvent}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.unProxyEventListCustom != null && this.unProxyEventListCustom["OnForm"] != null){
    this.unProxyEventListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:unProxyEventModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidUnProxyEvent }) => GuidUnProxyEvent), unProxyEventModel._EntitySetName);
       
       this.selection.clear();
 
       this.bindData();
   }else{
     
   }
 }

}

