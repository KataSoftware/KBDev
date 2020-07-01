

 class KstEmailTemplatePropertyNames{
	constructor(){}
	//axd
	GuidEmailTemplate:string = "GuidEmailTemplate";	

				 
				 
	Title:string = "Title";	

				 
				 
	TitleKey:string = "TitleKey";	

				 
				 
	Content:string = "Content";	

				 
				 
	GuidCompany:string = "GuidCompany";	

				 
				 
	CreatedBy:string = "CreatedBy";	

				 
				 
	UpdatedBy:string = "UpdatedBy";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	BizKeyEngine:string = "BizKeyEngine";	

				 
				 
	CreatedDate:string = "CreatedDate";	

				 
				 
	UpdatedDate:string = "UpdatedDate";	

				 
				 
}

//test
export  class KstEmailTemplateModel{
	Id?:string;

		GuidEmailTemplate:string;	

		 
	Title:string;	

		 
	TitleKey?:string;	

		 
	Content?:string;	

		 
	GuidCompany?:string;	

		 
	CreatedBy?:string;	

		 
	UpdatedBy?:string;	

		 
	IsDeleted?:boolean;	

		 
	BizKeyEngine?:string;	

		 
	CreatedDate?:string;	

		 
	UpdatedDate?:string;	

		 

	public static _EntitySetName:string =  "KstEmailTemplates";
	public static _EntityName:string =  "KstEmailTemplate";
	public static PropertyNames: KstEmailTemplatePropertyNames = new KstEmailTemplatePropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidEmailTemplate,Title,TitleKey,Content,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes";


	public get getSetName() : string {
		return KstEmailTemplateModel._EntitySetName;
	}
	public get getPropertyNames() : KstEmailTemplatePropertyNames {
		return KstEmailTemplateModel.PropertyNames;
	}
}


	


 class KstProxyGeoCityPropertyNames{
	constructor(){}
	//axd
	GuidCity:string = "GuidCity";	

				 
				 
	Name:string = "Name";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	GuidState:string = "GuidState";	

				 
				 
	GuidParent:string = "GuidParent";	

				 
				 
		FkKstProxyGeoCity2:string = "FkKstProxyGeoCity2";
		KstProxyGeoCity2:string = "KstProxyGeoCity2"; //test
				 
		FkKstProxyGeoState:string = "FkKstProxyGeoState";
		KstProxyGeoState:string = "KstProxyGeoState"; //test
				 
}

//test
export  class KstProxyGeoCityModel{
	Id?:string;

		GuidCity:string;	

		 
	Name:string;	

		 
	IsDeleted?:boolean;	

		 
	GuidState?:string;	

		 
	GuidParent?:string;	

		 
		FkKstProxyGeoCity2:string ;

		FkKstProxyGeoCity2Text:any;

		KstProxyGeoCity2:string;
		
			 
		 
		FkKstProxyGeoState:string ;

		FkKstProxyGeoStateText:any;

		KstProxyGeoState:string;
		
			 
		 

	public static _EntitySetName:string =  "KstProxyGeoCities";
	public static _EntityName:string =  "KstProxyGeoCity";
	public static PropertyNames: KstProxyGeoCityPropertyNames = new KstProxyGeoCityPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidCity,Name,IsDeleted,GuidState,GuidParent";


	public get getSetName() : string {
		return KstProxyGeoCityModel._EntitySetName;
	}
	public get getPropertyNames() : KstProxyGeoCityPropertyNames {
		return KstProxyGeoCityModel.PropertyNames;
	}
}


	


 class KstProxyGeoCountryPropertyNames{
	constructor(){}
	//axd
	GuidCountry:string = "GuidCountry";	

				 
				 
	Name:string = "Name";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
}

//test
export  class KstProxyGeoCountryModel{
	Id?:string;

		GuidCountry:string;	

		 
	Name:string;	

		 
	IsDeleted?:boolean;	

		 

	public static _EntitySetName:string =  "KstProxyGeoCountries";
	public static _EntityName:string =  "KstProxyGeoCountry";
	public static PropertyNames: KstProxyGeoCountryPropertyNames = new KstProxyGeoCountryPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidCountry,Name,IsDeleted";


