import { FormlyFieldConfig } from '@ngx-formly/core';

import { KstProxyGeoCountryModel } from './KstProxyGeoCountry.model';
	



 class KstProxyGeoStatePropertyNames{
	constructor(){}
	//axd
	GuidState:string = "GuidState";	

				 
				 
	Name:string = "Name";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	GuidCountry:string = "GuidCountry";	

				 
				 
		FkKstProxyGeoCountry:string = "FkKstProxyGeoCountry";
		KstProxyGeoCountry:string = "KstProxyGeoCountry"; //test
				 
}

//test
export  class KstProxyGeoStateModel{
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
			PropertyRelationName: "KstProxyGeoCountry",
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
	Id?:string;

		GuidState:string;	

		 
	Name:string;	

		 
	IsDeleted?:boolean = false;	

		 
	GuidCountry?:string;	

		 
		FkKstProxyGeoCountry:string ;

		FkKstProxyGeoCountryText:any;

		KstProxyGeoCountry:string;
		
			 
		 

	public static _EntitySetName:string =  "KstProxyGeoStates";
	public static _EntityName:string =  "KstProxyGeoState";
	public static PropertyNames: KstProxyGeoStatePropertyNames = new KstProxyGeoStatePropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidState,Name,IsDeleted,GuidCountry";


	public get getSetName() : string {
		return KstProxyGeoStateModel._EntitySetName;
	}
	public get getPropertyNames() : KstProxyGeoStatePropertyNames {
		return KstProxyGeoStateModel.PropertyNames;
	}
}


	
