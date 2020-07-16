 
 
 


 class secBusinessObjectPropertyNames{
	constructor(){}

	BusinessObjectKey:string = "BusinessObjectKey";					 
				 
	Name:string = "Name";					 
				 
	EntitySetName:string = "EntitySetName";					 
				 
	TableName:string = "TableName";					 
				 
	ExtensibleInfo:string = "ExtensibleInfo";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	Name_ES:string = "Name_ES";					 
				 
	Name_EN:string = "Name_EN";					 
				 
	Syncable:string = "Syncable";					 
				 
	Usemode:string = "Usemode";					 
				 
	UsemodeFrom:string = "UsemodeFrom";					 
				 
	IsUICustom:string = "IsUICustom";					 
				 
	TypeId:string = "TypeId";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	HideFromNavigation:string = "HideFromNavigation";					 
				 
	DisabledForNavigation:string = "DisabledForNavigation";					 
				 
	UseModeQuery:string = "UseModeQuery";					 
				 
	IsCustom:string = "IsCustom";					 
				 
	SQLRows:string = "SQLRows";					 
				 
	NoSQLRows:string = "NoSQLRows";					 
				 
	HideForPermissions:string = "HideForPermissions";					 
				 
	CosmosDBRows:string = "CosmosDBRows";					 
				 
	TableStorageRows:string = "TableStorageRows";					 
				 
	SQLEnabled:string = "SQLEnabled";					 
				 
	CosmosDBEnabled:string = "CosmosDBEnabled";					 
				 
	TableStorageEnabled:string = "TableStorageEnabled";					 
				 
	GuidReusableStoragePrimary:string = "GuidReusableStoragePrimary";					 
				 
	GuidReusableStorageForGet:string = "GuidReusableStorageForGet";					 
				 
	GuidReusableStorageType:string = "GuidReusableStorageType";					 
				 
	GuidReusableNoSQLGetDefault:string = "GuidReusableNoSQLGetDefault";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecParent:string = "FksecParent";
		secParent:string = "secParent";
				 
		FksecReusableStoragePrimary:string = "FksecReusableStoragePrimary";
		secReusableStoragePrimary:string = "secReusableStoragePrimary";
				 
		FksecReusableStorageForGet:string = "FksecReusableStorageForGet";
		secReusableStorageForGet:string = "secReusableStorageForGet";
				 
	PluralName:string = "PluralName";					 
				 
	CanRead:string = "CanRead";					 
				 
	CanCreate:string = "CanCreate";					 
				 
}


export  class secBusinessObjectModel{

	BusinessObjectKey:string;					 
	Name:string;					 
	EntitySetName:string;					 
	TableName:string;					 
	ExtensibleInfo:string;					 
	GuidModule:string;					 
	GuidBusinessObject:string;					 
	Name_ES:string;					 
	Name_EN:string;					 
	Syncable:any;					 
	Usemode:string;					 
	UsemodeFrom:string;					 
	IsUICustom:any;					 
	TypeId:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	UpdatedBy:string;					 
	HideFromNavigation:any;					 
	DisabledForNavigation:any;					 
	UseModeQuery:string;					 
	IsCustom:any;					 
	SQLRows:number;					 
	NoSQLRows:number;					 
	HideForPermissions:any;					 
	CosmosDBRows:number;					 
	TableStorageRows:number;					 
	SQLEnabled:any;					 
	CosmosDBEnabled:any;					 
	TableStorageEnabled:any;					 
	GuidReusableStoragePrimary:string;					 
	GuidReusableStorageForGet:string;					 
	GuidReusableStorageType:string;					 
	GuidReusableNoSQLGetDefault:string;					 
	PluralName:string;					 
	CanRead:any;					 
	CanCreate:any;					 

	public static _EntitySetName:string =  "secBusinessObjects";
	public static _EntityName:string =  "secBusinessObject";
	public static PropertyNames: secBusinessObjectPropertyNames = new secBusinessObjectPropertyNames();
}


	


 class secCompanyConfigurationPropertyNames{
	constructor(){}

	GuidCompany:string = "GuidCompany";					 
				 
	GuidReusableCatalog:string = "GuidReusableCatalog";					 
				 
	ValueString:string = "ValueString";					 
				 
	ValueInt:string = "ValueInt";					 
				 
	ValueBoolean:string = "ValueBoolean";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecReusableCatalog:string = "FksecReusableCatalog";
		secReusableCatalog:string = "secReusableCatalog";
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
}


export  class secCompanyConfigurationModel{

	GuidCompany:string;					 
	GuidReusableCatalog:string;					 
	ValueString:string;					 
	ValueInt:number;					 
	ValueBoolean:any;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secCompanyConfigurations";
	public static _EntityName:string =  "secCompanyConfiguration";
	public static PropertyNames: secCompanyConfigurationPropertyNames = new secCompanyConfigurationPropertyNames();
}


	


 class secCompanyExtraDataPropertyNames{
	constructor(){}

	GuidExtraData:string = "GuidExtraData";					 
				 
	PaypalIdOrEmail:string = "PaypalIdOrEmail";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	PayInstructionsPhone:string = "PayInstructionsPhone";					 
				 
	PayInstructionsPaypal:string = "PayInstructionsPaypal";					 
				 
	PayInstructionsCash:string = "PayInstructionsCash";					 
				 
	PayInstructionsPreCard:string = "PayInstructionsPreCard";					 
				 
	LogoFileName:string = "LogoFileName";					 
				 
	LogoFileData:string = "LogoFileData";					 
				 
	LogoFileSize:string = "LogoFileSize";					 
				 
	LogoFileType:string = "LogoFileType";					 
				 
	LegalName:string = "LegalName";					 
				 
	VATKey:string = "VATKey";					 
				 
	Address:string = "Address";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
}


export  class secCompanyExtraDataModel{

	GuidExtraData:string;					 
	PaypalIdOrEmail:string;					 
	UpdatedDate:string;					 
	CreatedDate:string;					 
	PayInstructionsPhone:string;					 
	PayInstructionsPaypal:string;					 
	PayInstructionsCash:string;					 
	PayInstructionsPreCard:string;					 
	LogoFileName:string;					 
	LogoFileData:string;					 
	LogoFileSize:number;					 
	LogoFileType:string;					 
	LegalName:string;					 
	VATKey:string;					 
	Address:string;					 
	UpdatedBy:string;					 
	CreatedBy:string;					 
	GuidCompany:string;					 

	public static _EntitySetName:string =  "secCompanyExtraDatas";
	public static _EntityName:string =  "secCompanyExtraData";
	public static PropertyNames: secCompanyExtraDataPropertyNames = new secCompanyExtraDataPropertyNames();
}


	


 class secCompanyTypePropertyNames{
	constructor(){}

	Name:string = "Name";					 
				 
	NameKey:string = "NameKey";					 
				 
	GuidCompanyType:string = "GuidCompanyType";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
}


export  class secCompanyTypeModel{

	Name:string;					 
	NameKey:string;					 
	GuidCompanyType:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secCompanyTypes";
	public static _EntityName:string =  "secCompanyType";
	public static PropertyNames: secCompanyTypePropertyNames = new secCompanyTypePropertyNames();
}


	


 class secContentMenuPropertyNames{
	constructor(){}

	GuidContent:string = "GuidContent";					 
				 
	MenuKey:string = "MenuKey";					 
				 
	GuidContentMenu:string = "GuidContentMenu";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecContent:string = "FksecContent";
		secContent:string = "secContent";
				 
}


export  class secContentMenuModel{

	GuidContent:string;					 
	MenuKey:string;					 
	GuidContentMenu:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secContentMenus";
	public static _EntityName:string =  "secContentMenu";
	public static PropertyNames: secContentMenuPropertyNames = new secContentMenuPropertyNames();
}


	


 class secContentRelationPropertyNames{
	constructor(){}

	GuidContent:string = "GuidContent";					 
				 
	GuidParent:string = "GuidParent";					 
				 
	OrderParent:string = "OrderParent";					 
				 
	GuidContentsRelation:string = "GuidContentsRelation";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecContent:string = "FksecContent";
		secContent:string = "secContent";
				 
		FksecContent1:string = "FksecContent1";
		secContent1:string = "secContent1";
				 
}


export  class secContentRelationModel{

	GuidContent:string;					 
	GuidParent:string;					 
	OrderParent:number;					 
	GuidContentsRelation:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secContentRelations";
	public static _EntityName:string =  "secContentRelation";
	public static PropertyNames: secContentRelationPropertyNames = new secContentRelationPropertyNames();
}


	


 class secContentTypePropertyNames{
	constructor(){}

	Name:string = "Name";					 
				 
	ContentTypeKey:string = "ContentTypeKey";					 
				 
	GuidContentType:string = "GuidContentType";					 
				 
	Name_ES:string = "Name_ES";					 
				 
	Name_EN:string = "Name_EN";					 
				 
	PluralName:string = "PluralName";					 
				 
	PluralName_ES:string = "PluralName_ES";					 
				 
	PluralName_EN:string = "PluralName_EN";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
}


export  class secContentTypeModel{

	Name:string;					 
	ContentTypeKey:string;					 
	GuidContentType:string;					 
	Name_ES:string;					 
	Name_EN:string;					 
	PluralName:string;					 
	PluralName_ES:string;					 
	PluralName_EN:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secContentTypes";
	public static _EntityName:string =  "secContentType";
	public static PropertyNames: secContentTypePropertyNames = new secContentTypePropertyNames();
}


	


 class secDataColumnPropertyNames{
	constructor(){}

	TableName:string = "TableName";					 
				 
	ColumnName:string = "ColumnName";					 
				 
	ColumnValue:string = "ColumnValue";					 
				 
	GuidDataColumn:string = "GuidDataColumn";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
}


export  class secDataColumnModel{

	TableName:string;					 
	ColumnName:string;					 
	ColumnValue:string;					 
	GuidDataColumn:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secDataColumns";
	public static _EntityName:string =  "secDataColumn";
	public static PropertyNames: secDataColumnPropertyNames = new secDataColumnPropertyNames();
}


	


 class secFilePropertyNames{
	constructor(){}

	GuidFile:string = "GuidFile";					 
				 
	FileType:string = "FileType";					 
				 
	FileName:string = "FileName";					 
				 
	FileData:string = "FileData";					 
				 
	FileSize:string = "FileSize";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	Tags:string = "Tags";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	FileStorage:string = "FileStorage";					 
				 
}


export  class secFileModel{

	GuidFile:string;					 
	FileType:string;					 
	FileName:string;					 
	FileData:string;					 
	FileSize:number;					 
	CreatedDate:string;					 
	IsDeleted:any;					 
	UpdatedBy:string;					 
	CreatedBy:string;					 
	Tags:string;					 
	GuidCompany:string;					 
	UpdatedDate:string;					 
	FileStorage:string;					 

	public static _EntitySetName:string =  "secFiles";
	public static _EntityName:string =  "secFile";
	public static PropertyNames: secFilePropertyNames = new secFilePropertyNames();
}


	


 class secGeoCountryPropertyNames{
	constructor(){}

	ISO_CODE:string = "ISO_CODE";					 
				 
	Name:string = "Name";					 
				 
	OtherNames:string = "OtherNames";					 
				 
	GuidCountry:string = "GuidCountry";					 
				 
	ISO_CODE3:string = "ISO_CODE3";					 
				 
	ISO_NUMERIC:string = "ISO_NUMERIC";					 
				 
	fips:string = "fips";					 
				 
	Capital:string = "Capital";					 
				 
	Area:string = "Area";					 
				 
	Continent:string = "Continent";					 
				 
	GeonameId:string = "GeonameId";					 
				 
	CurrencyCode:string = "CurrencyCode";					 
				 
	CurrencyName:string = "CurrencyName";					 
				 
	PhoneCode:string = "PhoneCode";					 
				 
	Languages:string = "Languages";					 
				 
	SyncDate:string = "SyncDate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	ZipCode:string = "ZipCode";					 
				 
}


export  class secGeoCountryModel{

	ISO_CODE:string;					 
	Name:string;					 
	OtherNames:string;					 
	GuidCountry:string;					 
	ISO_CODE3:string;					 
	ISO_NUMERIC:number;					 
	fips:string;					 
	Capital:string;					 
	Area:number;					 
	Continent:string;					 
	GeonameId:number;					 
	CurrencyCode:string;					 
	CurrencyName:string;					 
	PhoneCode:string;					 
	Languages:string;					 
	SyncDate:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	ZipCode:string;					 

	public static _EntitySetName:string =  "secGeoCountries";
	public static _EntityName:string =  "secGeoCountry";
	public static PropertyNames: secGeoCountryPropertyNames = new secGeoCountryPropertyNames();
}


	


 class secLoginProviderPropertyNames{
	constructor(){}

	Name:string = "Name";					 
				 
	Url:string = "Url";					 
				 
	Description:string = "Description";					 
				 
	GuidLoginProvider:string = "GuidLoginProvider";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
}


export  class secLoginProviderModel{

	Name:string;					 
	Url:string;					 
	Description:string;					 
	GuidLoginProvider:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secLoginProviders";
	public static _EntityName:string =  "secLoginProvider";
	public static PropertyNames: secLoginProviderPropertyNames = new secLoginProviderPropertyNames();
}


	


 class secMembershipLevelPropertyNames{
	constructor(){}

	GuidMembershipLevel:string = "GuidMembershipLevel";					 
				 
	Name:string = "Name";					 
				 
	NameKey:string = "NameKey";					 
				 
	MembershipLevel:string = "MembershipLevel";					 
				 
	Name_ES:string = "Name_ES";					 
				 
	Name_EN:string = "Name_EN";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	DescriptionShort:string = "DescriptionShort";					 
				 
	DescriptionShort_ES:string = "DescriptionShort_ES";					 
				 
	DescriptionShort_EN:string = "DescriptionShort_EN";					 
				 
	Price:string = "Price";					 
				 
	Price_USD:string = "Price_USD";					 
				 
	Price_MXN:string = "Price_MXN";					 
				 
}


export  class secMembershipLevelModel{

	GuidMembershipLevel:string;					 
	Name:string;					 
	NameKey:string;					 
	MembershipLevel:number;					 
	Name_ES:string;					 
	Name_EN:string;					 
	UpdatedDate:string;					 
	CreatedDate:string;					 
	UpdatedBy:string;					 
	CreatedBy:string;					 
	DescriptionShort:string;					 
	DescriptionShort_ES:string;					 
	DescriptionShort_EN:string;					 
	Price:number;					 
	Price_USD:number;					 
	Price_MXN:number;					 

	public static _EntitySetName:string =  "secMembershipLevels";
	public static _EntityName:string =  "secMembershipLevel";
	public static PropertyNames: secMembershipLevelPropertyNames = new secMembershipLevelPropertyNames();
}


	


 class secMembershipModulePropertyNames{
	constructor(){}

	GuidModule:string = "GuidModule";					 
				 
	GuidMembershipLevel:string = "GuidMembershipLevel";					 
				 
	Name:string = "Name";					 
				 
	Name_ES:string = "Name_ES";					 
				 
	Name_EN:string = "Name_EN";					 
				 
	Price:string = "Price";					 
				 
	DaysFree:string = "DaysFree";					 
				 
	RequireCardFree:string = "RequireCardFree";					 
				 
	GuidMembershipModule:string = "GuidMembershipModule";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	Price_USD:string = "Price_USD";					 
				 
	Price_MXN:string = "Price_MXN";					 
				 
		FksecMembershipLevel:string = "FksecMembershipLevel";
		secMembershipLevel:string = "secMembershipLevel";
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
}


export  class secMembershipModuleModel{

	GuidModule:string;					 
	GuidMembershipLevel:string;					 
	Name:string;					 
	Name_ES:string;					 
	Name_EN:string;					 
	Price:number;					 
	DaysFree:number;					 
	RequireCardFree:any;					 
	GuidMembershipModule:string;					 
	UpdatedDate:string;					 
	CreatedDate:string;					 
	UpdatedBy:string;					 
	CreatedBy:string;					 
	Price_USD:number;					 
	Price_MXN:number;					 

	public static _EntitySetName:string =  "secMembershipModules";
	public static _EntityName:string =  "secMembershipModule";
	public static PropertyNames: secMembershipModulePropertyNames = new secMembershipModulePropertyNames();
}


	


 class secMenuFormPropertyNames{
	constructor(){}

	Url:string = "Url";					 
				 
	FormKey:string = "FormKey";					 
				 
	Title:string = "Title";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	GuidPermission:string = "GuidPermission";					 
				 
	GuidForm:string = "GuidForm";					 
				 
	ParentGuidForm:string = "ParentGuidForm";					 
				 
	ActionName:string = "ActionName";					 
				 
	OverrideApp:string = "OverrideApp";					 
				 
	UseMode:string = "UseMode";					 
				 
	LangResource:string = "LangResource";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
		FksecMenuParent:string = "FksecMenuParent";
		secMenuParent:string = "secMenuParent";
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecPermission:string = "FksecPermission";
		secPermission:string = "secPermission";
				 
}


export  class secMenuFormModel{

	Url:string;					 
	FormKey:string;					 
	Title:string;					 
	GuidModule:string;					 
	GuidBusinessObject:string;					 
	GuidPermission:string;					 
	GuidForm:string;					 
	ParentGuidForm:string;					 
	ActionName:string;					 
	OverrideApp:string;					 
	UseMode:string;					 
	LangResource:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secMenuForms";
	public static _EntityName:string =  "secMenuForm";
	public static PropertyNames: secMenuFormPropertyNames = new secMenuFormPropertyNames();
}


	


 class secMessageNotificationPropertyNames{
	constructor(){}

	GuidMessageNotification:string = "GuidMessageNotification";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	ActionKey:string = "ActionKey";					 
				 
	TitleMessage:string = "TitleMessage";					 
				 
	Description:string = "Description";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	TitleMessage_EN:string = "TitleMessage_EN";					 
				 
	TitleMessage_RU:string = "TitleMessage_RU";					 
				 
	Description_EN:string = "Description_EN";					 
				 
	Description_RU:string = "Description_RU";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
}


export  class secMessageNotificationModel{

	GuidMessageNotification:string;					 
	GuidBusinessObject:string;					 
	ActionKey:string;					 
	TitleMessage:string;					 
	Description:string;					 
	GuidModule:string;					 
	TitleMessage_EN:string;					 
	TitleMessage_RU:string;					 
	Description_EN:string;					 
	Description_RU:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secMessageNotifications";
	public static _EntityName:string =  "secMessageNotification";
	public static PropertyNames: secMessageNotificationPropertyNames = new secMessageNotificationPropertyNames();
}


	


 class secMessageNotificationTemplatePropertyNames{
	constructor(){}

	GuidMessageTemplate:string = "GuidMessageTemplate";					 
				 
	FromEmail:string = "FromEmail";					 
				 
	TemplateHtml:string = "TemplateHtml";					 
				 
	FromName:string = "FromName";					 
				 
	GuidMessageNotification:string = "GuidMessageNotification";					 
				 
	IsBase:string = "IsBase";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	ActionGroupKey:string = "ActionGroupKey";					 
				 
	Title:string = "Title";					 
				 
	MessageSubject:string = "MessageSubject";					 
				 
	ToCC:string = "ToCC";					 
				 
	Description_RU:string = "Description_RU";					 
				 
	Description_EN:string = "Description_EN";					 
				 
	TitleMessage_EN:string = "TitleMessage_EN";					 
				 
	TitleMessage_RU:string = "TitleMessage_RU";					 
				 
		FksecMessageNotification:string = "FksecMessageNotification";
		secMessageNotification:string = "secMessageNotification";
				 
}


export  class secMessageNotificationTemplateModel{

	GuidMessageTemplate:string;					 
	FromEmail:string;					 
	TemplateHtml:string;					 
	FromName:string;					 
	GuidMessageNotification:string;					 
	IsBase:any;					 
	GuidCompany:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	IsDeleted:any;					 
	ActionGroupKey:string;					 
	Title:string;					 
	MessageSubject:string;					 
	ToCC:string;					 
	Description_RU:string;					 
	Description_EN:string;					 
	TitleMessage_EN:string;					 
	TitleMessage_RU:string;					 

