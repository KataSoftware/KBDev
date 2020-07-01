import { sfsService } from 'src/app/services/common/sfs.service';
import { AppListBaseTypedPage } from 'src/app/pages/common/app-list-base-typed/app-list-base-typed.page';
import { Component, OnInit, Injector, ViewChild, TemplateRef } from '@angular/core';
import { secEventLogModel } from 'src/app/models/common/system-models';
import { DataService, UserService, ServiceData } from 'sfscommon';
import { TimeAgoPipe } from 'src/app/pipes/common/timeago';

import swal from 'sweetalert';
@Component({
  selector: 'app-event-logs-page',
  templateUrl: './event-logs-page.page.html',
  styleUrls: ['./event-logs-page.page.scss'],
})
export class EventLogsPage extends AppListBaseTypedPage<secEventLogModel> implements OnInit {
  @ViewChild('guidEventCell') public guidEventCell: TemplateRef<any>;
  @ViewChild('titleCell') public titleCell: TemplateRef<any>;
  @ViewChild('createdDateCell') public createdDateCell: TemplateRef<any>;
  
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
          cellTemplate: this.guidEventCell,
          name: '',
          cellClass: this.getCellClass,
          prop: secEventLogModel.PropertyNames.GuidMyEventLog,
          sortable: false,
        },
        {
          cellTemplate: this.titleCell,
          name: 'Título',
          cellClass: this.getCellClass,
          prop: secEventLogModel.PropertyNames.Title,
          sortable: false,
        },
        {
          cellTemplate: this.createdDateCell,
          name: '',
          cellClass: this.getCellClass,
          prop: secEventLogModel.PropertyNames.CreatedDate,
        }];


      this.serviceData = {

        Page: 1,
        PageSize: 10,
        RestServiceAppKey: 'SFSCoreSecurity', // no es necesario si se trata de la aplicación de negocio, en este caso se especifica porque estamos usando el servicio de la app core
        EntitySet: secEventLogModel._EntitySetName,
        Fields: `${secEventLogModel.PropertyNames.Title},${secEventLogModel.PropertyNames.IsException}`,
        
        FreeText: this.serviceData.FreeText,
        AllFields: true,
        SortBy: 'CreatedDate',
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

  getCellClass(row:secEventLogModel){
      if (row != null && row.IsException == true ){
        return "error ";
      }else{
        return "";
      }
  }

  async delete(){
    let modalResponse = await this.showConfirm(this.selection.selected.length);
   
     if (modalResponse == true) {
         let response = await this.sfsService.Delete(this.selection.selected.map(({ GuidMyEventLog }) => GuidMyEventLog), secEventLogModel._EntitySetName);
         swal.close();
          this.selection.clear();
   
         this.bindData();
     }else{
       swal.close();
     }
   }
  
  async edit(row:secEventLogModel){
    console.log("ax77", row);
    this.navCtrl.navigateForward(`system/events/detail/${row.GuidMyEventLog}`, { animated: true });
  }
  
  


}
