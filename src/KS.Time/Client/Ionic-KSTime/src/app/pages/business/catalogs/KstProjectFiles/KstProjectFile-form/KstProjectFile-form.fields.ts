import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     KstProjectFileModel, 
	KstFileModel,
	KstProjectModel,
  
} from 'src/app/models/business/models';

export class KstProjectFileFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstProjectFileModel.PropertyNames.GuidProject,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstProjectModel,  
			DataValue: KstProjectModel.PropertyNames.GuidProject,
            DataText: KstProjectModel.PropertyNames.Name 
			},
        label: KstProjectFileModel.PropertyNames.GuidProject,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstProjectFileModel.PropertyNames.GuidFile,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstFileModel,  
			DataValue: KstFileModel.PropertyNames.GuidFile,
            DataText: KstFileModel.PropertyNames.FileName 
			},
        label: KstProjectFileModel.PropertyNames.GuidFile,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
}

