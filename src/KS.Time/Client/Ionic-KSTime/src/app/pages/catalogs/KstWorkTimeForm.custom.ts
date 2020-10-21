import { FormGroup } from '@angular/forms';
import { isNullOrUndefined } from 'util';
import { IonItem } from '@ionic/angular';
import { GenericFormPage } from 'src/app/sfs/generic/generic-form/generic-form.page';
import { KstWorkTimeModel } from 'src/app/sfs/models/codegen/KstWorkTime.model';



export class KstWorkTimeFormCustom {
   

    public static OnShowing(page: GenericFormPage, e: any): void {
        //console.log("ok...");
        page.title = "Tiempo de trabajo";
        page.setOrder({ Name: KstWorkTimeModel.PropertyNames.Title, Label: "Tarea" });
        page.setOrder({ Name: KstWorkTimeModel.PropertyNames.Comments, Label: "Comentarios" });
        page.setOrder({ Name: KstWorkTimeModel.PropertyNames.Hours, Label: "Horas" });
        page.setOrder({ Name: KstWorkTimeModel.PropertyNames.GuidProject, Label: "Proyecto" });
        page.setOrder({ Name: KstWorkTimeModel.PropertyNames.GuidActivityType, Label: "Tipo de actividad" });
        page.setOrder({ Name: KstWorkTimeModel.PropertyNames.GuidActivity, Label: "Actividad" });
        page.setOrder({ Name: KstWorkTimeModel.PropertyNames.DueDate, Label: "Fecha limite" });


        page.setOrderRelation({ Name: "" });
        page.sfsService.SetNavigationData({ name: "test!!!"});

    }
}