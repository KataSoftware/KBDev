import { FormlyFieldConfig } from '@ngx-formly/core';
import { KstEmailTemplateModel } from './KstEmailTemplate';


export class KstEmailTemplateFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstEmailTemplateModel.PropertyNames.Title,
    type: 'input',

    templateOptions: {
        label: KstEmailTemplateModel.PropertyNames.Title,
        placeholder: '',
        required: true,
		
		maxLength: 255,
    }
},
{
    key: KstEmailTemplateModel.PropertyNames.TitleKey,
    type: 'input',

    templateOptions: {
        label: KstEmailTemplateModel.PropertyNames.TitleKey,
        placeholder: '',
        required: false,
		
		maxLength: 20,
    }
},
{
    key: KstEmailTemplateModel.PropertyNames.Content,
    type: 'textarea',

    templateOptions: {
        label: KstEmailTemplateModel.PropertyNames.Content,
        placeholder: '',
        required: false,
		rows: 5,
    }
},
	];
    }
}