	public static _EntitySetName:string =  "secMessageNotificationTemplates";
	public static _EntityName:string =  "secMessageNotificationTemplate";
	public static PropertyNames: secMessageNotificationTemplatePropertyNames = new secMessageNotificationTemplatePropertyNames();
}


	


 class secMessagePropertyNames{
	constructor(){}

	Readed:string = "Readed";					 
				 
	SendedToOther:string = "SendedToOther";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	TitleMessage:string = "TitleMessage";					 
				 
	ContentMessage:string = "ContentMessage";					 
				 
	SendDate:string = "SendDate";					 
				 
	ReadDate:string = "ReadDate";					 
				 
	ToUser:string = "ToUser";					 
				 
	ToEmail:string = "ToEmail";					 
				 
	ToCC:string = "ToCC";					 
				 
	GuidMessage:string = "GuidMessage";					 
				 
	FromCompany:string = "FromCompany";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	IsDraft:string = "IsDraft";					 
				 
	IsProcessed:string = "IsProcessed";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecUser:string = "FksecUser";
		secUser:string = "secUser";
				 
		FksecUser1:string = "FksecUser1";
		secUser1:string = "secUser1";
				 
}


export  class secMessageModel{

	Readed:any;					 
	SendedToOther:any;					 
	GuidUser:string;					 
	TitleMessage:string;					 
	ContentMessage:string;					 
	SendDate:string;					 
	ReadDate:string;					 
	ToUser:string;					 
	ToEmail:string;					 
	ToCC:string;					 
	GuidMessage:string;					 
	FromCompany:string;					 
	IsDeleted:any;					 
	IsDraft:any;					 
	IsProcessed:any;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secMessages";
	public static _EntityName:string =  "secMessage";
	public static PropertyNames: secMessagePropertyNames = new secMessagePropertyNames();
}


	


 class secMessageToUserPropertyNames{
	constructor(){}

	Title:string = "Title";					 
				 
	From:string = "From";					 
				 
	DateReceived:string = "DateReceived";					 
				 
	GuidMessage:string = "GuidMessage";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	Readed:string = "Readed";					 
				 
	GuidMessageToUser:string = "GuidMessageToUser";					 
				 
	Notified:string = "Notified";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecMessage:string = "FksecMessage";
		secMessage:string = "secMessage";
				 
		FksecUser:string = "FksecUser";
		secUser:string = "secUser";
				 
}


export  class secMessageToUserModel{

	Title:string;					 
	From:string;					 
	DateReceived:string;					 
	GuidMessage:string;					 
	GuidUser:string;					 
	Readed:string;					 
	GuidMessageToUser:string;					 
	Notified:any;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secMessageToUsers";
	public static _EntityName:string =  "secMessageToUser";
	public static PropertyNames: secMessageToUserPropertyNames = new secMessageToUserPropertyNames();
}


	


 class secModulePropertyNames{
	constructor(){}

	Name:string = "Name";					 
				 
	PathModule:string = "PathModule";					 
				 
	ModuleParentId:string = "ModuleParentId";					 
				 
	TypeFullObject:string = "TypeFullObject";					 
				 
	ModuleKey:string = "ModuleKey";					 
				 
	ExtensibleInfo:string = "ExtensibleInfo";					 
				 
	ModuleNamespace:string = "ModuleNamespace";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	IsAllowed:string = "IsAllowed";					 
				 
	Name_EN:string = "Name_EN";					 
				 
	Name_ES:string = "Name_ES";					 
				 
	DescriptionShort:string = "DescriptionShort";					 
				 
	DescriptionShort_ES:string = "DescriptionShort_ES";					 
				 
	DescriptionShort_EN:string = "DescriptionShort_EN";					 
				 
	DomainApp:string = "DomainApp";					 
				 
	GuidAdminRole:string = "GuidAdminRole";					 
				 
	Slogan:string = "Slogan";					 
				 
	AllowAutoService:string = "AllowAutoService";					 
				 
	ListIDNewsletter:string = "ListIDNewsletter";					 
				 
	Langs:string = "Langs";					 
				 
	WithPublicPage:string = "WithPublicPage";					 
				 
	GuidAppTemplate:string = "GuidAppTemplate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	IsTest:string = "IsTest";					 
				 
	FaceBookAppId:string = "FaceBookAppId";					 
				 
	FacebookAppSecret:string = "FacebookAppSecret";					 
				 
	MicrosoftClientId:string = "MicrosoftClientId";					 
				 
	MicrosoftClientSecret:string = "MicrosoftClientSecret";					 
				 
	GoogleClientId:string = "GoogleClientId";					 
				 
	GoogleClientSecret:string = "GoogleClientSecret";					 
				 
	GuidAutoServiceRole:string = "GuidAutoServiceRole";					 
				 
	UsePersonalCompDefault:string = "UsePersonalCompDefault";					 
				 
	CustomDomain:string = "CustomDomain";					 
				 
	DisableCustDomainCompany:string = "DisableCustDomainCompany";					 
				 
	HomeAppPath:string = "HomeAppPath";					 
				 
	HomePublicPath:string = "HomePublicPath";					 
				 
	HomeDefaultPath:string = "HomeDefaultPath";					 
				 
	GuidCompUISetting:string = "GuidCompUISetting";					 
				 
	RecaptchaPublicKey:string = "RecaptchaPublicKey";					 
				 
	RecaptchaPrivateKey:string = "RecaptchaPrivateKey";					 
				 
	DisableThirdPartyProviders:string = "DisableThirdPartyProviders";					 
				 
	HidePlatformBrand:string = "HidePlatformBrand";					 
				 
	PreventDomainByCompany:string = "PreventDomainByCompany";					 
				 
	UseOwnUserRepo:string = "UseOwnUserRepo";					 
				 
	GuidDefaultCompany:string = "GuidDefaultCompany";					 
				 
		FksecAppTemplate:string = "FksecAppTemplate";
		secAppTemplate:string = "secAppTemplate";
				 
		FksecCompUISetting:string = "FksecCompUISetting";
		secCompUISetting:string = "secCompUISetting";
				 
		FksecRole:string = "FksecRole";
		secRole:string = "secRole";
				 
		FksecAutoserviceDefaultRole:string = "FksecAutoserviceDefaultRole";
		secAutoserviceDefaultRole:string = "secAutoserviceDefaultRole";
				 
	ComputedNumObjects:string = "ComputedNumObjects";					 
				 
	CompanyDefaultId:string = "CompanyDefaultId";					 
				 
}


export  class secModuleModel{

	Name:string;					 
	PathModule:string;					 
	ModuleParentId:number;					 
	TypeFullObject:string;					 
	ModuleKey:string;					 
	ExtensibleInfo:string;					 
	ModuleNamespace:string;					 
	GuidModule:string;					 
	IsAllowed:any;					 
	Name_EN:string;					 
	Name_ES:string;					 
	DescriptionShort:string;					 
	DescriptionShort_ES:string;					 
	DescriptionShort_EN:string;					 
	DomainApp:string;					 
	GuidAdminRole:string;					 
	Slogan:string;					 
	AllowAutoService:any;					 
	ListIDNewsletter:string;					 
	Langs:string;					 
	WithPublicPage:any;					 
	GuidAppTemplate:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	IsTest:any;					 
	FaceBookAppId:string;					 
	FacebookAppSecret:string;					 
	MicrosoftClientId:string;					 
	MicrosoftClientSecret:string;					 
	GoogleClientId:string;					 
	GoogleClientSecret:string;					 
	GuidAutoServiceRole:string;					 
	UsePersonalCompDefault:any;					 
	CustomDomain:string;					 
	DisableCustDomainCompany:any;					 
	HomeAppPath:string;					 
	HomePublicPath:string;					 
	HomeDefaultPath:string;					 
	GuidCompUISetting:string;					 
	RecaptchaPublicKey:string;					 
	RecaptchaPrivateKey:string;					 
	DisableThirdPartyProviders:any;					 
	HidePlatformBrand:any;					 
	PreventDomainByCompany:any;					 
	UseOwnUserRepo:any;					 
	GuidDefaultCompany:string;					 
	ComputedNumObjects:number;					 
	CompanyDefaultId:string;					 

	public static _EntitySetName:string =  "secModules";
	public static _EntityName:string =  "secModule";
	public static PropertyNames: secModulePropertyNames = new secModulePropertyNames();
}


	


 class secModuleObjectPermissionPropertyNames{
	constructor(){}

	GuidModule:string = "GuidModule";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	GuidPermission:string = "GuidPermission";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecPermission:string = "FksecPermission";
		secPermission:string = "secPermission";
				 
}


export  class secModuleObjectPermissionModel{

	GuidModule:string;					 
	GuidBusinessObject:string;					 
	GuidPermission:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secModuleObjectPermissions";
	public static _EntityName:string =  "secModuleObjectPermission";
	public static PropertyNames: secModuleObjectPermissionPropertyNames = new secModuleObjectPermissionPropertyNames();
}


	


 class secMoneyMovementTypePropertyNames{
	constructor(){}

	NameKey:string = "NameKey";					 
				 
	Name:string = "Name";					 
				 
	GuidMoneyMovementType:string = "GuidMoneyMovementType";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
}


export  class secMoneyMovementTypeModel{

	NameKey:string;					 
	Name:string;					 
	GuidMoneyMovementType:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secMoneyMovementTypes";
	public static _EntityName:string =  "secMoneyMovementType";
	public static PropertyNames: secMoneyMovementTypePropertyNames = new secMoneyMovementTypePropertyNames();
}


	


 class secMoneyPaymentPropertyNames{
	constructor(){}

	Name:string = "Name";					 
				 
	NameKey:string = "NameKey";					 
				 
	GuidPaymentType:string = "GuidPaymentType";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
}


export  class secMoneyPaymentModel{

	Name:string;					 
	NameKey:string;					 
	GuidPaymentType:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secMoneyPayments";
	public static _EntityName:string =  "secMoneyPayment";
	public static PropertyNames: secMoneyPaymentPropertyNames = new secMoneyPaymentPropertyNames();
}


	


 class secPaymentMethodPropertyNames{
	constructor(){}

	Name:string = "Name";					 
				 
	NameKey:string = "NameKey";					 
				 
	GuidPaymentMethod:string = "GuidPaymentMethod";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
}


export  class secPaymentMethodModel{

	Name:string;					 
	NameKey:string;					 
	GuidPaymentMethod:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secPaymentMethods";
	public static _EntityName:string =  "secPaymentMethod";
	public static PropertyNames: secPaymentMethodPropertyNames = new secPaymentMethodPropertyNames();
}


	


 class secProfilePropertyNames{
	constructor(){}

	FirstName:string = "FirstName";					 
				 
	LastName:string = "LastName";					 
				 
	LastName2:string = "LastName2";					 
				 
	ActualAddress:string = "ActualAddress";					 
				 
	BirthDay:string = "BirthDay";					 
				 
	HomePhone:string = "HomePhone";					 
				 
	WorkPhone:string = "WorkPhone";					 
				 
	MobilePhone:string = "MobilePhone";					 
				 
	Email:string = "Email";					 
				 
	WebAddress:string = "WebAddress";					 
				 
	IM_msn:string = "IM_msn";					 
				 
	IM_yahoo:string = "IM_yahoo";					 
				 
	IM_AIM:string = "IM_AIM";					 
				 
	IM_google:string = "IM_google";					 
				 
	Sex:string = "Sex";					 
				 
	ExtensibleInfo:string = "ExtensibleInfo";					 
				 
	IdCompanyFavorite:string = "IdCompanyFavorite";					 
				 
	LocalizacionFavorite:string = "LocalizacionFavorite";					 
				 
	GuidActualCountry:string = "GuidActualCountry";					 
				 
	GuidWorkCountry:string = "GuidWorkCountry";					 
				 
	GuidActualState:string = "GuidActualState";					 
				 
	GuidWorkState:string = "GuidWorkState";					 
				 
	GuidActualCity:string = "GuidActualCity";					 
				 
	GuidWorkCity:string = "GuidWorkCity";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecGeoCountry:string = "FksecGeoCountry";
		secGeoCountry:string = "secGeoCountry";
				 
		FksecGeoCountry1:string = "FksecGeoCountry1";
		secGeoCountry1:string = "secGeoCountry1";
				 
		FksecGeoCity:string = "FksecGeoCity";
		secGeoCity:string = "secGeoCity";
				 
		FksecGeoCity1:string = "FksecGeoCity1";
		secGeoCity1:string = "secGeoCity1";
				 
		FksecGeoState:string = "FksecGeoState";
		secGeoState:string = "secGeoState";
				 
		FksecGeoState1:string = "FksecGeoState1";
		secGeoState1:string = "secGeoState1";
				 
}


export  class secProfileModel{

	FirstName:string;					 
	LastName:string;					 
	LastName2:string;					 
	ActualAddress:string;					 
	BirthDay:string;					 
	HomePhone:string;					 
	WorkPhone:string;					 
	MobilePhone:string;					 
	Email:string;					 
	WebAddress:string;					 
	IM_msn:string;					 
	IM_yahoo:string;					 
	IM_AIM:string;					 
	IM_google:string;					 
	Sex:number;					 
	ExtensibleInfo:string;					 
	IdCompanyFavorite:number;					 
	LocalizacionFavorite:string;					 
	GuidActualCountry:string;					 
	GuidWorkCountry:string;					 
	GuidActualState:string;					 
	GuidWorkState:string;					 
	GuidActualCity:string;					 
	GuidWorkCity:string;					 
	GuidUser:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secProfiles";
	public static _EntityName:string =  "secProfile";
	public static PropertyNames: secProfilePropertyNames = new secProfilePropertyNames();
}


	


 class secReusableCatalogPropertyNames{
	constructor(){}

	GuidReusableCatalog:string = "GuidReusableCatalog";					 
				 
	NameKey:string = "NameKey";					 
				 
	DataType:string = "DataType";					 
				 
	Title:string = "Title";					 
				 
		FksecReusableCatalogValue:string = "FksecReusableCatalogValue";
		secReusableCatalogValue:string = "secReusableCatalogValue";
				 
}


export  class secReusableCatalogModel{

	GuidReusableCatalog:string;					 
	NameKey:string;					 
	DataType:string;					 
	Title:string;					 

	public static _EntitySetName:string =  "secReusableCatalogs";
	public static _EntityName:string =  "secReusableCatalog";
	public static PropertyNames: secReusableCatalogPropertyNames = new secReusableCatalogPropertyNames();
}


	


 class secReusableCatalogValuePropertyNames{
	constructor(){}

	GuidReusableCatalogValue:string = "GuidReusableCatalogValue";					 
				 
	GuidReusableCatalog:string = "GuidReusableCatalog";					 
				 
	ValueString:string = "ValueString";					 
				 
	ValueInt:string = "ValueInt";					 
				 
	ValueBoolean:string = "ValueBoolean";					 
				 
	ValueDecimal:string = "ValueDecimal";					 
				 
	OrderOption:string = "OrderOption";					 
				 
	Title:string = "Title";					 
				 
		FksecReusableCatalog:string = "FksecReusableCatalog";
		secReusableCatalog:string = "secReusableCatalog";
				 
}


export  class secReusableCatalogValueModel{

	GuidReusableCatalogValue:string;					 
	GuidReusableCatalog:string;					 
	ValueString:string;					 
	ValueInt:number;					 
	ValueBoolean:any;					 
	ValueDecimal:number;					 
	OrderOption:number;					 
	Title:string;					 

	public static _EntitySetName:string =  "secReusableCatalogValues";
	public static _EntityName:string =  "secReusableCatalogValue";
	public static PropertyNames: secReusableCatalogValuePropertyNames = new secReusableCatalogValuePropertyNames();
}


	


 class secRoleDataPermissionPropertyNames{
	constructor(){}

	GuidRole:string = "GuidRole";					 
				 
	GuidDataColumn:string = "GuidDataColumn";					 
				 
	GuidPermission:string = "GuidPermission";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecDataColumn:string = "FksecDataColumn";
		secDataColumn:string = "secDataColumn";
				 
		FksecRole:string = "FksecRole";
		secRole:string = "secRole";
				 
}


export  class secRoleDataPermissionModel{

	GuidRole:string;					 
	GuidDataColumn:string;					 
	GuidPermission:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secRoleDataPermissions";
	public static _EntityName:string =  "secRoleDataPermission";
	public static PropertyNames: secRoleDataPermissionPropertyNames = new secRoleDataPermissionPropertyNames();
}


	


 class secRoleModuleObjectPermissionPropertyNames{
	constructor(){}

	IsAllowed:string = "IsAllowed";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	GuidRole:string = "GuidRole";					 
				 
	GuidPermission:string = "GuidPermission";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecRole:string = "FksecRole";
		secRole:string = "secRole";
				 
		FksecPermission:string = "FksecPermission";
		secPermission:string = "secPermission";
				 
}


export  class secRoleModuleObjectPermissionModel{

	IsAllowed:any;					 
	UpdatedDate:string;					 
	CreatedDate:string;					 
	GuidModule:string;					 
	GuidBusinessObject:string;					 
	GuidRole:string;					 
	GuidPermission:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 

	public static _EntitySetName:string =  "secRoleModuleObjectPermissions";
	public static _EntityName:string =  "secRoleModuleObjectPermission";
	public static PropertyNames: secRoleModuleObjectPermissionPropertyNames = new secRoleModuleObjectPermissionPropertyNames();
}


	


 class secRoleModulePermissionPropertyNames{
	constructor(){}

	UpdatedDate:string = "UpdatedDate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	GuidRole:string = "GuidRole";					 
				 
	GuidPermission:string = "GuidPermission";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	IsAllowed:string = "IsAllowed";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecRole:string = "FksecRole";
		secRole:string = "secRole";
				 
		FksecPermission:string = "FksecPermission";
		secPermission:string = "secPermission";
				 
}


export  class secRoleModulePermissionModel{

	UpdatedDate:string;					 
	CreatedDate:string;					 
	GuidModule:string;					 
	GuidRole:string;					 
	GuidPermission:string;					 
	UpdatedBy:string;					 
	CreatedBy:string;					 
	IsAllowed:any;					 

	public static _EntitySetName:string =  "secRoleModulePermissions";
	public static _EntityName:string =  "secRoleModulePermission";
	public static PropertyNames: secRoleModulePermissionPropertyNames = new secRoleModulePermissionPropertyNames();
}


	


 class secUser_LoginProvidersPropertyNames{
	constructor(){}

	UrlProfile:string = "UrlProfile";					 
				 
	UserName:string = "UserName";					 
				 
	FavoriteName:string = "FavoriteName";					 
				 
	FirstName:string = "FirstName";					 
				 
	LastName:string = "LastName";					 
				 
	Email:string = "Email";					 
				 
	IsEmailValid:string = "IsEmailValid";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	GuidUserLoginProvider:string = "GuidUserLoginProvider";					 
				 
	GuidLoginProvider:string = "GuidLoginProvider";					 
				 
	IdUserProvider:string = "IdUserProvider";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	GuidFile:string = "GuidFile";					 
				 
	AccessToken:string = "AccessToken";					 
				 
	AvatarUrl:string = "AvatarUrl";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
		FksecLoginProvider:string = "FksecLoginProvider";
		secLoginProvider:string = "secLoginProvider";
				 
		FksecUser:string = "FksecUser";
		secUser:string = "secUser";
				 
		FksecFile:string = "FksecFile";
		secFile:string = "secFile";
				 
}


export  class secUser_LoginProvidersModel{

	UrlProfile:string;					 
	UserName:string;					 
	FavoriteName:string;					 
	FirstName:string;					 
	LastName:string;					 
	Email:string;					 
	IsEmailValid:any;					 
	GuidUser:string;					 
	GuidUserLoginProvider:string;					 
	GuidLoginProvider:string;					 
	IdUserProvider:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	GuidFile:string;					 
	AccessToken:string;					 
	AvatarUrl:string;					 
	IsDeleted:any;					 

	public static _EntitySetName:string =  "secUser_LoginProviders";
	public static _EntityName:string =  "secUser_LoginProviders";
	public static PropertyNames: secUser_LoginProvidersPropertyNames = new secUser_LoginProvidersPropertyNames();
}


	


 class secUserConfigurationPropertyNames{
	constructor(){}

	GuidUser:string = "GuidUser";					 
				 
	GuidReusableCatalog:string = "GuidReusableCatalog";					 
				 
	ValueString:string = "ValueString";					 
				 
	ValueInt:string = "ValueInt";					 
				 
	ValueBoolean:string = "ValueBoolean";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecReusableCatalog:string = "FksecReusableCatalog";
		secReusableCatalog:string = "secReusableCatalog";
				 
		FksecUser:string = "FksecUser";
		secUser:string = "secUser";
				 
}


export  class secUserConfigurationModel{

