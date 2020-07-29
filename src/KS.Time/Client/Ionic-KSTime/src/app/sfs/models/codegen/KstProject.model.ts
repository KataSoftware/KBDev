

 class KstProjectPropertyNames{
	constructor(){}
	//axd
	GuidProject:string = "GuidProject";	

				 
				 
	Name:string = "Name";	

				 
				 
	GuidCompany:string = "GuidCompany";	

				 
				 
	CreatedBy:string = "CreatedBy";	

				 
				 
	UpdatedBy:string = "UpdatedBy";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	BizKeyEngine:string = "BizKeyEngine";	

				 
				 
	CreatedDate:string = "CreatedDate";	

				 
				 
	UpdatedDate:string = "UpdatedDate";	

				 
				 
	NumActivities:string = "NumActivities";	

				 
				 
	NumUsers:string = "NumUsers";	

				 
				 
}

//test
export  class KstProjectModel{
	Id?:string;

		GuidProject:string;	

		 
	Name:string;	

		 
	GuidCompany?:string;	

		 
	CreatedBy?:string;	

		 
	UpdatedBy?:string;	

		 
	IsDeleted?:boolean;	

		 
	BizKeyEngine?:string;	

		 
	CreatedDate?:string;	

		 
	UpdatedDate?:string;	

		 
	NumActivities?:number;	

		 
	NumUsers?:number;	

		 

	public static _EntitySetName:string =  "KstProjects";
	public static _EntityName:string =  "KstProject";
	public static PropertyNames: KstProjectPropertyNames = new KstProjectPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidProject,Name,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes,NumActivities,NumUsers";


	public get getSetName() : string {
		return KstProjectModel._EntitySetName;
	}
	public get getPropertyNames() : KstProjectPropertyNames {
		return KstProjectModel.PropertyNames;
	}
}


	
