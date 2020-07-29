

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


	