	GuidUser:string;					 
	GuidReusableCatalog:string;					 
	ValueString:string;					 
	ValueInt:number;					 
	ValueBoolean:any;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secUserConfigurations";
	public static _EntityName:string =  "secUserConfiguration";
	public static PropertyNames: secUserConfigurationPropertyNames = new secUserConfigurationPropertyNames();
}


	


 class secUserPaymentPropertyNames{
	constructor(){}

	GuidUserPayment:string = "GuidUserPayment";					 
				 
	Amount:string = "Amount";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	Comments:string = "Comments";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	GuidPaymentMethod:string = "GuidPaymentMethod";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
		FksecPaymentMethod:string = "FksecPaymentMethod";
		secPaymentMethod:string = "secPaymentMethod";
				 
		FksecUser:string = "FksecUser";
		secUser:string = "secUser";
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
}


export  class secUserPaymentModel{

	GuidUserPayment:string;					 
	Amount:number;					 
	UpdatedDate:string;					 
	CreatedDate:string;					 
	Comments:string;					 
	GuidCompany:string;					 
	GuidPaymentMethod:string;					 
	GuidUser:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 

	public static _EntitySetName:string =  "secUserPayments";
	public static _EntityName:string =  "secUserPayment";
	public static PropertyNames: secUserPaymentPropertyNames = new secUserPaymentPropertyNames();
}


	


 class secMemberModuleCompPropertyNames{
	constructor(){}

	GuidMemberModuleComp:string = "GuidMemberModuleComp";					 
				 
	GuidCompanyUse:string = "GuidCompanyUse";					 
				 
	StartDate:string = "StartDate";					 
				 
	StartDateFree:string = "StartDateFree";					 
				 
	DiscountAmount:string = "DiscountAmount";					 
				 
	DiscountPercent:string = "DiscountPercent";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	GuidMembershipModule:string = "GuidMembershipModule";					 
				 
		FksecMembershipModule:string = "FksecMembershipModule";
		secMembershipModule:string = "secMembershipModule";
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
	TrialOption:string = "TrialOption";					 
				 
	Credits:string = "Credits";					 
				 
	AcceptAgreement:string = "AcceptAgreement";					 
				 
}


export  class secMemberModuleCompModel{

	GuidMemberModuleComp:string;					 
	GuidCompanyUse:string;					 
	StartDate:string;					 
	StartDateFree:string;					 
	DiscountAmount:number;					 
	DiscountPercent:number;					 
	UpdatedDate:string;					 
	CreatedDate:string;					 
	UpdatedBy:string;					 
	CreatedBy:string;					 
	IsDeleted:any;					 
	GuidMembershipModule:string;					 
	TrialOption:string;					 
	Credits:number;					 
	AcceptAgreement:string;					 

	public static _EntitySetName:string =  "secMemberModuleComps";
	public static _EntityName:string =  "secMemberModuleComp";
	public static PropertyNames: secMemberModuleCompPropertyNames = new secMemberModuleCompPropertyNames();
}


	


 class secMemberModuleCompCoverPropertyNames{
	constructor(){}

	GuidMemModuleCompCover:string = "GuidMemModuleCompCover";					 
				 
	GuidMemberModuleComp:string = "GuidMemberModuleComp";					 
				 
	StartDate:string = "StartDate";					 
				 
	Months:string = "Months";					 
				 
	EndDate:string = "EndDate";					 
				 
	GuidMovement:string = "GuidMovement";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
		FksecMemberModuleComp:string = "FksecMemberModuleComp";
		secMemberModuleComp:string = "secMemberModuleComp";
				 
		FksecMoneyMovement:string = "FksecMoneyMovement";
		secMoneyMovement:string = "secMoneyMovement";
				 
}


export  class secMemberModuleCompCoverModel{

	GuidMemModuleCompCover:string;					 
	GuidMemberModuleComp:string;					 
	StartDate:string;					 
	Months:number;					 
	EndDate:string;					 
	GuidMovement:string;					 
	UpdatedDate:string;					 
	CreatedDate:string;					 
	UpdatedBy:string;					 
	CreatedBy:string;					 

	public static _EntitySetName:string =  "secMemberModuleCompCovers";
	public static _EntityName:string =  "secMemberModuleCompCover";
	public static PropertyNames: secMemberModuleCompCoverPropertyNames = new secMemberModuleCompCoverPropertyNames();
}


	


 class secAuditPropertyNames{
	constructor(){}

	actionkey:string = "actionkey";					 
				 
	RevisionStamp:string = "RevisionStamp";					 
				 
	ExtraInfo:string = "ExtraInfo";					 
				 
	ExtraSystemInfo:string = "ExtraSystemInfo";					 
				 
	TableName:string = "TableName";					 
				 
	Actions:string = "Actions";					 
				 
	ChangedColumns:string = "ChangedColumns";					 
				 
	OldData:string = "OldData";					 
				 
	NewData:string = "NewData";					 
				 
	AuditId:string = "AuditId";					 
				 
	BusinessObjectKey:string = "BusinessObjectKey";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	Format:string = "Format";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
	UserDef:string = "UserDef";					 
				 
	BusinessObjectName:string = "BusinessObjectName";					 
				 
}


export  class secAuditModel{

	actionkey:string;					 
	RevisionStamp:string;					 
	ExtraInfo:string;					 
	ExtraSystemInfo:string;					 
	TableName:string;					 
	Actions:string;					 
	ChangedColumns:string;					 
	OldData:string;					 
	NewData:string;					 
	AuditId:string;					 
	BusinessObjectKey:string;					 
	GuidBusinessObject:string;					 
	GuidUser:string;					 
	GuidCompany:string;					 
	Format:number;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	UserDef:string;					 
	BusinessObjectName:string;					 

	public static _EntitySetName:string =  "secAudits";
	public static _EntityName:string =  "secAudit";
	public static PropertyNames: secAuditPropertyNames = new secAuditPropertyNames();
}


	


 class secProcessQueuePropertyNames{
	constructor(){}

	GuidsecProcessQueue:string = "GuidsecProcessQueue";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	StartDateTime:string = "StartDateTime";					 
				 
	EndDateTime:string = "EndDateTime";					 
				 
	Description:string = "Description";					 
				 
	IdProcess:string = "IdProcess";					 
				 
	PercentCompleted:string = "PercentCompleted";					 
				 
	Title:string = "Title";					 
				 
	Finished:string = "Finished";					 
				 
	TypeResult:string = "TypeResult";					 
				 
	ExtraValues:string = "ExtraValues";					 
				 
	FinishedUI:string = "FinishedUI";					 
				 
}


export  class secProcessQueueModel{

	GuidsecProcessQueue:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	GuidCompany:string;					 
	IsDeleted:any;					 
	StartDateTime:string;					 
	EndDateTime:string;					 
	Description:string;					 
	IdProcess:string;					 
	PercentCompleted:number;					 
	Title:string;					 
	Finished:any;					 
	TypeResult:string;					 
	ExtraValues:string;					 
	FinishedUI:any;					 

	public static _EntitySetName:string =  "secProcessQueues";
	public static _EntityName:string =  "secProcessQueue";
	public static PropertyNames: secProcessQueuePropertyNames = new secProcessQueuePropertyNames();
}


	


 class secBizPartnerPropertyNames{
	constructor(){}

	GuidBizPartner:string = "GuidBizPartner";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	Authorized:string = "Authorized";					 
				 
		FksecUser:string = "FksecUser";
		secUser:string = "secUser";
				 
}


export  class secBizPartnerModel{

	GuidBizPartner:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	IsDeleted:any;					 
	GuidUser:string;					 
	Authorized:any;					 

	public static _EntitySetName:string =  "secBizPartners";
	public static _EntityName:string =  "secBizPartner";
	public static PropertyNames: secBizPartnerPropertyNames = new secBizPartnerPropertyNames();
}


	


 class secCouponPropertyNames{
	constructor(){}

	GuidCoupon:string = "GuidCoupon";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	GuidBizPartner:string = "GuidBizPartner";					 
				 
	ExpirationDate:string = "ExpirationDate";					 
				 
	CouponCode:string = "CouponCode";					 
				 
	IsReusable:string = "IsReusable";					 
				 
	UseLimit:string = "UseLimit";					 
				 
	Price:string = "Price";					 
				 
	FreeCredits:string = "FreeCredits";					 
				 
	PercentDiscount:string = "PercentDiscount";					 
				 
	GuidCouponType:string = "GuidCouponType";					 
				 
		FksecBizPartner:string = "FksecBizPartner";
		secBizPartner:string = "secBizPartner";
				 
		FksecReusableCatalogValue:string = "FksecReusableCatalogValue";
		secReusableCatalogValue:string = "secReusableCatalogValue";
				 
}


export  class secCouponModel{

	GuidCoupon:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	IsDeleted:any;					 
	GuidBizPartner:string;					 
	ExpirationDate:string;					 
	CouponCode:string;					 
	IsReusable:any;					 
	UseLimit:number;					 
	Price:number;					 
	FreeCredits:number;					 
	PercentDiscount:number;					 
	GuidCouponType:string;					 

	public static _EntitySetName:string =  "secCoupons";
	public static _EntityName:string =  "secCoupon";
	public static PropertyNames: secCouponPropertyNames = new secCouponPropertyNames();
}


	


 class secMoneyMovementPropertyNames{
	constructor(){}

	ChargeOrPayment:string = "ChargeOrPayment";					 
				 
	Amount:string = "Amount";					 
				 
	Comments:string = "Comments";					 
				 
	GuidMovement:string = "GuidMovement";					 
				 
	DateMovement:string = "DateMovement";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	GuidUserPayment:string = "GuidUserPayment";					 
				 
	GuidCompanyAdd:string = "GuidCompanyAdd";					 
				 
	GuidCompanyCharge:string = "GuidCompanyCharge";					 
				 
	GuidUserCharge:string = "GuidUserCharge";					 
				 
	GuidUserAdd:string = "GuidUserAdd";					 
				 
	GuidMoneyMovementType:string = "GuidMoneyMovementType";					 
				 
		FksecMoneyMovementType:string = "FksecMoneyMovementType";
		secMoneyMovementType:string = "secMoneyMovementType";
				 
		FksecUserPayment:string = "FksecUserPayment";
		secUserPayment:string = "secUserPayment";
				 
		FksecUser:string = "FksecUser";
		secUser:string = "secUser";
				 
		FksecUser1:string = "FksecUser1";
		secUser1:string = "secUser1";
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
		FksecCompany1:string = "FksecCompany1";
		secCompany1:string = "secCompany1";
				 
}


export  class secMoneyMovementModel{

	ChargeOrPayment:string;					 
	Amount:number;					 
	Comments:string;					 
	GuidMovement:string;					 
	DateMovement:string;					 
	UpdatedDate:string;					 
	UpdatedBy:string;					 
	CreatedBy:string;					 
	CreatedDate:string;					 
	GuidUserPayment:string;					 
	GuidCompanyAdd:string;					 
	GuidCompanyCharge:string;					 
	GuidUserCharge:string;					 
	GuidUserAdd:string;					 
	GuidMoneyMovementType:string;					 

	public static _EntitySetName:string =  "secMoneyMovements";
	public static _EntityName:string =  "secMoneyMovement";
	public static PropertyNames: secMoneyMovementPropertyNames = new secMoneyMovementPropertyNames();
}


	


 class secUserPropertyNames{
	constructor(){}

	UserName:string = "UserName";					 
				 
	FirstName:string = "FirstName";					 
				 
	LastName:string = "LastName";					 
				 
	Email:string = "Email";					 
				 
	AutogeneratePassword:string = "AutogeneratePassword";					 
				 
	SendPassword:string = "SendPassword";					 
				 
	DisplayName:string = "DisplayName";					 
				 
	UserId:string = "UserId";					 
				 
	LoweredUserName:string = "LoweredUserName";					 
				 
	IsAnonymous:string = "IsAnonymous";					 
				 
	LastActivityDate:string = "LastActivityDate";					 
				 
	Password:string = "Password";					 
				 
	ExtensibleInfo:string = "ExtensibleInfo";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	EmailVerified:string = "EmailVerified";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	GuidFilePhoto:string = "GuidFilePhoto";					 
				 
	Bio:string = "Bio";					 
				 
	IsInvited:string = "IsInvited";					 
				 
	EmailCodeVerirication:string = "EmailCodeVerirication";					 
				 
	ENewsLetterSync:string = "ENewsLetterSync";					 
				 
	Lang:string = "Lang";					 
				 
	CountryCode:string = "CountryCode";					 
				 
	IntegrationID:string = "IntegrationID";					 
				 
	GuidAddedBy:string = "GuidAddedBy";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	Token:string = "Token";					 
				 
	TimeZoneId:string = "TimeZoneId";					 
				 
		FksecFile:string = "FksecFile";
		secFile:string = "secFile";
				 
		FkAddedBy:string = "FkAddedBy";
		AddedBy:string = "AddedBy";
				 
	ExistFile:string = "ExistFile";					 
				 
	GuidSecFile:string = "GuidSecFile";					 
				 
	UrlImage:string = "UrlImage";					 
				 
	NumRoles:string = "NumRoles";					 
				 
	FullName:string = "FullName";					 
				 
	InitialEmail:string = "InitialEmail";					 
				 
	InitialUserName:string = "InitialUserName";					 
				 
	TotalCredit:string = "TotalCredit";					 
				 
}


export  class secUserModel{

	UserName:string;					 
	FirstName:string;					 
	LastName:string;					 
	Email:string;					 
	AutogeneratePassword:any;					 
	SendPassword:any;					 
	DisplayName:string;					 
	UserId:string;					 
	LoweredUserName:string;					 
	IsAnonymous:any;					 
	LastActivityDate:string;					 
	Password:string;					 
	ExtensibleInfo:string;					 
	UpdatedDate:string;					 
	CreatedDate:string;					 
	EmailVerified:any;					 
	GuidUser:string;					 
	UpdatedBy:string;					 
	CreatedBy:string;					 
	GuidFilePhoto:string;					 
	Bio:string;					 
	IsInvited:any;					 
	EmailCodeVerirication:string;					 
	ENewsLetterSync:any;					 
	Lang:string;					 
	CountryCode:string;					 
	IntegrationID:string;					 
	GuidAddedBy:string;					 
	IsDeleted:any;					 
	Token:string;					 
	TimeZoneId:string;					 
	ExistFile:any;					 
	GuidSecFile:string;					 
	UrlImage:string;					 
	NumRoles:number;					 
	FullName:string;					 
	InitialEmail:string;					 
	InitialUserName:string;					 
	TotalCredit:number;					 

	public static _EntitySetName:string =  "secUsers";
	public static _EntityName:string =  "secUser";
	public static PropertyNames: secUserPropertyNames = new secUserPropertyNames();
}


	


 class secUserCompanyPropertyNames{
	constructor(){}

	GuidCompany:string = "GuidCompany";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	GuidUserCompany:string = "GuidUserCompany";					 
				 
	CompanyAccepted:string = "CompanyAccepted";					 
				 
	Useraccepted:string = "Useraccepted";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	CompanyUser:string = "CompanyUser";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	Disabled:string = "Disabled";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	GuidRole:string = "GuidRole";					 
				 
	LastSelectedDate:string = "LastSelectedDate";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	ENewsLetterSync:string = "ENewsLetterSync";					 
				 
	TotalItems:string = "TotalItems";					 
				 
	UpdatedDateTotalItems:string = "UpdatedDateTotalItems";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	NewNotifications:string = "NewNotifications";					 
				 
	TotalNotifications:string = "TotalNotifications";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecUser:string = "FksecUser";
		secUser:string = "secUser";
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
		FksecRole:string = "FksecRole";
		secRole:string = "secRole";
				 
	UserOwner:string = "UserOwner";					 
				 
	IsForTest:string = "IsForTest";					 
				 
	ForTestPattern:string = "ForTestPattern";					 
				 
	ForTestNumber:string = "ForTestNumber";					 
				 
	UserGuidFile:string = "UserGuidFile";					 
				 
	Email:string = "Email";					 
				 
	CompanyGuidFile:string = "CompanyGuidFile";					 
				 
	SetInitialData:string = "SetInitialData";					 
				 
	FirstName:string = "FirstName";					 
				 
	LastName:string = "LastName";					 
				 
	Password:string = "Password";					 
				 
	AppNameKey:string = "AppNameKey";					 
				 
}


export  class secUserCompanyModel{

	GuidCompany:string;					 
	GuidUser:string;					 
	GuidUserCompany:string;					 
	CompanyAccepted:any;					 
	Useraccepted:any;					 
	CreatedBy:string;					 
	CompanyUser:string;					 
	CreatedDate:string;					 
	Disabled:any;					 
	IsDeleted:any;					 
	GuidRole:string;					 
	LastSelectedDate:string;					 
	GuidModule:string;					 
	ENewsLetterSync:any;					 
	TotalItems:number;					 
	UpdatedDateTotalItems:string;					 
	UpdatedDate:string;					 
	NewNotifications:number;					 
	TotalNotifications:number;					 
	UserOwner:string;					 
	IsForTest:any;					 
	ForTestPattern:string;					 
	ForTestNumber:number;					 
	UserGuidFile:string;					 
	Email:string;					 
	CompanyGuidFile:string;					 
	SetInitialData:any;					 
	FirstName:string;					 
	LastName:string;					 
	Password:string;					 
	AppNameKey:string;					 

	public static _EntitySetName:string =  "secUserCompanies";
	public static _EntityName:string =  "secUserCompany";
	public static PropertyNames: secUserCompanyPropertyNames = new secUserCompanyPropertyNames();
}


	


 class secFilterQueryPropertyNames{
	constructor(){}

	Title:string = "Title";					 
				 
	QueryLinq:string = "QueryLinq";					 
				 
	HtmlContent:string = "HtmlContent";					 
				 
	IsShared:string = "IsShared";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	UseMode:string = "UseMode";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	GuidFilterQuery:string = "GuidFilterQuery";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
	QueryDisplay:string = "QueryDisplay";					 
				 
}


export  class secFilterQueryModel{

	Title:string;					 
	QueryLinq:string;					 
	HtmlContent:string;					 
	IsShared:any;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	UseMode:string;					 
	GuidBusinessObject:string;					 
	GuidFilterQuery:string;					 
	GuidCompany:string;					 
	QueryDisplay:string;					 

	public static _EntitySetName:string =  "secFilterQueries";
	public static _EntityName:string =  "secFilterQuery";
	public static PropertyNames: secFilterQueryPropertyNames = new secFilterQueryPropertyNames();
}


	


 class secModComOptionPropertyNames{
	constructor(){}

	GuidModCompOption:string = "GuidModCompOption";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	ValueInt:string = "ValueInt";					 
				 
	ValueString:string = "ValueString";					 
				 
	ValueBoolean:string = "ValueBoolean";					 
				 
	ValueDecimal:string = "ValueDecimal";					 
				 
	ValueDateTime:string = "ValueDateTime";					 
				 
	GuidModuleOption:string = "GuidModuleOption";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecModuleOption:string = "FksecModuleOption";
		secModuleOption:string = "secModuleOption";
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
}


export  class secModComOptionModel{

	GuidModCompOption:string;					 
	GuidCompany:string;					 
	ValueInt:number;					 
	ValueString:string;					 
	ValueBoolean:any;					 
	ValueDecimal:number;					 
	ValueDateTime:string;					 
	GuidModuleOption:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secModComOptions";
	public static _EntityName:string =  "secModComOption";
	public static PropertyNames: secModComOptionPropertyNames = new secModComOptionPropertyNames();
}


	


 class secModuleOptionPropertyNames{
	constructor(){}

	GuidModuleOption:string = "GuidModuleOption";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	Name:string = "Name";					 
				 
	NameKey:string = "NameKey";					 
				 
	OptionDataType:string = "OptionDataType";					 
				 
	DefaultValueString:string = "DefaultValueString";					 
				 
	DefaultValueDecimal:string = "DefaultValueDecimal";					 
				 
	DefaultValueDateTime:string = "DefaultValueDateTime";					 
				 
	DefaultValueBoolean:string = "DefaultValueBoolean";					 
				 
	DefaultValueInt:string = "DefaultValueInt";					 
				 
	Description:string = "Description";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
}


export  class secModuleOptionModel{

