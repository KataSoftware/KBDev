import { FormlyFieldConfig } from '@ngx-formly/core';

import { KstFileModel } from './KstFile.model';
import { KstProjectModel } from './KstProject.model';
	



 class KstProjectFilePropertyNames{
	constructor(){}
	//axd
	GuidProjectFile:string = "GuidProjectFile";	

				 
				 
	GuidProject:string = "GuidProject";	

				 
				 
	GuidFile:string = "GuidFile";	

				 
				 
	GuidCompany:string = "GuidCompany";	

				 
				 
	CreatedBy:string = "CreatedBy";	

				 
				 
	UpdatedBy:string = "UpdatedBy";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	BizKeyEngine:string = "BizKeyEngine";	

				 
				 
	CreatedDate:string = "CreatedDate";	

				 
				 
	UpdatedDate:string = "UpdatedDate";	

				 
				 
		FkKstFile:string = "FkKstFile";
		KstFile:string = "KstFile"; //test
				 
		FkKstProject:string = "FkKstProject";
		KstProject:string = "KstProject"; //test
				 
}

//test
export  class KstProjectFileModel{
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstProjectFileModel.PropertyNames.GuidProject,
    type: 'select',

    templateOptions: {
		  "relation": {
			PropertyRelationName: "KstProject",
			EntityModel: KstProjectModel,  
			DataValue: KstProjectModel.PropertyNames.GuidProject,
            DataText: KstProjectModel.PropertyNames.Name 
			},
        label: KstProjectFileModel.PropertyNames.GuidProject,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstProjectFileModel.PropertyNames.GuidFile,
    type: 'select',

    templateOptions: {
		  "relation": {
			PropertyRelationName: "KstFile",
			EntityModel: KstFileModel,  
			DataValue: KstFileModel.PropertyNames.GuidFile,
            DataText: KstFileModel.PropertyNames.FileName 
			},
        label: KstProjectFileModel.PropertyNames.GuidFile,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
	Id?:string;

		GuidProjectFile:string;	

		 
	GuidProject?:string;	

		 
	GuidFile?:string;	

		 
	GuidCompany?:string;	

		 
	CreatedBy?:string;	

		 
	UpdatedBy?:string;	

		 
	IsDeleted?:boolean = false;	

		 
	BizKeyEngine?:string;	

		 
	CreatedDate?:string;	

		 
	UpdatedDate?:string;	

		 
		FkKstFile:string ;

		FkKstFileText:any;

		KstFile:string;
		
			 
		 
		FkKstProject:string ;

		FkKstProjectText:any;

		KstProject:string;
		
			 
		 

	public static _EntitySetName:string =  "KstProjectFiles";
	public static _EntityName:string =  "KstProjectFile";
	public static PropertyNames: KstProjectFilePropertyNames = new KstProjectFilePropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidProjectFile,GuidProject,GuidFile,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes";


	public get getSetName() : string {
		return KstProjectFileModel._EntitySetName;
	}
	public get getPropertyNames() : KstProjectFilePropertyNames {
		return KstProjectFileModel.PropertyNames;
	}
}


	
