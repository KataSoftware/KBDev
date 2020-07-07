import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { KstFileModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';

import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'KstFile-list',
  templateUrl: './KstFile-list.page.html',
  styleUrls: ['./KstFile-list.page.scss'],
})
export class KstFileListPage extends AppListBaseTypedPage<KstFileModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.KstFileListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.KstFileListCustom = _import["KstFileListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidFileCell') public GuidFileCell: TemplateRef<any>;

	@ViewChild('FileNameCell') public FileNameCell: TemplateRef<any>;

	@ViewChild('FileTypeCell') public FileTypeCell: TemplateRef<any>;

	@ViewChild('FileDataCell') public FileDataCell: TemplateRef<any>;

	@ViewChild('FileStorageCell') public FileStorageCell: TemplateRef<any>;

	@ViewChild('ContainerStorageCell') public ContainerStorageCell: TemplateRef<any>;

	@ViewChild('FileThumbSizesCell') public FileThumbSizesCell: TemplateRef<any>;

	@ViewChild('FileSizeCell') public FileSizeCell: TemplateRef<any>;

	@ViewChild('GuidCompanyCell') public GuidCompanyCell: TemplateRef<any>;

	@ViewChild('CreatedByCell') public CreatedByCell: TemplateRef<any>;

	@ViewChild('UpdatedByCell') public UpdatedByCell: TemplateRef<any>;

	@ViewChild('IsDeletedCell') public IsDeletedCell: TemplateRef<any>;

	@ViewChild('BizKeyEngineCell') public BizKeyEngineCell: TemplateRef<any>;

	@ViewChild('CreatedDateCell') public CreatedDateCell: TemplateRef<any>;

	@ViewChild('UpdatedDateCell') public UpdatedDateCell: TemplateRef<any>;

	@ViewChild('BytesCell') public BytesCell: TemplateRef<any>;

	@ViewChild('KstProjectFilesCell') public KstProjectFilesCell: TemplateRef<any>;

	@ViewChild('KstUserFilesCell') public KstUserFilesCell: TemplateRef<any>;

	@ViewChild('KstWorkTimeFilesCell') public KstWorkTimeFilesCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	KstFileListCustom:any = null;
	customClass = 'KstFile-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new KstFileModel();
		//this.title = "KstFiles";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: KstFileModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(KstFileModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.KstFileListCustom = p["KstFileListCustom"];
    if (this.KstFileListCustom != null && this.KstFileListCustom["OnShowing"] != null){
      this.KstFileListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, KstFileModel._EntitySetName, Object.getOwnPropertyNames(KstFileModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.KstFileListCustom != null && this.KstFileListCustom["OnItems"] != null) {
						this.KstFileListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:KstFileModel = null;
  refreshFilter(){
    this.itemFilter = new KstFileModel();
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
    
	this.setOrder( { Name: "GuidFile" } );
   
    
	   this.setOrder({ Name: "FileName" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.KstFileListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.KstFileListCustom = _import["KstFileListCustom"];
              if (this.KstFileListCustom != null) {
                this.KstFileListCustom["OnShowing"](this);
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
routeAdd:string="KstFile/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidFileCell,
    name: '',
    prop: KstFileModel.PropertyNames.GuidFile,
	sortBy: "GuidFile",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.FileNameCell,
    name: KstFileModel.PropertyNames.FileName,
    prop: KstFileModel.PropertyNames.FileName,
	sortBy: "FileName",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.FileTypeCell,
    name: KstFileModel.PropertyNames.FileType,
    prop: KstFileModel.PropertyNames.FileType,
	sortBy: "FileType",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.FileDataCell,
    name: KstFileModel.PropertyNames.FileData,
    prop: KstFileModel.PropertyNames.FileData,
	sortBy: "FileData",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.FileStorageCell,
    name: KstFileModel.PropertyNames.FileStorage,
    prop: KstFileModel.PropertyNames.FileStorage,
	sortBy: "FileStorage",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.ContainerStorageCell,
    name: KstFileModel.PropertyNames.ContainerStorage,
    prop: KstFileModel.PropertyNames.ContainerStorage,
	sortBy: "ContainerStorage",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.FileThumbSizesCell,
    name: KstFileModel.PropertyNames.FileThumbSizes,
    prop: KstFileModel.PropertyNames.FileThumbSizes,
	sortBy: "FileThumbSizes",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.FileSizeCell,
    name: KstFileModel.PropertyNames.FileSize,
    prop: KstFileModel.PropertyNames.FileSize,
	sortBy: "FileSize",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedByCell,
    name: KstFileModel.PropertyNames.CreatedBy,
    prop: KstFileModel.PropertyNames.CreatedBy,
	sortBy: "CreatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedByCell,
    name: KstFileModel.PropertyNames.UpdatedBy,
    prop: KstFileModel.PropertyNames.UpdatedBy,
	sortBy: "UpdatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.BizKeyEngineCell,
    name: KstFileModel.PropertyNames.BizKeyEngine,
    prop: KstFileModel.PropertyNames.BizKeyEngine,
	sortBy: "BizKeyEngine",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedDateCell,
    name: KstFileModel.PropertyNames.CreatedDate,
    prop: KstFileModel.PropertyNames.CreatedDate,
	sortBy: "CreatedDate",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedDateCell,
    name: KstFileModel.PropertyNames.UpdatedDate,
    prop: KstFileModel.PropertyNames.UpdatedDate,
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

    if (this.KstFileListCustom != null && this.KstFileListCustom["OnItems"] != null){
      this.KstFileListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.KstFileListCustom != null && this.KstFileListCustom["OnCustomActionExecute"] != null){
      this.KstFileListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:KstFileModel){
  if (this.KstFileListCustom != null && this.KstFileListCustom["OnForm"] != null){
    this.KstFileListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:KstFileModel){
	let route =  `${this.routeAdd}/${row.GuidFile}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.KstFileListCustom != null && this.KstFileListCustom["OnForm"] != null){
    this.KstFileListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:KstFileModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidFile }) => GuidFile), KstFileModel._EntitySetName);
       
       this.selection.clear();
 
       this.bindData();
   }else{
     
   }
 }

}

