import { sfsService } from 'src/app/services/common/sfs.service';
import { FormGroup, FormControl } from '@angular/forms';
import { ControlTypes } from 'src/app/pages/common/app-form-base/app-form-base.page';
import { isNullOrUndefined } from 'util';
import { KstProxyUserFormPage } from './KstProxyUser-form.page';
import { KstProxyUserModel } from 'src/app/models/business/models';

export class KstProxyUserFormCustom {
    public static OnShowing(page: KstProxyUserFormPage, e: any): void {

        page.title = "Usuario";

        page.setOrder({
            Name: KstProxyUserModel.PropertyNames.FirstName,
            Label: "Nombre"
        });
        page.setOrder({
            Name: KstProxyUserModel.PropertyNames.LastName,
            Label: "Apellidos"
        });
        let service: sfsService = page.injector.get(sfsService);
        let originalEmail = null;
        page.setOrder({ 
            Name: KstProxyUserModel.PropertyNames.Email , 
            Label:"Email",
            Validators: {
                email: {
                  expression: (control) => /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/.test(control.value),
                  message: 'Formato incorrecto',
                }
              },
        
              AsyncValidators: {
                uniqueUsername: {
                  expression: async (control: FormControl) => {
                    if (originalEmail == null && page.item != null) {
                      originalEmail = page.item.Email;
                    }
        
                    if (originalEmail != control.value) {
                      return await service.IsEmailAvailable(control.value);
                    } else {
                      return true;
                    }
        
                  },
                  message: 'Este correo ya se encuentra registrado',
                },
              },
        });

        page.setOrder({
            Name: KstProxyUserModel.PropertyNames.GuidRole,
            Label: "Rol",
           
          
        });


    }
}