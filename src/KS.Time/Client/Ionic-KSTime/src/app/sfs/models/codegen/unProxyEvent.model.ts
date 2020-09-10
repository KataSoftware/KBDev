import { FormlyFieldConfig } from '@ngx-formly/core';

	



 class unProxyEventPropertyNames{
	constructor(){}
	//axd
	GuidUnProxyEvent:string = "GuidUnProxyEvent";	

				 
				 
	Title:string = "Title";	

				 
				 
	Message:string = "Message";	

				 
				 
	TypeEvent:string = "TypeEvent";	

				 
				 
	IsException:string = "IsException";	

				 
				 
	UpdatedDate:string = "UpdatedDate";	

				 
				 
}

//test
export  class unProxyEventModel{

    public static GetChildren(){
		let results:Array<ChildRelation> = [];
		return results;
	}
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: unProxyEventModel.PropertyNames.Title,
    type: 'input',

    templateOptions: {
	        label: unProxyEventModel.PropertyNames.Title,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: unProxyEventModel.PropertyNames.Message,
    type: 'input',

    templateOptions: {
	        label: unProxyEventModel.PropertyNames.Message,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: unProxyEventModel.PropertyNames.TypeEvent,
    type: 'textarea',

    templateOptions: {
	        label: unProxyEventModel.PropertyNames.TypeEvent,
        placeholder: '',
        required: false,
		rows: 5,
    }
},
{
    key: unProxyEventModel.PropertyNames.IsException,
    type: 'checkbox',

    templateOptions: {
	 
	indeterminate: false,
        label: unProxyEventModel.PropertyNames.IsException,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
	Id?:string;

		GuidUnProxyEvent:string;	

		 
	Title?:string;	

		 
	Message?:string;	

		 
	TypeEvent?:string;	

		 
	IsException?:boolean = false;	

		 
	UpdatedDate?:string;	

		 

	public static _EntitySetName:string =  "unProxyEvents";
	public static _EntityName:string =  "unProxyEvent";
	public static PropertyNames: unProxyEventPropertyNames = new unProxyEventPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidUnProxyEvent,Title,Message,TypeEvent,IsException,UpdatedDate";

	public static _DefaultProperty: string= "Title";

	public get getSetName() : string {
		return unProxyEventModel._EntitySetName;
	}
	public get getPropertyNames() : unProxyEventPropertyNames {
		return unProxyEventModel.PropertyNames;
	}
}


	
