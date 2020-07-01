import { isNullOrUndefined } from 'util';
import { KstWorkTimeFormPage } from './KstWorkTime-form.page';
import { KstWorkTimeModel } from 'src/app/models/business/models';


export class KstWorkTimeFormCustom {
    public static OnShowing(page: KstWorkTimeFormPage, e: any): void {

        page.title = "Registro de horas";

        page.setOrder({
            Name: KstWorkTimeModel.PropertyNames.Hours,
            Label: "Horas"
        });
        page.setOrder({
            Name: KstWorkTimeModel.PropertyNames.Title,
            Label: "Título"
        });

        let projects = page.bizAppService.Get({  });
        page.setOrder({
            Name: KstWorkTimeModel.PropertyNames.GuidProject,
            Label: "Título"
        });
        page.setOrder({
            Name: KstWorkTimeModel.PropertyNames.GuidActivity,
            Label: "Título"
        });

    }



}