	public get getSetName() : string {
		return KstProxyGeoCountryModel._EntitySetName;
	}
	public get getPropertyNames() : KstProxyGeoCountryPropertyNames {
		return KstProxyGeoCountryModel.PropertyNames;
	}
}


	


 class KstProxyGeoStatePropertyNames{
	constructor(){}
	//axd
	GuidState:string = "GuidState";	

				 
				 
	Name:string = "Name";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	GuidCountry:string = "GuidCountry";	

				 
				 
		FkKstProxyGeoCountry:string = "FkKstProxyGeoCountry";
		KstProxyGeoCountry:string = "KstProxyGeoCountry"; //test
				 
}

//test
export  class KstProxyGeoStateModel{
	Id?:string;

		GuidState:string;	

		 
	Name:string;	

		 
	IsDeleted?:boolean;	

		 
	GuidCountry?:string;	

		 
		FkKstProxyGeoCountry:string ;

		FkKstProxyGeoCountryText:any;

		KstProxyGeoCountry:string;
		
			 
		 

	public static _EntitySetName:string =  "KstProxyGeoStates";
	public static _EntityName:string =  "KstProxyGeoState";
	public static PropertyNames: KstProxyGeoStatePropertyNames = new KstProxyGeoStatePropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidState,Name,IsDeleted,GuidCountry";


	public get getSetName() : string {
		return KstProxyGeoStateModel._EntitySetName;
	}
	public get getPropertyNames() : KstProxyGeoStatePropertyNames {
		return KstProxyGeoStateModel.PropertyNames;
	}
}


	


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


	


 class KstProxyRolePropertyNames{
	constructor(){}
	//axd
	GuidRole:string = "GuidRole";	

				 
				 
	RoleName:string = "RoleName";	

				 
				 
	NameKey:string = "NameKey";	

				 
				 
	UpdatedDate:string = "UpdatedDate";	

				 
				 
	IsDeleted:string = "IsDeleted";	

				 
				 
	CreatedDate:string = "CreatedDate";	

				 
				 
}

//test
export  class KstProxyRoleModel{
	Id?:string;

		GuidRole:string;	

		 
	RoleName:string;	

		 
	NameKey:string;	

		 
	UpdatedDate?:string;	

		 
	IsDeleted?:boolean;	

		 
	CreatedDate?:string;	

		 

	public static _EntitySetName:string =  "KstProxyRoles";
	public static _EntityName:string =  "KstProxyRole";
	public static PropertyNames: KstProxyRolePropertyNames = new KstProxyRolePropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidRole,RoleName,NameKey,UpdatedDate,IsDeleted,CreatedDate";


	public get getSetName() : string {
		return KstProxyRoleModel._EntitySetName;
	}
	public get getPropertyNames() : KstProxyRolePropertyNames {
		return KstProxyRoleModel.PropertyNames;
	}
}


	


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


	


 class unProxyBusinessObjectPropertyNames{
	constructor(){}
	//axd
	GuidBusinessObject:string = "GuidBusinessObject";	

				 
				 
	Name:string = "Name";	

				 
				 
	BusinessObjectKey:string = "BusinessObjectKey";	

				 
				 
	EntitySetName:string = "EntitySetName";	

				 
				 
}

//test
export  class unProxyBusinessObjectModel{
	Id?:string;

		GuidBusinessObject:string;	

		 
	Name?:string;	

		 
	BusinessObjectKey?:string;	

		 
	EntitySetName?:string;	

		 

	public static _EntitySetName:string =  "unProxyBusinessObjects";
	public static _EntityName:string =  "unProxyBusinessObject";
	public static PropertyNames: unProxyBusinessObjectPropertyNames = new unProxyBusinessObjectPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidBusinessObject,Name,BusinessObjectKey,EntitySetName";