	GuidModuleOption:string;					 
	GuidModule:string;					 
	Name:string;					 
	NameKey:string;					 
	OptionDataType:string;					 
	DefaultValueString:string;					 
	DefaultValueDecimal:number;					 
	DefaultValueDateTime:string;					 
	DefaultValueBoolean:any;					 
	DefaultValueInt:number;					 
	Description:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secModuleOptions";
	public static _EntityName:string =  "secModuleOption";
	public static PropertyNames: secModuleOptionPropertyNames = new secModuleOptionPropertyNames();
}


	


 class secGeoCityPropertyNames{
	constructor(){}

	Name:string = "Name";					 
				 
	OtherNames:string = "OtherNames";					 
				 
	GuidState:string = "GuidState";					 
				 
	GuidCity:string = "GuidCity";					 
				 
	GeonameId:string = "GeonameId";					 
				 
	Asciiname:string = "Asciiname";					 
				 
	Latitude:string = "Latitude";					 
				 
	Longitude:string = "Longitude";					 
				 
	Timezone:string = "Timezone";					 
				 
	SyncDate:string = "SyncDate";					 
				 
	AdminCode1:string = "AdminCode1";					 
				 
	Fcode:string = "Fcode";					 
				 
	CountryCode:string = "CountryCode";					 
				 
	Children:string = "Children";					 
				 
	ToponymName:string = "ToponymName";					 
				 
	AdminName1:string = "AdminName1";					 
				 
	GuidParent:string = "GuidParent";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	AdminCode2:string = "AdminCode2";					 
				 
	AdminCode3:string = "AdminCode3";					 
				 
	PostalCode:string = "PostalCode";					 
				 
	Population:string = "Population";					 
				 
		FksecGeoState:string = "FksecGeoState";
		secGeoState:string = "secGeoState";
				 
		FkParentCity:string = "FkParentCity";
		ParentCity:string = "ParentCity";
				 
}


export  class secGeoCityModel{

	Name:string;					 
	OtherNames:string;					 
	GuidState:string;					 
	GuidCity:string;					 
	GeonameId:number;					 
	Asciiname:string;					 
	Latitude:string;					 
	Longitude:string;					 
	Timezone:string;					 
	SyncDate:string;					 
	AdminCode1:string;					 
	Fcode:string;					 
	CountryCode:string;					 
	Children:number;					 
	ToponymName:string;					 
	AdminName1:string;					 
	GuidParent:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	AdminCode2:string;					 
	AdminCode3:string;					 
	PostalCode:string;					 
	Population:number;					 

	public static _EntitySetName:string =  "secGeoCities";
	public static _EntityName:string =  "secGeoCity";
	public static PropertyNames: secGeoCityPropertyNames = new secGeoCityPropertyNames();
}


	


 class secGeoStatePropertyNames{
	constructor(){}

	Name:string = "Name";					 
				 
	OtherNames:string = "OtherNames";					 
				 
	Code:string = "Code";					 
				 
	GuidCountry:string = "GuidCountry";					 
				 
	GuidState:string = "GuidState";					 
				 
	GeonameId:string = "GeonameId";					 
				 
	Asciiname:string = "Asciiname";					 
				 
	Latitude:string = "Latitude";					 
				 
	Longitude:string = "Longitude";					 
				 
	Timezone:string = "Timezone";					 
				 
	ModificationDate:string = "ModificationDate";					 
				 
	SyncDate:string = "SyncDate";					 
				 
	Children:string = "Children";					 
				 
	ToponymName:string = "ToponymName";					 
				 
	AdminName1:string = "AdminName1";					 
				 
	CountryCode:string = "CountryCode";					 
				 
	AdminCode1:string = "AdminCode1";					 
				 
	Fcode:string = "Fcode";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecGeoCountry:string = "FksecGeoCountry";
		secGeoCountry:string = "secGeoCountry";
				 
}


export  class secGeoStateModel{

	Name:string;					 
	OtherNames:string;					 
	Code:string;					 
	GuidCountry:string;					 
	GuidState:string;					 
	GeonameId:number;					 
	Asciiname:string;					 
	Latitude:string;					 
	Longitude:string;					 
	Timezone:string;					 
	ModificationDate:string;					 
	SyncDate:string;					 
	Children:number;					 
	ToponymName:string;					 
	AdminName1:string;					 
	CountryCode:string;					 
	AdminCode1:string;					 
	Fcode:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secGeoStates";
	public static _EntityName:string =  "secGeoState";
	public static PropertyNames: secGeoStatePropertyNames = new secGeoStatePropertyNames();
}


	


 class secCompanyPropertyNames{
	constructor(){}

	Name:string = "Name";					 
				 
	GuidCompanyType:string = "GuidCompanyType";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	CompanyParentGuid:string = "CompanyParentGuid";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	GuidFileLogo:string = "GuidFileLogo";					 
				 
	GuidCountry:string = "GuidCountry";					 
				 
	GuidState:string = "GuidState";					 
				 
	GuidCity:string = "GuidCity";					 
				 
	GuidUserOwner:string = "GuidUserOwner";					 
				 
	Description:string = "Description";					 
				 
	CanChildMoreChildren:string = "CanChildMoreChildren";					 
				 
	CanChildsAdminRoles:string = "CanChildsAdminRoles";					 
				 
	IntegrationID:string = "IntegrationID";					 
				 
	TimeZoneNameID:string = "TimeZoneNameID";					 
				 
	ColorPrimary:string = "ColorPrimary";					 
				 
	ColorBGApp:string = "ColorBGApp";					 
				 
	ColorBGForm:string = "ColorBGForm";					 
				 
	HidePlatformBrand:string = "HidePlatformBrand";					 
				 
	CustomDomain:string = "CustomDomain";					 
				 
	CustomEmailSender:string = "CustomEmailSender";					 
				 
	NameKey:string = "NameKey";					 
				 
	GuidCompUISetting:string = "GuidCompUISetting";					 
				 
		FkParent:string = "FkParent";
		Parent:string = "Parent";
				 
		FksecCompanyType:string = "FksecCompanyType";
		secCompanyType:string = "secCompanyType";
				 
		FksecFile:string = "FksecFile";
		secFile:string = "secFile";
				 
		FksecUser:string = "FksecUser";
		secUser:string = "secUser";
				 
		FksecCompUISetting:string = "FksecCompUISetting";
		secCompUISetting:string = "secCompUISetting";
				 
	NumModules:string = "NumModules";					 
				 
	ChildrenComputed:string = "ChildrenComputed";					 
				 
	NumUserRolesComputed:string = "NumUserRolesComputed";					 
				 
	ContainModules:string = "ContainModules";					 
				 
	UsedSpaceComputed:string = "UsedSpaceComputed";					 
				 
	UsedSpaceText:string = "UsedSpaceText";					 
				 
	UsedSpacePercent:string = "UsedSpacePercent";					 
				 
	AppNameKeys:string = "AppNameKeys";					 
				 
	QtyUsers:string = "QtyUsers";					 
				 
	ExistImage:string = "ExistImage";					 
				 
	GuidSecFile:string = "GuidSecFile";					 
				 
}


export  class secCompanyModel{

	Name:string;					 
	GuidCompanyType:string;					 
	GuidCompany:string;					 
	CompanyParentGuid:string;					 
	UpdatedDate:string;					 
	CreatedDate:string;					 
	UpdatedBy:string;					 
	CreatedBy:string;					 
	IsDeleted:any;					 
	GuidFileLogo:string;					 
	GuidCountry:string;					 
	GuidState:string;					 
	GuidCity:string;					 
	GuidUserOwner:string;					 
	Description:string;					 
	CanChildMoreChildren:any;					 
	CanChildsAdminRoles:any;					 
	IntegrationID:string;					 
	TimeZoneNameID:string;					 
	ColorPrimary:string;					 
	ColorBGApp:string;					 
	ColorBGForm:string;					 
	HidePlatformBrand:any;					 
	CustomDomain:string;					 
	CustomEmailSender:string;					 
	NameKey:string;					 
	GuidCompUISetting:string;					 
	NumModules:number;					 
	ChildrenComputed:number;					 
	NumUserRolesComputed:number;					 
	ContainModules:any;					 
	UsedSpaceComputed:string;					 
	UsedSpaceText:string;					 
	UsedSpacePercent:number;					 
	AppNameKeys:string;					 
	QtyUsers:number;					 
	ExistImage:any;					 
	GuidSecFile:string;					 

	public static _EntitySetName:string =  "secCompanies";
	public static _EntityName:string =  "secCompany";
	public static PropertyNames: secCompanyPropertyNames = new secCompanyPropertyNames();
}


	


 class secEventAppPropertyNames{
	constructor(){}

	GuidEventApp:string = "GuidEventApp";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	NameKey:string = "NameKey";					 
				 
	Name:string = "Name";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
}


export  class secEventAppModel{

	GuidEventApp:string;					 
	GuidModule:string;					 
	NameKey:string;					 
	Name:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secEventApps";
	public static _EntityName:string =  "secEventApp";
	public static PropertyNames: secEventAppPropertyNames = new secEventAppPropertyNames();
}


	


 class secEventNotifyPropertyNames{
	constructor(){}

	GuidEventNotify:string = "GuidEventNotify";					 
				 
	GuidEventApp:string = "GuidEventApp";					 
				 
	Conditions:string = "Conditions";					 
				 
	Title:string = "Title";					 
				 
	Enabled:string = "Enabled";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecEventApp:string = "FksecEventApp";
		secEventApp:string = "secEventApp";
				 
}


export  class secEventNotifyModel{

	GuidEventNotify:string;					 
	GuidEventApp:string;					 
	Conditions:string;					 
	Title:string;					 
	Enabled:any;					 
	GuidCompany:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secEventNotifies";
	public static _EntityName:string =  "secEventNotify";
	public static PropertyNames: secEventNotifyPropertyNames = new secEventNotifyPropertyNames();
}


	


 class secEventNotifyToPropertyNames{
	constructor(){}

	GuidEventNotifyTo:string = "GuidEventNotifyTo";					 
				 
	GuidEventNotify:string = "GuidEventNotify";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	Email:string = "Email";					 
				 
	GuidDestinataryType:string = "GuidDestinataryType";					 
				 
	GuidMessageTemplate:string = "GuidMessageTemplate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecEventNotify:string = "FksecEventNotify";
		secEventNotify:string = "secEventNotify";
				 
		FksecReusableCatalogValue:string = "FksecReusableCatalogValue";
		secReusableCatalogValue:string = "secReusableCatalogValue";
				 
}


export  class secEventNotifyToModel{

	GuidEventNotifyTo:string;					 
	GuidEventNotify:string;					 
	GuidUser:string;					 
	Email:string;					 
	GuidDestinataryType:string;					 
	GuidMessageTemplate:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secEventNotifyTos";
	public static _EntityName:string =  "secEventNotifyTo";
	public static PropertyNames: secEventNotifyToPropertyNames = new secEventNotifyToPropertyNames();
}


	


 class secFeaurePricePropertyNames{
	constructor(){}

	GuidFeatureConcept:string = "GuidFeatureConcept";					 
				 
	GuidFeaturePrice:string = "GuidFeaturePrice";					 
				 
	Min:string = "Min";					 
				 
	Max:string = "Max";					 
				 
	Price:string = "Price";					 
				 
	Price_USD:string = "Price_USD";					 
				 
	Price_MXN:string = "Price_MXN";					 
				 
	PriceBy_ES:string = "PriceBy_ES";					 
				 
	PriceBy:string = "PriceBy";					 
				 
	PriceBy_EN:string = "PriceBy_EN";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecFeatureConcept:string = "FksecFeatureConcept";
		secFeatureConcept:string = "secFeatureConcept";
				 
}


export  class secFeaurePriceModel{

	GuidFeatureConcept:string;					 
	GuidFeaturePrice:string;					 
	Min:number;					 
	Max:number;					 
	Price:number;					 
	Price_USD:number;					 
	Price_MXN:number;					 
	PriceBy_ES:string;					 
	PriceBy:string;					 
	PriceBy_EN:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secFeaurePrices";
	public static _EntityName:string =  "secFeaurePrice";
	public static PropertyNames: secFeaurePricePropertyNames = new secFeaurePricePropertyNames();
}


	


 class secMemLevelFeaturePropertyNames{
	constructor(){}

	GuidFeatureConcept:string = "GuidFeatureConcept";					 
				 
	GuidMembershipLevel:string = "GuidMembershipLevel";					 
				 
	GuidMemLevelFeature:string = "GuidMemLevelFeature";					 
				 
	ValueBoolean:string = "ValueBoolean";					 
				 
	ValueInt:string = "ValueInt";					 
				 
	ValueUnlimited:string = "ValueUnlimited";					 
				 
	ValueLimited:string = "ValueLimited";					 
				 
	ValueDecimal:string = "ValueDecimal";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecMembershipLevel:string = "FksecMembershipLevel";
		secMembershipLevel:string = "secMembershipLevel";
				 
		FksecFeatureConcept:string = "FksecFeatureConcept";
		secFeatureConcept:string = "secFeatureConcept";
				 
}


export  class secMemLevelFeatureModel{

	GuidFeatureConcept:string;					 
	GuidMembershipLevel:string;					 
	GuidMemLevelFeature:string;					 
	ValueBoolean:any;					 
	ValueInt:number;					 
	ValueUnlimited:any;					 
	ValueLimited:any;					 
	ValueDecimal:number;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secMemLevelFeatures";
	public static _EntityName:string =  "secMemLevelFeature";
	public static PropertyNames: secMemLevelFeaturePropertyNames = new secMemLevelFeaturePropertyNames();
}


	


 class secFeatureConceptPropertyNames{
	constructor(){}

	GuidFeatureConcept:string = "GuidFeatureConcept";					 
				 
	Name:string = "Name";					 
				 
	Name_ES:string = "Name_ES";					 
				 
	Name_EN:string = "Name_EN";					 
				 
	NameKey:string = "NameKey";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	Price_USD:string = "Price_USD";					 
				 
	Price_MXN:string = "Price_MXN";					 
				 
	Price:string = "Price";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
	DiscountForCompany:string = "DiscountForCompany";					 
				 
}


export  class secFeatureConceptModel{

	GuidFeatureConcept:string;					 
	Name:string;					 
	Name_ES:string;					 
	Name_EN:string;					 
	NameKey:string;					 
	GuidModule:string;					 
	Price_USD:number;					 
	Price_MXN:number;					 
	Price:number;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	DiscountForCompany:number;					 

	public static _EntitySetName:string =  "secFeatureConcepts";
	public static _EntityName:string =  "secFeatureConcept";
	public static PropertyNames: secFeatureConceptPropertyNames = new secFeatureConceptPropertyNames();
}


	


 class secIssuePropertyNames{
	constructor(){}

	GuidIssue:string = "GuidIssue";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	Title:string = "Title";					 
				 
	Description:string = "Description";					 
				 
	GuidUserReported:string = "GuidUserReported";					 
				 
	GuidUserAsigned:string = "GuidUserAsigned";					 
				 
	GuidIssueType:string = "GuidIssueType";					 
				 
	GuidIssueLevel:string = "GuidIssueLevel";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	Public:string = "Public";					 
				 
	GuidIssueRelated:string = "GuidIssueRelated";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	GuidStatus:string = "GuidStatus";					 
				 
	Num:string = "Num";					 
				 
	ErrorStartMethod:string = "ErrorStartMethod";					 
				 
	ErrorStartFile:string = "ErrorStartFile";					 
				 
	ErrorStartLine:string = "ErrorStartLine";					 
				 
	ErrorEndMethod:string = "ErrorEndMethod";					 
				 
	ErrorEndFile:string = "ErrorEndFile";					 
				 
	ErrorEndLine:string = "ErrorEndLine";					 
				 
	ErrorTypeException:string = "ErrorTypeException";					 
				 
	ErrorFirstMessage:string = "ErrorFirstMessage";					 
				 
	ErrorOccurrences:string = "ErrorOccurrences";					 
				 
	ErrorStartInstanceName:string = "ErrorStartInstanceName";					 
				 
	ErrorEndInstanceName:string = "ErrorEndInstanceName";					 
				 
	CommentOfIssue:string = "CommentOfIssue";					 
				 
	Priority:string = "Priority";					 
				 
	GuidReusable_RepositoryCode:string = "GuidReusable_RepositoryCode";					 
				 
	RepoRevisionNum:string = "RepoRevisionNum";					 
				 
	RepoID:string = "RepoID";					 
				 
	TimeEstimated:string = "TimeEstimated";					 
				 
	TimeReal:string = "TimeReal";					 
				 
	ProduceCost:string = "ProduceCost";					 
				 
	GuidCompanyOwner:string = "GuidCompanyOwner";					 
				 
	GuidUserAcepted:string = "GuidUserAcepted";					 
				 
	Progress:string = "Progress";					 
				 
	DateStarted:string = "DateStarted";					 
				 
	DateEnded:string = "DateEnded";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
		FksecIssue1:string = "FksecIssue1";
		secIssue1:string = "secIssue1";
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecReusableIssueLevel:string = "FksecReusableIssueLevel";
		secReusableIssueLevel:string = "secReusableIssueLevel";
				 
		FksecReusableIssueType:string = "FksecReusableIssueType";
		secReusableIssueType:string = "secReusableIssueType";
				 
		FksecReusableStatus:string = "FksecReusableStatus";
		secReusableStatus:string = "secReusableStatus";
				 
		FkReusableRepositoryCode:string = "FkReusableRepositoryCode";
		ReusableRepositoryCode:string = "ReusableRepositoryCode";
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
		FksecUserAccepted:string = "FksecUserAccepted";
		secUserAccepted:string = "secUserAccepted";
				 
	ComputedVotes:string = "ComputedVotes";					 
				 
	ComputedNumberVotes:string = "ComputedNumberVotes";					 
				 
	TimeCustom:string = "TimeCustom";					 
				 
}


export  class secIssueModel{

	GuidIssue:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	IsDeleted:any;					 
	Title:string;					 
	Description:string;					 
	GuidUserReported:string;					 
	GuidUserAsigned:string;					 
	GuidIssueType:string;					 
	GuidIssueLevel:string;					 
	GuidModule:string;					 
	Public:any;					 
	GuidIssueRelated:string;					 
	GuidBusinessObject:string;					 
	GuidStatus:string;					 
	Num:number;					 
	ErrorStartMethod:string;					 
	ErrorStartFile:string;					 
	ErrorStartLine:number;					 
	ErrorEndMethod:string;					 
	ErrorEndFile:string;					 
	ErrorEndLine:number;					 
	ErrorTypeException:string;					 
	ErrorFirstMessage:string;					 
	ErrorOccurrences:number;					 
	ErrorStartInstanceName:string;					 
	ErrorEndInstanceName:string;					 
	CommentOfIssue:string;					 
	Priority:number;					 
	GuidReusable_RepositoryCode:string;					 
	RepoRevisionNum:number;					 
	RepoID:string;					 
	TimeEstimated:number;					 
	TimeReal:number;					 
	ProduceCost:any;					 
	GuidCompanyOwner:string;					 
	GuidUserAcepted:string;					 
	Progress:number;					 
	DateStarted:string;					 
	DateEnded:string;					 
	ComputedVotes:number;					 
	ComputedNumberVotes:number;					 
	TimeCustom:string;					 

	public static _EntitySetName:string =  "secIssues";
	public static _EntityName:string =  "secIssue";
	public static PropertyNames: secIssuePropertyNames = new secIssuePropertyNames();
}


	


 class secIssueVotePropertyNames{
	constructor(){}

	GuidIssueVote:string = "GuidIssueVote";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	VoteValue:string = "VoteValue";					 
				 
	Comments:string = "Comments";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	GuidIssue:string = "GuidIssue";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecIssue:string = "FksecIssue";
		secIssue:string = "secIssue";
				 
}


export  class secIssueVoteModel{

	GuidIssueVote:string;					 
	CreatedDate:string;					 
	CreatedBy:string;					 
	VoteValue:any;					 
	Comments:string;					 
	GuidUser:string;					 
	GuidIssue:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secIssueVotes";
	public static _EntityName:string =  "secIssueVote";
	public static PropertyNames: secIssueVotePropertyNames = new secIssueVotePropertyNames();
}


	


 class secIssueRelationPropertyNames{
	constructor(){}

	GuidIssueRelation:string = "GuidIssueRelation";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	GuidIssue:string = "GuidIssue";					 
				 
	GuidIssueOther:string = "GuidIssueOther";					 
				 
	GuidStatus:string = "GuidStatus";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecIssue:string = "FksecIssue";
		secIssue:string = "secIssue";
				 
		FksecIssueOther:string = "FksecIssueOther";
		secIssueOther:string = "secIssueOther";
				 
		FksecReusableStatus:string = "FksecReusableStatus";
		secReusableStatus:string = "secReusableStatus";
				 
}


export  class secIssueRelationModel{

