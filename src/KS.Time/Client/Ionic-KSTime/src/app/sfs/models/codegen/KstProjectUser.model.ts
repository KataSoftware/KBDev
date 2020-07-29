

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


	
