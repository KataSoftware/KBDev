import { FormlyFieldConfig } from '@ngx-formly/core';
import { ChildRelation } from '../common/page.model';

import { KstProjectModel } from './KstProject.model';
import { KstActivityTypeModel } from './KstActivityType.model';
	



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

				 
				 
	GuidActivityType:string = "GuidActivityType";	

				 
				 
		FkKstProject:string = "FkKstProject";
		KstProject:string = "KstProject"; //test
				 
		FkKstActivityType:string = "FkKstActivityType";
		KstActivityType:string = "KstActivityType"; //test
				 
}

//test
export  class KstActivityModel{

    public static GetChildren(){
		let results:Array<ChildRelation> = [];
        results.push({
            Name: "KstWorkTimes",
            FkPropertyName: "GuidActivity",
            Label: "KstWorkTimes",
            EntityName: "KstWorkTime"
        });
		return results;
	}
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstActivityModel.PropertyNames.Name,
    type: 'input',

    templateOptions: {
	
        label: KstActivityModel.PropertyNames.Name,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstActivityModel.PropertyNames.GuidProject,
    type: 'select',

    templateOptions: {
		
	  "relation": {
			PropertyRelationName: "KstProject",
			EntityModel: KstProjectModel,  
			DataValue: KstProjectModel.PropertyNames.GuidProject,
            DataText: KstProjectModel.PropertyNames.Name 
			},

        label: KstActivityModel.PropertyNames.GuidProject,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstActivityModel.PropertyNames.IsCustomByUser,
    type: 'checkbox',

    templateOptions: {
	 
	indeterminate: false,

        label: KstActivityModel.PropertyNames.IsCustomByUser,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstActivityModel.PropertyNames.GuidActivityType,
    type: 'select',

    templateOptions: {
		
	  "relation": {
			PropertyRelationName: "KstActivityType",
			EntityModel: KstActivityTypeModel,  
			DataValue: KstActivityTypeModel.PropertyNames.GuidActivityType,
            DataText: KstActivityTypeModel.PropertyNames.Name 
			},

        label: KstActivityModel.PropertyNames.GuidActivityType,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
	Id?:string;

		GuidActivity:string;	

		 
	Name?:string;	

		 
	GuidProject?:string;	

		 
	IsCustomByUser:boolean = false;	

		 
	GuidCompany?:string;	

		 
	CreatedBy?:string;	

		 
	UpdatedBy?:string;	

		 
	IsDeleted?:boolean = false;	

		 
	BizKeyEngine?:string;	

		 
	CreatedDate?:string;	

		 
	UpdatedDate?:string;	

		 
	GuidActivityType?:string;	

		 
		FkKstProject:string ;

		FkKstProjectText:any;

		KstProject:string;
		
			 
		 
		FkKstActivityType:string ;

		FkKstActivityTypeText:any;

		KstActivityType:string;
		
			 
		 

	public static _EntitySetName:string =  "KstActivities";
	public static _EntityName:string =  "KstActivity";
	public static PropertyNames: KstActivityPropertyNames = new KstActivityPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidActivity,Name,GuidProject,IsCustomByUser,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes,GuidActivityType";

	public static _DefaultProperty: string= "Name";

	public get getSetName() : string {
		return KstActivityModel._EntitySetName;
	}
	public get getPropertyNames() : KstActivityPropertyNames {
		return KstActivityModel.PropertyNames;
	}
}


	
