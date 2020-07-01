import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     KstProxyUserModel, 
	KstProxyRoleModel,
  
} from 'src/app/models/business/models';

export class KstProxyUserFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstProxyUserModel.PropertyNames.DisplayName,
    type: 'input',

    templateOptions: {
        label: KstProxyUserModel.PropertyNames.DisplayName,
        placeholder: '',
        required: false,
		
		maxLength: 150,
    }
},
{
    key: KstProxyUserModel.PropertyNames.Username,
    type: 'input',

    templateOptions: {
        label: KstProxyUserModel.PropertyNames.Username,
        placeholder: '',
        required: false,
		
		maxLength: 100,
    }
},
{
    key: KstProxyUserModel.PropertyNames.Password,
    type: 'input',

    templateOptions: {
        label: KstProxyUserModel.PropertyNames.Password,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstProxyUserModel.PropertyNames.FirstName,
    type: 'input',

    templateOptions: {
        label: KstProxyUserModel.PropertyNames.FirstName,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstProxyUserModel.PropertyNames.LastName,
    type: 'input',

    templateOptions: {
        label: KstProxyUserModel.PropertyNames.LastName,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstProxyUserModel.PropertyNames.Email,
    type: 'input',

    templateOptions: {
        label: KstProxyUserModel.PropertyNames.Email,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstProxyUserModel.PropertyNames.GuidRole,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstProxyRoleModel,  
			DataValue: KstProxyRoleModel.PropertyNames.GuidRole,
            DataText: KstProxyRoleModel.PropertyNames.RoleName 
			},
        label: KstProxyUserModel.PropertyNames.GuidRole,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstProxyUserModel.PropertyNames.Disabled,
    type: 'checkbox',

    templateOptions: {
        label: KstProxyUserModel.PropertyNames.Disabled,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
}

