import { sfsService } from 'src/app/services/common/sfs.service';
import { FormGroup } from '@angular/forms';
import { ControlTypes } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { isNullOrUndefined } from 'util';
import { KstProxyUserListPage } from './KstProxyUser-list.page';
import { KstProxyUserModel } from 'src/app/models/business/models';

export class KstProxyUserListCustom {
    public static OnShowing(page: KstProxyUserListPage, e: any): void {

        page.title = "Usuarios";
        page.tableColumns = [];
        page.setOrder({ Name: KstProxyUserModel.PropertyNames.GuidUser });
        page.setOrder({ 
            Name: KstProxyUserModel.PropertyNames.DisplayName , 
            Label: "Nombre"} );
        page.setOrder({ 
            Name: KstProxyUserModel.PropertyNames.Email , 
            Label:"Email",
            
        });
        page.setOrder({ 
            Name: `Fk${KstProxyUserModel.PropertyNames.KstProxyRole}Text`, 
            Label: "Rol"});
       
        page.setOrder({ Name: 'actions' });

    }
}