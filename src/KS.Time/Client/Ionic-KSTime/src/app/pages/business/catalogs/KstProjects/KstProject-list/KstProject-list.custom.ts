import { KstProjectListPage } from './KstProject-list.page';
import { KstProjectModel } from 'src/app/models/business/models';

export class KstProjectListCustom {
    public static OnShowing(page: KstProjectListPage, e: any): void {

        // page.title = "Proyectos";
        // page.tableColumns = [];
        // page.setOrder({ Name: KstProjectModel.PropertyNames.GuidProject });
        // page.setOrder({ Name: KstProjectModel.PropertyNames.Name, Label: "Nombre" });
        // page.setOrder({ Name: KstProjectModel.PropertyNames.NumUsers, Label: "Usuarios" });
        // page.setOrder({ Name: KstProjectModel.PropertyNames.NumActivities, Label: "Actividades" });

        // page.setOrder({ Name: 'actions' });

    }

    public static OnItems(page: KstProjectListPage, data: Array<KstProjectModel>): void {

       /*  setTimeout(() => {
            for (var i = 0; i < data.length; i++) {
                let row = i + 1;
                let td = document.querySelector('sfs-table > div > table > tbody > tr:nth-child(' + row + ') > td:nth-child(4)');
                if (td != null){
                    if (data[i].NumActivities == 0){
                        td.classList.add("activities-0"); 
                    }                   
                }   
            }
        }, 500); */
    }

}