import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     KstProxyGeoStateModel, 
	KstProxyGeoCountryModel,
  
} from 'src/app/models/business/models';

export class KstProxyGeoStateFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstProxyGeoStateModel.PropertyNames.Name,
    type: 'input',

    templateOptions: {
        label: KstProxyGeoStateModel.PropertyNames.Name,
        placeholder: '',
        required: true,
		
		maxLength: 255,
    }
},
{
    key: KstProxyGeoStateModel.PropertyNames.GuidCountry,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstProxyGeoCountryModel,  
			DataValue: KstProxyGeoCountryModel.PropertyNames.GuidCountry,
            DataText: KstProxyGeoCountryModel.PropertyNames.Name 
			},
        label: KstProxyGeoStateModel.PropertyNames.GuidCountry,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
}