	public get getSetName() : string {
		return unProxyBusinessObjectModel._EntitySetName;
	}
	public get getPropertyNames() : unProxyBusinessObjectPropertyNames {
		return unProxyBusinessObjectModel.PropertyNames;
	}
}


	


 class unProxyEventPropertyNames{
	constructor(){}
	//axd
	GuidUnProxyEvent:string = "GuidUnProxyEvent";	

				 
				 
	Title:string = "Title";	

				 
				 
	Message:string = "Message";	

				 
				 
	TypeEvent:string = "TypeEvent";	

				 
				 
	IsException:string = "IsException";	

				 
				 
	UpdatedDate:string = "UpdatedDate";	

				 
				 
}

//test
export  class unProxyEventModel{
	Id?:string;

		GuidUnProxyEvent:string;	

		 
	Title?:string;	

		 
	Message?:string;	

		 
	TypeEvent?:string;	

		 
	IsException?:boolean;	

		 
	UpdatedDate?:string;	

		 

	public static _EntitySetName:string =  "unProxyEvents";
	public static _EntityName:string =  "unProxyEvent";
	public static PropertyNames: unProxyEventPropertyNames = new unProxyEventPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidUnProxyEvent,Title,Message,TypeEvent,IsException,UpdatedDate";


	public get getSetName() : string {
		return unProxyEventModel._EntitySetName;
	}
	public get getPropertyNames() : unProxyEventPropertyNames {
		return unProxyEventModel.PropertyNames;
	}
}


	


 class unProxySettingPropertyNames{
	constructor(){}
	//axd
	 SMTPServerId:string = "SMTPServer";	
	 SMTPSSLEnabledId:string = "SMTPSSLEnabled";	
	 SMTPUserId:string = "SMTPUser";	
	 SMTPPasswordId:string = "SMTPPassword";	
	 SMTPFromNameId:string = "SMTPFromName";	
	 SMTPPortId:string = "SMTPPort";	
	 SMTPFromEmailId:string = "SMTPFromEmail";	
	 AzureBlobStorageConnectionId:string = "AzureBlobStorageConnection";	
	 SaveBlobInAzureStorageId:string = "SaveBlobInAzureStorage";	
	 SaveBlobInDataBaseId:string = "SaveBlobInDataBase";	
	 UserNameGeoNamesId:string = "UserNameGeoNames";	
	 EngineURLId:string = "EngineURL";	
	 ENGINE_API_KEYId:string = "ENGINE_API_KEY";	
	 MAMBU_URLId:string = "MAMBU_URL";	
	 MAMBU_USERId:string = "MAMBU_USER";	
	 MAMBU_PWDId:string = "MAMBU_PWD";	
	 KM_MAXIMOId:string = "KM_MAXIMO";	
	 MAP_KEYId:string = "MAP_KEY";	
	 ENGINE_OAUTH_CLIENT_IDId:string = "ENGINE_OAUTH_CLIENT_ID";	
	 ENGINE_OAUTH_LOGIN_URLId:string = "ENGINE_OAUTH_LOGIN_URL";	
	 ENGINE_OAUTH_USERNAMEId:string = "ENGINE_OAUTH_USERNAME";	
	 ENGINE_OAUTH_PASSWORDId:string = "ENGINE_OAUTH_PASSWORD";	
	 ENGINE_OAUTH_CLIENT_SECRETId:string = "ENGINE_OAUTH_CLIENT_SECRET";	
	 ENGINE_DEFINITION_IDId:string = "ENGINE_DEFINITION_ID";	
	 CONTAINER_DATOS_CLIENTE_IDId:string = "CONTAINER_DATOS_CLIENTE_ID";	
	 CONTAINER_DOCUMENTOS_IDId:string = "CONTAINER_DOCUMENTOS_ID";	
	 CONTAINER_DIRECCION_IDId:string = "CONTAINER_DIRECCION_ID";	
	 CONTAINER_DATOS_FINANCIEROS_IDId:string = "CONTAINER_DATOS_FINANCIEROS_ID";	
	 CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_IDId:string = "CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID";	
	 CONTAINER_BENEFICIARIOS_IDId:string = "CONTAINER_BENEFICIARIOS_ID";	
	 CONTAINER_CONTRATOS_IDId:string = "CONTAINER_CONTRATOS_ID";	
	 CONTAINER_APROBACION_IDId:string = "CONTAINER_APROBACION_ID";	
	 MAMBU_CONTRATO_TEMPLATEIDId:string = "MAMBU_CONTRATO_TEMPLATEID";	
	 MAMBU_CARATULA_TEMPLATEIDId:string = "MAMBU_CARATULA_TEMPLATEID";	
	 MAMBU_PAGARE_TEMPLATEIDId:string = "MAMBU_PAGARE_TEMPLATEID";	
	 MAMBU_REFERENCIASPAGO_TEMPLATEIDId:string = "MAMBU_REFERENCIASPAGO_TEMPLATEID";	
	 MATI_AUTH_HEADERId:string = "MATI_AUTH_HEADER";	
	 WEBBHOOK_MATI_KEYId:string = "WEBBHOOK_MATI_KEY";	
	GuidUnProxySetting:string = "GuidUnProxySetting";	

				 
				 
	SMTPServer:string = "SMTPServer";	

				 
				 
	SMTPSSLEnabled:string = "SMTPSSLEnabled";	

				 
				 
	SMTPUser:string = "SMTPUser";	

				 
				 
	SMTPPassword:string = "SMTPPassword";	

				 
				 
	SMTPFromName:string = "SMTPFromName";	

				 
				 
	SMTPPort:string = "SMTPPort";	

				 
				 
	SMTPFromEmail:string = "SMTPFromEmail";	

				 
				 
	AzureBlobStorageConnection:string = "AzureBlobStorageConnection";	

				 
				 
	SaveBlobInAzureStorage:string = "SaveBlobInAzureStorage";	

				 
				 
	SaveBlobInDataBase:string = "SaveBlobInDataBase";	

				 
				 
	UserNameGeoNames:string = "UserNameGeoNames";	

				 
				 
	EngineURL:string = "EngineURL";	

				 
				 
	ENGINE_API_KEY:string = "ENGINE_API_KEY";	

				 
				 
	MAMBU_URL:string = "MAMBU_URL";	

				 
				 
	MAMBU_USER:string = "MAMBU_USER";	

				 
				 
	MAMBU_PWD:string = "MAMBU_PWD";	

				 
				 
	KM_MAXIMO:string = "KM_MAXIMO";	

				 
				 
	MAP_KEY:string = "MAP_KEY";	

				 
				 
	ENGINE_OAUTH_CLIENT_ID:string = "ENGINE_OAUTH_CLIENT_ID";	

				 
				 
	ENGINE_OAUTH_LOGIN_URL:string = "ENGINE_OAUTH_LOGIN_URL";	

				 
				 
	ENGINE_OAUTH_USERNAME:string = "ENGINE_OAUTH_USERNAME";	

				 
				 
	ENGINE_OAUTH_PASSWORD:string = "ENGINE_OAUTH_PASSWORD";	

				 
				 
	ENGINE_OAUTH_CLIENT_SECRET:string = "ENGINE_OAUTH_CLIENT_SECRET";	

				 
				 
	ENGINE_DEFINITION_ID:string = "ENGINE_DEFINITION_ID";	

				 
				 
	CONTAINER_DATOS_CLIENTE_ID:string = "CONTAINER_DATOS_CLIENTE_ID";	

				 
				 
	CONTAINER_DOCUMENTOS_ID:string = "CONTAINER_DOCUMENTOS_ID";	

				 
				 
	CONTAINER_DIRECCION_ID:string = "CONTAINER_DIRECCION_ID";	

				 
				 
	CONTAINER_DATOS_FINANCIEROS_ID:string = "CONTAINER_DATOS_FINANCIEROS_ID";	

				 
				 
	CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID:string = "CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID";	

				 
				 
	CONTAINER_BENEFICIARIOS_ID:string = "CONTAINER_BENEFICIARIOS_ID";	

				 
				 
	CONTAINER_CONTRATOS_ID:string = "CONTAINER_CONTRATOS_ID";	

				 
				 
	CONTAINER_APROBACION_ID:string = "CONTAINER_APROBACION_ID";	

				 
				 
	MAMBU_CONTRATO_TEMPLATEID:string = "MAMBU_CONTRATO_TEMPLATEID";	

				 
				 
	MAMBU_CARATULA_TEMPLATEID:string = "MAMBU_CARATULA_TEMPLATEID";	

				 
				 
	MAMBU_PAGARE_TEMPLATEID:string = "MAMBU_PAGARE_TEMPLATEID";	

				 
				 
	MAMBU_REFERENCIASPAGO_TEMPLATEID:string = "MAMBU_REFERENCIASPAGO_TEMPLATEID";	

				 
				 
	MATI_AUTH_HEADER:string = "MATI_AUTH_HEADER";	

				 
				 
	WEBBHOOK_MATI_KEY:string = "WEBBHOOK_MATI_KEY";	

				 
				 
}

