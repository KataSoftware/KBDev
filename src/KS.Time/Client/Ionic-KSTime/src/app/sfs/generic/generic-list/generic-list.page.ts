import { NgZone } from '@angular/core';
import { Component, OnInit, Injector, ViewChild, TemplateRef, ViewChildren, ElementRef, QueryList, AfterViewInit } from '@angular/core';
import { DataService, TableColumn, SystemCore, titlePlace, addButtonPlace } from 'sfscommon';
//import swal from 'sweetalert';
import { FormlyFieldConfig } from '@ngx-formly/core';
import { FormGroup } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { AppListBaseTypedPage } from '../../common/app-list-base-typed/app-list-base-typed.page';
import { bizAppService } from '../../services/business.service';
import { GenericModel } from '../../models/common/models';
import { sfsService } from '../../services/sfs.service';
import { BindListSettings } from '../../common/app-list-base/app-list-base.page';
import { MatExpansionPanel, MatExpansionPanelTitle } from '@angular/material/expansion';
import {  GestureController, IonItem } from '@ionic/angular';



@Component({
  selector: 'generic-list',
  templateUrl: './generic-list.page.html',
  styleUrls: ['./generic-list.page.scss'],
})
export class GenericListPage extends AppListBaseTypedPage<GenericModel> implements OnInit, AfterViewInit {

  fields: Array<FormlyFieldConfig> = null;
  bindedData: boolean = false;
  formFilter: FormGroup = new FormGroup({});
  async doRefresh(event){
    await this.refreshFilter(event);
  }
  ngAfterViewInit() {
    
    //const cardArray = this.cards.toArray();
    //this.useLongPress(cardArray);
  }
  public checkboxChange(item:any){
    if (item.__isChecked == false){
      this.selection.deselect(item);
      
    }else{
      this.selection.select(item);
      
    }
  }
  public longPress(event:any, item:any, num:any){
  
    item.__isChecked = true;
    this.selection.select(item);

  }
  
  
  
  public async openMassiveActions() {
    let actions = this.actionSheetCtrl.create(
      {
        header: 'Selecionados',
        buttons: [
          { text: 'Delete', role: 'destructive' },

          { text: 'Cancel', role: 'cancel' }
        ]
      }

    );

    (await actions).present();
  }
  private _isExpansionIndicator(target: any): boolean {
    console.log(target);
    const expansionIndicatorClass = 'mat-expansion-indicator';
    return (target.classList && target.classList.contains(expansionIndicatorClass));
  }
  selectItem( event: Event, item:any){
    if (!event.target["classList"].contains("checkbox-icon") && event.type != "ionChange"){
      this.edit(item);
    }
    console.log("checkbox", event);
  }
  expand(matExpansionPanel: MatExpansionPanel, event: Event, item:any): void {
    event.preventDefault(); // Preventing event bubbling
   
    if (!this._isExpansionIndicator(event.target)) {
      //this.edit(item);
      matExpansionPanel.close(); // Here's the magic
    }
  }
  public async scrollTo(content, id, index,) {

    let customOffset = index * this.averageItemHeight;

    // Se hace el scroll hasta el punto especificado
    content.scrollToPoint(0, customOffset, 250);
  }


  private _bizAppService: bizAppService;

  public get bizAppService(): bizAppService {
    if (!this._bizAppService) {

      this._bizAppService = this.injector.get(bizAppService);
    }

    return this._bizAppService;
  }

  public set bizAppService(value: bizAppService) { this._bizAppService = value; }
  GenericListCustom: any = null;

  noSysColumns: Array<TableColumn> = [];
  customClass: string;
  entityName: string = "Generic";
  entityModel: any = null;

