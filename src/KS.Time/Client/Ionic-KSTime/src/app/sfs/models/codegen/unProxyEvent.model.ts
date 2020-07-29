

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


	
