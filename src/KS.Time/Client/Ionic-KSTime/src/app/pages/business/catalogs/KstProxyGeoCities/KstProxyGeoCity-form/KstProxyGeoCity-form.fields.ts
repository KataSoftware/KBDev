import { FormlyFieldConfig } from '@ngx-formly/core';
import { 
     KstProxyGeoCityModel, 
	KstProxyGeoStateModel,
  
} from 'src/app/models/business/models';

export class KstProxyGeoCityFormFields {
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstProxyGeoCityModel.PropertyNames.Name,
    type: 'input',

    templateOptions: {
        label: KstProxyGeoCityModel.PropertyNames.Name,
        placeholder: '',
        required: true,
		
		maxLength: 255,
    }
},
{
    key: KstProxyGeoCityModel.PropertyNames.GuidState,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstProxyGeoStateModel,  
			DataValue: KstProxyGeoStateModel.PropertyNames.GuidState,
            DataText: KstProxyGeoStateModel.PropertyNames.Name 
			},
        label: KstProxyGeoCityModel.PropertyNames.GuidState,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstProxyGeoCityModel.PropertyNames.GuidParent,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstProxyGeoCityModel,  
			DataValue: KstProxyGeoCityModel.PropertyNames.GuidCity,
            DataText: KstProxyGeoCityModel.PropertyNames.Name 
			},
        label: KstProxyGeoCityModel.PropertyNames.GuidParent,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
}

