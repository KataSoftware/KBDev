

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
	Id?:string;

		GuidUserFile:string;	

		 
	GuidUser?:string;	

		 
	GuidFile?:string;	

		 
	IsProfileDefault?:boolean;	

		 
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
		
			 
		 
		FkKstProxyUser:string ;

		FkKstProxyUserText:any;

		KstProxyUser:string;
		
			 
		 

	public static _EntitySetName:string =  "KstUserFiles";
	public static _EntityName:string =  "KstUserFile";
	public static PropertyNames: KstUserFilePropertyNames = new KstUserFilePropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidUserFile,GuidUser,GuidFile,IsProfileDefault,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes";


	public get getSetName() : string {
		return KstUserFileModel._EntitySetName;
	}
	public get getPropertyNames() : KstUserFilePropertyNames {
		return KstUserFileModel.PropertyNames;
	}
}


	
