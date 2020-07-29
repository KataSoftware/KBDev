

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


	
