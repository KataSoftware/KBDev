

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


	
