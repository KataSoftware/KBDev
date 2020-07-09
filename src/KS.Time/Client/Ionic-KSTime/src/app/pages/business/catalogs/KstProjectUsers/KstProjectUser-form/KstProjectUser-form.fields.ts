import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     KstProjectUserModel, 
	KstProjectModel,
	KstProxyUserModel,
  
} from 'src/app/models/business/models';

export class KstProjectUserFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstProjectUserModel.PropertyNames.GuidProject,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstProjectModel,  
			DataValue: KstProjectModel.PropertyNames.GuidProject,
            DataText: KstProjectModel.PropertyNames.Name 
			},
        label: KstProjectUserModel.PropertyNames.GuidProject,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstProjectUserModel.PropertyNames.GuidUser,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstProxyUserModel,  
			DataValue: KstProxyUserModel.PropertyNames.GuidUser,
            DataText: KstProxyUserModel.PropertyNames.DisplayName 
			},
        label: KstProjectUserModel.PropertyNames.GuidUser,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstProjectUserModel.PropertyNames.StartDate,
    type: 'datepicker',

    templateOptions: {
        label: KstProjectUserModel.PropertyNames.StartDate,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstProjectUserModel.PropertyNames.EndDate,
    type: 'datepicker',

    templateOptions: {
        label: KstProjectUserModel.PropertyNames.EndDate,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
}

