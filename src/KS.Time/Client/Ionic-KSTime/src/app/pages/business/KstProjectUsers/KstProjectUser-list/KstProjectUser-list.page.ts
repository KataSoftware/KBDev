import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { KstProjectUserModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';
//import swal from 'sweetalert';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'KstProjectUser-list',
  templateUrl: './KstProjectUser-list.page.html',
  styleUrls: ['./KstProjectUser-list.page.scss'],
})
export class KstProjectUserListPage extends AppListBaseTypedPage<KstProjectUserModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.KstProjectUserListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.KstProjectUserListCustom = _import["KstProjectUserListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidProjectUserCell') public GuidProjectUserCell: TemplateRef<any>;

	@ViewChild('GuidProjectCell') public GuidProjectCell: TemplateRef<any>;

	@ViewChild('GuidUserCell') public GuidUserCell: TemplateRef<any>;

	@ViewChild('StartDateCell') public StartDateCell: TemplateRef<any>;

	@ViewChild('EndDateCell') public EndDateCell: TemplateRef<any>;

	@ViewChild('GuidCompanyCell') public GuidCompanyCell: TemplateRef<any>;

	@ViewChild('CreatedByCell') public CreatedByCell: TemplateRef<any>;

	@ViewChild('UpdatedByCell') public UpdatedByCell: TemplateRef<any>;

	@ViewChild('IsDeletedCell') public IsDeletedCell: TemplateRef<any>;

	@ViewChild('BizKeyEngineCell') public BizKeyEngineCell: TemplateRef<any>;

	@ViewChild('CreatedDateCell') public CreatedDateCell: TemplateRef<any>;

	@ViewChild('UpdatedDateCell') public UpdatedDateCell: TemplateRef<any>;

	@ViewChild('BytesCell') public BytesCell: TemplateRef<any>;

	@ViewChild('KstProjectCell') public KstProjectCell: TemplateRef<any>;

	@ViewChild('KstProxyUserCell') public KstProxyUserCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	KstProjectUserListCustom:any = null;
	customClass = 'KstProjectUser-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new KstProjectUserModel();
		//this.title = "KstProjectUsers";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: KstProjectUserModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(KstProjectUserModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.KstProjectUserListCustom = p["KstProjectUserListCustom"];
    if (this.KstProjectUserListCustom != null && this.KstProjectUserListCustom["OnShowing"] != null){
      this.KstProjectUserListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, KstProjectUserModel._EntitySetName, Object.getOwnPropertyNames(KstProjectUserModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.KstProjectUserListCustom != null && this.KstProjectUserListCustom["OnItems"] != null) {
						this.KstProjectUserListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:KstProjectUserModel = null;
  refreshFilter(){
    this.itemFilter = new KstProjectUserModel();
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
    
	this.setOrder( { Name: "GuidProjectUser" } );
   
    
	   this.setOrder({ Name: "BizKeyEngine" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.KstProjectUserListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.KstProjectUserListCustom = _import["KstProjectUserListCustom"];
              if (this.KstProjectUserListCustom != null) {
                this.KstProjectUserListCustom["OnShowing"](this);
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
routeAdd:string="KstProjectUser/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidProjectUserCell,
    name: '',
    prop: KstProjectUserModel.PropertyNames.GuidProjectUser,
	sortBy: "GuidProjectUser",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.GuidProjectCell,
    name: KstProjectUserModel.PropertyNames.GuidProject,
    prop: KstProjectUserModel.PropertyNames.GuidProject,
	sortBy: "GuidProject",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.GuidUserCell,
    name: KstProjectUserModel.PropertyNames.GuidUser,
    prop: KstProjectUserModel.PropertyNames.GuidUser,
	sortBy: "GuidUser",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.StartDateCell,
    name: KstProjectUserModel.PropertyNames.StartDate,
    prop: KstProjectUserModel.PropertyNames.StartDate,
	sortBy: "StartDate",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.EndDateCell,
    name: KstProjectUserModel.PropertyNames.EndDate,
    prop: KstProjectUserModel.PropertyNames.EndDate,
	sortBy: "EndDate",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedByCell,
    name: KstProjectUserModel.PropertyNames.CreatedBy,
    prop: KstProjectUserModel.PropertyNames.CreatedBy,
	sortBy: "CreatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedByCell,
    name: KstProjectUserModel.PropertyNames.UpdatedBy,
    prop: KstProjectUserModel.PropertyNames.UpdatedBy,
	sortBy: "UpdatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.BizKeyEngineCell,
    name: KstProjectUserModel.PropertyNames.BizKeyEngine,
    prop: KstProjectUserModel.PropertyNames.BizKeyEngine,
	sortBy: "BizKeyEngine",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedDateCell,
    name: KstProjectUserModel.PropertyNames.CreatedDate,
    prop: KstProjectUserModel.PropertyNames.CreatedDate,
	sortBy: "CreatedDate",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedDateCell,
    name: KstProjectUserModel.PropertyNames.UpdatedDate,
    prop: KstProjectUserModel.PropertyNames.UpdatedDate,
	sortBy: "UpdatedDate",
    sortable: true,
    
    headerClass: 'updated',
	cellClass: 'updated',
},
{
	
	cellTemplate: this.KstProjectCell,
    name: KstProjectUserModel.PropertyNames.KstProject,
    prop: `Fk${KstProjectUserModel.PropertyNames.KstProject}Text`,
	sortBy: "KstProject.Name",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.KstProxyUserCell,
    name: KstProjectUserModel.PropertyNames.KstProxyUser,
    prop: `Fk${KstProjectUserModel.PropertyNames.KstProxyUser}Text`,
	sortBy: "KstProxyUser.DisplayName",
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

    if (this.KstProjectUserListCustom != null && this.KstProjectUserListCustom["OnItems"] != null){
      this.KstProjectUserListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.KstProjectUserListCustom != null && this.KstProjectUserListCustom["OnCustomActionExecute"] != null){
      this.KstProjectUserListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:KstProjectUserModel){
  if (this.KstProjectUserListCustom != null && this.KstProjectUserListCustom["OnForm"] != null){
    this.KstProjectUserListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:KstProjectUserModel){
	let route =  `${this.routeAdd}/${row.GuidProjectUser}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.KstProjectUserListCustom != null && this.KstProjectUserListCustom["OnForm"] != null){
    this.KstProjectUserListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:KstProjectUserModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidProjectUser }) => GuidProjectUser), KstProjectUserModel._EntitySetName);
       //swal.close();
       this.selection.clear();
 
       this.bindData();
   }else{
     //swal.close();
   }
 }

}

