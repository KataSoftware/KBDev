//import { sfsService } from './../../../../services/common/sfs.service';
import { sfsService } from 'src/app/services/common/sfs.service';
import { unProxyBusinessObjectFormFields } from './../unProxyBusinessObject-form/unProxyBusinessObject-form.fields';
import { unProxyBusinessObjectListPage } from './unProxyBusinessObject-list.page';

import { FormGroup } from '@angular/forms';
import { unProxyBusinessObjectModel } from 'src/app/models/business/models';


export class unProxyBusinessObjectListCustom {

    /**
     *
     */

    public static OnShowing(page: unProxyBusinessObjectListPage, e: any): void {
        page.title = "Catálogos del sistema";
       

        //page.routeForm = "";
    
    }
    public static OnForm(page:unProxyBusinessObjectListPage, e:unProxyBusinessObjectModel){
        //page.navCtrl.navigateForward(e.BusinessObjectKey + '/list', { animated: true });
    }
    public static OnActionExecute(page:unProxyBusinessObjectListPage, e:unProxyBusinessObjectModel){

    }
    public static OnClickItem(page:unProxyBusinessObjectListPage, e:unProxyBusinessObjectModel){
        page.navCtrl.navigateForward(e.BusinessObjectKey + '/list', { animated: true });
    }
    public static OnItems(page:unProxyBusinessObjectListPage, e:any){
        //e["_actions"] = null; 
       

        if (page.userData.IsCompanyAdmin() == false){
            page.data.forEach((p)=> {
                 p["_actions"] = null;
            });
        }
    }

    public static OnNgOnInit(page: unProxyBusinessObjectListPage, e: any): void {

    }
}