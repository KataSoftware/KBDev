import { sfsService } from 'src/app/services/common/sfs.service';
import { FormGroup } from '@angular/forms';
import { ControlTypes } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { isNullOrUndefined } from 'util';
import { KstActivityListPage } from './KstActivity-list.page';
import { KstActivityModel } from 'src/app/models/business/models';

export class KstActivityListCustom {
    public static OnShowing(page: KstActivityListPage, e: any): void {

        page.title = "Actividades";
        page.tableColumns = [];
        page.setOrder({ Name: KstActivityModel.PropertyNames.GuidActivity });
        page.setOrder({ Name: KstActivityModel.PropertyNames.Name, Label: "Nombre"});
        page.setOrder({ Name: `Fk${KstActivityModel.PropertyNames.KstProject}Text`, Label: "Proyecto"});
        page.setOrder({ Name: 'actions' });

    }
}