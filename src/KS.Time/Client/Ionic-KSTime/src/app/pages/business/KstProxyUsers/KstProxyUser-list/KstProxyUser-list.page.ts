import { bizAppService } from 'src/app/services/business/business.service';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { KstProxyUserModel } from 'src/app/models/business/models';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { DataService, TableColumn } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';
import { sfsService } from 'src/app/services/common/sfs.service';
import swal from 'sweetalert';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActionModel, BindListSettings } from 'src/app/pages/common/app-list-base/app-list-base.page';



@Component({
  selector: 'KstProxyUser-list',
  templateUrl: './KstProxyUser-list.page.html',
  styleUrls: ['./KstProxyUser-list.page.scss'],
})
export class KstProxyUserListPage extends AppListBaseTypedPage<KstProxyUserModel> implements OnInit {
    fields:Array<FormlyFieldConfig> = null;

     formFilter:FormGroup= new FormGroup({});
	 ngAfterViewInit() {
	 console.log("ubiCustomer ngAfterViewInit");
       if (this.KstProxyUserListCustom == null ){

		
           // let _import = await import(`./${this.customClass}`);


          //  this.KstProxyUserListCustom = _import["KstProxyUserListCustom"];

          
       }
      
    }
	@ViewChild('actionsTmpl') public actionsTmpl: TemplateRef<any>;
	@ViewChild('HeaderCheckTemplate') public HeaderCheckTemplate: TemplateRef<any>;
	@ViewChild('GuidUserCell') public GuidUserCell: TemplateRef<any>;

	@ViewChild('DisplayNameCell') public DisplayNameCell: TemplateRef<any>;

	@ViewChild('UsernameCell') public UsernameCell: TemplateRef<any>;

	@ViewChild('PasswordCell') public PasswordCell: TemplateRef<any>;

	@ViewChild('FirstNameCell') public FirstNameCell: TemplateRef<any>;

	@ViewChild('LastNameCell') public LastNameCell: TemplateRef<any>;

	@ViewChild('EmailCell') public EmailCell: TemplateRef<any>;

	@ViewChild('GuidRoleCell') public GuidRoleCell: TemplateRef<any>;

	@ViewChild('UpdatedDateCell') public UpdatedDateCell: TemplateRef<any>;

	@ViewChild('IsDeletedCell') public IsDeletedCell: TemplateRef<any>;

	@ViewChild('CreatedDateCell') public CreatedDateCell: TemplateRef<any>;

	@ViewChild('DisabledCell') public DisabledCell: TemplateRef<any>;

	@ViewChild('KstProjectUsersCell') public KstProjectUsersCell: TemplateRef<any>;

	@ViewChild('KstProxyRoleCell') public KstProxyRoleCell: TemplateRef<any>;

	@ViewChild('KstUserFilesCell') public KstUserFilesCell: TemplateRef<any>;


    private _bizAppService: bizAppService;

	public get bizAppService(): bizAppService {
		if (!this._bizAppService) {

			this._bizAppService = this.injector.get(bizAppService);
		}

		return this._bizAppService;
	}

	public set bizAppService(value: bizAppService) { this._bizAppService = value; }
	KstProxyUserListCustom:any = null;
	customClass = 'KstProxyUser-list.custom';

