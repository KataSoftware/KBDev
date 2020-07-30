import { 
     KstProxyRoleModel, 
  
} from 'src/app/models/business/models';


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
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstProxyRoleModel.PropertyNames.RoleName,
    type: 'input',

    templateOptions: {
        label: KstProxyRoleModel.PropertyNames.RoleName,
        placeholder: '',
        required: true,
		
		maxLength: 150,
    }
},
{
    key: KstProxyRoleModel.PropertyNames.NameKey,
    type: 'input',

    templateOptions: {
        label: KstProxyRoleModel.PropertyNames.NameKey,
        placeholder: '',
        required: true,
		
		maxLength: 100,
    }
},
	];
    }
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


	