	GuidIssueRelation:string;					 
	CreatedDate:string;					 
	CreatedBy:string;					 
	IsDeleted:any;					 
	GuidIssue:string;					 
	GuidIssueOther:string;					 
	GuidStatus:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secIssueRelations";
	public static _EntityName:string =  "secIssueRelation";
	public static PropertyNames: secIssueRelationPropertyNames = new secIssueRelationPropertyNames();
}


	


 class secBizObjPropertyPropertyNames{
	constructor(){}

	GuidBizObjProperty:string = "GuidBizObjProperty";					 
				 
	Name:string = "Name";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
}


export  class secBizObjPropertyModel{

	GuidBizObjProperty:string;					 
	Name:string;					 
	GuidBusinessObject:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secBizObjProperties";
	public static _EntityName:string =  "secBizObjProperty";
	public static PropertyNames: secBizObjPropertyPropertyNames = new secBizObjPropertyPropertyNames();
}


	


 class secEventLogPropertyNames{
	constructor(){}

	CreatedDate:string = "CreatedDate";					 
				 
	Message:string = "Message";					 
				 
	Category:string = "Category";					 
				 
	Title:string = "Title";					 
				 
	ProcessId:string = "ProcessId";					 
				 
	Win32ThreadId:string = "Win32ThreadId";					 
				 
	IsException:string = "IsException";					 
				 
	GuidMyEventLog:string = "GuidMyEventLog";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	GuidCompanyLog:string = "GuidCompanyLog";					 
				 
	Url:string = "Url";					 
				 
	IsAjaxRequest:string = "IsAjaxRequest";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	ActionTypeKey:string = "ActionTypeKey";					 
				 
	IPClient:string = "IPClient";					 
				 
	BrowserType:string = "BrowserType";					 
				 
	BrowserLanguages:string = "BrowserLanguages";					 
				 
	GuidIssue:string = "GuidIssue";					 
				 
	QueryString:string = "QueryString";					 
				 
	UrlReferrer:string = "UrlReferrer";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
		FksecIssue:string = "FksecIssue";
		secIssue:string = "secIssue";
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
	UserDef:string = "UserDef";					 
				 
}


export  class secEventLogModel{

	CreatedDate:string;					 
	Message:string;					 
	Category:number;					 
	Title:string;					 
	ProcessId:string;					 
	Win32ThreadId:string;					 
	IsException:any;					 
	GuidMyEventLog:string;					 
	CreatedBy:string;					 
	GuidModule:string;					 
	GuidCompanyLog:string;					 
	Url:string;					 
	IsAjaxRequest:any;					 
	GuidBusinessObject:string;					 
	ActionTypeKey:string;					 
	IPClient:string;					 
	BrowserType:string;					 
	BrowserLanguages:string;					 
	GuidIssue:string;					 
	QueryString:string;					 
	UrlReferrer:string;					 
	UpdatedDate:string;					 
	UserDef:string;					 

	public static _EntitySetName:string =  "secEventLogs";
	public static _EntityName:string =  "secEventLog";
	public static PropertyNames: secEventLogPropertyNames = new secEventLogPropertyNames();
}


	


 class secSyncMatchPropertyPropertyNames{
	constructor(){}

	GuidSyncMatchProp:string = "GuidSyncMatchProp";					 
				 
	GuidSyncMacthDefProp:string = "GuidSyncMacthDefProp";					 
				 
	GuidBizObjProperty:string = "GuidBizObjProperty";					 
				 
	GuidSyncMatchDefObjects:string = "GuidSyncMatchDefObjects";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecBizObjProperty:string = "FksecBizObjProperty";
		secBizObjProperty:string = "secBizObjProperty";
				 
		FksecSyncMatchDefObject:string = "FksecSyncMatchDefObject";
		secSyncMatchDefObject:string = "secSyncMatchDefObject";
				 
		FksecSyncMatchDefProp:string = "FksecSyncMatchDefProp";
		secSyncMatchDefProp:string = "secSyncMatchDefProp";
				 
	ComputedEntityName:string = "ComputedEntityName";					 
				 
}


export  class secSyncMatchPropertyModel{

	GuidSyncMatchProp:string;					 
	GuidSyncMacthDefProp:string;					 
	GuidBizObjProperty:string;					 
	GuidSyncMatchDefObjects:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	ComputedEntityName:string;					 

	public static _EntitySetName:string =  "secSyncMatchProperties";
	public static _EntityName:string =  "secSyncMatchProperty";
	public static PropertyNames: secSyncMatchPropertyPropertyNames = new secSyncMatchPropertyPropertyNames();
}


	


 class secSyncItemPropertyNames{
	constructor(){}

	GuidSyncItem:string = "GuidSyncItem";					 
				 
	GuidSyncMatchDefObject:string = "GuidSyncMatchDefObject";					 
				 
	OrigId:string = "OrigId";					 
				 
	GuidSyncIntegrator:string = "GuidSyncIntegrator";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecSyncMatchDefObject:string = "FksecSyncMatchDefObject";
		secSyncMatchDefObject:string = "secSyncMatchDefObject";
				 
		FksecSyncIntegrator:string = "FksecSyncIntegrator";
		secSyncIntegrator:string = "secSyncIntegrator";
				 
	EntityComputed:string = "EntityComputed";					 
				 
	ModuleComputed:string = "ModuleComputed";					 
				 
	TextComputed:string = "TextComputed";					 
				 
}


export  class secSyncItemModel{

	GuidSyncItem:string;					 
	GuidSyncMatchDefObject:string;					 
	OrigId:string;					 
	GuidSyncIntegrator:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	EntityComputed:string;					 
	ModuleComputed:string;					 
	TextComputed:string;					 

	public static _EntitySetName:string =  "secSyncItems";
	public static _EntityName:string =  "secSyncItem";
	public static PropertyNames: secSyncItemPropertyNames = new secSyncItemPropertyNames();
}


	


 class secSyncMatchDefObjectPropertyNames{
	constructor(){}

	GuidSyncMatchDefObject:string = "GuidSyncMatchDefObject";					 
				 
	GuidSyncMatchDef:string = "GuidSyncMatchDef";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
		FksecSyncMatchDef:string = "FksecSyncMatchDef";
		secSyncMatchDef:string = "secSyncMatchDef";
				 
	NameComputed:string = "NameComputed";					 
				 
}


export  class secSyncMatchDefObjectModel{

	GuidSyncMatchDefObject:string;					 
	GuidSyncMatchDef:string;					 
	GuidBusinessObject:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	NameComputed:string;					 

	public static _EntitySetName:string =  "secSyncMatchDefObjects";
	public static _EntityName:string =  "secSyncMatchDefObject";
	public static PropertyNames: secSyncMatchDefObjectPropertyNames = new secSyncMatchDefObjectPropertyNames();
}


	


 class secSyncMatchDefPropPropertyNames{
	constructor(){}

	GuidSyncMacthDefProp:string = "GuidSyncMacthDefProp";					 
				 
	PropertyMacthName:string = "PropertyMacthName";					 
				 
	GuidSyncMatchDef:string = "GuidSyncMatchDef";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecSyncMatchDef:string = "FksecSyncMatchDef";
		secSyncMatchDef:string = "secSyncMatchDef";
				 
}


export  class secSyncMatchDefPropModel{

	GuidSyncMacthDefProp:string;					 
	PropertyMacthName:string;					 
	GuidSyncMatchDef:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secSyncMatchDefProps";
	public static _EntityName:string =  "secSyncMatchDefProp";
	public static PropertyNames: secSyncMatchDefPropPropertyNames = new secSyncMatchDefPropPropertyNames();
}


	


 class secSyncIntegratorPropertyNames{
	constructor(){}

	GuidSyncIntegrator:string = "GuidSyncIntegrator";					 
				 
	GuidSyncMatchDef:string = "GuidSyncMatchDef";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	OwnerCompany:string = "OwnerCompany";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
		FksecSyncMatchDef:string = "FksecSyncMatchDef";
		secSyncMatchDef:string = "secSyncMatchDef";
				 
}


export  class secSyncIntegratorModel{

	GuidSyncIntegrator:string;					 
	GuidSyncMatchDef:string;					 
	CreatedDate:string;					 
	CreatedBy:string;					 
	OwnerCompany:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secSyncIntegrators";
	public static _EntityName:string =  "secSyncIntegrator";
	public static PropertyNames: secSyncIntegratorPropertyNames = new secSyncIntegratorPropertyNames();
}


	


 class secSyncMatchDefPropertyNames{
	constructor(){}

	GuidSyncMatchDef:string = "GuidSyncMatchDef";					 
				 
	Name:string = "Name";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	TypeSync:string = "TypeSync";					 
				 
	UniqueDirectionObject:string = "UniqueDirectionObject";					 
				 
	UseSameId:string = "UseSameId";					 
				 
		FksecSyncMatchDefObject:string = "FksecSyncMatchDefObject";
		secSyncMatchDefObject:string = "secSyncMatchDefObject";
				 
}


export  class secSyncMatchDefModel{

	GuidSyncMatchDef:string;					 
	Name:string;					 
	CreatedBy:string;					 
	CreatedDate:string;					 
	UpdatedBy:string;					 
	UpdatedDate:string;					 
	TypeSync:string;					 
	UniqueDirectionObject:string;					 
	UseSameId:any;					 

	public static _EntitySetName:string =  "secSyncMatchDefs";
	public static _EntityName:string =  "secSyncMatchDef";
	public static PropertyNames: secSyncMatchDefPropertyNames = new secSyncMatchDefPropertyNames();
}


	


 class secWFActivityPropertyNames{
	constructor(){}

	GuidWFActivity:string = "GuidWFActivity";					 
				 
	Title:string = "Title";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	GuidProcess:string = "GuidProcess";					 
				 
	DecisionYes:string = "DecisionYes";					 
				 
	DecisionNo:string = "DecisionNo";					 
				 
	GuidFromState:string = "GuidFromState";					 
				 
	GuidReusable_ActivityType:string = "GuidReusable_ActivityType";					 
				 
	OrderActivity:string = "OrderActivity";					 
				 
		FksecDecisionNo_WFState:string = "FksecDecisionNo_WFState";
		secDecisionNo_WFState:string = "secDecisionNo_WFState";
				 
		FksecDecisionYes_WFState:string = "FksecDecisionYes_WFState";
		secDecisionYes_WFState:string = "secDecisionYes_WFState";
				 
		FksecFromState_WFState:string = "FksecFromState_WFState";
		secFromState_WFState:string = "secFromState_WFState";
				 
		FksecWFProcess:string = "FksecWFProcess";
		secWFProcess:string = "secWFProcess";
				 
		FksecReusable_ActivityType:string = "FksecReusable_ActivityType";
		secReusable_ActivityType:string = "secReusable_ActivityType";
				 
	Users:string = "Users";					 
				 
}


export  class secWFActivityModel{

	GuidWFActivity:string;					 
	Title:string;					 
	CreatedDate:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	UpdatedDate:string;					 
	IsDeleted:any;					 
	GuidProcess:string;					 
	DecisionYes:string;					 
	DecisionNo:string;					 
	GuidFromState:string;					 
	GuidReusable_ActivityType:string;					 
	OrderActivity:number;					 
	Users:string;					 

	public static _EntitySetName:string =  "secWFActivities";
	public static _EntityName:string =  "secWFActivity";
	public static PropertyNames: secWFActivityPropertyNames = new secWFActivityPropertyNames();
}


	


 class secWFProcessPropertyNames{
	constructor(){}

	GuidProcess:string = "GuidProcess";					 
				 
	Title:string = "Title";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	ProcessKey:string = "ProcessKey";					 
				 
	GuidBizObjProperty:string = "GuidBizObjProperty";					 
				 
	GuidDefaultState:string = "GuidDefaultState";					 
				 
	GuidPropertyUserWaiting:string = "GuidPropertyUserWaiting";					 
				 
	GuiBusinessObjectUsersWaiting:string = "GuiBusinessObjectUsersWaiting";					 
				 
	AutoStart:string = "AutoStart";					 
				 
	GuidPropertyUsersWaiting:string = "GuidPropertyUsersWaiting";					 
				 
	GuidPropertyAuthor:string = "GuidPropertyAuthor";					 
				 
		FksecBizObjProperty:string = "FksecBizObjProperty";
		secBizObjProperty:string = "secBizObjProperty";
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
		FksecWFState:string = "FksecWFState";
		secWFState:string = "secWFState";
				 
		FksecPropertyUserWaiting:string = "FksecPropertyUserWaiting";
		secPropertyUserWaiting:string = "secPropertyUserWaiting";
				 
		FksecBizObjUsersWaiting:string = "FksecBizObjUsersWaiting";
		secBizObjUsersWaiting:string = "secBizObjUsersWaiting";
				 
		FksecPropertyUsersWaiting:string = "FksecPropertyUsersWaiting";
		secPropertyUsersWaiting:string = "secPropertyUsersWaiting";
				 
		FksecAuthorProperty:string = "FksecAuthorProperty";
		secAuthorProperty:string = "secAuthorProperty";
				 
}


export  class secWFProcessModel{

	GuidProcess:string;					 
	Title:string;					 
	GuidBusinessObject:string;					 
	CreatedDate:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	UpdatedDate:string;					 
	IsDeleted:any;					 
	ProcessKey:string;					 
	GuidBizObjProperty:string;					 
	GuidDefaultState:string;					 
	GuidPropertyUserWaiting:string;					 
	GuiBusinessObjectUsersWaiting:string;					 
	AutoStart:any;					 
	GuidPropertyUsersWaiting:string;					 
	GuidPropertyAuthor:string;					 

	public static _EntitySetName:string =  "secWFProcesses";
	public static _EntityName:string =  "secWFProcess";
	public static PropertyNames: secWFProcessPropertyNames = new secWFProcessPropertyNames();
}


	


 class secWFStatePropertyNames{
	constructor(){}

	GuidWFState:string = "GuidWFState";					 
				 
	Title:string = "Title";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	GuidWorkFlow:string = "GuidWorkFlow";					 
				 
	StateOrder:string = "StateOrder";					 
				 
	ColorClassName:string = "ColorClassName";					 
				 
	SetPropertyValue:string = "SetPropertyValue";					 
				 
	StateKey:string = "StateKey";					 
				 
	GuidPropertySetTrue:string = "GuidPropertySetTrue";					 
				 
	ColorClassNameRow:string = "ColorClassNameRow";					 
				 
	GuidPropertySetFalse:string = "GuidPropertySetFalse";					 
				 
		FksecWFProcess:string = "FksecWFProcess";
		secWFProcess:string = "secWFProcess";
				 
		FksecBizObjProperty:string = "FksecBizObjProperty";
		secBizObjProperty:string = "secBizObjProperty";
				 
		FksecBizObjPropertySetFalse:string = "FksecBizObjPropertySetFalse";
		secBizObjPropertySetFalse:string = "secBizObjPropertySetFalse";
				 
}


export  class secWFStateModel{

	GuidWFState:string;					 
	Title:string;					 
	CreatedDate:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	UpdatedDate:string;					 
	IsDeleted:any;					 
	GuidWorkFlow:string;					 
	StateOrder:number;					 
	ColorClassName:string;					 
	SetPropertyValue:string;					 
	StateKey:string;					 
	GuidPropertySetTrue:string;					 
	ColorClassNameRow:string;					 
	GuidPropertySetFalse:string;					 

	public static _EntitySetName:string =  "secWFStates";
	public static _EntityName:string =  "secWFState";
	public static PropertyNames: secWFStatePropertyNames = new secWFStatePropertyNames();
}


	


 class secWFActivityUserPropertyNames{
	constructor(){}

	GuidWFActivityUser:string = "GuidWFActivityUser";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	GuidWFActivity:string = "GuidWFActivity";					 
				 
	OrderDecision:string = "OrderDecision";					 
				 
	GetUsersFromBizObj:string = "GetUsersFromBizObj";					 
				 
	GuidBizObjPropertyUsers:string = "GuidBizObjPropertyUsers";					 
				 
	Title:string = "Title";					 
				 
		FksecUser:string = "FksecUser";
		secUser:string = "secUser";
				 
		FksecWFActivity:string = "FksecWFActivity";
		secWFActivity:string = "secWFActivity";
				 
		FksecBizObjProperty:string = "FksecBizObjProperty";
		secBizObjProperty:string = "secBizObjProperty";
				 
}


export  class secWFActivityUserModel{

	GuidWFActivityUser:string;					 
	CreatedDate:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	UpdatedDate:string;					 
	GuidCompany:string;					 
	IsDeleted:any;					 
	GuidUser:string;					 
	GuidWFActivity:string;					 
	OrderDecision:number;					 
	GetUsersFromBizObj:any;					 
	GuidBizObjPropertyUsers:string;					 
	Title:string;					 

	public static _EntitySetName:string =  "secWFActivityUsers";
	public static _EntityName:string =  "secWFActivityUser";
	public static PropertyNames: secWFActivityUserPropertyNames = new secWFActivityUserPropertyNames();
}


	


 class secWFActivityUserLogPropertyNames{
	constructor(){}

	GuidWFActivityUserLog:string = "GuidWFActivityUserLog";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	GuidStateBefore:string = "GuidStateBefore";					 
				 
	Decision:string = "Decision";					 
				 
	Comments:string = "Comments";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	OrigId:string = "OrigId";					 
				 
	GuidWFActivity:string = "GuidWFActivity";					 
				 
	GuidStateAfter:string = "GuidStateAfter";					 
				 
	GuidWFActivityUser:string = "GuidWFActivityUser";					 
				 
	Waiting:string = "Waiting";					 
				 
	Completed:string = "Completed";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
		FksecUser:string = "FksecUser";
		secUser:string = "secUser";
				 
		FksecWFActivity:string = "FksecWFActivity";
		secWFActivity:string = "secWFActivity";
				 
		FksecWFActivityUser:string = "FksecWFActivityUser";
		secWFActivityUser:string = "secWFActivityUser";
				 
		FksecState_Before_WFState:string = "FksecState_Before_WFState";
		secState_Before_WFState:string = "secState_Before_WFState";
				 
		FksecState_After_WFState:string = "FksecState_After_WFState";
		secState_After_WFState:string = "secState_After_WFState";
				 
}


export  class secWFActivityUserLogModel{

	GuidWFActivityUserLog:string;					 
	CreatedDate:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	UpdatedDate:string;					 
	GuidCompany:string;					 
	IsDeleted:any;					 
	GuidUser:string;					 
	GuidStateBefore:string;					 
	Decision:any;					 
	Comments:string;					 
	GuidBusinessObject:string;					 
	OrigId:string;					 
	GuidWFActivity:string;					 
	GuidStateAfter:string;					 
	GuidWFActivityUser:string;					 
	Waiting:any;					 
	Completed:any;					 

	public static _EntitySetName:string =  "secWFActivityUserLogs";
	public static _EntityName:string =  "secWFActivityUserLog";
	public static PropertyNames: secWFActivityUserLogPropertyNames = new secWFActivityUserLogPropertyNames();
}


	


 class secCompModConfigPropertyNames{
	constructor(){}

	GuidCompModConfig:string = "GuidCompModConfig";					 
				 
	GuidCompanyModule:string = "GuidCompanyModule";					 
				 
	GuidReusable_CompModConfig:string = "GuidReusable_CompModConfig";					 
				 
	ValueString:string = "ValueString";					 
				 
	ValueTime:string = "ValueTime";					 
				 
	ValueInt:string = "ValueInt";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecReusableCompModConfig:string = "FksecReusableCompModConfig";
		secReusableCompModConfig:string = "secReusableCompModConfig";
				 
		FksecCompanyModule:string = "FksecCompanyModule";
		secCompanyModule:string = "secCompanyModule";
				 
}


export  class secCompModConfigModel{

	GuidCompModConfig:string;					 
	GuidCompanyModule:string;					 
	GuidReusable_CompModConfig:string;					 
	ValueString:string;					 
	ValueTime:string;					 
	ValueInt:number;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secCompModConfigs";
	public static _EntityName:string =  "secCompModConfig";
	public static PropertyNames: secCompModConfigPropertyNames = new secCompModConfigPropertyNames();
}


	


 class secSettingValuePropertyNames{
	constructor(){}

	GuidSettingVaue:string = "GuidSettingVaue";					 
				 
	GuidSetting:string = "GuidSetting";					 
				 
	ValueString:string = "ValueString";					 
				 
	Title:string = "Title";					 
				 
	Description:string = "Description";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecSetting:string = "FksecSetting";
		secSetting:string = "secSetting";
				 
}


export  class secSettingValueModel{

