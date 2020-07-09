import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     unProxyBusinessObjectModel, 
  
} from 'src/app/models/business/models';

export class unProxyBusinessObjectFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: unProxyBusinessObjectModel.PropertyNames.Name,
    type: 'input',

    templateOptions: {
        label: unProxyBusinessObjectModel.PropertyNames.Name,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: unProxyBusinessObjectModel.PropertyNames.BusinessObjectKey,
    type: 'input',

    templateOptions: {
        label: unProxyBusinessObjectModel.PropertyNames.BusinessObjectKey,
        placeholder: '',
        required: false,
		
		maxLength: 100,
    }
},
{
    key: unProxyBusinessObjectModel.PropertyNames.EntitySetName,
    type: 'input',

    templateOptions: {
        label: unProxyBusinessObjectModel.PropertyNames.EntitySetName,
        placeholder: '',
        required: false,
		
		maxLength: 100,
    }
},
	];
    }
}

