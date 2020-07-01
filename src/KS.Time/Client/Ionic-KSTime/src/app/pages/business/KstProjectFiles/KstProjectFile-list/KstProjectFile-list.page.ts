import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { KstProjectFileModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';
import swal from 'sweetalert';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'KstProjectFile-list',
  templateUrl: './KstProjectFile-list.page.html',
  styleUrls: ['./KstProjectFile-list.page.scss'],
})
export class KstProjectFileListPage extends AppListBaseTypedPage<KstProjectFileModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.KstProjectFileListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.KstProjectFileListCustom = _import["KstProjectFileListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidProjectFileCell') public GuidProjectFileCell: TemplateRef<any>;

	@ViewChild('GuidProjectCell') public GuidProjectCell: TemplateRef<any>;

	@ViewChild('GuidFileCell') public GuidFileCell: TemplateRef<any>;

	@ViewChild('GuidCompanyCell') public GuidCompanyCell: TemplateRef<any>;

	@ViewChild('CreatedByCell') public CreatedByCell: TemplateRef<any>;

	@ViewChild('UpdatedByCell') public UpdatedByCell: TemplateRef<any>;

	@ViewChild('IsDeletedCell') public IsDeletedCell: TemplateRef<any>;

	@ViewChild('BizKeyEngineCell') public BizKeyEngineCell: TemplateRef<any>;

	@ViewChild('CreatedDateCell') public CreatedDateCell: TemplateRef<any>;

	@ViewChild('UpdatedDateCell') public UpdatedDateCell: TemplateRef<any>;

	@ViewChild('BytesCell') public BytesCell: TemplateRef<any>;

	@ViewChild('KstFileCell') public KstFileCell: TemplateRef<any>;

	@ViewChild('KstProjectCell') public KstProjectCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	KstProjectFileListCustom:any = null;
	customClass = 'KstProjectFile-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new KstProjectFileModel();
		//this.title = "KstProjectFiles";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: KstProjectFileModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(KstProjectFileModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.KstProjectFileListCustom = p["KstProjectFileListCustom"];
    if (this.KstProjectFileListCustom != null && this.KstProjectFileListCustom["OnShowing"] != null){
      this.KstProjectFileListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, KstProjectFileModel._EntitySetName, Object.getOwnPropertyNames(KstProjectFileModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.KstProjectFileListCustom != null && this.KstProjectFileListCustom["OnItems"] != null) {
						this.KstProjectFileListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:KstProjectFileModel = null;
  refreshFilter(){
    this.itemFilter = new KstProjectFileModel();
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
    
	this.setOrder( { Name: "GuidProjectFile" } );
   
    
	   this.setOrder({ Name: "BizKeyEngine" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.KstProjectFileListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.KstProjectFileListCustom = _import["KstProjectFileListCustom"];
              if (this.KstProjectFileListCustom != null) {
                this.KstProjectFileListCustom["OnShowing"](this);
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
routeAdd:string="KstProjectFile/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidProjectFileCell,
    name: '',
    prop: KstProjectFileModel.PropertyNames.GuidProjectFile,
	sortBy: "GuidProjectFile",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.GuidProjectCell,
    name: KstProjectFileModel.PropertyNames.GuidProject,
    prop: KstProjectFileModel.PropertyNames.GuidProject,
	sortBy: "GuidProject",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.GuidFileCell,
    name: KstProjectFileModel.PropertyNames.GuidFile,
    prop: KstProjectFileModel.PropertyNames.GuidFile,
	sortBy: "GuidFile",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedByCell,
    name: KstProjectFileModel.PropertyNames.CreatedBy,
    prop: KstProjectFileModel.PropertyNames.CreatedBy,
	sortBy: "CreatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedByCell,
    name: KstProjectFileModel.PropertyNames.UpdatedBy,
    prop: KstProjectFileModel.PropertyNames.UpdatedBy,
	sortBy: "UpdatedBy",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.BizKeyEngineCell,
    name: KstProjectFileModel.PropertyNames.BizKeyEngine,
    prop: KstProjectFileModel.PropertyNames.BizKeyEngine,
	sortBy: "BizKeyEngine",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.CreatedDateCell,
    name: KstProjectFileModel.PropertyNames.CreatedDate,
    prop: KstProjectFileModel.PropertyNames.CreatedDate,
	sortBy: "CreatedDate",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedDateCell,
    name: KstProjectFileModel.PropertyNames.UpdatedDate,
    prop: KstProjectFileModel.PropertyNames.UpdatedDate,
	sortBy: "UpdatedDate",
    sortable: true,
    
    headerClass: 'updated',
	cellClass: 'updated',
},
{
	
	cellTemplate: this.KstFileCell,
    name: KstProjectFileModel.PropertyNames.KstFile,
    prop: `Fk${KstProjectFileModel.PropertyNames.KstFile}Text`,
	sortBy: "KstFile.FileName",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.KstProjectCell,
    name: KstProjectFileModel.PropertyNames.KstProject,
    prop: `Fk${KstProjectFileModel.PropertyNames.KstProject}Text`,
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

    if (this.KstProjectFileListCustom != null && this.KstProjectFileListCustom["OnItems"] != null){
      this.KstProjectFileListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.KstProjectFileListCustom != null && this.KstProjectFileListCustom["OnCustomActionExecute"] != null){
      this.KstProjectFileListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:KstProjectFileModel){
  if (this.KstProjectFileListCustom != null && this.KstProjectFileListCustom["OnForm"] != null){
    this.KstProjectFileListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:KstProjectFileModel){
	let route =  `${this.routeAdd}/${row.GuidProjectFile}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.KstProjectFileListCustom != null && this.KstProjectFileListCustom["OnForm"] != null){
    this.KstProjectFileListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:KstProjectFileModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidProjectFile }) => GuidProjectFile), KstProjectFileModel._EntitySetName);
       swal.close();
       this.selection.clear();
 
       this.bindData();
   }else{
     swal.close();
   }
 }

}

