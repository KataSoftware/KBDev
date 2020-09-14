import { FormlyFieldConfig } from '@ngx-formly/core';
import { ChildRelation } from '../common/page.model';

import { KstFileModel } from './KstFile.model';
import { KstProxyUserModel } from './KstProxyUser.model';
	



 class KstUserFilePropertyNames{
	constructor(){}
	//axd
	GuidUserFile:string = "GuidUserFile";	

				 
				 
	GuidUser:string = "GuidUser";	

				 
				 
	GuidFile:string = "GuidFile";	

				 
				 
	IsProfileDefault:string = "IsProfileDefault";	

				 
				 
	GuidCompany:string = "GuidCompany";	

				 
				 
	CreatedBy:string = "CreatedBy";	

				 
				 
	UpdatedBy:string = "UpdatedBy";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	BizKeyEngine:string = "BizKeyEngine";	

				 
				 
	CreatedDate:string = "CreatedDate";	

				 
				 
	UpdatedDate:string = "UpdatedDate";	

				 
				 
		FkKstFile:string = "FkKstFile";
		KstFile:string = "KstFile"; //test
				 
		FkKstProxyUser:string = "FkKstProxyUser";
		KstProxyUser:string = "KstProxyUser"; //test
				 
}

//test
export  class KstUserFileModel{

    public static GetChildren(){
		let results:Array<ChildRelation> = [];
		return results;
	}
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstUserFileModel.PropertyNames.GuidUser,
    type: 'select',

    templateOptions: {
		"parents": "GuidRole:KstProxyRole.GuidRole",	
	  //"parents": "GuidProject:KstProject.GuidProject;GuidActivityType:KstActivityType.GuidActivityType",
	
	  "relation": {
			PropertyRelationName: "KstProxyUser",
			EntityModel: KstProxyUserModel,  
			DataValue: KstProxyUserModel.PropertyNames.GuidUser,
            DataText: KstProxyUserModel.PropertyNames.DisplayName 
			},

        label: KstUserFileModel.PropertyNames.GuidUser,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstUserFileModel.PropertyNames.GuidFile,
    type: 'select',

    templateOptions: {
		
	  "relation": {
			PropertyRelationName: "KstFile",
			EntityModel: KstFileModel,  
			DataValue: KstFileModel.PropertyNames.GuidFile,
            DataText: KstFileModel.PropertyNames.FileName 
			},

        label: KstUserFileModel.PropertyNames.GuidFile,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstUserFileModel.PropertyNames.IsProfileDefault,
    type: 'checkbox',

    templateOptions: {
	 
	indeterminate: false,

        label: KstUserFileModel.PropertyNames.IsProfileDefault,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
	Id?:string;

		GuidUserFile:string;	

		 
	GuidUser?:string;	

		 
	GuidFile?:string;	

		 
	IsProfileDefault?:boolean = false;	

		 
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
		
			 
		 
		FkKstProxyUser:string ;

		FkKstProxyUserText:any;

		KstProxyUser:string;
		
			 
		 

	public static _EntitySetName:string =  "KstUserFiles";
	public static _EntityName:string =  "KstUserFile";
	public static PropertyNames: KstUserFilePropertyNames = new KstUserFilePropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidUserFile,GuidUser,GuidFile,IsProfileDefault,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes";

	public static _DefaultProperty: string= "BizKeyEngine";

	public get getSetName() : string {
		return KstUserFileModel._EntitySetName;
	}
	public get getPropertyNames() : KstUserFilePropertyNames {
		return KstUserFileModel.PropertyNames;
	}
}


	