	GuidSettingVaue:string;					 
	GuidSetting:string;					 
	ValueString:string;					 
	Title:string;					 
	Description:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secSettingValues";
	public static _EntityName:string =  "secSettingValue";
	public static PropertyNames: secSettingValuePropertyNames = new secSettingValuePropertyNames();
}


	


 class secComModSettingPropertyNames{
	constructor(){}

	GuidCompModSetting:string = "GuidCompModSetting";					 
				 
	GuidCompanyModule:string = "GuidCompanyModule";					 
				 
	GuidSetting:string = "GuidSetting";					 
				 
	GuidSettingVaue:string = "GuidSettingVaue";					 
				 
	ValueInt:string = "ValueInt";					 
				 
	ValueBoolean:string = "ValueBoolean";					 
				 
	ValueDecimal:string = "ValueDecimal";					 
				 
	ValueString:string = "ValueString";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecSettingValue:string = "FksecSettingValue";
		secSettingValue:string = "secSettingValue";
				 
		FksecSetting:string = "FksecSetting";
		secSetting:string = "secSetting";
				 
		FksecCompanyModule:string = "FksecCompanyModule";
		secCompanyModule:string = "secCompanyModule";
				 
	SettingKey:string = "SettingKey";					 
				 
	CustomValueText:string = "CustomValueText";					 
				 
}


export  class secComModSettingModel{

	GuidCompModSetting:string;					 
	GuidCompanyModule:string;					 
	GuidSetting:string;					 
	GuidSettingVaue:string;					 
	ValueInt:number;					 
	ValueBoolean:any;					 
	ValueDecimal:number;					 
	ValueString:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	SettingKey:string;					 
	CustomValueText:string;					 

	public static _EntitySetName:string =  "secComModSettings";
	public static _EntityName:string =  "secComModSetting";
	public static PropertyNames: secComModSettingPropertyNames = new secComModSettingPropertyNames();
}


	


 class secSettingPropertyNames{
	constructor(){}

	GuidSetting:string = "GuidSetting";					 
				 
	NameKey:string = "NameKey";					 
				 
	Name:string = "Name";					 
				 
	Description:string = "Description";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	GuidSettingVaue:string = "GuidSettingVaue";					 
				 
	TypeDataOption:string = "TypeDataOption";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecSettingValue:string = "FksecSettingValue";
		secSettingValue:string = "secSettingValue";
				 
}


export  class secSettingModel{

	GuidSetting:string;					 
	NameKey:string;					 
	Name:string;					 
	Description:string;					 
	GuidModule:string;					 
	GuidSettingVaue:string;					 
	TypeDataOption:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secSettings";
	public static _EntityName:string =  "secSetting";
	public static PropertyNames: secSettingPropertyNames = new secSettingPropertyNames();
}


	


 class secModuleSettingPropertyNames{
	constructor(){}

	GuidModuleSetting:string = "GuidModuleSetting";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	GuidSetting:string = "GuidSetting";					 
				 
	GuidSettingVaueDefault:string = "GuidSettingVaueDefault";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	ValueInt:string = "ValueInt";					 
				 
	ValueBoolean:string = "ValueBoolean";					 
				 
	ValueDecimal:string = "ValueDecimal";					 
				 
	ValueString:string = "ValueString";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecSetting:string = "FksecSetting";
		secSetting:string = "secSetting";
				 
		FksecSettingValue:string = "FksecSettingValue";
		secSettingValue:string = "secSettingValue";
				 
}


export  class secModuleSettingModel{

	GuidModuleSetting:string;					 
	GuidModule:string;					 
	GuidSetting:string;					 
	GuidSettingVaueDefault:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	ValueInt:number;					 
	ValueBoolean:any;					 
	ValueDecimal:number;					 
	ValueString:string;					 

	public static _EntitySetName:string =  "secModuleSettings";
	public static _EntityName:string =  "secModuleSetting";
	public static PropertyNames: secModuleSettingPropertyNames = new secModuleSettingPropertyNames();
}


	


 class secAppTemplatePropertyNames{
	constructor(){}

	GuidAppTemplate:string = "GuidAppTemplate";					 
				 
	Title:string = "Title";					 
				 
	RelativeHttpPath:string = "RelativeHttpPath";					 
				 
	GuidExclusiveModule:string = "GuidExclusiveModule";					 
				 
	Description:string = "Description";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
}


export  class secAppTemplateModel{

	GuidAppTemplate:string;					 
	Title:string;					 
	RelativeHttpPath:string;					 
	GuidExclusiveModule:string;					 
	Description:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secAppTemplates";
	public static _EntityName:string =  "secAppTemplate";
	public static PropertyNames: secAppTemplatePropertyNames = new secAppTemplatePropertyNames();
}


	


 class secTaskHistoryPropertyNames{
	constructor(){}

	GuidTaskHistory:string = "GuidTaskHistory";					 
				 
	StartTime:string = "StartTime";					 
				 
	EndTime:string = "EndTime";					 
				 
	GuidTask:string = "GuidTask";					 
				 
	UrlReponse:string = "UrlReponse";					 
				 
	ResponseCodeN:string = "ResponseCodeN";					 
				 
	IsManual:string = "IsManual";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecTask:string = "FksecTask";
		secTask:string = "secTask";
				 
}


export  class secTaskHistoryModel{

	GuidTaskHistory:string;					 
	StartTime:string;					 
	EndTime:string;					 
	GuidTask:string;					 
	UrlReponse:string;					 
	ResponseCodeN:number;					 
	IsManual:any;					 
	CreatedBy:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secTaskHistories";
	public static _EntityName:string =  "secTaskHistory";
	public static PropertyNames: secTaskHistoryPropertyNames = new secTaskHistoryPropertyNames();
}


	


 class secTaskPropertyNames{
	constructor(){}

	GuidTask:string = "GuidTask";					 
				 
	StartDT:string = "StartDT";					 
				 
	RepeatEachHr:string = "RepeatEachHr";					 
				 
	UrlEndPoint:string = "UrlEndPoint";					 
				 
	CompanyOwner:string = "CompanyOwner";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
}


export  class secTaskModel{

	GuidTask:string;					 
	StartDT:string;					 
	RepeatEachHr:number;					 
	UrlEndPoint:string;					 
	CompanyOwner:string;					 
	GuidModule:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secTasks";
	public static _EntityName:string =  "secTask";
	public static PropertyNames: secTaskPropertyNames = new secTaskPropertyNames();
}


	


 class secCompAppHistoryPropertyNames{
	constructor(){}

	GuidCompAppHistory:string = "GuidCompAppHistory";					 
				 
	GuidCompanyModule:string = "GuidCompanyModule";					 
				 
	StatDate:string = "StatDate";					 
				 
	TotalBytes:string = "TotalBytes";					 
				 
	TotalCreated:string = "TotalCreated";					 
				 
	TotalDeleted:string = "TotalDeleted";					 
				 
	TotalUpdated:string = "TotalUpdated";					 
				 
	TotalMessages:string = "TotalMessages";					 
				 
	TotalSumBytes:string = "TotalSumBytes";					 
				 
	TotalSumKbytes:string = "TotalSumKbytes";					 
				 
	TotalSumMb:string = "TotalSumMb";					 
				 
	TotalUsers:string = "TotalUsers";					 
				 
	TotalCustomRoles:string = "TotalCustomRoles";					 
				 
	TotalFilesGb:string = "TotalFilesGb";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	TotalNowGlobalBytes:string = "TotalNowGlobalBytes";					 
				 
	TotalErrors:string = "TotalErrors";					 
				 
		FksecCompanyModule:string = "FksecCompanyModule";
		secCompanyModule:string = "secCompanyModule";
				 
}


export  class secCompAppHistoryModel{

	GuidCompAppHistory:string;					 
	GuidCompanyModule:string;					 
	StatDate:string;					 
	TotalBytes:string;					 
	TotalCreated:number;					 
	TotalDeleted:number;					 
	TotalUpdated:number;					 
	TotalMessages:number;					 
	TotalSumBytes:string;					 
	TotalSumKbytes:string;					 
	TotalSumMb:string;					 
	TotalUsers:number;					 
	TotalCustomRoles:number;					 
	TotalFilesGb:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	TotalNowGlobalBytes:string;					 
	TotalErrors:number;					 

	public static _EntitySetName:string =  "secCompAppHistories";
	public static _EntityName:string =  "secCompAppHistory";
	public static PropertyNames: secCompAppHistoryPropertyNames = new secCompAppHistoryPropertyNames();
}


	


 class secCompAppFeaturePropertyNames{
	constructor(){}

	GuidCompAppFeature:string = "GuidCompAppFeature";					 
				 
	GuidFeatureConcept:string = "GuidFeatureConcept";					 
				 
	GuidCompanyModule:string = "GuidCompanyModule";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	DiscountPrecent:string = "DiscountPrecent";					 
				 
	FromDateTime:string = "FromDateTime";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
		FksecFeatureConcept:string = "FksecFeatureConcept";
		secFeatureConcept:string = "secFeatureConcept";
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecCompanyModule:string = "FksecCompanyModule";
		secCompanyModule:string = "secCompanyModule";
				 
	Price:string = "Price";					 
				 
	TotalPrice:string = "TotalPrice";					 
				 
}


export  class secCompAppFeatureModel{

	GuidCompAppFeature:string;					 
	GuidFeatureConcept:string;					 
	GuidCompanyModule:string;					 
	GuidCompany:string;					 
	GuidModule:string;					 
	DiscountPrecent:number;					 
	FromDateTime:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	Price:number;					 
	TotalPrice:number;					 

	public static _EntitySetName:string =  "secCompAppFeatures";
	public static _EntityName:string =  "secCompAppFeature";
	public static PropertyNames: secCompAppFeaturePropertyNames = new secCompAppFeaturePropertyNames();
}


	


 class secInvoicePropertyNames{
	constructor(){}

	GuidInvoice:string = "GuidInvoice";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	InvoiceNum:string = "InvoiceNum";					 
				 
	InvoiceDate:string = "InvoiceDate";					 
				 
	ServicesFrom:string = "ServicesFrom";					 
				 
	ServicesTo:string = "ServicesTo";					 
				 
	PreTotal:string = "PreTotal";					 
				 
	Taxes:string = "Taxes";					 
				 
	Total:string = "Total";					 
				 
	CurrencyCode:string = "CurrencyCode";					 
				 
	GuidCompanyModule:string = "GuidCompanyModule";					 
				 
	Calculated:string = "Calculated";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	TotalDiscount:string = "TotalDiscount";					 
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecCompanyModule:string = "FksecCompanyModule";
		secCompanyModule:string = "secCompanyModule";
				 
	TitleDesc:string = "TitleDesc";					 
				 
}


export  class secInvoiceModel{

	GuidInvoice:string;					 
	GuidCompany:string;					 
	InvoiceNum:number;					 
	InvoiceDate:string;					 
	ServicesFrom:string;					 
	ServicesTo:string;					 
	PreTotal:number;					 
	Taxes:number;					 
	Total:number;					 
	CurrencyCode:string;					 
	GuidCompanyModule:string;					 
	Calculated:any;					 
	GuidModule:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	TotalDiscount:number;					 
	TitleDesc:string;					 

	public static _EntitySetName:string =  "secInvoices";
	public static _EntityName:string =  "secInvoice";
	public static PropertyNames: secInvoicePropertyNames = new secInvoicePropertyNames();
}


	


 class secInvoiceDetailPropertyNames{
	constructor(){}

	GuidInvoiceDetail:string = "GuidInvoiceDetail";					 
				 
	GuidInvoice:string = "GuidInvoice";					 
				 
	GuidFeatureConcept:string = "GuidFeatureConcept";					 
				 
	UnitPrice:string = "UnitPrice";					 
				 
	Discount:string = "Discount";					 
				 
	Qty:string = "Qty";					 
				 
	Total:string = "Total";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	DiscountPercent:string = "DiscountPercent";					 
				 
		FksecFeatureConcept:string = "FksecFeatureConcept";
		secFeatureConcept:string = "secFeatureConcept";
				 
		FksecInvoice:string = "FksecInvoice";
		secInvoice:string = "secInvoice";
				 
}


export  class secInvoiceDetailModel{

	GuidInvoiceDetail:string;					 
	GuidInvoice:string;					 
	GuidFeatureConcept:string;					 
	UnitPrice:number;					 
	Discount:number;					 
	Qty:number;					 
	Total:number;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	DiscountPercent:number;					 

	public static _EntitySetName:string =  "secInvoiceDetails";
	public static _EntityName:string =  "secInvoiceDetail";
	public static PropertyNames: secInvoiceDetailPropertyNames = new secInvoiceDetailPropertyNames();
}


	


 class secCompanyModulePropertyNames{
	constructor(){}

	GuidModule:string = "GuidModule";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	GuidCompanyModule:string = "GuidCompanyModule";					 
				 
	TotalBytes:string = "TotalBytes";					 
				 
	TotalDeleted:string = "TotalDeleted";					 
				 
	TotalDeletedBytes:string = "TotalDeletedBytes";					 
				 
	TotalItems:string = "TotalItems";					 
				 
	UpdatedDateTotals:string = "UpdatedDateTotals";					 
				 
	GuidAppTemplate:string = "GuidAppTemplate";					 
				 
	StartDate:string = "StartDate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	TotalUsers:string = "TotalUsers";					 
				 
	TotalUserRoles:string = "TotalUserRoles";					 
				 
	TotalAuditCatalogs:string = "TotalAuditCatalogs";					 
				 
	CompanyChildren:string = "CompanyChildren";					 
				 
	ChildrenTotalBytes:string = "ChildrenTotalBytes";					 
				 
	TotalBytesWithChildren:string = "TotalBytesWithChildren";					 
				 
	TotalUserRolesWithChildren:string = "TotalUserRolesWithChildren";					 
				 
	DefaultInPublic:string = "DefaultInPublic";					 
				 
	HideFromPublic:string = "HideFromPublic";					 
				 
	CustomDomain:string = "CustomDomain";					 
				 
	DisableThirdPartyProviders:string = "DisableThirdPartyProviders";					 
				 
	FaceBookAppId:string = "FaceBookAppId";					 
				 
	FacebookAppSecret:string = "FacebookAppSecret";					 
				 
	MicrosoftClientId:string = "MicrosoftClientId";					 
				 
	MicrosoftClientSecret:string = "MicrosoftClientSecret";					 
				 
	GoogleClientId:string = "GoogleClientId";					 
				 
	GoogleClientSecret:string = "GoogleClientSecret";					 
				 
	PreventChangeCompany:string = "PreventChangeCompany";					 
				 
	RecaptchaPublicKey:string = "RecaptchaPublicKey";					 
				 
	RecaptchaPrivateKey:string = "RecaptchaPrivateKey";					 
				 
	Office365ClientId:string = "Office365ClientId";					 
				 
	Office365ClientSecret:string = "Office365ClientSecret";					 
				 
	Office365Authority:string = "Office365Authority";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
		FksecAppTemplate:string = "FksecAppTemplate";
		secAppTemplate:string = "secAppTemplate";
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
	SizeTextComputed:string = "SizeTextComputed";					 
				 
}


export  class secCompanyModuleModel{

	GuidModule:string;					 
	GuidCompany:string;					 
	GuidCompanyModule:string;					 
	TotalBytes:string;					 
	TotalDeleted:number;					 
	TotalDeletedBytes:string;					 
	TotalItems:number;					 
	UpdatedDateTotals:string;					 
	GuidAppTemplate:string;					 
	StartDate:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	TotalUsers:number;					 
	TotalUserRoles:number;					 
	TotalAuditCatalogs:number;					 
	CompanyChildren:number;					 
	ChildrenTotalBytes:string;					 
	TotalBytesWithChildren:string;					 
	TotalUserRolesWithChildren:number;					 
	DefaultInPublic:any;					 
	HideFromPublic:any;					 
	CustomDomain:string;					 
	DisableThirdPartyProviders:any;					 
	FaceBookAppId:string;					 
	FacebookAppSecret:string;					 
	MicrosoftClientId:string;					 
	MicrosoftClientSecret:string;					 
	GoogleClientId:string;					 
	GoogleClientSecret:string;					 
	PreventChangeCompany:any;					 
	RecaptchaPublicKey:string;					 
	RecaptchaPrivateKey:string;					 
	Office365ClientId:string;					 
	Office365ClientSecret:string;					 
	Office365Authority:string;					 
	IsDeleted:any;					 
	SizeTextComputed:string;					 

	public static _EntitySetName:string =  "secCompanyModules";
	public static _EntityName:string =  "secCompanyModule";
	public static PropertyNames: secCompanyModulePropertyNames = new secCompanyModulePropertyNames();
}


	


 class secCompAppBizObjectPropertyNames{
	constructor(){}

	GuidCompAppBizObject:string = "GuidCompAppBizObject";					 
				 
	GuidCompanyModule:string = "GuidCompanyModule";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	TotalBytes:string = "TotalBytes";					 
				 
	TotalDeleted:string = "TotalDeleted";					 
				 
	TotalItems:string = "TotalItems";					 
				 
	TotalsUpdated:string = "TotalsUpdated";					 
				 
	UpdatedDateTotals:string = "UpdatedDateTotals";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	TotalBytesDeleted:string = "TotalBytesDeleted";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
		FksecCompanyModule:string = "FksecCompanyModule";
		secCompanyModule:string = "secCompanyModule";
				 
	PluralName:string = "PluralName";					 
				 
	ModuleComputed:string = "ModuleComputed";					 
				 
	SizeText:string = "SizeText";					 
				 
	SizeDeletedText:string = "SizeDeletedText";					 
				 
}


export  class secCompAppBizObjectModel{

	GuidCompAppBizObject:string;					 
	GuidCompanyModule:string;					 
	GuidBusinessObject:string;					 
	TotalBytes:string;					 
	TotalDeleted:number;					 
	TotalItems:number;					 
	TotalsUpdated:string;					 
	UpdatedDateTotals:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	TotalBytesDeleted:string;					 
	PluralName:string;					 
	ModuleComputed:string;					 
	SizeText:string;					 
	SizeDeletedText:string;					 

	public static _EntitySetName:string =  "secCompAppBizObjects";
	public static _EntityName:string =  "secCompAppBizObject";
	public static PropertyNames: secCompAppBizObjectPropertyNames = new secCompAppBizObjectPropertyNames();
}


	


 class secBizPropertyDescriptionPropertyNames{
	constructor(){}

	GuidBizPropertyDescription:string = "GuidBizPropertyDescription";					 
				 
	GuidBizObjProperty:string = "GuidBizObjProperty";					 
				 
	UICulture:string = "UICulture";					 
				 
	Name:string = "Name";					 
				 
	ShortDescription:string = "ShortDescription";					 
				 
	ShortWarning:string = "ShortWarning";					 
				 
	LongDescription:string = "LongDescription";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	OwnerComptany:string = "OwnerComptany";					 
				 
	ResourceKey:string = "ResourceKey";					 
				 
	PluralName:string = "PluralName";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	PlaceHolder:string = "PlaceHolder";					 
				 
		FksecBizObjProperty:string = "FksecBizObjProperty";
		secBizObjProperty:string = "secBizObjProperty";
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
}


export  class secBizPropertyDescriptionModel{

	GuidBizPropertyDescription:string;					 
	GuidBizObjProperty:string;					 
	UICulture:string;					 
	Name:string;					 
	ShortDescription:string;					 
	ShortWarning:string;					 
	LongDescription:string;					 
	GuidBusinessObject:string;					 
	OwnerComptany:string;					 
	ResourceKey:string;					 
	PluralName:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	UpdatedBy:string;					 
	PlaceHolder:string;					 

	public static _EntitySetName:string =  "secBizPropertyDescriptions";
	public static _EntityName:string =  "secBizPropertyDescription";
	public static PropertyNames: secBizPropertyDescriptionPropertyNames = new secBizPropertyDescriptionPropertyNames();
}


	


 class secInvoicePaymentPropertyNames{
	constructor(){}

	GuidInvoicePayment:string = "GuidInvoicePayment";					 
				 
	PaymentDate:string = "PaymentDate";					 
				 
	Verified:string = "Verified";					 
				 
	GuidInvoice:string = "GuidInvoice";					 
				 
	Amount:string = "Amount";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	CompanyPayment:string = "CompanyPayment";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
		FksecInvoice:string = "FksecInvoice";
		secInvoice:string = "secInvoice";
				 
}


export  class secInvoicePaymentModel{

