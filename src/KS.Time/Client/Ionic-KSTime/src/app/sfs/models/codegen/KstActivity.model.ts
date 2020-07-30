import { FormlyFieldConfig } from '@ngx-formly/core';

import { KstProjectModel } from './KstProject.model';
	



 class KstActivityPropertyNames{
	constructor(){}
	//axd
	GuidActivity:string = "GuidActivity";	

				 
				 
	Name:string = "Name";	

				 
				 
	GuidProject:string = "GuidProject";	

				 
				 
	IsCustomByUser:string = "IsCustomByUser";	

				 
				 
	GuidCompany:string = "GuidCompany";	

				 
				 
	CreatedBy:string = "CreatedBy";	

				 
				 
	UpdatedBy:string = "UpdatedBy";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	BizKeyEngine:string = "BizKeyEngine";	

				 
				 
	CreatedDate:string = "CreatedDate";	

				 
				 
	UpdatedDate:string = "UpdatedDate";	

				 
				 
		FkKstProject:string = "FkKstProject";
		KstProject:string = "KstProject"; //test
				 
}

//test
export  class KstActivityModel{
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstActivityModel.PropertyNames.Name,
    type: 'input',

    templateOptions: {
        label: KstActivityModel.PropertyNames.Name,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstActivityModel.PropertyNames.GuidProject,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstProjectModel,  
			DataValue: KstProjectModel.PropertyNames.GuidProject,
            DataText: KstProjectModel.PropertyNames.Name 
			},
        label: KstActivityModel.PropertyNames.GuidProject,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstActivityModel.PropertyNames.IsCustomByUser,
    type: 'checkbox',

    templateOptions: {
        label: KstActivityModel.PropertyNames.IsCustomByUser,
        placeholder: '',
        required: true,
		
    }
},
	];
    }
	Id?:string;

		GuidActivity:string;	

		 
	Name?:string;	

		 
	GuidProject?:string;	

		 
	IsCustomByUser:boolean;	

		 
	GuidCompany?:string;	

		 
	CreatedBy?:string;	

		 
	UpdatedBy?:string;	

		 
	IsDeleted?:boolean;	

		 
	BizKeyEngine?:string;	

		 
	CreatedDate?:string;	

		 
	UpdatedDate?:string;	

		 
		FkKstProject:string ;

		FkKstProjectText:any;

		KstProject:string;
		
			 
		 

	public static _EntitySetName:string =  "KstActivities";
	public static _EntityName:string =  "KstActivity";
	public static PropertyNames: KstActivityPropertyNames = new KstActivityPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidActivity,Name,GuidProject,IsCustomByUser,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes";


	public get getSetName() : string {
		return KstActivityModel._EntitySetName;
	}
	public get getPropertyNames() : KstActivityPropertyNames {
		return KstActivityModel.PropertyNames;
	}
}


	
