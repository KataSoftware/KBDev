import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { DataService, TableColumn } from 'sfscommon';
//import swal from 'sweetalert';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { AppListBaseTypedPage } from '../../common/app-list-base-typed/app-list-base-typed.page';
import { bizAppService } from '../../services/business.service';
import { GenericModel } from '../../models/common/models';
import { sfsService } from '../../services/sfs.service';
import { BindListSettings } from '../../common/app-list-base/app-list-base.page';



@Component({
  selector: 'generic-list',
  templateUrl: './generic-list.page.html',
  styleUrls: ['./generic-list.page.scss'],
})
export class GenericListPage extends AppListBaseTypedPage<GenericModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
  
    
      
    }

    

    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
  GenericListCustom:any = null;
 
	customClass:string;
  entityName:string="Generic";
  entityModel:any=null;
	constructor( public injector: Injector,private activatedRoute: ActivatedRoute, public sfsService: sfsService) {
    super(injector);
    this.entityName = this.activatedRoute.snapshot.paramMap.get('catalog');
		
	/*
	import(`./${this.customClass}`).then(p=>{
    this.GenericListCustom = p["GenericListCustom"];
    if (this.GenericListCustom != null && this.GenericListCustom["OnShowing"] != null){
      this.GenericListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, this.entityModel._EntitySetName, Object.getOwnPropertyNames(this.entityModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.GenericListCustom != null && this.GenericListCustom["OnItems"] != null) {
						this.GenericListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:any = null;
  refreshFilter(){
    this.itemFilter = new this.entityModel();
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


   async ngOnInit() {
    import(
         /* webpackMode: "lazy-once" */
         /* webpackPrefetch: true */
         /* webpackInclude: /\.ts$/ */
         /* webpackPreload: true */
 `../../models/codegen/${this.entityName}.model`).then((_model)=> {
  this.entityModel = _model[this.entityName +"Model"]

    this.itemFilter = new this.entityModel();
		//this.title = "KstEmailTemplates";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: this.entityModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(this.entityModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };

   console.log("ubiCustomer ngOnInit");
  //this.userData = await this.userService.getUserData();
  //let query: string;

	
     this.getColumns();
    
	this.setOrder( { Name: "GuidEmailTemplate" } );
   
    
	   this.setOrder({ Name: "Title" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.GenericListCustom == null ){
		  import(
                /* webpackMode: "eager" */
         /* webpackPrefetch: true */
         /* webpackInclude: /\.ts$/ */
         /* webpackPreload: true */      
                `../../../pages/catalogs/${this.entityName}List.custom`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.GenericListCustom = _import[this.entityName +"ListCustom"];
              if (this.GenericListCustom != null) {
                this.GenericListCustom["OnShowing"](this);
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
       

		
      }).catch((error)=> {
				this.externalCustomFileChecked = true;
				console.log("error ", error);
      });
}
bindDisplayColumns(){
  this.displayedColumns = [];
  for (let column of this.tableColumns) { this.displayedColumns.push(column.prop); }

}
routeAdd:string;
async addItem(){
  this.routeAdd = this.entityName + "/form";
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
    this.tableColumns = [];
    
    let idCol:Array<any> =[{

      name: '',
      prop: this.entityModel.PropertyNames.GuidEmailTemplate,
    sortBy: "GuidEmailTemplate",
      sortable: false,
      width: 50,
      headerClass: 'selectCheck',
    cellClass: 'selectCheck',
  }];

  let sysCols:Array<any> =[{
	
	
    name: this.entityModel.PropertyNames.UpdatedBy,
    prop: this.entityModel.PropertyNames.UpdatedBy,
	sortBy: "UpdatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},

{
	
  
  
    name: this.entityModel.PropertyNames.UpdatedDate,
    prop: this.entityModel.PropertyNames.UpdatedDate,
	sortBy: "UpdatedDate",
    sortable: true,   
    headerClass: 'updated',
	cellClass: 'updated',
},
    
{
    name: '',
    prop: "actions",
    sortable: false,
    cellClass: 'actions',
    headerClass: 'actions',
	
}]; 
    this.backtableColumns = [
      ...idCol,
      ...this.pageService.getColumnsFromFields(this.entityModel.GetFields()),
      ...sysCols

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

    if (this.GenericListCustom != null && this.GenericListCustom["OnItems"] != null){
      this.GenericListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.GenericListCustom != null && this.GenericListCustom["OnCustomActionExecute"] != null){
      this.GenericListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:GenericModel){
  if (this.GenericListCustom != null && this.GenericListCustom["OnForm"] != null){
    this.GenericListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:GenericModel){
	let route =  `${this.routeAdd}/${row.Id}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.GenericListCustom != null && this.GenericListCustom["OnForm"] != null){
    this.GenericListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:GenericModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ Id }) => Id), GenericModel._EntitySetName);
       //swal.close();
       this.selection.clear();
 
       this.bindData();
   }else{
     //swal.close();
   }
 }

}

