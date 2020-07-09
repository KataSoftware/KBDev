import { sfsService } from 'src/app/services/common/sfs.service';
import { FormGroup } from '@angular/forms';
import { ControlTypes } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { isNullOrUndefined } from 'util';
import { KstProjectUserListPage } from './KstProjectUser-list.page';
import { KstProjectUserModel } from 'src/app/models/business/models';

export class KstProjectUserListCustom {
    public static OnShowing(page: KstProjectUserListPage, e: any): void {

        page.title = "Usuarios por proyecto";
        page.tableColumns = [];
        page.setOrder({ Name: KstProjectUserModel.PropertyNames.GuidProjectUser });
        page.setOrder({ Name: `Fk${KstProjectUserModel.PropertyNames.KstProject}Text`, Label: "Proyecto"});
        page.setOrder({ Name: `Fk${KstProjectUserModel.PropertyNames.KstProxyUser}Text`, Label: "Usuario"});
        page.setOrder({ Name: KstProjectUserModel.PropertyNames.StartDate, Label: "Desde"});
        page.setOrder({ Name: KstProjectUserModel.PropertyNames.EndDate, Label: "Hasta"});
        page.setOrder({ Name: 'actions' });

    }
}