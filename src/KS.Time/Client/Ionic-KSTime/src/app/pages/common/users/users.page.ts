import { sfsService } from 'src/app/services/common/sfs.service';

import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { ListPage, DataService, UserDataModel, UserService, Pagination, ServiceData } from 'sfscommon';
import { secUserModel } from 'src/app/models/common/system-models';
import { SelectionModel } from '@angular/cdk/collections';
import { AppListBasePage } from 'src/app/pages/common/app-list-base/app-list-base.page';

@Component({
  selector: 'app-users',
  templateUrl: './users.page.html',
  styleUrls: ['./users.page.scss'],
})
export class UsersPage extends AppListBasePage implements OnInit {
  selection = new SelectionModel<secUserModel>(true, []);
  public userData: UserDataModel;
  @ViewChild('userGuidCell') public userGuidCell: TemplateRef<any>;
  @ViewChild('displayNameCell') public displayNameCell: TemplateRef<any>;
  @ViewChild('emailCell') public emailCell: TemplateRef<any>;
  @ViewChild('numRolesCell') public numRolesCell: TemplateRef<any>;
  public tempPagination: Pagination;
  centralServiceName:string=null;
  guidCentralService:string = null;
  constructor(public injector: Injector,
    public userService: UserService,
    public sfsService:sfsService
    ) {
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

    this.guidCentralService = this.route.snapshot.paramMap.get("CentralServiceGuid");
   
  }
  async ionViewWillEnter() {
    if (this.loadingData == false) { await this.loadData(); }
  }

  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.data.length;
    return numSelected === numRows;
  }

  masterToggle() {
    this.isAllSelected() ?
        this.selection.clear() :
        this.data.forEach(row => this.selection.select(row));
  }

  /** The label for the checkbox on the passed row */
  checkboxLabel(row?: secUserModel): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row `;
  }

  async delete(){
   let modalResponse = await this.showConfirm(this.selection.selected.length);

    if (modalResponse == true) {
        let response = await this.sfsService.Delete(this.selection.selected.map(({ GuidUser }) => GuidUser), secUserModel._EntitySetName);
        
       

        this.bindData();
    }else{
      
    }
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
          cellTemplate: this.userGuidCell,
          name: '',
          cellClass:'selectCheck',
          prop: secUserModel.PropertyNames.GuidUser,
          sortable: false,
        },
        {
          cellTemplate: this.displayNameCell,
          name: 'Nombre del usuario',
          prop: 'DisplayName',
          sortable: false,
        },
        {
          cellTemplate: this.emailCell,
          name: 'Correo',
          prop: 'Email',
        },
        {
          cellTemplate: this.numRolesCell,
          name: 'Roles',
          prop: secUserModel.PropertyNames.NumRoles,
        }
      ];

        

      this.serviceData = {

        Page: 1,
        PageSize: 7,
        RestServiceAppKey: 'SFSCoreSecurity',// no es necesario si se trata de la aplicación de negocio, en este caso se especifica porque estamos usando el servicio de la app core
        EntitySet: 'secUsers',
        Fields: "DisplayName,Email,NumRoles",
        Usemode:"companyuser",
        Query: null,
        AllFields: true,
        FreeText: this.serviceData.FreeText,
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
    this.navCtrl.navigateForward(`system/users/detail/${row.Id}`, { animated: true });
  }

  async addItem(){
    this.navCtrl.navigateForward(`system/users/create`, { animated: true });
  }

  async goToUserRoles(row:secUserModel){
    this.navCtrl.navigateForward(`system/users-roles/user/${row.GuidUser}`, { animated: true });

  }


}
