
import { unProxyBusinessObjectModel } from 'src/app/sfs/models/codegen/unProxyBusinessObject.model';
import { GenericListPage } from 'src/app/sfs/generic/generic-list/generic-list.page';



export class unProxyBusinessObjectListCustom {
   
    public static OnCustomActionExecute(page: GenericListPage, row:unProxyBusinessObjectModel, actionKey:string): void{
        //console.log("row", row, actionKey);
        page.navCtrl.navigateForward(`catalog/${row.BusinessObjectKey}`);
    }


    public static OnShowing(page: GenericListPage, e: any): void {
        //console.log("ok...");
        page.title = "Catálogo";
        //page.setOrder({ Name: unProxyBusinessObjectModel.PropertyNames.Name, Label: "Nombre" });

        page.addActions([{ Text: "Ir al catálogo", ActionKey: "go-catalog"}]);
    }
}