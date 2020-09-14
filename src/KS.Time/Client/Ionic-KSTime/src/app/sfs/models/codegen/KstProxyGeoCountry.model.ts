﻿import { FormlyFieldConfig } from '@ngx-formly/core';
import { ChildRelation } from '../common/page.model';

	



 class KstProxyGeoCountryPropertyNames{
	constructor(){}
	//axd
	GuidCountry:string = "GuidCountry";	

				 
				 
	Name:string = "Name";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
}

//test
export  class KstProxyGeoCountryModel{

    public static GetChildren(){
		let results:Array<ChildRelation> = [];
        results.push({
            Name: "KstProxyGeoStates",
            FkPropertyName: "GuidCountry",
            Label: "KstProxyGeoStates",
            EntityName: "KstProxyGeoState"
        });
		return results;
	}
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
	Id?:string;

		GuidCountry:string;	

		 
	Name:string;	

		 
	IsDeleted?:boolean = false;	

		 

	public static _EntitySetName:string =  "KstProxyGeoCountries";
	public static _EntityName:string =  "KstProxyGeoCountry";
	public static PropertyNames: KstProxyGeoCountryPropertyNames = new KstProxyGeoCountryPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidCountry,Name,IsDeleted";

	public static _DefaultProperty: string= "Name";

	public get getSetName() : string {
		return KstProxyGeoCountryModel._EntitySetName;
	}
	public get getPropertyNames() : KstProxyGeoCountryPropertyNames {
		return KstProxyGeoCountryModel.PropertyNames;
	}
}


	
