import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     unProxyEventModel, 
  
} from 'src/app/models/business/models';

export class unProxyEventFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: unProxyEventModel.PropertyNames.Title,
    type: 'input',

    templateOptions: {
        label: unProxyEventModel.PropertyNames.Title,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: unProxyEventModel.PropertyNames.Message,
    type: 'input',

    templateOptions: {
        label: unProxyEventModel.PropertyNames.Message,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: unProxyEventModel.PropertyNames.TypeEvent,
    type: 'textarea',

    templateOptions: {
        label: unProxyEventModel.PropertyNames.TypeEvent,
        placeholder: '',
        required: false,
		rows: 5,
    }
},
{
    key: unProxyEventModel.PropertyNames.IsException,
    type: 'checkbox',

    templateOptions: {
        label: unProxyEventModel.PropertyNames.IsException,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
}

