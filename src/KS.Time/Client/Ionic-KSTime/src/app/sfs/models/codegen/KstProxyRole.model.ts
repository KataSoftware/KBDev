﻿import { FormlyFieldConfig } from '@ngx-formly/core';
import { ChildRelation } from '../common/page.model';

	



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

    public static GetChildren(){
		let results:Array<ChildRelation> = [];
        results.push({
            Name: "KstProxyUsers",
            FkPropertyName: "GuidRole",
            Label: "KstProxyUsers",
            EntityName: "KstProxyUser"
        });
		return results;
	}
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

		 
	IsDeleted?:boolean = false;	

		 
	CreatedDate?:string;	

		 

	public static _EntitySetName:string =  "KstProxyRoles";
	public static _EntityName:string =  "KstProxyRole";
	public static PropertyNames: KstProxyRolePropertyNames = new KstProxyRolePropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidRole,RoleName,NameKey,UpdatedDate,IsDeleted,CreatedDate";

	public static _DefaultProperty: string= "RoleName";

	public get getSetName() : string {
		return KstProxyRoleModel._EntitySetName;
	}
	public get getPropertyNames() : KstProxyRolePropertyNames {
		return KstProxyRoleModel.PropertyNames;
	}
}


	
