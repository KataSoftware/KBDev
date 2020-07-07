import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { KstUserFileModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';

import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'KstUserFile-list',
  templateUrl: './KstUserFile-list.page.html',
  styleUrls: ['./KstUserFile-list.page.scss'],
})
export class KstUserFileListPage extends AppListBaseTypedPage<KstUserFileModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.KstUserFileListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.KstUserFileListCustom = _import["KstUserFileListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidUserFileCell') public GuidUserFileCell: TemplateRef<any>;

	@ViewChild('GuidUserCell') public GuidUserCell: TemplateRef<any>;

	@ViewChild('GuidFileCell') public GuidFileCell: TemplateRef<any>;

	@ViewChild('IsProfileDefaultCell') public IsProfileDefaultCell: TemplateRef<any>;

	@ViewChild('GuidCompanyCell') public GuidCompanyCell: TemplateRef<any>;

	@ViewChild('CreatedByCell') public CreatedByCell: TemplateRef<any>;

	@ViewChild('UpdatedByCell') public UpdatedByCell: TemplateRef<any>;

	@ViewChild('IsDeletedCell') public IsDeletedCell: TemplateRef<any>;

	@ViewChild('BizKeyEngineCell') public BizKeyEngineCell: TemplateRef<any>;

	@ViewChild('CreatedDateCell') public CreatedDateCell: TemplateRef<any>;

	@ViewChild('UpdatedDateCell') public UpdatedDateCell: TemplateRef<any>;

	@ViewChild('BytesCell') public BytesCell: TemplateRef<any>;

	@ViewChild('KstFileCell') public KstFileCell: TemplateRef<any>;

	@ViewChild('KstProxyUserCell') public KstProxyUserCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	KstUserFileListCustom:any = null;
	customClass = 'KstUserFile-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new KstUserFileModel();
		//this.title = "KstUserFiles";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: KstUserFileModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(KstUserFileModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.KstUserFileListCustom = p["KstUserFileListCustom"];
    if (this.KstUserFileListCustom != null && this.KstUserFileListCustom["OnShowing"] != null){
      this.KstUserFileListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, KstUserFileModel._EntitySetName, Object.getOwnPropertyNames(KstUserFileModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.KstUserFileListCustom != null && this.KstUserFileListCustom["OnItems"] != null) {
						this.KstUserFileListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:KstUserFileModel = null;
  refreshFilter(){
    this.itemFilter = new KstUserFileModel();
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
    
	this.setOrder( { Name: "GuidUserFile" } );
   
    
	   this.setOrder({ Name: "BizKeyEngine" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.KstUserFileListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.KstUserFileListCustom = _import["KstUserFileListCustom"];
              if (this.KstUserFileListCustom != null) {
                this.KstUserFileListCustom["OnShowing"](this);
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
routeAdd:string="KstUserFile/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidUserFileCell,
    name: '',
    prop: KstUserFileModel.PropertyNames.GuidUserFile,
	sortBy: "GuidUserFile",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.GuidUserCell,
    name: KstUserFileModel.PropertyNames.GuidUser,
    prop: KstUserFileModel.PropertyNames.GuidUser,
	sortBy: "GuidUser",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.GuidFileCell,
    name: KstUserFileModel.PropertyNames.GuidFile,
    prop: KstUserFileModel.PropertyNames.GuidFile,
	sortBy: "GuidFile",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.IsProfileDefaultCell,
    name: KstUserFileModel.PropertyNames.IsProfileDefault,
    prop: KstUserFileModel.PropertyNames.IsProfileDefault,
	sortBy: "IsProfileDefault",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedByCell,
    name: KstUserFileModel.PropertyNames.CreatedBy,
    prop: KstUserFileModel.PropertyNames.CreatedBy,
	sortBy: "CreatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedByCell,
    name: KstUserFileModel.PropertyNames.UpdatedBy,
    prop: KstUserFileModel.PropertyNames.UpdatedBy,
	sortBy: "UpdatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.BizKeyEngineCell,
    name: KstUserFileModel.PropertyNames.BizKeyEngine,
    prop: KstUserFileModel.PropertyNames.BizKeyEngine,
	sortBy: "BizKeyEngine",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedDateCell,
    name: KstUserFileModel.PropertyNames.CreatedDate,
    prop: KstUserFileModel.PropertyNames.CreatedDate,
	sortBy: "CreatedDate",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedDateCell,
    name: KstUserFileModel.PropertyNames.UpdatedDate,
    prop: KstUserFileModel.PropertyNames.UpdatedDate,
	sortBy: "UpdatedDate",
    sortable: true,
    
    headerClass: 'updated',
	cellClass: 'updated',
},
{
	
	cellTemplate: this.KstFileCell,
    name: KstUserFileModel.PropertyNames.KstFile,
    prop: `Fk${KstUserFileModel.PropertyNames.KstFile}Text`,
	sortBy: "KstFile.FileName",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.KstProxyUserCell,
    name: KstUserFileModel.PropertyNames.KstProxyUser,
    prop: `Fk${KstUserFileModel.PropertyNames.KstProxyUser}Text`,
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

    if (this.KstUserFileListCustom != null && this.KstUserFileListCustom["OnItems"] != null){
      this.KstUserFileListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.KstUserFileListCustom != null && this.KstUserFileListCustom["OnCustomActionExecute"] != null){
      this.KstUserFileListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:KstUserFileModel){
  if (this.KstUserFileListCustom != null && this.KstUserFileListCustom["OnForm"] != null){
    this.KstUserFileListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:KstUserFileModel){
	let route =  `${this.routeAdd}/${row.GuidUserFile}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.KstUserFileListCustom != null && this.KstUserFileListCustom["OnForm"] != null){
    this.KstUserFileListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:KstUserFileModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidUserFile }) => GuidUserFile), KstUserFileModel._EntitySetName);
       
       this.selection.clear();
 
       this.bindData();
   }else{
     
   }
 }

}