	GuidInvoicePayment:string;					 
	PaymentDate:string;					 
	Verified:any;					 
	GuidInvoice:string;					 
	Amount:number;					 
	CreatedBy:string;					 
	CreatedDate:string;					 
	CompanyPayment:string;					 
	UpdatedDate:string;					 
	UpdatedBy:string;					 
	IsDeleted:any;					 

	public static _EntitySetName:string =  "secInvoicePayments";
	public static _EntityName:string =  "secInvoicePayment";
	public static PropertyNames: secInvoicePaymentPropertyNames = new secInvoicePaymentPropertyNames();
}


	


 class secInvPaymentFilePropertyNames{
	constructor(){}

	GuidInvPaymentFile:string = "GuidInvPaymentFile";					 
				 
	GuidInvoicePayment:string = "GuidInvoicePayment";					 
				 
	GuidFile:string = "GuidFile";					 
				 
	Description:string = "Description";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
		FksecFile:string = "FksecFile";
		secFile:string = "secFile";
				 
		FksecInvoicePayment:string = "FksecInvoicePayment";
		secInvoicePayment:string = "secInvoicePayment";
				 
}


export  class secInvPaymentFileModel{

	GuidInvPaymentFile:string;					 
	GuidInvoicePayment:string;					 
	GuidFile:string;					 
	Description:string;					 
	CreatedDate:string;					 
	CreatedBy:string;					 
	UpdatedDate:string;					 
	UpdatedBy:string;					 
	IsDeleted:any;					 

	public static _EntitySetName:string =  "secInvPaymentFiles";
	public static _EntityName:string =  "secInvPaymentFile";
	public static PropertyNames: secInvPaymentFilePropertyNames = new secInvPaymentFilePropertyNames();
}


	


 class secCompanyLoginPropertyNames{
	constructor(){}

	GuidCompanyLogin:string = "GuidCompanyLogin";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	Microsoft:string = "Microsoft";					 
				 
	Google:string = "Google";					 
				 
	LinkedIn:string = "LinkedIn";					 
				 
	Facebook:string = "Facebook";					 
				 
	Yahoo:string = "Yahoo";					 
				 
	Twitter:string = "Twitter";					 
				 
	MicrosoftClientId:string = "MicrosoftClientId";					 
				 
	MicrosoftClientSecret:string = "MicrosoftClientSecret";					 
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
}


export  class secCompanyLoginModel{

	GuidCompanyLogin:string;					 
	GuidCompany:string;					 
	Microsoft:any;					 
	Google:any;					 
	LinkedIn:any;					 
	Facebook:any;					 
	Yahoo:any;					 
	Twitter:any;					 
	MicrosoftClientId:string;					 
	MicrosoftClientSecret:string;					 

	public static _EntitySetName:string =  "secCompanyLogins";
	public static _EntityName:string =  "secCompanyLogin";
	public static PropertyNames: secCompanyLoginPropertyNames = new secCompanyLoginPropertyNames();
}


	


 class secWFConnectorPropertyNames{
	constructor(){}

	GuidWFConnector:string = "GuidWFConnector";					 
				 
	GuidWFActivityFrom:string = "GuidWFActivityFrom";					 
				 
	GuidWFActivityTo:string = "GuidWFActivityTo";					 
				 
		FksecWFActivityFrom:string = "FksecWFActivityFrom";
		secWFActivityFrom:string = "secWFActivityFrom";
				 
		FksecWFActivityTo:string = "FksecWFActivityTo";
		secWFActivityTo:string = "secWFActivityTo";
				 
}


export  class secWFConnectorModel{

	GuidWFConnector:string;					 
	GuidWFActivityFrom:string;					 
	GuidWFActivityTo:string;					 

	public static _EntitySetName:string =  "secWFConnectors";
	public static _EntityName:string =  "secWFConnector";
	public static PropertyNames: secWFConnectorPropertyNames = new secWFConnectorPropertyNames();
}


	


 class secCompUISettingPropertyNames{
	constructor(){}

	GuidCompUISetting:string = "GuidCompUISetting";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	PrimaryButtonsBG:string = "PrimaryButtonsBG";					 
				 
	PrimaryButtonsTextColor:string = "PrimaryButtonsTextColor";					 
				 
	TopMenuBG:string = "TopMenuBG";					 
				 
	TopCompanyLogoBG:string = "TopCompanyLogoBG";					 
				 
	AppMenuBG:string = "AppMenuBG";					 
				 
	BGColor:string = "BGColor";					 
				 
	FormBG:string = "FormBG";					 
				 
	InputFocusedBG:string = "InputFocusedBG";					 
				 
	Title:string = "Title";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	TextLinkColor:string = "TextLinkColor";					 
				 
	ListHeaderTextColor:string = "ListHeaderTextColor";					 
				 
	ListHeaderBG:string = "ListHeaderBG";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	WarningColorLiteBG:string = "WarningColorLiteBG";					 
				 
	ErrorColorLiteBG:string = "ErrorColorLiteBG";					 
				 
	SuccessColorLiteBG:string = "SuccessColorLiteBG";					 
				 
	CssCode:string = "CssCode";					 
				 
	BodyClasses:string = "BodyClasses";					 
				 
	TextTitle1Color:string = "TextTitle1Color";					 
				 
	TextTitle2Color:string = "TextTitle2Color";					 
				 
	ListItemOverBG:string = "ListItemOverBG";					 
				 
	UserProfileInSideMenu:string = "UserProfileInSideMenu";					 
				 
	IconsDefaultColor:string = "IconsDefaultColor";					 
				 
	ControlFillColorDefault:string = "ControlFillColorDefault";					 
				 
	GuidModule:string = "GuidModule";					 
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
}


export  class secCompUISettingModel{

	GuidCompUISetting:string;					 
	GuidCompany:string;					 
	PrimaryButtonsBG:string;					 
	PrimaryButtonsTextColor:string;					 
	TopMenuBG:string;					 
	TopCompanyLogoBG:string;					 
	AppMenuBG:string;					 
	BGColor:string;					 
	FormBG:string;					 
	InputFocusedBG:string;					 
	Title:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	TextLinkColor:string;					 
	ListHeaderTextColor:string;					 
	ListHeaderBG:string;					 
	IsDeleted:any;					 
	WarningColorLiteBG:string;					 
	ErrorColorLiteBG:string;					 
	SuccessColorLiteBG:string;					 
	CssCode:string;					 
	BodyClasses:string;					 
	TextTitle1Color:string;					 
	TextTitle2Color:string;					 
	ListItemOverBG:string;					 
	UserProfileInSideMenu:any;					 
	IconsDefaultColor:string;					 
	ControlFillColorDefault:string;					 
	GuidModule:string;					 

	public static _EntitySetName:string =  "secCompUISettings";
	public static _EntityName:string =  "secCompUISetting";
	public static PropertyNames: secCompUISettingPropertyNames = new secCompUISettingPropertyNames();
}


	


 class secAuditPropertyPropertyNames{
	constructor(){}

	AuditId:string = "AuditId";					 
				 
	PropertyName:string = "PropertyName";					 
				 
	PropertyValueInt:string = "PropertyValueInt";					 
				 
	PropertyValueText:string = "PropertyValueText";					 
				 
	propertyValueGuid:string = "propertyValueGuid";					 
				 
	propertyValueBinary:string = "propertyValueBinary";					 
				 
	PropertyType:string = "PropertyType";					 
				 
	PropertyDisplay:string = "PropertyDisplay";					 
				 
	PropertyValue:string = "PropertyValue";					 
				 
	GuidProperty:string = "GuidProperty";					 
				 
		FksecAudit:string = "FksecAudit";
		secAudit:string = "secAudit";
				 
}


export  class secAuditPropertyModel{

	AuditId:string;					 
	PropertyName:string;					 
	PropertyValueInt:number;					 
	PropertyValueText:string;					 
	propertyValueGuid:string;					 
	propertyValueBinary:string;					 
	PropertyType:string;					 
	PropertyDisplay:string;					 
	PropertyValue:string;					 
	GuidProperty:string;					 

	public static _EntitySetName:string =  "secAuditProperties";
	public static _EntityName:string =  "secAuditProperty";
	public static PropertyNames: secAuditPropertyPropertyNames = new secAuditPropertyPropertyNames();
}


	


 class secTimeZonePropertyNames{
	constructor(){}

	GuidTimeZone:string = "GuidTimeZone";					 
				 
	CountryCode:string = "CountryCode";					 
				 
	Name:string = "Name";					 
				 
	ZoneID:string = "ZoneID";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	UseDST:string = "UseDST";					 
				 
	StartDST:string = "StartDST";					 
				 
	EndDST:string = "EndDST";					 
				 
	HrsOffsetDST:string = "HrsOffsetDST";					 
				 
	HrsOffset:string = "HrsOffset";					 
				 
}


export  class secTimeZoneModel{

	GuidTimeZone:string;					 
	CountryCode:string;					 
	Name:string;					 
	ZoneID:number;					 
	CreatedDate:string;					 
	CreatedBy:string;					 
	UpdatedDate:string;					 
	UpdatedBy:string;					 
	UseDST:any;					 
	StartDST:string;					 
	EndDST:string;					 
	HrsOffsetDST:number;					 
	HrsOffset:number;					 

	public static _EntitySetName:string =  "secTimeZones";
	public static _EntityName:string =  "secTimeZone";
	public static PropertyNames: secTimeZonePropertyNames = new secTimeZonePropertyNames();
}


	


 class secUpdatePropertyNames{
	constructor(){}

	GuidUpdate:string = "GuidUpdate";					 
				 
	VersionID:string = "VersionID";					 
				 
	VersionName:string = "VersionName";					 
				 
	ScriptSQL:string = "ScriptSQL";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	ExecutionResult:string = "ExecutionResult";					 
				 
	ExecutionWithError:string = "ExecutionWithError";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	GuidModule:string = "GuidModule";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
}


export  class secUpdateModel{

	GuidUpdate:string;					 
	VersionID:number;					 
	VersionName:string;					 
	ScriptSQL:string;					 
	CreatedDate:string;					 
	ExecutionResult:string;					 
	ExecutionWithError:any;					 
	UpdatedDate:string;					 
	GuidModule:string;					 

	public static _EntitySetName:string =  "secUpdates";
	public static _EntityName:string =  "secUpdate";
	public static PropertyNames: secUpdatePropertyNames = new secUpdatePropertyNames();
}


	


 class secNoSQLLogPropertyNames{
	constructor(){}

	GuidNoSQLLog:string = "GuidNoSQLLog";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	GuidNoSQLMovement:string = "GuidNoSQLMovement";					 
				 
	Success:string = "Success";					 
				 
	Message:string = "Message";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
		FksecNoSQLMovement:string = "FksecNoSQLMovement";
		secNoSQLMovement:string = "secNoSQLMovement";
				 
}


export  class secNoSQLLogModel{

	GuidNoSQLLog:string;					 
	GuidBusinessObject:string;					 
	GuidNoSQLMovement:string;					 
	Success:any;					 
	Message:string;					 

	public static _EntitySetName:string =  "secNoSQLLogs";
	public static _EntityName:string =  "secNoSQLLog";
	public static PropertyNames: secNoSQLLogPropertyNames = new secNoSQLLogPropertyNames();
}


	


 class secNoSQLMovementPropertyNames{
	constructor(){}

	GuidNoSQLMovement:string = "GuidNoSQLMovement";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	ItemsForBulk:string = "ItemsForBulk";					 
				 
	PlaninglForMove:string = "PlaninglForMove";					 
				 
	TotalMove:string = "TotalMove";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	GuidReusableStorageSource:string = "GuidReusableStorageSource";					 
				 
	GuidReusableStorageTarget:string = "GuidReusableStorageTarget";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
}


export  class secNoSQLMovementModel{

	GuidNoSQLMovement:string;					 
	GuidBusinessObject:string;					 
	ItemsForBulk:number;					 
	PlaninglForMove:number;					 
	TotalMove:number;					 
	UpdatedDate:string;					 
	CreatedDate:string;					 
	GuidReusableStorageSource:string;					 
	GuidReusableStorageTarget:string;					 

	public static _EntitySetName:string =  "secNoSQLMovements";
	public static _EntityName:string =  "secNoSQLMovement";
	public static PropertyNames: secNoSQLMovementPropertyNames = new secNoSQLMovementPropertyNames();
}


	


 class secNoSQLOptionPropertyNames{
	constructor(){}

	GuidNoSQLOption:string = "GuidNoSQLOption";					 
				 
	Name:string = "Name";					 
				 
	NameKey:string = "NameKey";					 
				 
}


export  class secNoSQLOptionModel{

	GuidNoSQLOption:string;					 
	Name:string;					 
	NameKey:string;					 

	public static _EntitySetName:string =  "secNoSQLOptions";
	public static _EntityName:string =  "secNoSQLOption";
	public static PropertyNames: secNoSQLOptionPropertyNames = new secNoSQLOptionPropertyNames();
}


	


 class secModuleUserPropertyNames{
	constructor(){}

	GuidModuleUser:string = "GuidModuleUser";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	AppNotificationToken:string = "AppNotificationToken";					 
				 
	NewNotifications:string = "NewNotifications";					 
				 
	TotalNotifications:string = "TotalNotifications";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecUser:string = "FksecUser";
		secUser:string = "secUser";
				 
}


export  class secModuleUserModel{

	GuidModuleUser:string;					 
	GuidModule:string;					 
	GuidUser:string;					 
	AppNotificationToken:string;					 
	NewNotifications:number;					 
	TotalNotifications:number;					 

	public static _EntitySetName:string =  "secModuleUsers";
	public static _EntityName:string =  "secModuleUser";
	public static PropertyNames: secModuleUserPropertyNames = new secModuleUserPropertyNames();
}


	


 class secNotificationPropertyNames{
	constructor(){}

	GuidNotification:string = "GuidNotification";					 
				 
	ToUser:string = "ToUser";					 
				 
	GuidNotificationPriority:string = "GuidNotificationPriority";					 
				 
	Title:string = "Title";					 
				 
	Body:string = "Body";					 
				 
	Priority:string = "Priority";					 
				 
	Sound:string = "Sound";					 
				 
	ToCustom:string = "ToCustom";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	UriActionIOS:string = "UriActionIOS";					 
				 
	UriActionAndroid:string = "UriActionAndroid";					 
				 
	UriActionWeb:string = "UriActionWeb";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecNotificationPriority:string = "FksecNotificationPriority";
		secNotificationPriority:string = "secNotificationPriority";
				 
}


export  class secNotificationModel{

	GuidNotification:string;					 
	ToUser:string;					 
	GuidNotificationPriority:string;					 
	Title:string;					 
	Body:string;					 
	Priority:string;					 
	Sound:string;					 
	ToCustom:string;					 
	GuidModule:string;					 
	UriActionIOS:string;					 
	UriActionAndroid:string;					 
	UriActionWeb:string;					 

	public static _EntitySetName:string =  "secNotifications";
	public static _EntityName:string =  "secNotification";
	public static PropertyNames: secNotificationPropertyNames = new secNotificationPropertyNames();
}


	


 class secNotificationPriorityPropertyNames{
	constructor(){}

	GuidNotificationPriority:string = "GuidNotificationPriority";					 
				 
	Name:string = "Name";					 
				 
}


export  class secNotificationPriorityModel{

	GuidNotificationPriority:string;					 
	Name:string;					 

	public static _EntitySetName:string =  "secNotificationPriorities";
	public static _EntityName:string =  "secNotificationPriority";
	public static PropertyNames: secNotificationPriorityPropertyNames = new secNotificationPriorityPropertyNames();
}


	


 class secModuleUserDevicePropertyNames{
	constructor(){}

	GuidModuleUserDevice:string = "GuidModuleUserDevice";					 
				 
	GuidModuleUser:string = "GuidModuleUser";					 
				 
	OS:string = "OS";					 
				 
	AppFirebaseNotificationToken:string = "AppFirebaseNotificationToken";					 
				 
	DeviceID:string = "DeviceID";					 
				 
		FksecModuleUser:string = "FksecModuleUser";
		secModuleUser:string = "secModuleUser";
				 
}


export  class secModuleUserDeviceModel{

	GuidModuleUserDevice:string;					 
	GuidModuleUser:string;					 
	OS:string;					 
	AppFirebaseNotificationToken:string;					 
	DeviceID:string;					 

	public static _EntitySetName:string =  "secModuleUserDevices";
	public static _EntityName:string =  "secModuleUserDevice";
	public static PropertyNames: secModuleUserDevicePropertyNames = new secModuleUserDevicePropertyNames();
}


	


 class secModuleUserCompanyPropertyNames{
	constructor(){}

	GuidModuleUserCompany:string = "GuidModuleUserCompany";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	GuidCompany:string = "GuidCompany";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	NewNotifications:string = "NewNotifications";					 
				 
	TotalNotifications:string = "TotalNotifications";					 
				 
	NewMessages:string = "NewMessages";					 
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecUser:string = "FksecUser";
		secUser:string = "secUser";
				 
}


export  class secModuleUserCompanyModel{

	GuidModuleUserCompany:string;					 
	GuidModule:string;					 
	GuidCompany:string;					 
	GuidUser:string;					 
	NewNotifications:number;					 
	TotalNotifications:number;					 
	NewMessages:number;					 

	public static _EntitySetName:string =  "secModuleUserCompanies";
	public static _EntityName:string =  "secModuleUserCompany";
	public static PropertyNames: secModuleUserCompanyPropertyNames = new secModuleUserCompanyPropertyNames();
}


	


 class secChatGroupPropertyNames{
	constructor(){}

	GuidChatGroup:string = "GuidChatGroup";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	NumPersons:string = "NumPersons";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	GuidUserCompany:string = "GuidUserCompany";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecUserCompany:string = "FksecUserCompany";
		secUserCompany:string = "secUserCompany";
				 
}


export  class secChatGroupModel{

	GuidChatGroup:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	NumPersons:number;					 
	GuidModule:string;					 
	GuidUserCompany:string;					 

	public static _EntitySetName:string =  "secChatGroups";
	public static _EntityName:string =  "secChatGroup";
	public static PropertyNames: secChatGroupPropertyNames = new secChatGroupPropertyNames();
}


	


 class secChatGroupUserPropertyNames{
	constructor(){}

	GuidChatGroupUser:string = "GuidChatGroupUser";					 
				 
	GuidUser:string = "GuidUser";					 
				 
	GuidChatGroup:string = "GuidChatGroup";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	IsOwner:string = "IsOwner";					 
				 
		FksecChatGroup:string = "FksecChatGroup";
		secChatGroup:string = "secChatGroup";
				 
		FksecUser:string = "FksecUser";
		secUser:string = "secUser";
				 
}


export  class secChatGroupUserModel{

	GuidChatGroupUser:string;					 
	GuidUser:string;					 
	GuidChatGroup:string;					 
	CreatedDate:string;					 
	IsDeleted:any;					 
	IsOwner:any;					 

	public static _EntitySetName:string =  "secChatGroupUsers";
	public static _EntityName:string =  "secChatGroupUser";
	public static PropertyNames: secChatGroupUserPropertyNames = new secChatGroupUserPropertyNames();
}


	


 class secTutorialPropertyNames{
	constructor(){}

	GuidTutorial:string = "GuidTutorial";					 
				 
	Name:string = "Name";					 
				 
	NameKey:string = "NameKey";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
}


export  class secTutorialModel{

	GuidTutorial:string;					 
	Name:string;					 
	NameKey:string;					 
	GuidModule:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	IsDeleted:any;					 

	public static _EntitySetName:string =  "secTutorials";
	public static _EntityName:string =  "secTutorial";
	public static PropertyNames: secTutorialPropertyNames = new secTutorialPropertyNames();
}


	


 class secTutorialItemPropertyNames{
	constructor(){}

	GuidTutorialItem:string = "GuidTutorialItem";					 
				 
	OrderItem:string = "OrderItem";					 
				 
	GuidTutorial:string = "GuidTutorial";					 
				 
	ImageUrl:string = "ImageUrl";					 
				 
	OrderContentHtml:string = "OrderContentHtml";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
		FksecTutorial:string = "FksecTutorial";
		secTutorial:string = "secTutorial";
				 
}


export  class secTutorialItemModel{

	GuidTutorialItem:string;					 
	OrderItem:number;					 
	GuidTutorial:string;					 
	ImageUrl:string;					 
	OrderContentHtml:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 
	IsDeleted:any;					 

