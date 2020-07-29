

 class KstWorkTimePropertyNames{
	constructor(){}
	//axd
	GuidWorkTime:string = "GuidWorkTime";	

				 
				 
	Title:string = "Title";	

				 
				 
	Comments:string = "Comments";	

				 
				 
	Hours:string = "Hours";	

				 
				 
	GuidProject:string = "GuidProject";	

				 
				 
	GuidActivity:string = "GuidActivity";	

				 
				 
	GuidCompany:string = "GuidCompany";	

				 
				 
	CreatedBy:string = "CreatedBy";	

				 
				 
	UpdatedBy:string = "UpdatedBy";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	BizKeyEngine:string = "BizKeyEngine";	

				 
				 
	CreatedDate:string = "CreatedDate";	

				 
				 
	UpdatedDate:string = "UpdatedDate";	

				 
				 
		FkKstActivity:string = "FkKstActivity";
		KstActivity:string = "KstActivity"; //test
				 
		FkKstProject:string = "FkKstProject";
		KstProject:string = "KstProject"; //test
				 
}

//test
export  class KstWorkTimeModel{
	Id?:string;

		GuidWorkTime:string;	

		 
	Title?:string;	

		 
	Comments?:string;	

		 
	Hours?:number;	

		 
	GuidProject?:string;	

		 
	GuidActivity?:string;	

		 
	GuidCompany?:string;	

		 
	CreatedBy?:string;	

		 
	UpdatedBy?:string;	

		 
	IsDeleted?:boolean;	

		 
	BizKeyEngine?:string;	

		 
	CreatedDate?:string;	

		 
	UpdatedDate?:string;	

		 
		FkKstActivity:string ;

		FkKstActivityText:any;

		KstActivity:string;
		
			 
		 
		FkKstProject:string ;

		FkKstProjectText:any;

		KstProject:string;
		
			 
		 

	public static _EntitySetName:string =  "KstWorkTimes";
	public static _EntityName:string =  "KstWorkTime";
	public static PropertyNames: KstWorkTimePropertyNames = new KstWorkTimePropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidWorkTime,Title,Comments,Hours,GuidProject,GuidActivity,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes";


	public get getSetName() : string {
		return KstWorkTimeModel._EntitySetName;
	}
	public get getPropertyNames() : KstWorkTimePropertyNames {
		return KstWorkTimeModel.PropertyNames;
	}
}


	
