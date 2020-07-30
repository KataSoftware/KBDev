 





import { FormlyFieldConfig } from '@ngx-formly/core';

	



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
public static GetFields():Array<FormlyFieldConfig>{
return [
{
    key: KstEmailTemplateModel.PropertyNames.Title,
    type: 'input',

    templateOptions: {
        label: KstEmailTemplateModel.PropertyNames.Title,
        placeholder: '',
        required: true,
		
		maxLength: 255,
    }
},
{
    key: KstEmailTemplateModel.PropertyNames.TitleKey,
    type: 'input',

    templateOptions: {
        label: KstEmailTemplateModel.PropertyNames.TitleKey,
        placeholder: '',
        required: false,
		
		maxLength: 20,
    }
},
{
    key: KstEmailTemplateModel.PropertyNames.Content,
    type: 'textarea',

    templateOptions: {
        label: KstEmailTemplateModel.PropertyNames.Content,
        placeholder: '',
        required: false,
		rows: 5,
    }
},
	];
    }
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


	
