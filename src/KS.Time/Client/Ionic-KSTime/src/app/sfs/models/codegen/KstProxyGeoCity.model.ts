﻿import { FormlyFieldConfig } from '@ngx-formly/core';

import { KstProxyGeoStateModel } from './KstProxyGeoState.model';
	



 class KstProxyGeoCityPropertyNames{
	constructor(){}
	//axd
	GuidCity:string = "GuidCity";	

				 
				 
	Name:string = "Name";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	GuidState:string = "GuidState";	

				 
				 
	GuidParent:string = "GuidParent";	

				 
				 
		FkKstProxyGeoCity2:string = "FkKstProxyGeoCity2";
		KstProxyGeoCity2:string = "KstProxyGeoCity2"; //test
				 
		FkKstProxyGeoState:string = "FkKstProxyGeoState";
		KstProxyGeoState:string = "KstProxyGeoState"; //test
				 
}

//test
export  class KstProxyGeoCityModel{
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
			PropertyRelationName: "KstProxyGeoState",
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
			PropertyRelationName: "KstProxyGeoCity2",
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
	Id?:string;

		GuidCity:string;	

		 
	Name:string;	

		 
	IsDeleted?:boolean;	

		 
	GuidState?:string;	

		 
	GuidParent?:string;	

		 
		FkKstProxyGeoCity2:string ;

		FkKstProxyGeoCity2Text:any;

		KstProxyGeoCity2:string;
		
			 
		 
		FkKstProxyGeoState:string ;

		FkKstProxyGeoStateText:any;

		KstProxyGeoState:string;
		
			 
		 

	public static _EntitySetName:string =  "KstProxyGeoCities";
	public static _EntityName:string =  "KstProxyGeoCity";
	public static PropertyNames: KstProxyGeoCityPropertyNames = new KstProxyGeoCityPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidCity,Name,IsDeleted,GuidState,GuidParent";


	public get getSetName() : string {
		return KstProxyGeoCityModel._EntitySetName;
	}
	public get getPropertyNames() : KstProxyGeoCityPropertyNames {
		return KstProxyGeoCityModel.PropertyNames;
	}
}


	
