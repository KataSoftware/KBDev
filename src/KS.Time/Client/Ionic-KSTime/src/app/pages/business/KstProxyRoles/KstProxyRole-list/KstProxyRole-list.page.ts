import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { KstProxyRoleModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';
import swal from 'sweetalert';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'KstProxyRole-list',
  templateUrl: './KstProxyRole-list.page.html',
  styleUrls: ['./KstProxyRole-list.page.scss'],
})
export class KstProxyRoleListPage extends AppListBaseTypedPage<KstProxyRoleModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.KstProxyRoleListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.KstProxyRoleListCustom = _import["KstProxyRoleListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidRoleCell') public GuidRoleCell: TemplateRef<any>;

	@ViewChild('RoleNameCell') public RoleNameCell: TemplateRef<any>;

	@ViewChild('NameKeyCell') public NameKeyCell: TemplateRef<any>;

	@ViewChild('UpdatedDateCell') public UpdatedDateCell: TemplateRef<any>;

	@ViewChild('IsDeletedCell') public IsDeletedCell: TemplateRef<any>;

	@ViewChild('CreatedDateCell') public CreatedDateCell: TemplateRef<any>;

	@ViewChild('KstProxyUsersCell') public KstProxyUsersCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	KstProxyRoleListCustom:any = null;
	customClass = 'KstProxyRole-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new KstProxyRoleModel();
		//this.title = "KstProxyRoles";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: KstProxyRoleModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(KstProxyRoleModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.KstProxyRoleListCustom = p["KstProxyRoleListCustom"];
    if (this.KstProxyRoleListCustom != null && this.KstProxyRoleListCustom["OnShowing"] != null){
      this.KstProxyRoleListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, KstProxyRoleModel._EntitySetName, Object.getOwnPropertyNames(KstProxyRoleModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.KstProxyRoleListCustom != null && this.KstProxyRoleListCustom["OnItems"] != null) {
						this.KstProxyRoleListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:KstProxyRoleModel = null;
  refreshFilter(){
    this.itemFilter = new KstProxyRoleModel();
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
    
	this.setOrder( { Name: "GuidRole" } );
   
    
	   this.setOrder({ Name: "RoleName" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.KstProxyRoleListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.KstProxyRoleListCustom = _import["KstProxyRoleListCustom"];
              if (this.KstProxyRoleListCustom != null) {
                this.KstProxyRoleListCustom["OnShowing"](this);
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
routeAdd:string="KstProxyRole/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidRoleCell,
    name: '',
    prop: KstProxyRoleModel.PropertyNames.GuidRole,
	sortBy: "GuidRole",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.RoleNameCell,
    name: KstProxyRoleModel.PropertyNames.RoleName,
    prop: KstProxyRoleModel.PropertyNames.RoleName,
	sortBy: "RoleName",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.NameKeyCell,
    name: KstProxyRoleModel.PropertyNames.NameKey,
    prop: KstProxyRoleModel.PropertyNames.NameKey,
	sortBy: "NameKey",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedDateCell,
    name: KstProxyRoleModel.PropertyNames.UpdatedDate,
    prop: KstProxyRoleModel.PropertyNames.UpdatedDate,
	sortBy: "UpdatedDate",
    sortable: true,
    
    headerClass: 'updated',
	cellClass: 'updated',
},
{
	
	cellTemplate: this.CreatedDateCell,
    name: KstProxyRoleModel.PropertyNames.CreatedDate,
    prop: KstProxyRoleModel.PropertyNames.CreatedDate,
	sortBy: "CreatedDate",
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

    if (this.KstProxyRoleListCustom != null && this.KstProxyRoleListCustom["OnItems"] != null){
      this.KstProxyRoleListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.KstProxyRoleListCustom != null && this.KstProxyRoleListCustom["OnCustomActionExecute"] != null){
      this.KstProxyRoleListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:KstProxyRoleModel){
  if (this.KstProxyRoleListCustom != null && this.KstProxyRoleListCustom["OnForm"] != null){
    this.KstProxyRoleListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:KstProxyRoleModel){
	let route =  `${this.routeAdd}/${row.GuidRole}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.KstProxyRoleListCustom != null && this.KstProxyRoleListCustom["OnForm"] != null){
    this.KstProxyRoleListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:KstProxyRoleModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidRole }) => GuidRole), KstProxyRoleModel._EntitySetName);
       swal.close();
       this.selection.clear();
 
       this.bindData();
   }else{
     swal.close();
   }
 }

}

