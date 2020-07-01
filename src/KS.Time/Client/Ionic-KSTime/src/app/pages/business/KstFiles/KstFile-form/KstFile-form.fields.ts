import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     KstFileModel, 
  
} from 'src/app/models/business/models';

export class KstFileFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstFileModel.PropertyNames.FileName,
    type: 'input',

    templateOptions: {
        label: KstFileModel.PropertyNames.FileName,
        placeholder: '',
        required: true,
		
		maxLength: 255,
    }
},
{
    key: KstFileModel.PropertyNames.FileType,
    type: 'input',

    templateOptions: {
        label: KstFileModel.PropertyNames.FileType,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstFileModel.PropertyNames.FileData,
    type: 'input',

    templateOptions: {
        label: KstFileModel.PropertyNames.FileData,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstFileModel.PropertyNames.FileStorage,
    type: 'input',

    templateOptions: {
        label: KstFileModel.PropertyNames.FileStorage,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: KstFileModel.PropertyNames.ContainerStorage,
    type: 'input',

    templateOptions: {
        label: KstFileModel.PropertyNames.ContainerStorage,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstFileModel.PropertyNames.FileThumbSizes,
    type: 'input',

    templateOptions: {
        label: KstFileModel.PropertyNames.FileThumbSizes,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstFileModel.PropertyNames.FileSize,
    type: 'input',

    templateOptions: {
        label: KstFileModel.PropertyNames.FileSize,
        placeholder: '',
        required: false,
		
        type: "number",
    }
},
	];
    }
}

