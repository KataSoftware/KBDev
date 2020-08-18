import { Component, Injector } from '@angular/core';
import { ListPage, UserDataModel, Pagination, TableColumn, uiSettings, titlePlace } from 'sfscommon';
import { FieldSettings, MobileFieldPlace } from '../../models/common/page.model';
import { PageService } from '../../services/page.service';



export class AppListBasePage extends ListPage {
  backtableColumns:Array<TableColumn> = [];
  private _pageService: PageService;

 public  setComponentColor(item:any, color:string){
    item["__elementcolor"] = color;
  }
  public  setComponentVisibility(item:any, visible:boolean){
    item["__visible"] = visible;
  }
  public  setActions(item:any, actions:Array<ActionModel>){
    item["__actions"] = actions;
  }

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
    this.actions.push({ Icon: "trash", Text: "Eliminar", ActionKey:"delete" });

    this.actions.push({ Icon: "eye", Text:"Detalles", ActionKey: "edit"});
   
    
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

  numOrder:number=0;
  setOrder(settings: FieldSettings) {
      this.numOrder = this.numOrder + 1;
      if (settings.Place == null && this.numOrder == 2){
        settings.Place = MobileFieldPlace.Value;
      }

      let finded = this.backtableColumns.find(p => p.prop == settings.Name);
      if (finded != null) {
          if (settings.Label != null ){
            finded.name = settings.Label;
          }
          
          finded.place = settings.Place;
          this.tableColumns.push(finded);
      }
  }

  actions:Array<ActionModel>=[];
  addActions(actions:Array<ActionModel>){
    if (this.localActions == null ){
      this.localActions = this.getDefaultItemActions(null, null);
     
    }
    this.localActions = this.localActions.concat(actions);
  }
  public localActions: Array<ActionModel> = null;
  public getItemsActions(row:any, contextType?:any ):Array<any>{
    let itemActions = this.getDefaultItemActions(null, null);
    return itemActions;
  }
  public getDefaultItemActions(row:any, contextType?:any ){
    if (this.localActions == null ){
      this.localActions = [];
      this.actions.forEach(item=> {
        this.localActions.push(item);
      });
    }
    //let localActions: Array<ActionModel> = [];
    
    return this.localActions;
  }
  routeForm:string=null;
  public userData: UserDataModel;
  public defaultHref: string;
  public tempPagination: Pagination;
    public  async showConfirm(settings:confirmSettings){
      

        const alert = await this.alertCtrl.create({
        cssClass: 'my-custom-class',
        header: 'Confirmar',
        message: `¿ Desea eliminar los <strong>${settings.numSelected}</strong> elementos seleccionados?`,
        buttons: [
          {
            text: 'Cancelar',
            role: 'cancel',
            cssClass: 'secondary',
            handler: () => {
              console.log('Confirm Cancel: blah');
            }
          }, {
            text: 'Sí, eliminar',
            handler: () => {
             settings.onOk();
            }
          }
        ]
      });
  
       alert.present();
      
       //return true;
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
 export class confirmSettings{
  text?:string=null;
  numSelected?:number=null;
  onOk? = ()=>{};

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