	public static _EntitySetName:string =  "secTutorialItems";
	public static _EntityName:string =  "secTutorialItem";
	public static PropertyNames: secTutorialItemPropertyNames = new secTutorialItemPropertyNames();
}


	


 class secContentPropertyNames{
	constructor(){}

	GuidContent:string = "GuidContent";					 
				 
	Title:string = "Title";					 
				 
	LargeContent:string = "LargeContent";					 
				 
	ModuleKey:string = "ModuleKey";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	CreatedUser:string = "CreatedUser";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	PropertyName:string = "PropertyName";					 
				 
	BusinessObjectKey:string = "BusinessObjectKey";					 
				 
	OrderContent:string = "OrderContent";					 
				 
	UseMode:string = "UseMode";					 
				 
	ActionKey:string = "ActionKey";					 
				 
	MenuKey:string = "MenuKey";					 
				 
	Slug:string = "Slug";					 
				 
	GuidContentType:string = "GuidContentType";					 
				 
	ForwardType:string = "ForwardType";					 
				 
	FormatType:string = "FormatType";					 
				 
	TitleKey:string = "TitleKey";					 
				 
	GuidFile:string = "GuidFile";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	DescriptionShort:string = "DescriptionShort";					 
				 
	Title_EN:string = "Title_EN";					 
				 
	Title_ES:string = "Title_ES";					 
				 
	Slug_EN:string = "Slug_EN";					 
				 
	Slug_ES:string = "Slug_ES";					 
				 
	LargeContent_ES:string = "LargeContent_ES";					 
				 
	LargeContent_EN:string = "LargeContent_EN";					 
				 
	DescriptionShort_ES:string = "DescriptionShort_ES";					 
				 
	DescriptionShort_EN:string = "DescriptionShort_EN";					 
				 
	GuidFile_ES:string = "GuidFile_ES";					 
				 
	GuidFile_EN:string = "GuidFile_EN";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	FieldDataType:string = "FieldDataType";					 
				 
	RelationType:string = "RelationType";					 
				 
	ShowImageInDetails:string = "ShowImageInDetails";					 
				 
	Published:string = "Published";					 
				 
	PublishDate:string = "PublishDate";					 
				 
	RedirectToContent:string = "RedirectToContent";					 
				 
	ImageShowPlace:string = "ImageShowPlace";					 
				 
	IdContent:string = "IdContent";					 
				 
	HeaderScript:string = "HeaderScript";					 
				 
	GuidReusableFeatureType:string = "GuidReusableFeatureType";					 
				 
	GuidFeatureParent:string = "GuidFeatureParent";					 
				 
	TextTags:string = "TextTags";					 
				 
	PreventHtmlEdit:string = "PreventHtmlEdit";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
		FksecContent1:string = "FksecContent1";
		secContent1:string = "secContent1";
				 
		FksecReusableCatalogValue:string = "FksecReusableCatalogValue";
		secReusableCatalogValue:string = "secReusableCatalogValue";
				 
		FksecReusableCatalogValue1:string = "FksecReusableCatalogValue1";
		secReusableCatalogValue1:string = "secReusableCatalogValue1";
				 
		FksecContent2:string = "FksecContent2";
		secContent2:string = "secContent2";
				 
		FksecContentType:string = "FksecContentType";
		secContentType:string = "secContentType";
				 
		FksecFile:string = "FksecFile";
		secFile:string = "secFile";
				 
		FksecFile1:string = "FksecFile1";
		secFile1:string = "secFile1";
				 
		FksecFile2:string = "FksecFile2";
		secFile2:string = "secFile2";
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecReusableCatalogValue2:string = "FksecReusableCatalogValue2";
		secReusableCatalogValue2:string = "secReusableCatalogValue2";
				 
		FksecReusableCatalogValue3:string = "FksecReusableCatalogValue3";
		secReusableCatalogValue3:string = "secReusableCatalogValue3";
				 
	ExistImage:string = "ExistImage";					 
				 
	GuidSecFile:string = "GuidSecFile";					 
				 
	ExistImage_EN:string = "ExistImage_EN";					 
				 
	GuidSecFile_EN:string = "GuidSecFile_EN";					 
				 
	ExistImage_ES:string = "ExistImage_ES";					 
				 
	GuidSecFile_ES:string = "GuidSecFile_ES";					 
				 
	InitialSlug:string = "InitialSlug";					 
				 
	InitialSlug_ES:string = "InitialSlug_ES";					 
				 
	InitialSlug_EN:string = "InitialSlug_EN";					 
				 
	ModuleName_ES:string = "ModuleName_ES";					 
				 
	ModuleName_EN:string = "ModuleName_EN";					 
				 
	ObjectName_ES:string = "ObjectName_ES";					 
				 
	ObjectName_EN:string = "ObjectName_EN";					 
				 
	ComputedOrder:string = "ComputedOrder";					 
				 
}


export  class secContentModel{

	GuidContent:string;					 
	Title:string;					 
	LargeContent:string;					 
	ModuleKey:string;					 
	CreatedDate:string;					 
	CreatedUser:number;					 
	UpdatedDate:string;					 
	PropertyName:string;					 
	BusinessObjectKey:string;					 
	OrderContent:number;					 
	UseMode:string;					 
	ActionKey:string;					 
	MenuKey:string;					 
	Slug:string;					 
	GuidContentType:string;					 
	ForwardType:string;					 
	FormatType:string;					 
	TitleKey:string;					 
	GuidFile:string;					 
	GuidModule:string;					 
	GuidBusinessObject:string;					 
	DescriptionShort:string;					 
	Title_EN:string;					 
	Title_ES:string;					 
	Slug_EN:string;					 
	Slug_ES:string;					 
	LargeContent_ES:string;					 
	LargeContent_EN:string;					 
	DescriptionShort_ES:string;					 
	DescriptionShort_EN:string;					 
	GuidFile_ES:string;					 
	GuidFile_EN:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	IsDeleted:any;					 
	FieldDataType:string;					 
	RelationType:string;					 
	ShowImageInDetails:any;					 
	Published:any;					 
	PublishDate:string;					 
	RedirectToContent:string;					 
	ImageShowPlace:string;					 
	IdContent:number;					 
	HeaderScript:string;					 
	GuidReusableFeatureType:string;					 
	GuidFeatureParent:string;					 
	TextTags:string;					 
	PreventHtmlEdit:any;					 
	ExistImage:any;					 
	GuidSecFile:string;					 
	ExistImage_EN:any;					 
	GuidSecFile_EN:string;					 
	ExistImage_ES:any;					 
	GuidSecFile_ES:string;					 
	InitialSlug:string;					 
	InitialSlug_ES:string;					 
	InitialSlug_EN:string;					 
	ModuleName_ES:string;					 
	ModuleName_EN:string;					 
	ObjectName_ES:string;					 
	ObjectName_EN:string;					 
	ComputedOrder:number;					 

	public static _EntitySetName:string =  "secContents";
	public static _EntityName:string =  "secContent";
	public static PropertyNames: secContentPropertyNames = new secContentPropertyNames();
}


	


 class secRolePropertyNames{
	constructor(){}

	RoleId:string = "RoleId";					 
				 
	RoleName:string = "RoleName";					 
				 
	LoweredRoleName:string = "LoweredRoleName";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	GuidRole:string = "GuidRole";					 
				 
	ParentGuidRole:string = "ParentGuidRole";					 
				 
	CreatedBy:string = "CreatedBy";					 
				 
	UpdatedBy:string = "UpdatedBy";					 
				 
	RoleName_ES:string = "RoleName_ES";					 
				 
	RoleName_EN:string = "RoleName_EN";					 
				 
	Description:string = "Description";					 
				 
	Description_EN:string = "Description_EN";					 
				 
	OwnerCompany:string = "OwnerCompany";					 
				 
	IsDeleted:string = "IsDeleted";					 
				 
	IsHeritable:string = "IsHeritable";					 
				 
	UrlStartForced:string = "UrlStartForced";					 
				 
	NameKey:string = "NameKey";					 
				 
	IsFullAccess:string = "IsFullAccess";					 
				 
		FksecRole1:string = "FksecRole1";
		secRole1:string = "secRole1";
				 
	InitialRoleName:string = "InitialRoleName";					 
				 
}


export  class secRoleModel{

	RoleId:string;					 
	RoleName:string;					 
	LoweredRoleName:string;					 
	UpdatedDate:string;					 
	CreatedDate:string;					 
	GuidRole:string;					 
	ParentGuidRole:string;					 
	CreatedBy:string;					 
	UpdatedBy:string;					 
	RoleName_ES:string;					 
	RoleName_EN:string;					 
	Description:string;					 
	Description_EN:string;					 
	OwnerCompany:string;					 
	IsDeleted:any;					 
	IsHeritable:any;					 
	UrlStartForced:string;					 
	NameKey:string;					 
	IsFullAccess:any;					 
	InitialRoleName:string;					 

	public static _EntitySetName:string =  "secRoles";
	public static _EntityName:string =  "secRole";
	public static PropertyNames: secRolePropertyNames = new secRolePropertyNames();
}


	


 class secTagPropertyNames{
	constructor(){}

	GuidTag:string = "GuidTag";					 
				 
	Title:string = "Title";					 
				 
	Title_EN:string = "Title_EN";					 
				 
	Title_ES:string = "Title_ES";					 
				 
	TagKey:string = "TagKey";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
}


export  class secTagModel{

	GuidTag:string;					 
	Title:string;					 
	Title_EN:string;					 
	Title_ES:string;					 
	TagKey:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secTags";
	public static _EntityName:string =  "secTag";
	public static PropertyNames: secTagPropertyNames = new secTagPropertyNames();
}


	


 class secPermissionPropertyNames{
	constructor(){}

	Name:string = "Name";					 
				 
	NameLocalizable:string = "NameLocalizable";					 
				 
	PermissionKey:string = "PermissionKey";					 
				 
	GuidPermission:string = "GuidPermission";					 
				 
	Name_ES:string = "Name_ES";					 
				 
	Name_EN:string = "Name_EN";					 
				 
	CreatedDate:string = "CreatedDate";					 
				 
	UpdatedDate:string = "UpdatedDate";					 
				 
}


export  class secPermissionModel{

	Name:string;					 
	NameLocalizable:string;					 
	PermissionKey:string;					 
	GuidPermission:string;					 
	Name_ES:string;					 
	Name_EN:string;					 
	CreatedDate:string;					 
	UpdatedDate:string;					 

	public static _EntitySetName:string =  "secPermissions";
	public static _EntityName:string =  "secPermission";
	public static PropertyNames: secPermissionPropertyNames = new secPermissionPropertyNames();
}


	


 class secGeoZipCodePropertyNames{
	constructor(){}

	GuidZipCode:string = "GuidZipCode";					 
				 
	AdminCode1:string = "AdminCode1";					 
				 
	AdminCode2:string = "AdminCode2";					 
				 
	AdminCode3:string = "AdminCode3";					 
				 
	AdminName1:string = "AdminName1";					 
				 
	AdminName2:string = "AdminName2";					 
				 
	AdminName3:string = "AdminName3";					 
				 
	Lng:string = "Lng";					 
				 
	Lat:string = "Lat";					 
				 
	CountryCode:string = "CountryCode";					 
				 
	PostalCode:string = "PostalCode";					 
				 
	PlaceName:string = "PlaceName";					 
				 
}


export  class secGeoZipCodeModel{

	GuidZipCode:string;					 
	AdminCode1:string;					 
	AdminCode2:string;					 
	AdminCode3:string;					 
	AdminName1:string;					 
	AdminName2:string;					 
	AdminName3:string;					 
	Lng:string;					 
	Lat:string;					 
	CountryCode:string;					 
	PostalCode:string;					 
	PlaceName:string;					 

	public static _EntitySetName:string =  "secGeoZipCodes";
	public static _EntityName:string =  "secGeoZipCode";
	public static PropertyNames: secGeoZipCodePropertyNames = new secGeoZipCodePropertyNames();
}


	


 class secContentBusinessObjectPropertyNames{
	constructor(){}

	GuidContent:string = "GuidContent";					 
				 
	GuidBusinessObject:string = "GuidBusinessObject";					 
				 
	GuidContentBusinessObject:string = "GuidContentBusinessObject";					 
				 
		FksecBusinessObject:string = "FksecBusinessObject";
		secBusinessObject:string = "secBusinessObject";
				 
		FksecContent:string = "FksecContent";
		secContent:string = "secContent";
				 
}


export  class secContentBusinessObjectModel{

	GuidContent:string;					 
	GuidBusinessObject:string;					 
	GuidContentBusinessObject:string;					 

	public static _EntitySetName:string =  "secContentBusinessObjects";
	public static _EntityName:string =  "secContentBusinessObject";
	public static PropertyNames: secContentBusinessObjectPropertyNames = new secContentBusinessObjectPropertyNames();
}


	


 class secCompanyRolePropertyNames{
	constructor(){}

	GuidCompany:string = "GuidCompany";					 
				 
	GuidRole:string = "GuidRole";					 
				 
	GuidCompanyRole:string = "GuidCompanyRole";					 
				 
		FksecCompany:string = "FksecCompany";
		secCompany:string = "secCompany";
				 
		FksecRole:string = "FksecRole";
		secRole:string = "secRole";
				 
}


export  class secCompanyRoleModel{

	GuidCompany:string;					 
	GuidRole:string;					 
	GuidCompanyRole:string;					 

	public static _EntitySetName:string =  "secCompanyRoles";
	public static _EntityName:string =  "secCompanyRole";
	public static PropertyNames: secCompanyRolePropertyNames = new secCompanyRolePropertyNames();
}


	


 class secContentTagPropertyNames{
	constructor(){}

	GuidContent:string = "GuidContent";					 
				 
	GuidTag:string = "GuidTag";					 
				 
	GuidContentTag:string = "GuidContentTag";					 
				 
		FksecContent:string = "FksecContent";
		secContent:string = "secContent";
				 
		FksecTag:string = "FksecTag";
		secTag:string = "secTag";
				 
}


export  class secContentTagModel{

	GuidContent:string;					 
	GuidTag:string;					 
	GuidContentTag:string;					 

	public static _EntitySetName:string =  "secContentTags";
	public static _EntityName:string =  "secContentTag";
	public static PropertyNames: secContentTagPropertyNames = new secContentTagPropertyNames();
}


	


 class secModulePermissionPropertyNames{
	constructor(){}

	GuidModule:string = "GuidModule";					 
				 
	GuidPermission:string = "GuidPermission";					 
				 
	GuidModulePermission:string = "GuidModulePermission";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecPermission:string = "FksecPermission";
		secPermission:string = "secPermission";
				 
}


export  class secModulePermissionModel{

	GuidModule:string;					 
	GuidPermission:string;					 
	GuidModulePermission:string;					 

	public static _EntitySetName:string =  "secModulePermissions";
	public static _EntityName:string =  "secModulePermission";
	public static PropertyNames: secModulePermissionPropertyNames = new secModulePermissionPropertyNames();
}


	


 class secModuleRolePropertyNames{
	constructor(){}

	GuidModuleRole:string = "GuidModuleRole";					 
				 
	GuidModule:string = "GuidModule";					 
				 
	GuidRole:string = "GuidRole";					 
				 
		FksecModule:string = "FksecModule";
		secModule:string = "secModule";
				 
		FksecRole:string = "FksecRole";
		secRole:string = "secRole";
				 
}


export  class secModuleRoleModel{

	GuidModuleRole:string;					 
	GuidModule:string;					 
	GuidRole:string;					 

	public static _EntitySetName:string =  "secModuleRoles";
	public static _EntityName:string =  "secModuleRole";
	public static PropertyNames: secModuleRolePropertyNames = new secModuleRolePropertyNames();
}


	


 class BuyCreditPropertyNames{
	constructor(){}

	IdBuyCredit:string = "IdBuyCredit";					 
				 
	Amount:string = "Amount";					 
				 
	SelectMethod:string = "SelectMethod";					 
				 
	Buttons:string = "Buttons";					 
				 
}


export  class BuyCreditModel{

	IdBuyCredit:number;					 
	Amount:number;					 
	SelectMethod:string;					 
	Buttons:string;					 

	public static _EntitySetName:string =  "BuyCredits";
	public static _EntityName:string =  "BuyCredit";
	public static PropertyNames: BuyCreditPropertyNames = new BuyCreditPropertyNames();
}


	


 class RegisterPropertyNames{
	constructor(){}

	IdRegister:string = "IdRegister";					 
				 
	UserName:string = "UserName";					 
				 
	Email:string = "Email";					 
				 
	Password:string = "Password";					 
				 
	Password2:string = "Password2";					 
				 
	FirstName:string = "FirstName";					 
				 
	LastName:string = "LastName";					 
				 
	Captcha:string = "Captcha";					 
				 
	Buttons:string = "Buttons";					 
				 
}


export  class RegisterModel{

	IdRegister:number;					 
	UserName:string;					 
	Email:string;					 
	Password:string;					 
	Password2:string;					 
	FirstName:string;					 
	LastName:string;					 
	Captcha:string;					 
	Buttons:string;					 

	public static _EntitySetName:string =  "Registers";
	public static _EntityName:string =  "Register";
	public static PropertyNames: RegisterPropertyNames = new RegisterPropertyNames();
}


	


 class RememberPasswordPropertyNames{
	constructor(){}

	IdRememberPassword:string = "IdRememberPassword";					 
				 
	UserNameOrEmail:string = "UserNameOrEmail";					 
				 
}


export  class RememberPasswordModel{

	IdRememberPassword:number;					 
	UserNameOrEmail:string;					 

	public static _EntitySetName:string =  "RememberPasswords";
	public static _EntityName:string =  "RememberPassword";
	public static PropertyNames: RememberPasswordPropertyNames = new RememberPasswordPropertyNames();
}


	


 class ResetPasswordPropertyNames{
	constructor(){}

	IdReset:string = "IdReset";					 
				 
	Password:string = "Password";					 
				 
	Password2:string = "Password2";					 
				 
}


export  class ResetPasswordModel{

	IdReset:number;					 
	Password:string;					 
	Password2:string;					 

	public static _EntitySetName:string =  "ResetPasswordSet";
	public static _EntityName:string =  "ResetPassword";
	public static PropertyNames: ResetPasswordPropertyNames = new ResetPasswordPropertyNames();
}


	


 class MyAccountEditPropertyNames{
	constructor(){}

	UserId:string = "UserId";					 
				 
	FirstName:string = "FirstName";					 
				 
	LastName:string = "LastName";					 
				 
	UserName:string = "UserName";					 
				 
	Email:string = "Email";					 
				 
	Password:string = "Password";					 
				 
	Buttons:string = "Buttons";					 
				 
}


export  class MyAccountEditModel{

	UserId:string;					 
	FirstName:string;					 
	LastName:string;					 
	UserName:string;					 
	Email:string;					 
	Password:string;					 
	Buttons:string;					 

	public static _EntitySetName:string =  "MyAccountEdits";
	public static _EntityName:string =  "MyAccountEdit";
	public static PropertyNames: MyAccountEditPropertyNames = new MyAccountEditPropertyNames();
}


	


 class MyAccountDisplayPropertyNames{
	constructor(){}

	UserId:string = "UserId";					 
				 
	FirstName:string = "FirstName";					 
				 
	LastName:string = "LastName";					 
				 
	UserName:string = "UserName";					 
				 
	Email:string = "Email";					 
				 
	Password:string = "Password";					 
				 
	Credits:string = "Credits";					 
				 
}


export  class MyAccountDisplayModel{

	UserId:string;					 
	FirstName:string;					 
	LastName:string;					 
	UserName:string;					 
	Email:string;					 
	Password:string;					 
	Credits:number;					 

	public static _EntitySetName:string =  "MyAccountDisplays";
	public static _EntityName:string =  "MyAccountDisplay";
	public static PropertyNames: MyAccountDisplayPropertyNames = new MyAccountDisplayPropertyNames();
}


	


 class MyCompanyChangePropertyNames{
	constructor(){}

		FkCurrentCompany:string = "FkCurrentCompany";
		CurrentCompany:string = "CurrentCompany";
				 
	ReturnUrl:string = "ReturnUrl";					 
				 
	IdMyCompanyChange:string = "IdMyCompanyChange";					 
				 
	GuidCurrentCompany:string = "GuidCurrentCompany";					 
				 
}


export  class MyCompanyChangeModel{

	ReturnUrl:string;					 
	IdMyCompanyChange:number;					 
	GuidCurrentCompany:string;					 

	public static _EntitySetName:string =  "MyCompanyChange";
	public static _EntityName:string =  "MyCompanyChange";
	public static PropertyNames: MyCompanyChangePropertyNames = new MyCompanyChangePropertyNames();
}


	
