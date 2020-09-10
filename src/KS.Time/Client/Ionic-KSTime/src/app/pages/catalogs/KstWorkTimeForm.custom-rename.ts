import { FormGroup } from '@angular/forms';
import { isNullOrUndefined } from 'util';
import { IonItem } from '@ionic/angular';
import { GenericFormPage } from 'src/app/sfs/generic/generic-form/generic-form.page';
import { KstWorkTimeModel } from 'src/app/sfs/models/codegen/KstWorkTime.model';



export class KstWorkTimeFormCustom {
   

    public static OnShowing(page: GenericFormPage, e: any): void {
        //console.log("ok...");
        
        page.setOrderRelation({ Name: "" });
        page.sfsService.SetNavigationData({ name: "test!!!"});

    }
}