import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     KstProxyRoleModel, 
  
} from 'src/app/models/business/models';

export class KstProxyRoleFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstProxyRoleModel.PropertyNames.RoleName,
    type: 'input',

    templateOptions: {
        label: KstProxyRoleModel.PropertyNames.RoleName,
        placeholder: '',
        required: true,
		
		maxLength: 150,
    }
},
{
    key: KstProxyRoleModel.PropertyNames.NameKey,
    type: 'input',

    templateOptions: {
        label: KstProxyRoleModel.PropertyNames.NameKey,
        placeholder: '',
        required: true,
		
		maxLength: 100,
    }
},
	];
    }
}

