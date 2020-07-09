import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     KstProxyGeoCountryModel, 
  
} from 'src/app/models/business/models';

export class KstProxyGeoCountryFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstProxyGeoCountryModel.PropertyNames.Name,
    type: 'input',

    templateOptions: {
        label: KstProxyGeoCountryModel.PropertyNames.Name,
        placeholder: '',
        required: true,
		
		maxLength: 255,
    }
},
	];
    }
}

