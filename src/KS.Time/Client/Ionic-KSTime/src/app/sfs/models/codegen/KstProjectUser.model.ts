import { FormlyFieldConfig } from '@ngx-formly/core';

import { KstProjectModel } from './KstProject.model';
import { KstProxyUserModel } from './KstProxyUser.model';
	



 class KstProjectUserPropertyNames{
	constructor(){}
	//axd
	GuidProjectUser:string = "GuidProjectUser";	

				 
				 
	GuidProject:string = "GuidProject";	

				 
				 
	GuidUser:string = "GuidUser";	

				 
				 
	StartDate:string = "StartDate";	

				 
				 
	EndDate:string = "EndDate";	

				 
				 
	GuidCompany:string = "GuidCompany";	

				 
				 
	CreatedBy:string = "CreatedBy";	

				 
				 
	UpdatedBy:string = "UpdatedBy";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	BizKeyEngine:string = "BizKeyEngine";	

				 
				 
	CreatedDate:string = "CreatedDate";	

				 
				 
	UpdatedDate:string = "UpdatedDate";	

				 
				 
		FkKstProject:string = "FkKstProject";
		KstProject:string = "KstProject"; //test
				 
		FkKstProxyUser:string = "FkKstProxyUser";
		KstProxyUser:string = "KstProxyUser"; //test
				 
}

//test
export  class KstProjectUserModel{
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstProjectUserModel.PropertyNames.GuidProject,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstProjectModel,  
			DataValue: KstProjectModel.PropertyNames.GuidProject,
            DataText: KstProjectModel.PropertyNames.Name 
			},
        label: KstProjectUserModel.PropertyNames.GuidProject,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstProjectUserModel.PropertyNames.GuidUser,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstProxyUserModel,  
			DataValue: KstProxyUserModel.PropertyNames.GuidUser,
            DataText: KstProxyUserModel.PropertyNames.DisplayName 
			},
        label: KstProjectUserModel.PropertyNames.GuidUser,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstProjectUserModel.PropertyNames.StartDate,
    type: 'datepicker',

    templateOptions: {
        label: KstProjectUserModel.PropertyNames.StartDate,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstProjectUserModel.PropertyNames.EndDate,
    type: 'datepicker',

    templateOptions: {
        label: KstProjectUserModel.PropertyNames.EndDate,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
	Id?:string;

		GuidProjectUser:string;	

		 
	GuidProject?:string;	

		 
	GuidUser?:string;	

		 
	StartDate?:string;	

		 
	EndDate?:string;	

		 
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
		
			 
		 
		FkKstProxyUser:string ;

		FkKstProxyUserText:any;

		KstProxyUser:string;
		
			 
		 

	public static _EntitySetName:string =  "KstProjectUsers";
	public static _EntityName:string =  "KstProjectUser";
	public static PropertyNames: KstProjectUserPropertyNames = new KstProjectUserPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidProjectUser,GuidProject,GuidUser,StartDate,EndDate,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes";


	public get getSetName() : string {
		return KstProjectUserModel._EntitySetName;
	}
	public get getPropertyNames() : KstProjectUserPropertyNames {
		return KstProjectUserModel.PropertyNames;
	}
}


	
