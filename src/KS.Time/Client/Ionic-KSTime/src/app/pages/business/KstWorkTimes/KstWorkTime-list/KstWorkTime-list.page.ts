import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { KstWorkTimeModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';

import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'KstWorkTime-list',
  templateUrl: './KstWorkTime-list.page.html',
  styleUrls: ['./KstWorkTime-list.page.scss'],
})
export class KstWorkTimeListPage extends AppListBaseTypedPage<KstWorkTimeModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.KstWorkTimeListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.KstWorkTimeListCustom = _import["KstWorkTimeListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidWorkTimeCell') public GuidWorkTimeCell: TemplateRef<any>;

	@ViewChild('TitleCell') public TitleCell: TemplateRef<any>;

	@ViewChild('CommentsCell') public CommentsCell: TemplateRef<any>;

	@ViewChild('HoursCell') public HoursCell: TemplateRef<any>;

	@ViewChild('GuidProjectCell') public GuidProjectCell: TemplateRef<any>;

	@ViewChild('GuidActivityCell') public GuidActivityCell: TemplateRef<any>;

	@ViewChild('GuidCompanyCell') public GuidCompanyCell: TemplateRef<any>;

	@ViewChild('CreatedByCell') public CreatedByCell: TemplateRef<any>;

	@ViewChild('UpdatedByCell') public UpdatedByCell: TemplateRef<any>;

	@ViewChild('IsDeletedCell') public IsDeletedCell: TemplateRef<any>;

	@ViewChild('BizKeyEngineCell') public BizKeyEngineCell: TemplateRef<any>;

	@ViewChild('CreatedDateCell') public CreatedDateCell: TemplateRef<any>;

	@ViewChild('UpdatedDateCell') public UpdatedDateCell: TemplateRef<any>;

	@ViewChild('BytesCell') public BytesCell: TemplateRef<any>;

	@ViewChild('KstActivityCell') public KstActivityCell: TemplateRef<any>;

	@ViewChild('KstProjectCell') public KstProjectCell: TemplateRef<any>;

	@ViewChild('KstWorkTimeFilesCell') public KstWorkTimeFilesCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	KstWorkTimeListCustom:any = null;
	customClass = 'KstWorkTime-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new KstWorkTimeModel();
		//this.title = "KstWorkTimes";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: KstWorkTimeModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(KstWorkTimeModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.KstWorkTimeListCustom = p["KstWorkTimeListCustom"];
    if (this.KstWorkTimeListCustom != null && this.KstWorkTimeListCustom["OnShowing"] != null){
      this.KstWorkTimeListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, KstWorkTimeModel._EntitySetName, Object.getOwnPropertyNames(KstWorkTimeModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.KstWorkTimeListCustom != null && this.KstWorkTimeListCustom["OnItems"] != null) {
						this.KstWorkTimeListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:KstWorkTimeModel = null;
  refreshFilter(){
    this.itemFilter = new KstWorkTimeModel();
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
    
	this.setOrder( { Name: "GuidWorkTime" } );
   
    
	   this.setOrder({ Name: "Title" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.KstWorkTimeListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.KstWorkTimeListCustom = _import["KstWorkTimeListCustom"];
              if (this.KstWorkTimeListCustom != null) {
                this.KstWorkTimeListCustom["OnShowing"](this);
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
routeAdd:string="KstWorkTime/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidWorkTimeCell,
    name: '',
    prop: KstWorkTimeModel.PropertyNames.GuidWorkTime,
	sortBy: "GuidWorkTime",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.TitleCell,
    name: KstWorkTimeModel.PropertyNames.Title,
    prop: KstWorkTimeModel.PropertyNames.Title,
	sortBy: "Title",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CommentsCell,
    name: KstWorkTimeModel.PropertyNames.Comments,
    prop: KstWorkTimeModel.PropertyNames.Comments,
	sortBy: "Comments",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.HoursCell,
    name: KstWorkTimeModel.PropertyNames.Hours,
    prop: KstWorkTimeModel.PropertyNames.Hours,
	sortBy: "Hours",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.GuidProjectCell,
    name: KstWorkTimeModel.PropertyNames.GuidProject,
    prop: KstWorkTimeModel.PropertyNames.GuidProject,
	sortBy: "GuidProject",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.GuidActivityCell,
    name: KstWorkTimeModel.PropertyNames.GuidActivity,
    prop: KstWorkTimeModel.PropertyNames.GuidActivity,
	sortBy: "GuidActivity",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedByCell,
    name: KstWorkTimeModel.PropertyNames.CreatedBy,
    prop: KstWorkTimeModel.PropertyNames.CreatedBy,
	sortBy: "CreatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedByCell,
    name: KstWorkTimeModel.PropertyNames.UpdatedBy,
    prop: KstWorkTimeModel.PropertyNames.UpdatedBy,
	sortBy: "UpdatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.BizKeyEngineCell,
    name: KstWorkTimeModel.PropertyNames.BizKeyEngine,
    prop: KstWorkTimeModel.PropertyNames.BizKeyEngine,
	sortBy: "BizKeyEngine",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedDateCell,
    name: KstWorkTimeModel.PropertyNames.CreatedDate,
    prop: KstWorkTimeModel.PropertyNames.CreatedDate,
	sortBy: "CreatedDate",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedDateCell,
    name: KstWorkTimeModel.PropertyNames.UpdatedDate,
    prop: KstWorkTimeModel.PropertyNames.UpdatedDate,
	sortBy: "UpdatedDate",
    sortable: true,
    
    headerClass: 'updated',
	cellClass: 'updated',
},
{
	
	cellTemplate: this.KstActivityCell,
    name: KstWorkTimeModel.PropertyNames.KstActivity,
    prop: `Fk${KstWorkTimeModel.PropertyNames.KstActivity}Text`,
	sortBy: "KstActivity.Name",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.KstProjectCell,
    name: KstWorkTimeModel.PropertyNames.KstProject,
    prop: `Fk${KstWorkTimeModel.PropertyNames.KstProject}Text`,
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

    if (this.KstWorkTimeListCustom != null && this.KstWorkTimeListCustom["OnItems"] != null){
      this.KstWorkTimeListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.KstWorkTimeListCustom != null && this.KstWorkTimeListCustom["OnCustomActionExecute"] != null){
      this.KstWorkTimeListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:KstWorkTimeModel){
  if (this.KstWorkTimeListCustom != null && this.KstWorkTimeListCustom["OnForm"] != null){
    this.KstWorkTimeListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:KstWorkTimeModel){
	let route =  `${this.routeAdd}/${row.GuidWorkTime}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.KstWorkTimeListCustom != null && this.KstWorkTimeListCustom["OnForm"] != null){
    this.KstWorkTimeListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:KstWorkTimeModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidWorkTime }) => GuidWorkTime), KstWorkTimeModel._EntitySetName);
       
       this.selection.clear();
 
       this.bindData();
   }else{
     
   }
 }

}

