import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     KstProjectModel, 
  
} from 'src/app/models/business/models';

export class KstProjectFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstProjectModel.PropertyNames.Name,
    type: 'input',

    templateOptions: {
        label: KstProjectModel.PropertyNames.Name,
        placeholder: '',
        required: true,
		
		maxLength: 255,
    }
},
{
    key: KstProjectModel.PropertyNames.NumActivities,
    type: 'input',

    templateOptions: {
        label: KstProjectModel.PropertyNames.NumActivities,
        placeholder: '',
        required: false,
		
        type: "number",
    }
},
{
    key: KstProjectModel.PropertyNames.NumUsers,
    type: 'input',

    templateOptions: {
        label: KstProjectModel.PropertyNames.NumUsers,
        placeholder: '',
        required: false,
		
        type: "number",
    }
},
	];
    }
}

