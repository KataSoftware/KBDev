

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

		 
	IsDeleted?:boolean;	

		 
	BizKeyEngine?:string;	

		 
	CreatedDate?:string;	

		 
	UpdatedDate?:string;	

		 

	public static _EntitySetName:string =  "KstFiles";
	public static _EntityName:string =  "KstFile";
	public static PropertyNames: KstFilePropertyNames = new KstFilePropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidFile,FileName,FileType,FileData,FileStorage,ContainerStorage,FileThumbSizes,FileSize,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes";


	public get getSetName() : string {
		return KstFileModel._EntitySetName;
	}
	public get getPropertyNames() : KstFilePropertyNames {
		return KstFileModel.PropertyNames;
	}
}


	
