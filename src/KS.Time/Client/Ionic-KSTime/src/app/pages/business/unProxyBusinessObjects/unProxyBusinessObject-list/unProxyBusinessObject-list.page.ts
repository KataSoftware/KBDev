import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { unProxyBusinessObjectModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';
import swal from 'sweetalert';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'unProxyBusinessObject-list',
  templateUrl: './unProxyBusinessObject-list.page.html',
  styleUrls: ['./unProxyBusinessObject-list.page.scss'],
})
export class unProxyBusinessObjectListPage extends AppListBaseTypedPage<unProxyBusinessObjectModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.unProxyBusinessObjectListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.unProxyBusinessObjectListCustom = _import["unProxyBusinessObjectListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidBusinessObjectCell') public GuidBusinessObjectCell: TemplateRef<any>;

	@ViewChild('NameCell') public NameCell: TemplateRef<any>;

	@ViewChild('BusinessObjectKeyCell') public BusinessObjectKeyCell: TemplateRef<any>;

	@ViewChild('EntitySetNameCell') public EntitySetNameCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	unProxyBusinessObjectListCustom:any = null;
	customClass = 'unProxyBusinessObject-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new unProxyBusinessObjectModel();
		//this.title = "unProxyBusinessObjects";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: unProxyBusinessObjectModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(unProxyBusinessObjectModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.unProxyBusinessObjectListCustom = p["unProxyBusinessObjectListCustom"];
    if (this.unProxyBusinessObjectListCustom != null && this.unProxyBusinessObjectListCustom["OnShowing"] != null){
      this.unProxyBusinessObjectListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, unProxyBusinessObjectModel._EntitySetName, Object.getOwnPropertyNames(unProxyBusinessObjectModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.unProxyBusinessObjectListCustom != null && this.unProxyBusinessObjectListCustom["OnItems"] != null) {
						this.unProxyBusinessObjectListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:unProxyBusinessObjectModel = null;
  refreshFilter(){
    this.itemFilter = new unProxyBusinessObjectModel();
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
    
	this.setOrder( { Name: "GuidBusinessObject" } );
   
    
	   this.setOrder({ Name: "Name" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.unProxyBusinessObjectListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.unProxyBusinessObjectListCustom = _import["unProxyBusinessObjectListCustom"];
              if (this.unProxyBusinessObjectListCustom != null) {
                this.unProxyBusinessObjectListCustom["OnShowing"](this);
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
routeAdd:string="unProxyBusinessObject/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidBusinessObjectCell,
    name: '',
    prop: unProxyBusinessObjectModel.PropertyNames.GuidBusinessObject,
	sortBy: "GuidBusinessObject",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.NameCell,
    name: unProxyBusinessObjectModel.PropertyNames.Name,
    prop: unProxyBusinessObjectModel.PropertyNames.Name,
	sortBy: "Name",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.BusinessObjectKeyCell,
    name: unProxyBusinessObjectModel.PropertyNames.BusinessObjectKey,
    prop: unProxyBusinessObjectModel.PropertyNames.BusinessObjectKey,
	sortBy: "BusinessObjectKey",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.EntitySetNameCell,
    name: unProxyBusinessObjectModel.PropertyNames.EntitySetName,
    prop: unProxyBusinessObjectModel.PropertyNames.EntitySetName,
	sortBy: "EntitySetName",
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

    if (this.unProxyBusinessObjectListCustom != null && this.unProxyBusinessObjectListCustom["OnItems"] != null){
      this.unProxyBusinessObjectListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.unProxyBusinessObjectListCustom != null && this.unProxyBusinessObjectListCustom["OnCustomActionExecute"] != null){
      this.unProxyBusinessObjectListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:unProxyBusinessObjectModel){
  if (this.unProxyBusinessObjectListCustom != null && this.unProxyBusinessObjectListCustom["OnForm"] != null){
    this.unProxyBusinessObjectListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:unProxyBusinessObjectModel){
	let route =  `${this.routeAdd}/${row.GuidBusinessObject}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.unProxyBusinessObjectListCustom != null && this.unProxyBusinessObjectListCustom["OnForm"] != null){
    this.unProxyBusinessObjectListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:unProxyBusinessObjectModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidBusinessObject }) => GuidBusinessObject), unProxyBusinessObjectModel._EntitySetName);
       swal.close();
       this.selection.clear();
 
       this.bindData();
   }else{
     swal.close();
   }
 }

}