//test
export  class unProxySettingModel{
	Id?:string;

		 SMTPServerId: string;
	 SMTPSSLEnabledId: string;
	 SMTPUserId: string;
	 SMTPPasswordId: string;
	 SMTPFromNameId: string;
	 SMTPPortId: string;
	 SMTPFromEmailId: string;
	 AzureBlobStorageConnectionId: string;
	 SaveBlobInAzureStorageId: string;
	 SaveBlobInDataBaseId: string;
	 UserNameGeoNamesId: string;
	 EngineURLId: string;
	 ENGINE_API_KEYId: string;
	 MAMBU_URLId: string;
	 MAMBU_USERId: string;
	 MAMBU_PWDId: string;
	 KM_MAXIMOId: string;
	 MAP_KEYId: string;
	 ENGINE_OAUTH_CLIENT_IDId: string;
	 ENGINE_OAUTH_LOGIN_URLId: string;
	 ENGINE_OAUTH_USERNAMEId: string;
	 ENGINE_OAUTH_PASSWORDId: string;
	 ENGINE_OAUTH_CLIENT_SECRETId: string;
	 ENGINE_DEFINITION_IDId: string;
	 CONTAINER_DATOS_CLIENTE_IDId: string;
	 CONTAINER_DOCUMENTOS_IDId: string;
	 CONTAINER_DIRECCION_IDId: string;
	 CONTAINER_DATOS_FINANCIEROS_IDId: string;
	 CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_IDId: string;
	 CONTAINER_BENEFICIARIOS_IDId: string;
	 CONTAINER_CONTRATOS_IDId: string;
	 CONTAINER_APROBACION_IDId: string;
	 MAMBU_CONTRATO_TEMPLATEIDId: string;
	 MAMBU_CARATULA_TEMPLATEIDId: string;
	 MAMBU_PAGARE_TEMPLATEIDId: string;
	 MAMBU_REFERENCIASPAGO_TEMPLATEIDId: string;
	 MATI_AUTH_HEADERId: string;
	 WEBBHOOK_MATI_KEYId: string;
	GuidUnProxySetting:string;	

		 
	SMTPServer?:string;	

		 
	SMTPSSLEnabled?:boolean;	

		 
	SMTPUser?:string;	

		 
	SMTPPassword?:string;	

		 
	SMTPFromName?:string;	

		 
	SMTPPort?:string;	

		 
	SMTPFromEmail?:string;	

		 
	AzureBlobStorageConnection?:string;	

		 
	SaveBlobInAzureStorage?:boolean;	

		 
	SaveBlobInDataBase?:boolean;	

		 
	UserNameGeoNames?:string;	

		 
	EngineURL?:string;	

		 
	ENGINE_API_KEY?:string;	

		 
	MAMBU_URL?:string;	

		 
	MAMBU_USER?:string;	

		 
	MAMBU_PWD?:string;	

		 
	KM_MAXIMO?:number;	

		 
	MAP_KEY?:string;	

		 
	ENGINE_OAUTH_CLIENT_ID?:string;	

		 
	ENGINE_OAUTH_LOGIN_URL?:string;	

		 
	ENGINE_OAUTH_USERNAME?:string;	

		 
	ENGINE_OAUTH_PASSWORD?:string;	

		 
	ENGINE_OAUTH_CLIENT_SECRET?:string;	

		 
	ENGINE_DEFINITION_ID?:string;	

		 
	CONTAINER_DATOS_CLIENTE_ID?:string;	

		 
	CONTAINER_DOCUMENTOS_ID?:string;	

		 
	CONTAINER_DIRECCION_ID?:string;	

		 
	CONTAINER_DATOS_FINANCIEROS_ID?:string;	

		 
	CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID?:string;	

		 
	CONTAINER_BENEFICIARIOS_ID?:string;	

		 
	CONTAINER_CONTRATOS_ID?:string;	

		 
	CONTAINER_APROBACION_ID?:string;	

		 
	MAMBU_CONTRATO_TEMPLATEID?:string;	

		 
	MAMBU_CARATULA_TEMPLATEID?:string;	

		 
	MAMBU_PAGARE_TEMPLATEID?:string;	

		 
	MAMBU_REFERENCIASPAGO_TEMPLATEID?:string;	

		 
	MATI_AUTH_HEADER?:string;	

		 
	WEBBHOOK_MATI_KEY?:string;	

		 

