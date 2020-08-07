import { Component, Injector } from '@angular/core';
import { ListPage, UserDataModel, Pagination, TableColumn, uiSettings, titlePlace } from 'sfscommon';
import { FieldSettings } from '../../models/common/page.model';
import { PageService } from '../../services/page.service';



export class AppListBasePage extends ListPage {
  backtableColumns:Array<TableColumn> = [];
  private _pageService: PageService;

  public get uiSettings(): uiSettings{
    if ((this.currentMediaQuery != undefined && (this.currentMediaQuery =='xs' || this.currentMediaQuery =='sm'))
     ||  this.systemService.isMobile()
    ){
      if (this.systemService.uiSettingsMobile.titlePlace == null ){
        this.systemService.uiSettingsMobile.titlePlace = titlePlace.header;
      }
      return this.systemService.uiSettingsMobile;
    }else{
      if (this.systemService.uiSettingsDesktop.titlePlace == null ){
        this.systemService.uiSettingsDesktop.titlePlace = titlePlace.header;
      }
      return this.systemService.uiSettingsDesktop;
      
    }
  }
  public get pageService(): PageService {
    if (!this._pageService) {

      this._pageService = this.injector.get(PageService);
    }

    return this._pageService;
  }
  constructor(public injector:Injector) {
    super(injector);
    this.actions.push({ Text: "Agregar nuevo", ActionKey:"add" });
    this.actions.push({ Text: "Eliminar", ActionKey:"delete" });
    this.listSettings = { 
      listMobile: listMobile.CardMin,
      goToDetailsMobile: goToDetailsMobile.primaryColumn,
      showIconExpand: true,
    };
  }
  onGetData(data:any){
    //console.log("data", data);
  }
  //canAddChecked:boolean=false;
  externalCustomFileChecked:boolean = false;
  get canAdd(){
    //console.log("canAdd");
    //this.canAddChecked = true;
    return this.actions.find(p=>  p.ActionKey == "add") != null;
  }
  get canDelete(){
  //  console.log("canAdd");
    //this.canAddChecked = true;
    return this.actions.find(p=>  p.ActionKey == "delete") != null;
  }

  addNewTitle:string="Agregar";

  
  setOrder(settings: FieldSettings) {


      let finded = this.backtableColumns.find(p => p.prop == settings.Name);
      if (finded != null) {
          if (settings.Label != null ){
            finded.name = settings.Label;
          }
          this.tableColumns.push(finded);
      }
  }

  actions:Array<ActionModel>=[];
  
  getActions(row:any, contextType?:any ){
    
    let localActions: Array<ActionModel> = [];
    localActions.push({ Icon: "edit", Text:"Detalles", ActionKey: "edit"});
    //console.log("adresd");
    localActions.push({ Icon: "delete", Text:"Eliminar",   ActionKey: "delete"});
    return localActions;
  }
  routeForm:string=null;
  public userData: UserDataModel;
  public defaultHref: string;
  public tempPagination: Pagination;
    public  async showConfirm(selectedRows?:Number):Promise<boolean>{
      
        const alert = await this.alertCtrl.create({
        cssClass: 'my-custom-class',
        header: 'Confirm!',
        message: 'Message <strong>text</strong>!!!',
        buttons: [
          {
            text: 'Cancel',
            role: 'cancel',
            cssClass: 'secondary',
            handler: (blah) => {
              console.log('Confirm Cancel: blah');
            }
          }, {
            text: 'Okay',
            handler: () => {
              console.log('Confirm Okay');
            }
          }
        ]
      });
  
       alert.present();
      
       return true;
    }
    public listSettings?:listSettings=null;

}


export class ActionModel{
  Icon?:string=null;
  Text:string=null;
  ActionKey:string=null;
}

export class listSettings{
   listMobile?:listMobile= listMobile.CardMin;
   goToDetailsMobile?:goToDetailsMobile=goToDetailsMobile.primaryColumn;
   showIconExpand?:boolean=true;

 }
export enum listMobile{
  CardMin=1,
  CardMax=2,
  NoExpanded=3
}
export enum goToDetailsMobile{
 primaryColumn=1,
 actionButton=2,
 allCard=3
}


export class BindListSettings{
 RestartPaging?:Boolean=true;
}