  @ViewChildren(IonItem, { read: ElementRef }) cards: QueryList<ElementRef>;
  longPressActivate=false;
  constructor(public injector: Injector, private activatedRoute: ActivatedRoute, public sfsService: sfsService,
    public gestureCtrl: GestureController,
    private zone:NgZone
  ) {
    super(injector);
    this.entityName = this.activatedRoute.snapshot.paramMap.get('catalog');
    // const gesture: Gesture = this.gestureCtrl.create({
    //   el: this.element.nativeElement,
    //   threshold: 15,
    //   gestureName: 'my-gesture',
    //   onMove: ev => this.onMoveHandler(ev)
    // }, true);
    /*
    import(`./${this.customClass}`).then(p=>{
      this.GenericListCustom = p["GenericListCustom"];
      if (this.GenericListCustom != null && this.GenericListCustom["OnShowing"] != null){
        this.GenericListCustom["OnShowing"](this);
      }
      }).catch(error=> {
      console.log(error);
      });*/

  }
  async ionViewWillEnter() {
    let navData = this.sfsService.GetNavigationData();
    console.log("ionViewWillEnter navData", navData);
    if (navData != null) {
      if (navData.RefreshData == true) {
        if (this.loadingData == false) {
          await this.bindData({ RestartPaging: navData.RestartPaging });
        }
      } else if (navData.ItemUpdated != null) {
        let itemFormService = await this.bizAppService.GetItem(navData.ItemUpdated.Id, this.entityModel._EntitySetName, Object.getOwnPropertyNames(this.entityModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","));
        if (itemFormService.status == "success" && itemFormService.data != null) {

          let itemFinded = this.data.find(p => p.Id == navData.ItemUpdated.Id);
          Object.assign(itemFinded, itemFormService.data);
          if (this.GenericListCustom != null && this.GenericListCustom["OnItems"] != null) {
            this.GenericListCustom["OnItems"](this, this.data);
          }
        }
      }
    } else {
      if (this.loadingData == false) { await this.bindData(); }
    }
  }

  hideFilter: boolean = true;

  itemFilter: any = null;
  async refreshFilter(event) {
    this.itemFilter = new this.entityModel();
    this.serviceData.Query = "";
    await this.bindData();
    event.target.complete();
  }

  showFilter() {
    if (this.hideFilter == true) {
      this.hideFilter = false;
    } else {
      this.hideFilter = true;
    }
  }


  async ngOnInit() {
    this.routeAdd = "/catalog/" + this.entityName + "/form";

    import(
      /* webpackMode: "lazy-once" */
      /* webpackPrefetch: true */
      /* webpackInclude: /\.ts$/ */
      /* webpackPreload: true */
      `../../models/codegen/${this.entityName}.model`).then((_model) => {
        this.entityModel = _model[this.entityName + "Model"]

        this.itemFilter = new this.entityModel();
        //this.title = "KstEmailTemplates";
        // this.serviceData = {

        //   Page: 1,
        //   PageSize: 7,
        //   EntitySet: this.entityModel._EntitySetName,
        //   Fields: Object.getOwnPropertyNames(this.entityModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(","),
        //   AllFields: true,
        //   SortBy: 'UpdatedDate',
        //   SortDirection: 'desc',

        
        // };
        this.serviceData.PageSize = 15;
        this.serviceData.EntitySet =  this.entityModel._EntitySetName;
        this.serviceData.Fields =  Object.getOwnPropertyNames(this.entityModel.PropertyNames).filter(p => !p.startsWith("Fk")).join(",");
        this.serviceData.AllFields = true;

        this.serviceData.SortBy= 'UpdatedDate';

        this.serviceData.SortDirection= 'desc';

        console.log("ubiCustomer ngOnInit");
        //this.userData = await this.userService.getUserData();
        //let query: string;


        this.getColumns();

        this.setOrder({ Name: "Id" });


        this.setOrder({ Name: "Title" });

        this.setOrder({ Name: "UpdatedDate", Label: "" });
        this.setOrder({ Name: 'actions' });

        if (this.GenericListCustom == null) {
          import(
            /* webpackMode: "eager" */
            /* webpackPrefetch: true */
            /* webpackInclude: /\.ts$/ */
            /* webpackPreload: true */
            `../../../pages/catalogs/${this.entityName}List.custom`).then((_import) => {
              this.userService.getUserData().then((result) => {
                this.userData = result;
                this.GenericListCustom = _import[this.entityName + "ListCustom"];
                if (this.GenericListCustom != null) {
                  this.GenericListCustom["OnShowing"](this);
                  this.externalCustomFileChecked = true;
                  this.bindDisplayColumns();
                  this.bindData();
                }
              }).catch((error) => {
                this.externalCustomFileChecked = true;
                console.log("error userData", error);
              });


            }).catch(error => {
              this.externalCustomFileChecked = true;
              console.log("error", error);
              this.bindDisplayColumns();
              this.bindData();
            });
        }



      }).catch((error) => {
        this.externalCustomFileChecked = true;
        console.log("error ", error);
      });
  }
  bindDisplayColumns() {
    this.displayedColumns = [];
    for (let column of this.tableColumns) { this.displayedColumns.push(column.prop); }

  }
  routeAdd: string = "/catalog/" + this.entityName + "/form";
 
