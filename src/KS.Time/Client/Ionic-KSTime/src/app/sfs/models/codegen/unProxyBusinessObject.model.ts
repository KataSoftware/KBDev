import { FormlyFieldConfig } from '@ngx-formly/core';

	



 class unProxyBusinessObjectPropertyNames{
	constructor(){}
	//axd
	GuidBusinessObject:string = "GuidBusinessObject";	

				 
				 
	Name:string = "Name";	

				 
				 
	BusinessObjectKey:string = "BusinessObjectKey";	

				 
				 
	EntitySetName:string = "EntitySetName";	

				 
				 
}

//test
export  class unProxyBusinessObjectModel{

    public static GetChildren(){
		let results:Array<ChildRelation> = [];
		return results;
	}
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: unProxyBusinessObjectModel.PropertyNames.Name,
    type: 'input',

    templateOptions: {
	        label: unProxyBusinessObjectModel.PropertyNames.Name,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: unProxyBusinessObjectModel.PropertyNames.BusinessObjectKey,
    type: 'input',

    templateOptions: {
	        label: unProxyBusinessObjectModel.PropertyNames.BusinessObjectKey,
        placeholder: '',
        required: false,
		
		maxLength: 100,
    }
},
{
    key: unProxyBusinessObjectModel.PropertyNames.EntitySetName,
    type: 'input',

    templateOptions: {
	        label: unProxyBusinessObjectModel.PropertyNames.EntitySetName,
        placeholder: '',
        required: false,
		
		maxLength: 100,
    }
},
	];
    }
	Id?:string;

		GuidBusinessObject:string;	

		 
	Name?:string;	

		 
	BusinessObjectKey?:string;	

		 
	EntitySetName?:string;	

		 

	public static _EntitySetName:string =  "unProxyBusinessObjects";
	public static _EntityName:string =  "unProxyBusinessObject";
	public static PropertyNames: unProxyBusinessObjectPropertyNames = new unProxyBusinessObjectPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidBusinessObject,Name,BusinessObjectKey,EntitySetName";

	public static _DefaultProperty: string= "Name";

	public get getSetName() : string {
		return unProxyBusinessObjectModel._EntitySetName;
	}
	public get getPropertyNames() : unProxyBusinessObjectPropertyNames {
		return unProxyBusinessObjectModel.PropertyNames;
	}
}


	
