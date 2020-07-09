import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     KstUserFileModel, 
	KstFileModel,
	KstProxyUserModel,
  
} from 'src/app/models/business/models';

export class KstUserFileFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstUserFileModel.PropertyNames.GuidUser,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstProxyUserModel,  
			DataValue: KstProxyUserModel.PropertyNames.GuidUser,
            DataText: KstProxyUserModel.PropertyNames.DisplayName 
			},
        label: KstUserFileModel.PropertyNames.GuidUser,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstUserFileModel.PropertyNames.GuidFile,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstFileModel,  
			DataValue: KstFileModel.PropertyNames.GuidFile,
            DataText: KstFileModel.PropertyNames.FileName 
			},
        label: KstUserFileModel.PropertyNames.GuidFile,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstUserFileModel.PropertyNames.IsProfileDefault,
    type: 'checkbox',

    templateOptions: {
        label: KstUserFileModel.PropertyNames.IsProfileDefault,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
}

