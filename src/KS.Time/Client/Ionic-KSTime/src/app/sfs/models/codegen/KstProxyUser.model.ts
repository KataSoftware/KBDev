import { FormlyFieldConfig } from '@ngx-formly/core';

import { KstProxyRoleModel } from './KstProxyRole.model';
	



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
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstProxyUserModel.PropertyNames.DisplayName,
    type: 'input',

    templateOptions: {
	        label: KstProxyUserModel.PropertyNames.DisplayName,
        placeholder: '',
        required: false,
		
		maxLength: 150,
    }
},
{
    key: KstProxyUserModel.PropertyNames.Username,
    type: 'input',

    templateOptions: {
	        label: KstProxyUserModel.PropertyNames.Username,
        placeholder: '',
        required: false,
		
		maxLength: 100,
    }
},
{
    key: KstProxyUserModel.PropertyNames.Password,
    type: 'input',

    templateOptions: {
	        label: KstProxyUserModel.PropertyNames.Password,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstProxyUserModel.PropertyNames.FirstName,
    type: 'input',

    templateOptions: {
	        label: KstProxyUserModel.PropertyNames.FirstName,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstProxyUserModel.PropertyNames.LastName,
    type: 'input',

    templateOptions: {
	        label: KstProxyUserModel.PropertyNames.LastName,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstProxyUserModel.PropertyNames.Email,
    type: 'input',

    templateOptions: {
	        label: KstProxyUserModel.PropertyNames.Email,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstProxyUserModel.PropertyNames.GuidRole,
    type: 'select',

    templateOptions: {
		  "relation": {
			PropertyRelationName: "KstProxyRole",
			EntityModel: KstProxyRoleModel,  
			DataValue: KstProxyRoleModel.PropertyNames.GuidRole,
            DataText: KstProxyRoleModel.PropertyNames.RoleName 
			},
        label: KstProxyUserModel.PropertyNames.GuidRole,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstProxyUserModel.PropertyNames.Disabled,
    type: 'checkbox',

    templateOptions: {
	 
	indeterminate: false,
        label: KstProxyUserModel.PropertyNames.Disabled,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
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

		 
	IsDeleted?:boolean = false;	

		 
	CreatedDate?:string;	

		 
	Disabled?:boolean = false;	

		 
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


	
