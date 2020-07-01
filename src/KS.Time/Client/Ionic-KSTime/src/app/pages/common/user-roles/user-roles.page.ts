import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { ListPage, DataService, UserService, UserDataModel, Pagination, ServiceData } from 'sfscommon';
import { secUserCompanyModel } from 'src/app/models/common/system-models';
import { SelectionModel } from '@angular/cdk/collections';

// Third Library Imports
import swal from 'sweetalert';
import { sfsService } from 'src/app/services/common/sfs.service';

@Component({
  selector: 'app-user-roles',
  templateUrl: './user-roles.page.html',
  styleUrls: ['./user-roles.page.scss'],
})
export class UserRolesPage extends ListPage implements OnInit {
  public userData: UserDataModel;

  selection = new SelectionModel<secUserCompanyModel>(true, []);
  // cells
  public defaultHref: string;
  backText = "Configuración";
  @ViewChild('guidUserCompanyCell') public guidUserCompanyCell: TemplateRef<any>;
  @ViewChild('userCell') public userCell: TemplateRef<any>;
  @ViewChild('roleCell') public roleCell: TemplateRef<any>;
  public tempPagination: Pagination;
  public guidUser: string = null;
  title:string="Usuarios y roles";
  constructor(public injector: Injector,
    public dataService: DataService,
    public userService: UserService,
    public sfsService: sfsService,
  ) {
    super(injector, dataService);
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

    this.guidUser = this.route.snapshot.paramMap.get("guidUser");
    if (this.guidUser != null) {
      this.defaultHref = "system/users";
      this.backText = "Usuarios";
    
    }
   
  }
  async ionViewWillEnter() {
    if (this.loadingData == false) { await this.loadData(); }
  }
  async ngOnInit() {

    this.userData = await this.userService.getUserData();
    let query: string;
    console.log("guidUser", this.guidUser);
    if (this.guidUser != null) {
      let userResponse  = await this.sfsService.CustomMethod({ guidUser: this.guidUser }, "secUsers", "GetUser");

      if (userResponse.status == "success"){
         if (userResponse.data != null){
          this.title = "Roles del usuario " +  userResponse.data.FirstName + " " + userResponse.data.LastName;
          console.log("title", this.title);
        }
      }
      

    }

    await this.bindData();

  }
  public async bindData() {
    try {
      this.tableColumns = [
        {
          cellTemplate: this.guidUserCompanyCell,
          name: '',
          prop: secUserCompanyModel.PropertyNames.GuidUserCompany,
          sortable: false,
        },
        {
          cellTemplate: this.userCell,
          name: 'Usuario',
          prop: secUserCompanyModel.PropertyNames.FksecUser,
          sortable: false,
        },
        {
          cellTemplate: this.roleCell,
          name: 'Rol',
          prop: secUserCompanyModel.PropertyNames.FksecRole,
        }];
      if (this.guidUser == null) {
        this.displayedColumns = [
          secUserCompanyModel.PropertyNames.GuidUserCompany, secUserCompanyModel.PropertyNames.FksecUser, secUserCompanyModel.PropertyNames.FksecRole
        ];
      } else {
        this.displayedColumns = [
          secUserCompanyModel.PropertyNames.GuidUserCompany,  secUserCompanyModel.PropertyNames.FksecRole
        ];
      }
      let query = null;
      if (this.guidUser != null) {
        query = `it.secUser.GuidUser = Guid("${this.guidUser}")`;
      }
      this.serviceData = {

        Page: 1,
        PageSize: 7,
        RestServiceAppKey: 'SFSCoreSecurity', // no es necesario si se trata de la aplicación de negocio, en este caso se especifica porque estamos usando el servicio de la app core
        EntitySet: secUserCompanyModel._EntitySetName,
        Fields: `${secUserCompanyModel.PropertyNames.secUser},${secUserCompanyModel.PropertyNames.secRole}`,
        Usemode: "users-admin-app",
        FreeText: this.serviceData.FreeText,
        AllFields: true,
        Query: query,
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

  public async search(e) {
    this.serviceData.FreeText = e.target.value;
    this.ngOnInit();
  }

  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.data.length;
    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  masterToggle() {
    this.isAllSelected() ?
      this.selection.clear() :
      this.data.forEach(row => this.selection.select(row));
  }

  /** The label for the checkbox on the passed row */
  checkboxLabel(row?: secUserCompanyModel): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row `;
  }

  async delete() {
    const modalResponse = await swal({
      title: 'Advertencia',
      className: 'swal-danger-modal',
      text: `Se eliminarán los ${this.selection.selected.length} registros seleccionados ¿Desea continuar?`,
      closeOnClickOutside: false,
      buttons: {
        cancelar: {
          text: 'Cancelar',
          value: false,
          visible: true,
          className: 'modal-cancelar-button',
          closeModal: false,
        },
        confirmar: {
          text: 'Continuar',
          value: true,
          visible: true,
          className: 'modal-continuar-button',
          closeModal: false
        }
      }
    });

    if (modalResponse == true) {
      let response = await this.sfsService.Delete(this.selection.selected.map(({ GuidUserCompany }) => GuidUserCompany), secUserCompanyModel._EntitySetName);
      swal.close();
      console.log("response of delete", response);

      this.bindData();
    } else {
      swal.close();
    }
  }

  async edit(row) {
    console.log("ax77", row);
    this.navCtrl.navigateForward(`system/users-roles/detail/${row.GuidUserCompany}`, { animated: true });
  }

  async addItem() {
    if (this.guidUser != null){
      this.navCtrl.navigateForward(`system/users-roles/user/${this.guidUser}/create`, { animated: true });
  
    }else{
    this.navCtrl.navigateForward(`system/users-roles/create`, { animated: true });
    }
  }
}