	constructor( public injector: Injector, public sfsService: sfsService) {
    super(injector);
		this.itemFilter = new KstProxyUserModel();
		//this.title = "KstProxyUsers";
	    this.serviceData = {

      Page: 1,
      PageSize: 7,
      EntitySet: KstProxyUserModel._EntitySetName,
      Fields: Object.getOwnPropertyNames(KstProxyUserModel.PropertyNames).filter(p=>   !p.startsWith("Fk")).join(","),
      AllFields: true,
      SortBy: 'UpdatedDate',
      SortDirection: 'desc',

    };
	/*
	import(`./${this.customClass}`).then(p=>{
    this.KstProxyUserListCustom = p["KstProxyUserListCustom"];
    if (this.KstProxyUserListCustom != null && this.KstProxyUserListCustom["OnShowing"] != null){
      this.KstProxyUserListCustom["OnShowing"](this);
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
				let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, KstProxyUserModel._EntitySetName, Object.getOwnPropertyNames(KstProxyUserModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
                if (itemFormService.status == "success" && itemFormService.data != null ) {

                    let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
                    Object.assign(itemFinded, itemFormService.data);
					if (this.KstProxyUserListCustom != null && this.KstProxyUserListCustom["OnItems"] != null) {
						this.KstProxyUserListCustom["OnItems"](this, this.data);
					}
				}
            }
        }else{
            if (this.loadingData == false) { await this.bindData(); }
        }
  }

  hideFilter:boolean=true;

  itemFilter:KstProxyUserModel = null;
  refreshFilter(){
    this.itemFilter = new KstProxyUserModel();
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
    
	this.setOrder( { Name: "GuidUser" } );
   
    
	   this.setOrder({ Name: "DisplayName" });
	
this.setOrder( { Name: "UpdatedDate", Label: "" } );
this.setOrder({ Name: 'actions'});

        if (this.KstProxyUserListCustom == null ){
		  import(`./${this.customClass}`).then((_import)=> {
            this.userService.getUserData().then((result)=> {
              this.userData = result;
              this.KstProxyUserListCustom = _import["KstProxyUserListCustom"];
              if (this.KstProxyUserListCustom != null) {
                this.KstProxyUserListCustom["OnShowing"](this);
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
routeAdd:string="KstProxyUser/form";
async addItem(){
  this.navCtrl.navigateForward(this.routeAdd, { animated: true });
}

  getColumns() {
 
	  this.tableColumns = [];
    this.backtableColumns = [

{
	headerTemplate: this.HeaderCheckTemplate,
	cellTemplate: this.GuidUserCell,
    name: '',
    prop: KstProxyUserModel.PropertyNames.GuidUser,
	sortBy: "GuidUser",
    sortable: false,
    width: 50,
    headerClass: 'selectCheck',
	cellClass: 'selectCheck',
},
{
	
	cellTemplate: this.DisplayNameCell,
    name: KstProxyUserModel.PropertyNames.DisplayName,
    prop: KstProxyUserModel.PropertyNames.DisplayName,
	sortBy: "DisplayName",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UsernameCell,
    name: KstProxyUserModel.PropertyNames.Username,
    prop: KstProxyUserModel.PropertyNames.Username,
	sortBy: "Username",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.PasswordCell,
    name: KstProxyUserModel.PropertyNames.Password,
    prop: KstProxyUserModel.PropertyNames.Password,
	sortBy: "Password",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.FirstNameCell,
    name: KstProxyUserModel.PropertyNames.FirstName,
    prop: KstProxyUserModel.PropertyNames.FirstName,
	sortBy: "FirstName",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.LastNameCell,
    name: KstProxyUserModel.PropertyNames.LastName,
    prop: KstProxyUserModel.PropertyNames.LastName,
	sortBy: "LastName",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.EmailCell,
    name: KstProxyUserModel.PropertyNames.Email,
    prop: KstProxyUserModel.PropertyNames.Email,
	sortBy: "Email",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.GuidRoleCell,
    name: KstProxyUserModel.PropertyNames.GuidRole,
    prop: KstProxyUserModel.PropertyNames.GuidRole,
	sortBy: "GuidRole",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.UpdatedDateCell,
    name: KstProxyUserModel.PropertyNames.UpdatedDate,
    prop: KstProxyUserModel.PropertyNames.UpdatedDate,
	sortBy: "UpdatedDate",
    sortable: true,
    
    headerClass: 'updated',
	cellClass: 'updated',
},
{
	
	cellTemplate: this.CreatedDateCell,
    name: KstProxyUserModel.PropertyNames.CreatedDate,
    prop: KstProxyUserModel.PropertyNames.CreatedDate,
	sortBy: "CreatedDate",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.DisabledCell,
    name: KstProxyUserModel.PropertyNames.Disabled,
    prop: KstProxyUserModel.PropertyNames.Disabled,
	sortBy: "Disabled",
    sortable: true,
    
    headerClass: 'title-cell',
	
},
{
	
	cellTemplate: this.KstProxyRoleCell,
    name: KstProxyUserModel.PropertyNames.KstProxyRole,
    prop: `Fk${KstProxyUserModel.PropertyNames.KstProxyRole}Text`,
	sortBy: "KstProxyRole.RoleName",
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

    if (this.KstProxyUserListCustom != null && this.KstProxyUserListCustom["OnItems"] != null){
      this.KstProxyUserListCustom["OnItems"](this, data);
    }
} 

action(row:any, actionKey:string){
  if (actionKey == "edit"){
    this.edit(row);
  }else if (actionKey == "delete"){
    this.delete(row);
  }else{
    if (this.KstProxyUserListCustom != null && this.KstProxyUserListCustom["OnCustomActionExecute"] != null){
      this.KstProxyUserListCustom["OnCustomActionExecute"](this, row);
    }
  }
}

clickItem(row:KstProxyUserModel){
  if (this.KstProxyUserListCustom != null && this.KstProxyUserListCustom["OnForm"] != null){
    this.KstProxyUserListCustom["OnClickItem"](this,row);
  }else{
    this.edit(row);
  }
}


edit(row:KstProxyUserModel){
	let route =  `${this.routeAdd}/${row.GuidUser}`;
 if (this.routeForm != null){
    route = this.routeForm;
  }
  if (this.KstProxyUserListCustom != null && this.KstProxyUserListCustom["OnForm"] != null){
    this.KstProxyUserListCustom["OnForm"](this,row);
  }
  this.navCtrl.navigateForward(route, { animated: true });
}



async delete(row:KstProxyUserModel){

	if (row != null ){
		this.selection.clear();
		this.selection.select(row);
	}
  let modalResponse = await this.showConfirm(this.selection.selected.length);
 
   if (modalResponse == true) {
       let response = await this.bizAppService.Delete(this.selection.selected.map(({ GuidUser }) => GuidUser), KstProxyUserModel._EntitySetName);
       swal.close();
       this.selection.clear();
 
       this.bindData();
   }else{
     swal.close();
   }
 }

}

