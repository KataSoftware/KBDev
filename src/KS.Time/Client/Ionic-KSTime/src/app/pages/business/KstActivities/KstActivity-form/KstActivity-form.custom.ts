import { sfsService } from 'src/app/services/common/sfs.service';
import { FormGroup } from '@angular/forms';
import { ControlTypes } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { isNullOrUndefined } from 'util';
import { KstActivityFormPage } from './KstActivity-form.page';
import { KstActivityModel } from 'src/app/models/business/models';

export class KstActivityFormCustom {
    public static OnShowing(page: KstActivityFormPage, e: any): void {

        page.title = "Actividad";
        
        page.setOrder({ Name: KstActivityModel.PropertyNames.Name, Label: "Nombre"});
        page.setOrder({ Name: KstActivityModel.PropertyNames.GuidProject, Label: "Proyecto"});
       
    }
}