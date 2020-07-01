import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     KstWorkTimeModel, 
	KstActivityModel,
	KstProjectModel,
  
} from 'src/app/models/business/models';

export class KstWorkTimeFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstWorkTimeModel.PropertyNames.Title,
    type: 'input',

    templateOptions: {
        label: KstWorkTimeModel.PropertyNames.Title,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstWorkTimeModel.PropertyNames.Comments,
    type: 'input',

    templateOptions: {
        label: KstWorkTimeModel.PropertyNames.Comments,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: KstWorkTimeModel.PropertyNames.Hours,
    type: 'input',

    templateOptions: {
        label: KstWorkTimeModel.PropertyNames.Hours,
        placeholder: '',
        required: false,
		
        type: "number",
    }
},
{
    key: KstWorkTimeModel.PropertyNames.GuidProject,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstProjectModel,  
			DataValue: KstProjectModel.PropertyNames.GuidProject,
            DataText: KstProjectModel.PropertyNames.Name 
			},
        label: KstWorkTimeModel.PropertyNames.GuidProject,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstWorkTimeModel.PropertyNames.GuidActivity,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstActivityModel,  
			DataValue: KstActivityModel.PropertyNames.GuidActivity,
            DataText: KstActivityModel.PropertyNames.Name 
			},
        label: KstWorkTimeModel.PropertyNames.GuidActivity,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
}

