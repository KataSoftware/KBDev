import { FormlyFieldConfig } from '@ngx-formly/core';

	



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

    public static GetChildren(){
		let results:Array<ChildRelation> = [];
        results.push({
            Name: "KstActivities",
            FkPropertyName: "GuidProject",
            Label: "KstActivities",
            EntityName: "KstActivity"
        });
        results.push({
            Name: "KstProjectUsers",
            FkPropertyName: "GuidProject",
            Label: "KstProjectUsers",
            EntityName: "KstProjectUser"
        });
        results.push({
            Name: "KstWorkTimes",
            FkPropertyName: "GuidProject",
            Label: "KstWorkTimes",
            EntityName: "KstWorkTime"
        });
        results.push({
            Name: "KstProjectFiles",
            FkPropertyName: "GuidProject",
            Label: "KstProjectFiles",
            EntityName: "KstProjectFile"
        });
		return results;
	}
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstProjectModel.PropertyNames.Name,
    type: 'input',

    templateOptions: {
	        label: KstProjectModel.PropertyNames.Name,
        placeholder: '',
        required: true,
		
		maxLength: 255,
    }
},
{
    key: KstProjectModel.PropertyNames.NumActivities,
    type: 'input',

    templateOptions: {
	        label: KstProjectModel.PropertyNames.NumActivities,
        placeholder: '',
        required: false,
		
        type: "number",
    }
},
{
    key: KstProjectModel.PropertyNames.NumUsers,
    type: 'input',

    templateOptions: {
	        label: KstProjectModel.PropertyNames.NumUsers,
        placeholder: '',
        required: false,
		
        type: "number",
    }
},
	];
    }
	Id?:string;

		GuidProject:string;	

		 
	Name:string;	

		 
	GuidCompany?:string;	

		 
	CreatedBy?:string;	

		 
	UpdatedBy?:string;	

		 
	IsDeleted?:boolean = false;	

		 
	BizKeyEngine?:string;	

		 
	CreatedDate?:string;	

		 
	UpdatedDate?:string;	

		 
	NumActivities?:number;	

		 
	NumUsers?:number;	

		 

	public static _EntitySetName:string =  "KstProjects";
	public static _EntityName:string =  "KstProject";
	public static PropertyNames: KstProjectPropertyNames = new KstProjectPropertyNames();
	public static _PropertyNamesForUpdate: string = "GuidProject,Name,GuidCompany,CreatedBy,UpdatedBy,IsDeleted,BizKeyEngine,CreatedDate,UpdatedDate,Bytes,NumActivities,NumUsers";

	public static _DefaultProperty: string= "Name";

	public get getSetName() : string {
		return KstProjectModel._EntitySetName;
	}
	public get getPropertyNames() : KstProjectPropertyNames {
		return KstProjectModel.PropertyNames;
	}
}


	
