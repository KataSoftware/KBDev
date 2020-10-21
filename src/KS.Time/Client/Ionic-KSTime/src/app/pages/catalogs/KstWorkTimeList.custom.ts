import { FormGroup } from '@angular/forms';
import { isNullOrUndefined } from 'util';
import { GenericListPage } from 'src/app/sfs/generic/generic-list/generic-list.page';
import { KstWorkTimeModel } from 'src/app/sfs/models/codegen/KstWorkTime.model';
import { IonItem } from '@ionic/angular';



export class KstWorkTimeListCustom {
    

    public static OnShowing(page: GenericListPage, e: any): void {
        
        
        // page["test"]= (item:KstWorkTimeModel)=>{
        //     if (item.NumActivities == 0 ){
        //         return "medium";
        //     }
        // };
        page.title = "Horas trabajadas";
        page.tableColumns = [];
        
        page.setOrder({ Name: KstWorkTimeModel.PropertyNames.Title, Label: "Título"});
        page.setOrder({ Name: KstWorkTimeModel.PropertyNames.GuidProject, Label: "Proyecto"});
        
        

    }
}