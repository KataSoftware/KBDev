import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { KstEmailTemplateModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';

import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'KstEmailTemplate-list',
  templateUrl: './KstEmailTemplate-list.page.html',
  styleUrls: ['./KstEmailTemplate-list.page.scss'],
})
export class KstEmailTemplateListPage extends AppListBaseTypedPage<KstEmailTemplateModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.KstEmailTemplateListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.KstEmailTemplateListCustom = _import["KstEmailTemplateListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidEmailTemplateCell') public GuidEmailTemplateCell: TemplateRef<any>;

	@ViewChild('TitleCell') public TitleCell: TemplateRef<any>;

	@ViewChild('TitleKeyCell') public TitleKeyCell: TemplateRef<any>;

	@ViewChild('ContentCell') public ContentCell: TemplateRef<any>;

	@ViewChild('GuidCompanyCell') public GuidCompanyCell: TemplateRef<any>;

	@ViewChild('CreatedByCell') public CreatedByCell: TemplateRef<any>;

	@ViewChild('UpdatedByCell') public UpdatedByCell: TemplateRef<any>;

	@ViewChild('IsDeletedCell') public IsDeletedCell: TemplateRef<any>;

	@ViewChild('BizKeyEngineCell') public BizKeyEngineCell: TemplateRef<any>;

	@ViewChild('CreatedDateCell') public CreatedDateCell: TemplateRef<any>;

	@ViewChild('UpdatedDateCell') public UpdatedDateCell: TemplateRef<any>;

	@ViewChild('BytesCell') public BytesCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	KstEmailTemplateListCustom:any = null;
	customClass = 'KstEmailTemplate-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new KstEmailTemplateModel();
		//this.title = "KstEmailTemplates";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: KstEmailTemplateModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(KstEmailTemplateModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.KstEmailTemplateListCustom = p["KstEmailTemplateListCustom"];
    if (this.KstEmailTemplateListCustom != null && this.KstEmailTemplateListCustom["OnShowing"] != null){
      this.KstEmailTemplateListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, KstEmailTemplateModel._EntitySetName, Object.getOwnPropertyNames(KstEmailTemplateModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.KstEmailTemplateListCustom != null && this.KstEmailTemplateListCustom["OnItems"] != null) {
						this.KstEmailTemplateListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:KstEmailTemplateModel = null;
  refreshFilter(){
    this.itemFilter = new KstEmailTemplateModel();
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
    
	this.setOrder( { Name: "GuidEmailTemplate" } );
   
    
	   this.setOrder({ Name: "Title" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.KstEmailTemplateListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.KstEmailTemplateListCustom = _import["KstEmailTemplateListCustom"];
              if (this.KstEmailTemplateListCustom != null) {
                this.KstEmailTemplateListCustom["OnShowing"](this);
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
routeAdd:string="KstEmailTemplate/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidEmailTemplateCell,
    name: '',
    prop: KstEmailTemplateModel.PropertyNames.GuidEmailTemplate,
	sortBy: "GuidEmailTemplate",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.TitleCell,
    name: KstEmailTemplateModel.PropertyNames.Title,
    prop: KstEmailTemplateModel.PropertyNames.Title,
	sortBy: "Title",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.TitleKeyCell,
    name: KstEmailTemplateModel.PropertyNames.TitleKey,
    prop: KstEmailTemplateModel.PropertyNames.TitleKey,
	sortBy: "TitleKey",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.ContentCell,
    name: KstEmailTemplateModel.PropertyNames.Content,
    prop: KstEmailTemplateModel.PropertyNames.Content,
	sortBy: "Content",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedByCell,
    name: KstEmailTemplateModel.PropertyNames.CreatedBy,
    prop: KstEmailTemplateModel.PropertyNames.CreatedBy,
	sortBy: "CreatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedByCell,
    name: KstEmailTemplateModel.PropertyNames.UpdatedBy,
    prop: KstEmailTemplateModel.PropertyNames.UpdatedBy,
	sortBy: "UpdatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.BizKeyEngineCell,
    name: KstEmailTemplateModel.PropertyNames.BizKeyEngine,
    prop: KstEmailTemplateModel.PropertyNames.BizKeyEngine,
	sortBy: "BizKeyEngine",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedDateCell,
    name: KstEmailTemplateModel.PropertyNames.CreatedDate,
    prop: KstEmailTemplateModel.PropertyNames.CreatedDate,
	sortBy: "CreatedDate",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedDateCell,
    name: KstEmailTemplateModel.PropertyNames.UpdatedDate,
    prop: KstEmailTemplateModel.PropertyNames.UpdatedDate,
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

    if (this.KstEmailTemplateListCustom != null && this.KstEmailTemplateListCustom["OnItems"] != null){
      this.KstEmailTemplateListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.KstEmailTemplateListCustom != null && this.KstEmailTemplateListCustom["OnCustomActionExecute"] != null){
      this.KstEmailTemplateListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:KstEmailTemplateModel){
  if (this.KstEmailTemplateListCustom != null && this.KstEmailTemplateListCustom["OnForm"] != null){
    this.KstEmailTemplateListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:KstEmailTemplateModel){
	let route =  `${this.routeAdd}/${row.GuidEmailTemplate}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.KstEmailTemplateListCustom != null && this.KstEmailTemplateListCustom["OnForm"] != null){
    this.KstEmailTemplateListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:KstEmailTemplateModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidEmailTemplate }) => GuidEmailTemplate), KstEmailTemplateModel._EntitySetName);
       
       this.selection.clear();
 
       this.bindData();
   }else{
     
   }
 }

}

