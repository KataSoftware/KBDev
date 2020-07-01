import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     KstWorkTimeFileModel, 
	KstFileModel,
	KstWorkTimeModel,
  
} from 'src/app/models/business/models';

export class KstWorkTimeFileFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstWorkTimeFileModel.PropertyNames.GuidWorkTime,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstWorkTimeModel,  
			DataValue: KstWorkTimeModel.PropertyNames.GuidWorkTime,
            DataText: KstWorkTimeModel.PropertyNames.Title 
			},
        label: KstWorkTimeFileModel.PropertyNames.GuidWorkTime,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstWorkTimeFileModel.PropertyNames.GuidFile,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstFileModel,  
			DataValue: KstFileModel.PropertyNames.GuidFile,
            DataText: KstFileModel.PropertyNames.FileName 
			},
        label: KstWorkTimeFileModel.PropertyNames.GuidFile,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
}

