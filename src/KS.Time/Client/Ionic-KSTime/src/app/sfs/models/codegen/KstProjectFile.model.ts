

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
	Id?:string;

		GuidProjectFile:string;	

		 
	GuidProject?:string;	

		 
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


	
