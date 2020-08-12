import { FormGroup } from '@angular/forms';
import { isNullOrUndefined } from 'util';
import { GenericListPage } from 'src/app/sfs/generic/generic-list/generic-list.page';
import { KstProjectModel } from 'src/app/sfs/models/codegen/KstProject.model';
import { IonItem } from '@ionic/angular';



export class KstProjectListCustom {
    public static OnItems(page: GenericListPage, data: Array<KstProjectModel>){
        data.forEach(item=> {
            // if (item.NumActivities == 0){
            //     page.setComponentColor(item, "medium");
            // }
            if (item.NumActivities > 0){
                page.setComponentVisibility(item, true);
            }
            page.setActions(item, []);
            

        });
    }

    public static OnShowing(page: GenericListPage, e: any): void {
        console.log("aver ");
        page["test"]= (item:KstProjectModel)=>{
            if (item.NumActivities == 0 ){
                return "medium";
            }
        };
        page.title = "Proyectos";
        page.tableColumns = [];
        
        page.setOrder({ Name: KstProjectModel.PropertyNames.Name, Label: "Nombre"});
        page.setOrder({ Name: KstProjectModel.PropertyNames.NumActivities, Label: "Actividades"
    });
        page.setOrder({ Name: 'actions' });

        page.addActions([
            { Text: "Mi acción personalizada", ActionKey: "custom-action-1" },
            { Text: "Otra personalizada", ActionKey: "custom-action-2" }

        ]);

    }
}