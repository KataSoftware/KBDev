import { FormGroup } from '@angular/forms';
import { isNullOrUndefined } from 'util';
import { IonItem } from '@ionic/angular';
import { GenericFormPage } from 'src/app/sfs/generic/generic-form/generic-form.page';
import { unProxyBusinessObjectModel } from 'src/app/sfs/models/codegen/unProxyBusinessObject.model';



export class unProxyBusinessObjectFormCustom {
   

    public static OnShowing(page: GenericFormPage, e: any): void {
        //console.log("ok...");
        page.title = "Catálogo";
        page.setOrder({ Name: unProxyBusinessObjectModel.PropertyNames.Name, Label: "Nombre" });

    }
}