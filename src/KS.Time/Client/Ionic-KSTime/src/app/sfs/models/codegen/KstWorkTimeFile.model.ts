import { FormlyFieldConfig } from '@ngx-formly/core';

import { KstFileModel } from './KstFile.model';
import { KstWorkTimeModel } from './KstWorkTime.model';
	



 class KstWorkTimeFilePropertyNames{
	constructor(){}
	//axd
	GuidWorkTimeFile:string = "GuidWorkTimeFile";	

				 
				 
	GuidWorkTime:string = "GuidWorkTime";	

				 
				 
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
				 
		FkKstWorkTime:string = "FkKstWorkTime";
		KstWorkTime:string = "KstWorkTime"; //test
				 
}

//test
export  class KstWorkTimeFileModel{
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstWorkTimeFileModel.PropertyNames.GuidWorkTime,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstWorkTimeModel,  
			DataValue: KstWorkTimeModel.PropertyNames.GuidWorkTime,
            DataText: KstWorkTimeModel.PropertyNames.Title 
			},
        label: KstWorkTimeFileModel.PropertyNames.GuidWorkTime,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstWorkTimeFileModel.PropertyNames.GuidFile,
    type: 'select',

    templateOptions: {
	  "relation": {   
			EntityModel: KstFileModel,  
			DataValue: KstFileModel.PropertyNames.GuidFile,
            DataText: KstFileModel.PropertyNames.FileName 
			},
        label: KstWorkTimeFileModel.PropertyNames.GuidFile,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
	Id?:string;

		GuidWorkTimeFile:string;	

		 
	GuidWorkTime?:string;	

		 
	GuidFile?:string;	

		 
	GuidCompany?:string;	

		 
	CreatedBy?:string;	

		 
	UpdatedBy?:string;	

		 
	IsDeleted?:boolean;	

		 
	BizKeyEngine?:string;	

		 
	CreatedDate?:string;	

		 
	UpdatedDate?:string;	

		 
		FkKstFile:string ;

		FkKstFileText:any;

		KstFile:string;
		
			 
		 
		FkKstWorkTime:string ;

		FkKstWorkTimeText:any;

		KstWorkTime:string;
		
			 
		 

	public static _EntitySetName:string =  "KstWorkTimeFiles";
	public static _EntityName:string =  "KstWorkTimeFile";
	public static PropertyNames: KstWorkTimeFilePropertyNames = new KstWorkTimeFilePropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidWorkTimeFile,GuidWorkTime,GuidFile,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes";


	public get getSetName() : string {
		return KstWorkTimeFileModel._EntitySetName;
	}
	public get getPropertyNames() : KstWorkTimeFilePropertyNames {
		return KstWorkTimeFileModel.PropertyNames;
	}
}


	
