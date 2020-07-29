

 class KstProxyUserPropertyNames{
	constructor(){}
	//axd
	GuidUser:string = "GuidUser";	

				 
				 
	DisplayName:string = "DisplayName";	

				 
				 
	Username:string = "Username";	

				 
				 
	Password:string = "Password";	

				 
				 
	FirstName:string = "FirstName";	

				 
				 
	LastName:string = "LastName";	

				 
				 
	Email:string = "Email";	

				 
				 
	GuidRole:string = "GuidRole";	

				 
				 
	UpdatedDate:string = "UpdatedDate";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	CreatedDate:string = "CreatedDate";	

				 
				 
	Disabled:string = "Disabled";	

				 
				 
		FkKstProxyRole:string = "FkKstProxyRole";
		KstProxyRole:string = "KstProxyRole"; //test
				 
}

//test
export  class KstProxyUserModel{
	Id?:string;

		GuidUser:string;	

		 
	DisplayName?:string;	

		 
	Username?:string;	

		 
	Password?:string;	

		 
	FirstName?:string;	

		 
	LastName?:string;	

		 
	Email?:string;	

		 
	GuidRole?:string;	

		 
	UpdatedDate?:string;	

		 
	IsDeleted?:boolean;	

		 
	CreatedDate?:string;	

		 
	Disabled?:boolean;	

		 
		FkKstProxyRole:string ;

		FkKstProxyRoleText:any;

		KstProxyRole:string;
		
			 
		 

	public static _EntitySetName:string =  "KstProxyUsers";
	public static _EntityName:string =  "KstProxyUser";
	public static PropertyNames: KstProxyUserPropertyNames = new KstProxyUserPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidUser,DisplayName,Username,Password,FirstName,LastName,Email,GuidRole,UpdatedDate,IsDeleted,CreatedDate,Disabled";


	public get getSetName() : string {
		return KstProxyUserModel._EntitySetName;
	}
	public get getPropertyNames() : KstProxyUserPropertyNames {
		return KstProxyUserModel.PropertyNames;
	}
}


	
