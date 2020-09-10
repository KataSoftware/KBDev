import { FormlyFieldConfig } from '@ngx-formly/core';
import { ChildRelation } from '../common/page.model';

import { KstActivityModel } from './KstActivity.model';
import { KstProjectModel } from './KstProject.model';
import { KstActivityTypeModel } from './KstActivityType.model';
	



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

				 
				 
	DueDate:string = "DueDate";	

				 
				 
	GuidActivityType:string = "GuidActivityType";	

				 
				 
		FkKstActivity:string = "FkKstActivity";
		KstActivity:string = "KstActivity"; //test
				 
		FkKstProject:string = "FkKstProject";
		KstProject:string = "KstProject"; //test
				 
		FkKstActivityType:string = "FkKstActivityType";
		KstActivityType:string = "KstActivityType"; //test
				 
}

//test
export  class KstWorkTimeModel{

    public static GetChildren(){
		let results:Array<ChildRelation> = [];
        results.push({
            Name: "KstWorkTimeFiles",
            FkPropertyName: "GuidWorkTime",
            Label: "KstWorkTimeFiles",
            EntityName: "KstWorkTimeFile"
        });
		return results;
	}
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstWorkTimeModel.PropertyNames.Title,
    type: 'input',

    templateOptions: {
	        label: KstWorkTimeModel.PropertyNames.Title,
        placeholder: '',
        required: false,
		
		maxLength: 255,
    }
},
{
    key: KstWorkTimeModel.PropertyNames.Comments,
    type: 'input',

    templateOptions: {
	        label: KstWorkTimeModel.PropertyNames.Comments,
        placeholder: '',
        required: false,
		
		maxLength: 500,
    }
},
{
    key: KstWorkTimeModel.PropertyNames.Hours,
    type: 'input',

    templateOptions: {
	        label: KstWorkTimeModel.PropertyNames.Hours,
        placeholder: '',
        required: false,
		
        type: "number",
    }
},
{
    key: KstWorkTimeModel.PropertyNames.GuidProject,
    type: 'select',

    templateOptions: {
		  "relation": {
			PropertyRelationName: "KstProject",
			EntityModel: KstProjectModel,  
			DataValue: KstProjectModel.PropertyNames.GuidProject,
            DataText: KstProjectModel.PropertyNames.Name 
			},
        label: KstWorkTimeModel.PropertyNames.GuidProject,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstWorkTimeModel.PropertyNames.GuidActivity,
    type: 'select',

    templateOptions: {
		  "relation": {
			PropertyRelationName: "KstActivity",
			EntityModel: KstActivityModel,  
			DataValue: KstActivityModel.PropertyNames.GuidActivity,
            DataText: KstActivityModel.PropertyNames.Name 
			},
        label: KstWorkTimeModel.PropertyNames.GuidActivity,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstWorkTimeModel.PropertyNames.DueDate,
    type: 'datepicker',

    templateOptions: {
	        label: KstWorkTimeModel.PropertyNames.DueDate,
        placeholder: '',
        required: false,
		
    }
},
{
    key: KstWorkTimeModel.PropertyNames.GuidActivityType,
    type: 'select',

    templateOptions: {
		  "relation": {
			PropertyRelationName: "KstActivityType",
			EntityModel: KstActivityTypeModel,  
			DataValue: KstActivityTypeModel.PropertyNames.GuidActivityType,
            DataText: KstActivityTypeModel.PropertyNames.Name 
			},
        label: KstWorkTimeModel.PropertyNames.GuidActivityType,
        placeholder: '',
        required: false,
		
    }
},
	];
    }
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

		 
	IsDeleted?:boolean = false;	

		 
	BizKeyEngine?:string;	

		 
	CreatedDate?:string;	

		 
	UpdatedDate?:string;	

		 
	DueDate?:string;	

		 
	GuidActivityType?:string;	

		 
		FkKstActivity:string ;

		FkKstActivityText:any;

		KstActivity:string;
		
			 
		 
		FkKstProject:string ;

		FkKstProjectText:any;

		KstProject:string;
		
			 
		 
		FkKstActivityType:string ;

		FkKstActivityTypeText:any;

		KstActivityType:string;
		
			 
		 

	public static _EntitySetName:string =  "KstWorkTimes";
	public static _EntityName:string =  "KstWorkTime";
	public static PropertyNames: KstWorkTimePropertyNames = new KstWorkTimePropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidWorkTime,Title,Comments,Hours,GuidProject,GuidActivity,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes,DueDate,GuidActivityType";

	public static _DefaultProperty: string= "Title";

	public get getSetName() : string {
		return KstWorkTimeModel._EntitySetName;
	}
	public get getPropertyNames() : KstWorkTimePropertyNames {
		return KstWorkTimeModel.PropertyNames;
	}
}


	
