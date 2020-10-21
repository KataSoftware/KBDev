import { FormGroup } from '@angular/forms';
import { isNullOrUndefined } from 'util';
import { IonItem } from '@ionic/angular';
import { GenericFormPage } from 'src/app/sfs/generic/generic-form/generic-form.page';
import { KstProjectModel } from 'src/app/sfs/models/codegen/KstProject.model';



export class KstProjectFormCustom {
   

    public static OnShowing(page: GenericFormPage, e: any): void {
        //console.log("ok...");
        page.setOrder({ Name: KstProjectModel.PropertyNames.Name, Label: "Nombre" });
        page.setOrder({ Name: KstProjectModel.PropertyNames.NumActivities, Label: "Num. de actividades" });
        page.setOrder({ Name: KstProjectModel.PropertyNames.NumUsers, Label: "Num. de usuarios" });
        

        
        page.setOrderRelation({ Name: "KstWorkTime", Label: "Horas trabajadas" });
        page.setOrderRelation({ Name: "KstProjectFile", Label: "Archivos" });
        page.setOrderRelation({ Name: "KstProjectUser", Label: "Personas" });
        page.setOrderRelation({ Name: "KstActivity", Label: "Actividades" });

        //page.sfsService.SetNavigationData({ name: "test!!!"});

    }
}