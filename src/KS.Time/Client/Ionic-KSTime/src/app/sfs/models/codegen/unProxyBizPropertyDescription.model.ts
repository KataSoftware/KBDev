import { FormlyFieldConfig } from '@ngx-formly/core';
import { ChildRelation } from '../common/page.model';

	



 class unProxyBizPropertyDescriptionPropertyNames{
	constructor(){}
	//axd
	GuidBizPropertyDescription:string = "GuidBizPropertyDescription";	

				 
				 
	Name:string = "Name";	

				 
				 
}

//test
export  class unProxyBizPropertyDescriptionModel{

    public static GetChildren(){
		let results:Array<ChildRelation> = [];
		return results;
	}
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: unProxyBizPropertyDescriptionModel.PropertyNames.Name,
    type: 'input',

    templateOptions: {
	
        label: unProxyBizPropertyDescriptionModel.PropertyNames.Name,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
	];
    }
	Id?:string;

		GuidBizPropertyDescription:string;	

		 
	Name?:string;	

		 

	public static _EntitySetName:string =  "unProxyBizPRopertyDescriptions";
	public static _EntityName:string =  "unProxyBizPropertyDescription";
	public static PropertyNames: unProxyBizPropertyDescriptionPropertyNames = new unProxyBizPropertyDescriptionPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidBizPropertyDescription,Name";

	public static _DefaultProperty: string= "Name";

	public get getSetName() : string {
		return unProxyBizPropertyDescriptionModel._EntitySetName;
	}
	public get getPropertyNames() : unProxyBizPropertyDescriptionPropertyNames {
		return unProxyBizPropertyDescriptionModel.PropertyNames;
	}
}


	
