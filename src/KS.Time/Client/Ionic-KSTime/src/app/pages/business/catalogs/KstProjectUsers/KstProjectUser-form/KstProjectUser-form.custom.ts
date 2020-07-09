import { sfsService } from 'src/app/services/common/sfs.service';
import { FormGroup } from '@angular/forms';
import { ControlTypes } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { isNullOrUndefined } from 'util';
import { KstProjectUserFormPage } from './KstProjectUser-form.page';
import { KstProjectUserModel, KstProxyUserModel } from 'src/app/models/business/models';

export class KstProjectUserFormCustom {
    public static OnShowing(page: KstProjectUserFormPage, e: any): void {

        page.title = "Relación proyecto usuario";
        
        page.setOrder({ 
            Name: KstProjectUserModel.PropertyNames.GuidProject,
            Label: "Proyecto"});
        page.setOrder({
            Name: KstProjectUserModel.PropertyNames.GuidUser, 
            DataQuery: `it.${KstProxyUserModel.PropertyNames.Disabled} = false 
                OR it.${KstProxyUserModel.PropertyNames.Disabled} = null `,
            Label: "Usuario"});       
        page.setOrder({ 
            Name: KstProjectUserModel.PropertyNames.StartDate, 
            Label: "Fecha inicial",
            Columns: 6 });
        page.setOrder({ Name: KstProjectUserModel.PropertyNames.EndDate, 
            Label: "Fecha final",
             Columns: 6 });
    }
}