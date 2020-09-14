import { FormlyFieldConfig } from '@ngx-formly/core';
import { ChildRelation } from '../common/page.model';

	



 class KstFilePropertyNames{
	constructor(){}
	//axd
	GuidFile:string = "GuidFile";	

				 
				 
	FileName:string = "FileName";	

				 
				 
	FileType:string = "FileType";	

				 
				 
	FileData:string = "FileData";	

				 
				 
	FileStorage:string = "FileStorage";	

				 
				 
	ContainerStorage:string = "ContainerStorage";	

				 
				 
	FileThumbSizes:string = "FileThumbSizes";	

				 
				 
	FileSize:string = "FileSize";	

				 
				 
	GuidCompany:string = "GuidCompany";	

				 
				 
	CreatedBy:string = "CreatedBy";	

				 
				 
	UpdatedBy:string = "UpdatedBy";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	BizKeyEngine:string = "BizKeyEngine";	

				 
				 
	CreatedDate:string = "CreatedDate";	

				 
				 
	UpdatedDate:string = "UpdatedDate";	

				 
				 
}

//test
export  class KstFileModel{

    public static GetChildren(){
		let results:Array<ChildRelation> = [];
        results.push({
            Name: "KstProjectFiles",
            FkPropertyName: "GuidFile",
            Label: "KstProjectFiles",
            EntityName: "KstProjectFile"
        });
        results.push({
            Name: "KstUserFiles",
            FkPropertyName: "GuidFile",
            Label: "KstUserFiles",
            EntityName: "KstUserFile"
        });
        results.push({
            Name: "KstWorkTimeFiles",
            FkPropertyName: "GuidFile",
            Label: "KstWorkTimeFiles",
            EntityName: "KstWorkTimeFile"
        });
		return results;
	}
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstFileModel.PropertyNames.FileName,
    type: 'input',

    templateOptions: {
	
        label: KstFileModel.PropertyNames.FileName,
        placeholder: '',
        required: true,
		
		maxLength: 255,
    }
},
{
    key: KstFileModel.PropertyNames.FileType,
    type: 'input',

    templateOptions: {
	
        label: KstFileModel.PropertyNames.FileType,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstFileModel.PropertyNames.FileData,
    type: 'input',

    templateOptions: {
	
        label: KstFileModel.PropertyNames.FileData,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstFileModel.PropertyNames.FileStorage,
    type: 'input',

    templateOptions: {
	
        label: KstFileModel.PropertyNames.FileStorage,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: KstFileModel.PropertyNames.ContainerStorage,
    type: 'input',

    templateOptions: {
	
        label: KstFileModel.PropertyNames.ContainerStorage,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstFileModel.PropertyNames.FileThumbSizes,
    type: 'input',

    templateOptions: {
	
        label: KstFileModel.PropertyNames.FileThumbSizes,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstFileModel.PropertyNames.FileSize,
    type: 'input',

    templateOptions: {
	
        label: KstFileModel.PropertyNames.FileSize,
        placeholder: '',
        required: false,
		
        type: "number",
    }
},
	];
    }
	Id?:string;

		GuidFile:string;	

		 
	FileName:string;	

		 
	FileType?:string;	

		 
	FileData?:string;	

		 
	FileStorage?:string;	

		 
	ContainerStorage?:string;	

		 
	FileThumbSizes?:string;	

		 
	FileSize?:number;	

		 
	GuidCompany?:string;	

		 
	CreatedBy?:string;	

		 
	UpdatedBy?:string;	

		 
	IsDeleted?:boolean = false;	

		 
	BizKeyEngine?:string;	

		 
	CreatedDate?:string;	

		 
	UpdatedDate?:string;	

		 

	public static _EntitySetName:string =  "KstFiles";
	public static _EntityName:string =  "KstFile";
	public static PropertyNames: KstFilePropertyNames = new KstFilePropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidFile,FileName,FileType,FileData,FileStorage,ContainerStorage,FileThumbSizes,FileSize,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes";

	public static _DefaultProperty: string= "FileName";

	public get getSetName() : string {
		return KstFileModel._EntitySetName;
	}
	public get getPropertyNames() : KstFilePropertyNames {
		return KstFileModel.PropertyNames;
	}
}


	
