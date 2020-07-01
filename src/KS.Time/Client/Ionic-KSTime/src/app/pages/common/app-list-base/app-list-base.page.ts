import { Component, Injector } from '@angular/core';
import { ListPage, UserDataModel, Pagination, TableColumn } from 'sfscommon';
import swal from 'sweetalert';
import { FieldSettings } from '../app-form-base/app-form-base.page';

@Component({
  selector: 'app-app-list-base',
  templateUrl: './app-list-base.page.html',
  styleUrls: ['./app-list-base.page.scss'],
})
export class AppListBasePage extends ListPage {
  backtableColumns:Array<TableColumn> = [];
  constructor(public injector:Injector) {
    super(injector);
    this.actions.push({ Text: "Agregar nuevo", ActionKey:"add" });
    this.actions.push({ Text: "Eliminar", ActionKey:"delete" });
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
    public async showConfirm(selectedRows?:Number): Promise<Boolean>{
        const modalResponse = await swal({
            icon:'warning',
            title: 'Borrando',
            className: 'swal-danger-modal',
            text: `Se eliminarán los ${selectedRows} registros seleccionados ¿Desea continuar?`,
            
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
          return modalResponse;
    }

}


export class ActionModel{
  Icon?:string=null;
  Text:string=null;
  ActionKey:string=null;
}

export class BindListSettings{
 RestartPaging?:Boolean=true;
}