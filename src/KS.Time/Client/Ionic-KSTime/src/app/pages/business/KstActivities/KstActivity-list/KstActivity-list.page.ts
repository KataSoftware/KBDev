import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { KstActivityModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';

import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'KstActivity-list',
  templateUrl: './KstActivity-list.page.html',
  styleUrls: ['./KstActivity-list.page.scss'],
})
export class KstActivityListPage extends AppListBaseTypedPage<KstActivityModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.KstActivityListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.KstActivityListCustom = _import["KstActivityListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidActivityCell') public GuidActivityCell: TemplateRef<any>;

	@ViewChild('NameCell') public NameCell: TemplateRef<any>;

	@ViewChild('GuidProjectCell') public GuidProjectCell: TemplateRef<any>;

	@ViewChild('IsCustomByUserCell') public IsCustomByUserCell: TemplateRef<any>;

	@ViewChild('GuidCompanyCell') public GuidCompanyCell: TemplateRef<any>;

	@ViewChild('CreatedByCell') public CreatedByCell: TemplateRef<any>;

	@ViewChild('UpdatedByCell') public UpdatedByCell: TemplateRef<any>;

	@ViewChild('IsDeletedCell') public IsDeletedCell: TemplateRef<any>;

	@ViewChild('BizKeyEngineCell') public BizKeyEngineCell: TemplateRef<any>;

	@ViewChild('CreatedDateCell') public CreatedDateCell: TemplateRef<any>;

	@ViewChild('UpdatedDateCell') public UpdatedDateCell: TemplateRef<any>;

	@ViewChild('BytesCell') public BytesCell: TemplateRef<any>;

	@ViewChild('KstProjectCell') public KstProjectCell: TemplateRef<any>;

	@ViewChild('KstWorkTimesCell') public KstWorkTimesCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	KstActivityListCustom:any = null;
	customClass = 'KstActivity-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new KstActivityModel();
		//this.title = "KstActivities";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: KstActivityModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(KstActivityModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.KstActivityListCustom = p["KstActivityListCustom"];
    if (this.KstActivityListCustom != null && this.KstActivityListCustom["OnShowing"] != null){
      this.KstActivityListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, KstActivityModel._EntitySetName, Object.getOwnPropertyNames(KstActivityModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.KstActivityListCustom != null && this.KstActivityListCustom["OnItems"] != null) {
						this.KstActivityListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:KstActivityModel = null;
  refreshFilter(){
    this.itemFilter = new KstActivityModel();
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
    
	this.setOrder( { Name: "GuidActivity" } );
   
    
	   this.setOrder({ Name: "Name" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.KstActivityListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.KstActivityListCustom = _import["KstActivityListCustom"];
              if (this.KstActivityListCustom != null) {
                this.KstActivityListCustom["OnShowing"](this);
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
routeAdd:string="KstActivity/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidActivityCell,
    name: '',
    prop: KstActivityModel.PropertyNames.GuidActivity,
	sortBy: "GuidActivity",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.NameCell,
    name: KstActivityModel.PropertyNames.Name,
    prop: KstActivityModel.PropertyNames.Name,
	sortBy: "Name",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.GuidProjectCell,
    name: KstActivityModel.PropertyNames.GuidProject,
    prop: KstActivityModel.PropertyNames.GuidProject,
	sortBy: "GuidProject",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.IsCustomByUserCell,
    name: KstActivityModel.PropertyNames.IsCustomByUser,
    prop: KstActivityModel.PropertyNames.IsCustomByUser,
	sortBy: "IsCustomByUser",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedByCell,
    name: KstActivityModel.PropertyNames.CreatedBy,
    prop: KstActivityModel.PropertyNames.CreatedBy,
	sortBy: "CreatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedByCell,
    name: KstActivityModel.PropertyNames.UpdatedBy,
    prop: KstActivityModel.PropertyNames.UpdatedBy,
	sortBy: "UpdatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.BizKeyEngineCell,
    name: KstActivityModel.PropertyNames.BizKeyEngine,
    prop: KstActivityModel.PropertyNames.BizKeyEngine,
	sortBy: "BizKeyEngine",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedDateCell,
    name: KstActivityModel.PropertyNames.CreatedDate,
    prop: KstActivityModel.PropertyNames.CreatedDate,
	sortBy: "CreatedDate",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedDateCell,
    name: KstActivityModel.PropertyNames.UpdatedDate,
    prop: KstActivityModel.PropertyNames.UpdatedDate,
	sortBy: "UpdatedDate",
    sortable: true,
    
    headerClass: 'updated',
	cellClass: 'updated',
},
{
	
	cellTemplate: this.KstProjectCell,
    name: KstActivityModel.PropertyNames.KstProject,
    prop: `Fk${KstActivityModel.PropertyNames.KstProject}Text`,
	sortBy: "KstProject.Name",
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

    if (this.KstActivityListCustom != null && this.KstActivityListCustom["OnItems"] != null){
      this.KstActivityListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.KstActivityListCustom != null && this.KstActivityListCustom["OnCustomActionExecute"] != null){
      this.KstActivityListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:KstActivityModel){
  if (this.KstActivityListCustom != null && this.KstActivityListCustom["OnForm"] != null){
    this.KstActivityListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:KstActivityModel){
	let route =  `${this.routeAdd}/${row.GuidActivity}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.KstActivityListCustom != null && this.KstActivityListCustom["OnForm"] != null){
    this.KstActivityListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:KstActivityModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidActivity }) => GuidActivity), KstActivityModel._EntitySetName);
       
       this.selection.clear();
 
       this.bindData();
   }else{
     
   }
 }

}

