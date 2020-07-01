import { sfsService } from 'src/app/services/common/sfs.service';
import { Component, OnInit, ViewChild, TemplateRef, Injector } from '@angular/core';
import { ListPage, UserDataModel, UserService, DataService, Pagination, ServiceData } from 'sfscommon';
import { secRoleModel } from 'src/app/models/common/system-models';

import { bizAppService } from 'src/app/services/business/business.service';
import swal from 'sweetalert';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';

@Component({
  selector: 'app-roles',
  templateUrl: './roles.page.html',
  styleUrls: ['./roles.page.scss'],
})
export class RolesPage extends AppListBaseTypedPage<secRoleModel> implements OnInit {
  public userData: UserDataModel;

  // cells
  @ViewChild('guidRoleCell') public guidRoleCell: TemplateRef<any>;
  @ViewChild('roleNameCell') public roleNameCell: TemplateRef<any>;
  @ViewChild('nameKeyCell') public nameKeyCell: TemplateRef<any>;
  public tempPagination: Pagination;
  
  constructor(public injector: Injector,
    public userService: UserService, public sfsService:sfsService) { 
      super(injector);
      this.data = [];
      // Se inicializan
      this.pagination = {
        total: 0,
        pageIndex: 1,
        pageSize: 10,
        previousPageIndex: 0
      };

      this.defaultHref = "configuration";
      this.serviceData = new ServiceData();
  }
  async ionViewWillEnter() {
    if (this.loadingData == false) { await this.loadData(); }
  }

  public async ngOnInit() {

    this.userData = await this.userService.getUserData();
    let query: string;

    await this.bindData();
  }

  
  public async bindData() {
    try {
      this.tableColumns = [
        {
          cellTemplate: this.guidRoleCell,
          name: '',
          prop: secRoleModel.PropertyNames.GuidRole,
          sortable: false,
        },
        {
          cellTemplate: this.roleNameCell,
          name: 'Nombre del rol',
          prop: secRoleModel.PropertyNames.RoleName,
          sortable: false,
        },
        {
          cellTemplate: this.nameKeyCell,
          name: 'Clave de nombre',
          prop: secRoleModel.PropertyNames.NameKey,
        }];

        this.displayedColumns = [
          secRoleModel.PropertyNames.GuidRole, secRoleModel.PropertyNames.RoleName, secRoleModel.PropertyNames.NameKey
        ];

      this.serviceData = {

        Page: 1,
        PageSize: 7,
        RestServiceAppKey: 'SFSCoreSecurity', // no es necesario si se trata de la aplicación de negocio, en este caso se especifica porque estamos usando el servicio de la app core
        EntitySet: secRoleModel._EntitySetName,
        Fields: `${secRoleModel.PropertyNames.RoleName},${secRoleModel.PropertyNames.NameKey}`,
        Usemode: "roles-admin-app",
        FreeText: this.serviceData.FreeText,
        AllFields: true,
        SortBy: 'UpdatedDate',
        SortDirection: 'desc',

      };

      await this.configurePagination(this.serviceData);

      this.tempPagination = { ...this.pagination };
      this.tempPagination.pageIndex = 1;

      // Se recuperan los primeros elementos.
      this.data = await this.getData();
    }
    catch (error) { this.logError(error); }
    finally { this.loadingData = false; }
  }
  async edit(row){
    console.log("ax77", row);
    this.navCtrl.navigateForward(`system/roles/detail/${row.GuidRole}`, { animated: true });
  }
  async delete(){
    let modalResponse = await this.showConfirm(this.selection.selected.length);
   
     if (modalResponse == true) {
         let response = await this.sfsService.Delete(this.selection.selected.map(({ GuidRole }) => GuidRole), secRoleModel._EntitySetName);
         swal.close();
          this.selection.clear();
   
         this.bindData();
     }else{
       swal.close();
     }
   }
  async addItem(){
    this.navCtrl.navigateForward(`system/roles/create`, { animated: true });
  }

}
