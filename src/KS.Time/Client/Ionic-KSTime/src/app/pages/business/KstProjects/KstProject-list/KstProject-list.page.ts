import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { KstProjectModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';

import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'KstProject-list',
  templateUrl: './KstProject-list.page.html',
  styleUrls: ['./KstProject-list.page.scss'],
})
export class KstProjectListPage extends AppListBaseTypedPage<KstProjectModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.KstProjectListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.KstProjectListCustom = _import["KstProjectListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidProjectCell') public GuidProjectCell: TemplateRef<any>;

	@ViewChild('NameCell') public NameCell: TemplateRef<any>;

	@ViewChild('GuidCompanyCell') public GuidCompanyCell: TemplateRef<any>;

	@ViewChild('CreatedByCell') public CreatedByCell: TemplateRef<any>;

	@ViewChild('UpdatedByCell') public UpdatedByCell: TemplateRef<any>;

	@ViewChild('IsDeletedCell') public IsDeletedCell: TemplateRef<any>;

	@ViewChild('BizKeyEngineCell') public BizKeyEngineCell: TemplateRef<any>;

	@ViewChild('CreatedDateCell') public CreatedDateCell: TemplateRef<any>;

	@ViewChild('UpdatedDateCell') public UpdatedDateCell: TemplateRef<any>;

	@ViewChild('BytesCell') public BytesCell: TemplateRef<any>;

	@ViewChild('KstActivitiesCell') public KstActivitiesCell: TemplateRef<any>;

	@ViewChild('KstProjectUsersCell') public KstProjectUsersCell: TemplateRef<any>;

	@ViewChild('KstWorkTimesCell') public KstWorkTimesCell: TemplateRef<any>;

	@ViewChild('KstProjectFilesCell') public KstProjectFilesCell: TemplateRef<any>;

	@ViewChild('NumActivitiesCell') public NumActivitiesCell: TemplateRef<any>;

	@ViewChild('NumUsersCell') public NumUsersCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	KstProjectListCustom:any = null;
	customClass = 'KstProject-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new KstProjectModel();
		//this.title = "KstProjects";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: KstProjectModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(KstProjectModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.KstProjectListCustom = p["KstProjectListCustom"];
    if (this.KstProjectListCustom != null && this.KstProjectListCustom["OnShowing"] != null){
      this.KstProjectListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, KstProjectModel._EntitySetName, Object.getOwnPropertyNames(KstProjectModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.KstProjectListCustom != null && this.KstProjectListCustom["OnItems"] != null) {
						this.KstProjectListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:KstProjectModel = null;
  refreshFilter(){
    this.itemFilter = new KstProjectModel();
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
    
	this.setOrder( { Name: "GuidProject" } );
   
    
	   this.setOrder({ Name: "Name" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.KstProjectListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.KstProjectListCustom = _import["KstProjectListCustom"];
              if (this.KstProjectListCustom != null) {
                this.KstProjectListCustom["OnShowing"](this);
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
routeAdd:string="KstProject/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidProjectCell,
    name: '',
    prop: KstProjectModel.PropertyNames.GuidProject,
	sortBy: "GuidProject",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.NameCell,
    name: KstProjectModel.PropertyNames.Name,
    prop: KstProjectModel.PropertyNames.Name,
	sortBy: "Name",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedByCell,
    name: KstProjectModel.PropertyNames.CreatedBy,
    prop: KstProjectModel.PropertyNames.CreatedBy,
	sortBy: "CreatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedByCell,
    name: KstProjectModel.PropertyNames.UpdatedBy,
    prop: KstProjectModel.PropertyNames.UpdatedBy,
	sortBy: "UpdatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.BizKeyEngineCell,
    name: KstProjectModel.PropertyNames.BizKeyEngine,
    prop: KstProjectModel.PropertyNames.BizKeyEngine,
	sortBy: "BizKeyEngine",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedDateCell,
    name: KstProjectModel.PropertyNames.CreatedDate,
    prop: KstProjectModel.PropertyNames.CreatedDate,
	sortBy: "CreatedDate",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedDateCell,
    name: KstProjectModel.PropertyNames.UpdatedDate,
    prop: KstProjectModel.PropertyNames.UpdatedDate,
	sortBy: "UpdatedDate",
    sortable: true,
    
    headerClass: 'updated',
	cellClass: 'updated',
},
{
	
	cellTemplate: this.NumActivitiesCell,
    name: KstProjectModel.PropertyNames.NumActivities,
    prop: KstProjectModel.PropertyNames.NumActivities,
	sortBy: "NumActivities",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.NumUsersCell,
    name: KstProjectModel.PropertyNames.NumUsers,
    prop: KstProjectModel.PropertyNames.NumUsers,
	sortBy: "NumUsers",
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

    if (this.KstProjectListCustom != null && this.KstProjectListCustom["OnItems"] != null){
      this.KstProjectListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.KstProjectListCustom != null && this.KstProjectListCustom["OnCustomActionExecute"] != null){
      this.KstProjectListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:KstProjectModel){
  if (this.KstProjectListCustom != null && this.KstProjectListCustom["OnForm"] != null){
    this.KstProjectListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:KstProjectModel){
	let route =  `${this.routeAdd}/${row.GuidProject}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.KstProjectListCustom != null && this.KstProjectListCustom["OnForm"] != null){
    this.KstProjectListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:KstProjectModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidProject }) => GuidProject), KstProjectModel._EntitySetName);
       
       this.selection.clear();
 
       this.bindData();
   }else{
     
   }
 }

}

