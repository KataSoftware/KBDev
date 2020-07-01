import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     KstActivityModel, 
	KstProjectModel,
  
} from 'src/app/models/business/models';

export class KstActivityFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstActivityModel.PropertyNames.Name,
    type: 'input',

    templateOptions: {
        label: KstActivityModel.PropertyNames.Name,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstActivityModel.PropertyNames.GuidProject,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstProjectModel,  
			DataValue: KstProjectModel.PropertyNames.GuidProject,
            DataText: KstProjectModel.PropertyNames.Name 
			},
        label: KstActivityModel.PropertyNames.GuidProject,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstActivityModel.PropertyNames.IsCustomByUser,
    type: 'checkbox',

    templateOptions: {
        label: KstActivityModel.PropertyNames.IsCustomByUser,
        placeholder: '',
        required: true,
		
    }
},
	];
    }
}

