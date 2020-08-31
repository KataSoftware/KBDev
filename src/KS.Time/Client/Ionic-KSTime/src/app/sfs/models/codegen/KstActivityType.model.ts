import { FormlyFieldConfig } from '@ngx-formly/core';

	



 class KstActivityTypePropertyNames{
	constructor(){}
	//axd
	GuidActivityType:string = "GuidActivityType";	

				 
				 
	Name:string = "Name";	

				 
				 
	GuidCompany:string = "GuidCompany";	

				 
				 
	CreatedBy:string = "CreatedBy";	

				 
				 
	UpdatedBy:string = "UpdatedBy";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	BizKeyEngine:string = "BizKeyEngine";	

				 
				 
	CreatedDate:string = "CreatedDate";	

				 
				 
	UpdatedDate:string = "UpdatedDate";	

				 
				 
}

//test
export  class KstActivityTypeModel{
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstActivityTypeModel.PropertyNames.Name,
    type: 'input',

    templateOptions: {
	        label: KstActivityTypeModel.PropertyNames.Name,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
	];
    }
	Id?:string;

		GuidActivityType:string;	

		 
	Name?:string;	

		 
	GuidCompany?:string;	

		 
	CreatedBy?:string;	

		 
	UpdatedBy?:string;	

		 
	IsDeleted?:boolean = false;	

		 
	BizKeyEngine?:string;	

		 
	CreatedDate?:string;	

		 
	UpdatedDate?:string;	

		 

	public static _EntitySetName:string =  "KstActivityTypes";
	public static _EntityName:string =  "KstActivityType";
	public static PropertyNames: KstActivityTypePropertyNames = new KstActivityTypePropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidActivityType,Name,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes";

	public static _DefaultProperty: string= "Name";

	public get getSetName() : string {
		return KstActivityTypeModel._EntitySetName;
	}
	public get getPropertyNames() : KstActivityTypePropertyNames {
		return KstActivityTypeModel.PropertyNames;
	}
}


	