  async addItem() {
    this.navCtrl.navigateForward(this.routeAdd, { animated: true });
  }

  getPrimaryColumn(item: any) {
    let fieldname = this.pageService.getPrimaryColumn(this.tableColumns);
    if (fieldname != null) {
      return item[fieldname.prop];
    } else {
      return null;
    }

  }
  getColumnsForMobile(item: any) {
    let values: Array<any> = [];
    this.noSysColumns.forEach(col => {
      let nameProp = col.prop;

      values.push({ text: col.name, value: item[nameProp] });
    });
    return values;
  }
  getColumns() {

    this.tableColumns = [];

    let idCol: Array<any> = [{

      name: '',
      prop: "Id",
      sortBy: "Id",
      sortable: false,
      width: 50,
      headerClass: 'selectCheck',
      cellClass: 'selectCheck',
    }];

    let sysCols: Array<any> = [{


      name: this.entityModel.PropertyNames.UpdatedBy,
      prop: this.entityModel.PropertyNames.UpdatedBy,
      sortBy: "UpdatedBy",
      sortable: true,

      headerClass: 'title-cell',

    },

    {



      name: this.entityModel.PropertyNames.UpdatedDate,
      prop: this.entityModel.PropertyNames.UpdatedDate,
      sortBy: "UpdatedDate",
      sortable: true,
      headerClass: 'updated',
      cellClass: 'updated',
    },

    {
      name: '',
      prop: "actions",
      sortable: false,
      cellClass: 'actions',
      headerClass: 'actions',

    }];

    this.noSysColumns = this.pageService.getColumnsFromFields(this.entityModel.GetFields());
    this.backtableColumns = [
      ...idCol,
      ...this.noSysColumns,
      ...sysCols

    ];

  }
  existsPendingReport: boolean = false;
  public async bindData(settings?: BindListSettings) {
    try {
      this.bindedData = false;
      let restartPaging: Boolean = true;
      if (settings != null) {
        restartPaging = settings.RestartPaging;
      }
      await this.configurePagination(this.serviceData);
      this.pagination.pageIndex = 0;
      this.data = await this.getData(this.pagination);

    }
    catch (error) { this.logError(error); }
    finally { this.loadingData = false; this.bindedData = true; }
  }
  onGetData(data: any) {
    console.log("onGetData", data);


    data.forEach((p) => {
      p['_actions'] = this.getActions(p);
    });

    if (this.GenericListCustom != null && this.GenericListCustom["OnItems"] != null) {
      this.GenericListCustom["OnItems"](this, data);
    }

    
  
  }

  action(row: any, actionKey: string) {
    if (actionKey == "edit") {
      this.edit(row);
    } else if (actionKey == "delete") {
      this.delete(row);
    } else {
      if (this.GenericListCustom != null && this.GenericListCustom["OnCustomActionExecute"] != null) {
        this.GenericListCustom["OnCustomActionExecute"](this, row);
      }
    }
  }

  clickItem(row: GenericModel) {
    if (this.GenericListCustom != null && this.GenericListCustom["OnForm"] != null) {
      this.GenericListCustom["OnClickItem"](this, row);
    } else {
      this.edit(row);
    }
  }


  edit(row: GenericModel) {
    let route = `${this.routeAdd}/${row.Id}`;
    if (this.routeForm != null) {
      route = this.routeForm;
    }
    if (this.GenericListCustom != null && this.GenericListCustom["OnForm"] != null) {
      this.GenericListCustom["OnForm"](this, row);
    }
    this.navCtrl.navigateForward(route, { animated: true });
  }



  async delete(row: GenericModel) {

    if (row != null) {
      this.selection.clear();
      this.selection.select(row);
    }
    let modalResponse = await this.showConfirm(this.selection.selected.length);

    if (modalResponse == true) {
      let response = await this.bizAppService.Delete(this.selection.selected.map(({ Id }) => Id), GenericModel._EntitySetName);
      //swal.close();
      this.selection.clear();

      this.bindData();
    } else {
      //swal.close();
    }
  }

}

