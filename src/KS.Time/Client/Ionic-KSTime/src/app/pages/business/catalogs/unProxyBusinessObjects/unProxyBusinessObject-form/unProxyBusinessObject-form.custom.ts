import { TableColumn } from 'sfscommon';
//import { sfsService } from './../../../../services/common/sfs.service';
import { sfsService } from 'src/app/services/common/sfs.service';
import { unProxyBusinessObjectFormFields } from './unProxyBusinessObject-form.fields';
import { unProxyBusinessObjectFormPage } from './unProxyBusinessObject-form.page';

import { FormGroup } from '@angular/forms';


export class unProxyBusinessObjectFormCustom {

    /**
     *
     */

    public static OnShowing(page: unProxyBusinessObjectFormPage, e: any): void {
        page.title = "Catálogo del sistema";
        
        page.setOrder( { Name: "Name" } );
        
    }
   
}