	public static _EntitySetName:string =  "unProxySettings";
	public static _EntityName:string =  "unProxySetting";
	public static PropertyNames: unProxySettingPropertyNames = new unProxySettingPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidUnProxySetting,SMTPServer,SMTPSSLEnabled,SMTPUser,SMTPPassword,SMTPFromName,SMTPPort,SMTPFromEmail,AzureBlobStorageConnection,SaveBlobInAzureStorage,SaveBlobInDataBase,UserNameGeoNames,EngineURL,ENGINE_API_KEY,MAMBU_URL,MAMBU_USER,MAMBU_PWD,KM_MAXIMO,MAP_KEY,ENGINE_OAUTH_CLIENT_ID,ENGINE_OAUTH_LOGIN_URL,ENGINE_OAUTH_USERNAME,ENGINE_OAUTH_PASSWORD,ENGINE_OAUTH_CLIENT_SECRET,ENGINE_DEFINITION_ID,CONTAINER_DATOS_CLIENTE_ID,CONTAINER_DOCUMENTOS_ID,CONTAINER_DIRECCION_ID,CONTAINER_DATOS_FINANCIEROS_ID,CONTAINER_ENVIO_SMS_CONSULTA_UNYKOO_ID,CONTAINER_BENEFICIARIOS_ID,CONTAINER_CONTRATOS_ID,CONTAINER_APROBACION_ID,MAMBU_CONTRATO_TEMPLATEID,MAMBU_CARATULA_TEMPLATEID,MAMBU_PAGARE_TEMPLATEID,MAMBU_REFERENCIASPAGO_TEMPLATEID,MATI_AUTH_HEADER,WEBBHOOK_MATI_KEY";


	public get getSetName() : string {
		return unProxySettingModel._EntitySetName;
	}
	public get getPropertyNames() : unProxySettingPropertyNames {
		return unProxySettingModel.PropertyNames;
	}
}


	


 class UploadFileResultPropertyNames{
	constructor(){}
	//axd
	TotalRows:string = "TotalRows";	

				 
				 
	UrlFileResult:string = "UrlFileResult";	

				 
				 
	Ignored:string = "Ignored";	

				 
				 
}

//test
export  class UploadFileResultModel{
	Id?:string;

		TotalRows:number;	

		 
	UrlFileResult:string;	

		 
	Ignored?:number;	

		 

	public static _EntitySetName:string =  "UploadFileResult";
	public static _EntityName:string =  "UploadFileResult";
	public static PropertyNames: UploadFileResultPropertyNames = new UploadFileResultPropertyNames();
	public static _PropertyNamesForUpdate: string = "TotalRows,UrlFileResult,Ignored";


	public get getSetName() : string {
		return UploadFileResultModel._EntitySetName;
	}
	public get getPropertyNames() : UploadFileResultPropertyNames {
		return UploadFileResultModel.PropertyNames;
	}
}


	
