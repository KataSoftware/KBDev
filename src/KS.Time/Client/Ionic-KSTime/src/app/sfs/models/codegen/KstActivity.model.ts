﻿

 class KstActivityPropertyNames{
	constructor(){}
	//axd
	GuidActivity:string = "GuidActivity";	

				 
				 
	Name:string = "Name";	

				 
				 
	GuidProject:string = "GuidProject";	

				 
				 
	IsCustomByUser:string = "IsCustomByUser";	

				 
				 
	GuidCompany:string = "GuidCompany";	

				 
				 
	CreatedBy:string = "CreatedBy";	

				 
				 
	UpdatedBy:string = "UpdatedBy";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	BizKeyEngine:string = "BizKeyEngine";	

				 
				 
	CreatedDate:string = "CreatedDate";	

				 
				 
	UpdatedDate:string = "UpdatedDate";	

				 
				 
		FkKstProject:string = "FkKstProject";
		KstProject:string = "KstProject"; //test
				 
}

//test
export  class KstActivityModel{
	Id?:string;

		GuidActivity:string;	

		 
	Name?:string;	

		 
	GuidProject?:string;	

		 
	IsCustomByUser:boolean;	

		 
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
		
			 
		 

	public static _EntitySetName:string =  "KstActivities";
	public static _EntityName:string =  "KstActivity";
	public static PropertyNames: KstActivityPropertyNames = new KstActivityPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidActivity,Name,GuidProject,IsCustomByUser,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes";


	public get getSetName() : string {
		return KstActivityModel._EntitySetName;
	}
	public get getPropertyNames() : KstActivityPropertyNames {
		return KstActivityModel.PropertyNames;
	}
}


	
