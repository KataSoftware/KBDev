import { FormGroup } from '@angular/forms';
import { isNullOrUndefined } from 'util';
import { GenericListPage } from 'src/app/sfs/generic/generic-list/generic-list.page';
import { KstActivityModel } from 'src/app/sfs/models/codegen/KstActivity.model';



export class KstActivityListCustom {
    public static OnShowing(page: GenericListPage, e: any): void {
        console.log("aver");
        page.title = "Actividades";
        page.tableColumns = [];
        page.setOrder({ Name: KstActivityModel.PropertyNames.GuidActivity });
        page.setOrder({ Name: KstActivityModel.PropertyNames.Name, Label: "Nombre"});
        page.setOrder({ Name: `Fk${KstActivityModel.PropertyNames.KstProject}Text`, Label: "Proyecto"});
        page.setOrder({ Name: 'actions' });

    }
}