import { FormGroup } from '@angular/forms';
import { isNullOrUndefined } from 'util';
import { GenericListPage } from 'src/app/sfs/generic/generic-list/generic-list.page';
import { KstProjectModel } from 'src/app/sfs/models/codegen/KstProject.model';



export class KstProjectListCustom {
    public static OnShowing(page: GenericListPage, e: any): void {
        console.log("aver ");
        page.title = "Proyectos";
        page.tableColumns = [];
        page.setOrder({ Name: KstProjectModel.PropertyNames.Name, Label: "Nombre"});
        page.setOrder({ Name: KstProjectModel.PropertyNames.NumActivities, Label: "Actividades"});
        page.setOrder({ Name: 'actions' });

    }
}