

/************ Update: Tables ***************/

/******************** Add Table: dbo.secAppTemplate ************************/

/* Build Table Structure */
CREATE TABLE dbo.secAppTemplate
(
	GuidAppTemplate UniqueIdentifier NOT NULL,
	Title VARCHAR(255) NULL,
	RelativeHttpPath VARCHAR(1000) NULL,
	GuidExclusiveModule UniqueIdentifier NULL,
	Description VARCHAR(MAX) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secAppTemplate ADD CONSTRAINT pksecAppTemplate
	PRIMARY KEY (GuidAppTemplate);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secAppTemplate_FullStatics_Idx ON dbo.secAppTemplate (Bytes, GuidAppTemplate, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secAudit ************************/

/* Build Table Structure */
CREATE TABLE dbo.secAudit
(
	actionkey VARCHAR(50) NULL,
	RevisionStamp DATETIME NULL,
	ExtraInfo NCHAR(300) NULL,
	ExtraSystemInfo VARCHAR(500) NULL,
	TableName VARCHAR(50) NULL,
	Actions VARCHAR(1) NULL,
	ChangedColumns VARCHAR(1000) NULL,
	OldData NVARCHAR(MAX) NULL,
	NewData NVARCHAR(MAX) NULL,
	AuditId UniqueIdentifier NOT NULL,
	BusinessObjectKey VARCHAR(255) NULL,
	GuidBusinessObject UniqueIdentifier NULL,
	GuidUser UniqueIdentifier DEFAULT newid() NULL,
	GuidCompany UniqueIdentifier NULL,
	Format INTEGER NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secAudit ADD CONSTRAINT PK_myAudit
	PRIMARY KEY (AuditId);

/* Add Indexes */
CREATE NONCLUSTERED INDEX IX_BusinessObjectKey ON dbo.secAudit (BusinessObjectKey, GuidBusinessObject);

CREATE NONCLUSTERED INDEX secAudit_FullStatics_Idx ON dbo.secAudit (Bytes, AuditId, CreatedDate, UpdatedDate, GuidCompany);


/******************** Add Table: dbo.secAuditProperties ************************/

/* Build Table Structure */
CREATE TABLE dbo.secAuditProperties
(
	AuditId UniqueIdentifier NOT NULL,
	PropertyName VARCHAR(100) NOT NULL,
	PropertyValueInt INTEGER NULL,
	PropertyValueText VARCHAR(MAX) NULL,
	propertyValueGuid UniqueIdentifier NULL,
	propertyValueBinary VARBINARY(MAX) NULL,
	PropertyType VARCHAR(255) NULL,
	PropertyDisplay VARCHAR(MAX) NULL,
	PropertyValue VARCHAR(MAX) NULL,
	GuidProperty UniqueIdentifier NOT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secAuditProperties ADD CONSTRAINT PK_myAuditProperties
	PRIMARY KEY (GuidProperty);


/******************** Add Table: dbo.secBizObjProperty ************************/

/* Build Table Structure */
CREATE TABLE dbo.secBizObjProperty
(
	GuidBizObjProperty UniqueIdentifier NOT NULL,
	Name NVARCHAR(255) NULL,
	GuidBusinessObject UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secBizObjProperty ADD CONSTRAINT pksecBizObjProperty
	PRIMARY KEY (GuidBizObjProperty);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secBizObjProperty_FullStatics_Idx ON dbo.secBizObjProperty (Bytes, GuidBizObjProperty, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secBizPartner ************************/

/* Build Table Structure */
CREATE TABLE dbo.secBizPartner
(
	GuidBizPartner UniqueIdentifier NOT NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	IsDeleted BIT NULL,
	GuidUser UniqueIdentifier NULL,
	Authorized BIT NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secBizPartner ADD CONSTRAINT pksecBizPartner
	PRIMARY KEY (GuidBizPartner);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secBizPartner_FullStatics_Idx ON dbo.secBizPartner (Bytes, GuidBizPartner, CreatedDate, UpdatedDate, CreatedBy, IsDeleted);


/******************** Add Table: dbo.secBizPropertyDescriptions ************************/

/* Build Table Structure */
CREATE TABLE dbo.secBizPropertyDescriptions
(
	GuidBizPropertyDescription UniqueIdentifier NOT NULL,
	GuidBizObjProperty UniqueIdentifier NULL,
	UICulture VARCHAR(5) NULL,
	Name NVARCHAR(1000) NULL,
	ShortDescription NVARCHAR(255) NULL,
	ShortWarning NVARCHAR(255) NULL,
	LongDescription NVARCHAR(4000) NULL,
	GuidBusinessObject UniqueIdentifier NULL,
	OwnerComptany UniqueIdentifier NULL,
	ResourceKey VARCHAR(255) NULL,
	PluralName NVARCHAR(100) NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	PlaceHolder VARCHAR(255) NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secBizPropertyDescriptions ADD CONSTRAINT pksecBizPropertyDescriptions
	PRIMARY KEY (GuidBizPropertyDescription);

/* Add Indexes */
CREATE NONCLUSTERED INDEX _dta_index_secBizPropertyDescriptions_15_373576369__K3_K10_K8_K2_1_4_5_6_7_9_11_12_13_14 ON dbo.secBizPropertyDescriptions (GuidBizPropertyDescription, Name, ShortDescription, ShortWarning, LongDescription, OwnerComptany, PluralName, CreatedDate, UpdatedDate, UpdatedBy, UICulture, ResourceKey, GuidBusinessObject, GuidBizObjProperty);

CREATE NONCLUSTERED INDEX secBizPropertyDescriptions_FullStatics_Idx ON dbo.secBizPropertyDescriptions (Bytes, GuidBizPropertyDescription, CreatedDate, UpdatedDate);

CREATE NONCLUSTERED INDEX secBizPropertyDescriptions_GuidBusinessObject_GuidBizObjProperty_UICulture_Idx ON dbo.secBizPropertyDescriptions (GuidBusinessObject, GuidBizObjProperty, UICulture);

CREATE NONCLUSTERED INDEX secBizPropertyDescriptions_UICulture_Idx ON dbo.secBizPropertyDescriptions (UICulture);


/******************** Add Table: dbo.secBusinessObject ************************/

/* Build Table Structure */
CREATE TABLE dbo.secBusinessObject
(
	BusinessObjectKey VARCHAR(255) NULL,
	Name VARCHAR(300) NULL,
	EntitySetName VARCHAR(50) NULL,
	TableName VARCHAR(50) NULL,
	ExtensibleInfo XML NULL,
	GuidModule UniqueIdentifier NULL,
	GuidBusinessObject UniqueIdentifier DEFAULT newid() NOT NULL,
	Name_ES VARCHAR(300) NULL,
	Name_EN VARCHAR(300) NULL,
	Syncable BIT DEFAULT 'false' NOT NULL,
	Usemode VARCHAR(255) NULL,
	UsemodeFrom UniqueIdentifier NULL,
	IsUICustom BIT DEFAULT 'false' NOT NULL,
	TypeId VARCHAR(150) NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy UniqueIdentifier NULL,
	HideFromNavigation BIT DEFAULT 'false' NOT NULL,
	DisabledForNavigation BIT DEFAULT 'false' NULL,
	UseModeQuery VARCHAR(1000) NULL,
	Bytes INTEGER NULL,
	IsCustom BIT DEFAULT 'false' NOT NULL,
	GuidNoSQLOption UniqueIdentifier NULL,
	GuidReusableStorageType UniqueIdentifier NULL,
	SQLRows BIGINT NULL,
	NoSQLRows BIGINT NULL,
	HideForPermissions BIT NULL,
	CosmosDBRows BIGINT NULL,
	TableStorageRows BIGINT NULL,
	SQLEnabled BIT NULL,
	CosmosDBEnabled BIT NULL,
	TableStorageEnabled BIT NULL,
	GuidReusableStoragePrimary UniqueIdentifier NULL,
	GuidReusableStorageForGet UniqueIdentifier NULL,
	GuidReusableNoSQLGetDefault UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secBusinessObject ADD CONSTRAINT PK_secBusinessObject
	PRIMARY KEY (GuidBusinessObject);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secBusinessObject_BusinessObjectKey_Idx ON dbo.secBusinessObject (BusinessObjectKey);

CREATE NONCLUSTERED INDEX secBusinessObject_FullStatics_Idx ON dbo.secBusinessObject (Bytes, GuidBusinessObject, CreatedDate, UpdatedDate);

CREATE NONCLUSTERED INDEX secBusinessObject_TypeId_Idx ON dbo.secBusinessObject (TypeId);


/******************** Add Table: dbo.secChatGroup ************************/

/* Build Table Structure */
CREATE TABLE dbo.secChatGroup
(
	GuidChatGroup UniqueIdentifier NOT NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	NumPersons INTEGER NULL,
	GuidModule UniqueIdentifier NULL,
	GuidUserCompany UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secChatGroup ADD CONSTRAINT pksecChatGroup
	PRIMARY KEY (GuidChatGroup);


/******************** Add Table: dbo.secChatGroupUser ************************/

/* Build Table Structure */
CREATE TABLE dbo.secChatGroupUser
(
	GuidChatGroupUser UniqueIdentifier NOT NULL,
	GuidUser UniqueIdentifier NULL,
	GuidChatGroup UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	IsDeleted BIT DEFAULT 'false' NOT NULL,
	IsOwner BIT DEFAULT 'false' NOT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secChatGroupUser ADD CONSTRAINT pksecChatGroupUser
	PRIMARY KEY (GuidChatGroupUser);


/******************** Add Table: dbo.secComModSetting ************************/

/* Build Table Structure */
CREATE TABLE dbo.secComModSetting
(
	GuidCompModSetting UniqueIdentifier NOT NULL,
	GuidCompanyModule UniqueIdentifier NULL,
	GuidSetting UniqueIdentifier NULL,
	GuidSettingVaue UniqueIdentifier NULL,
	ValueInt INTEGER NULL,
	ValueBoolean BIT NULL,
	ValueDecimal DECIMAL(10, 2) NULL,
	ValueString VARCHAR(255) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secComModSetting ADD CONSTRAINT pksecComModSetting
	PRIMARY KEY (GuidCompModSetting);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secComModSetting_FullStatics_Idx ON dbo.secComModSetting (Bytes, GuidCompModSetting, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secCompAppBizObject ************************/

/* Build Table Structure */
CREATE TABLE dbo.secCompAppBizObject
(
	GuidCompAppBizObject UniqueIdentifier NOT NULL,
	GuidCompanyModule UniqueIdentifier NULL,
	GuidBusinessObject UniqueIdentifier NULL,
	TotalBytes FLOAT NULL,
	TotalDeleted INTEGER NULL,
	TotalItems INTEGER NULL,
	TotalsUpdated DATETIME NULL,
	UpdatedDateTotals DATETIME NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	TotalBytesDeleted FLOAT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secCompAppBizObject ADD CONSTRAINT pksecCompAppBizObject
	PRIMARY KEY (GuidCompAppBizObject);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secCompAppBizObject_FullStatics_Idx ON dbo.secCompAppBizObject (Bytes, GuidCompAppBizObject, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secCompAppFeature ************************/

/* Build Table Structure */
CREATE TABLE dbo.secCompAppFeature
(
	GuidCompAppFeature UniqueIdentifier NOT NULL,
	GuidFeatureConcept UniqueIdentifier NULL,
	GuidCompanyModule UniqueIdentifier NULL,
	GuidCompany UniqueIdentifier NULL,
	GuidModule UniqueIdentifier NULL,
	DiscountPrecent DECIMAL(10, 2) NULL,
	FromDateTime DATETIME NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secCompAppFeature ADD CONSTRAINT pksecCompAppFeature
	PRIMARY KEY (GuidCompAppFeature);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secCompAppFeature_FullStatics_Idx ON dbo.secCompAppFeature (Bytes, GuidCompAppFeature, CreatedDate, UpdatedDate, GuidCompany);


/******************** Add Table: dbo.secCompAppHistory ************************/

/* Build Table Structure */
CREATE TABLE dbo.secCompAppHistory
(
	GuidCompAppHistory UniqueIdentifier NOT NULL,
	GuidCompanyModule UniqueIdentifier NULL,
	StatDate DATETIME NOT NULL,
	TotalBytes FLOAT NULL,
	TotalCreated INTEGER NULL,
	TotalDeleted INTEGER NULL,
	TotalUpdated INTEGER NULL,
	TotalMessages INTEGER NULL,
	TotalSumBytes FLOAT NULL,
	TotalSumKbytes FLOAT NULL,
	TotalSumMb FLOAT NULL,
	TotalUsers INTEGER NULL,
	TotalCustomRoles INTEGER NULL,
	TotalFilesGb FLOAT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	TotalNowGlobalBytes FLOAT NULL,
	TotalErrors INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secCompAppHistory ADD CONSTRAINT pksecCompAppHistory
	PRIMARY KEY (GuidCompAppHistory);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secCompAppHistory_FullStatics_Idx ON dbo.secCompAppHistory (Bytes, GuidCompAppHistory, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secCompModConfig ************************/

/* Build Table Structure */
CREATE TABLE dbo.secCompModConfig
(
	GuidCompModConfig UniqueIdentifier NOT NULL,
	GuidCompanyModule UniqueIdentifier NULL,
	GuidReusable_CompModConfig UniqueIdentifier NULL,
	ValueString VARCHAR(255) NULL,
	ValueTime TIMESTAMP NULL,
	ValueInt INTEGER NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secCompModConfig ADD CONSTRAINT pksecCompModConfig
	PRIMARY KEY (GuidCompModConfig);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secCompModConfig_FullStatics_Idx ON dbo.secCompModConfig (Bytes, GuidCompModConfig, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secCompUISetting ************************/

/* Build Table Structure */
CREATE TABLE dbo.secCompUISetting
(
	GuidCompUISetting UniqueIdentifier NOT NULL,
	GuidCompany UniqueIdentifier NULL,
	PrimaryButtonsBG VARCHAR(50) NULL,
	PrimaryButtonsTextColor VARCHAR(50) NULL,
	TopMenuBG VARCHAR(50) NULL,
	TopCompanyLogoBG VARCHAR(50) NULL,
	AppMenuBG VARCHAR(50) NULL,
	BGColor VARCHAR(50) NULL,
	FormBG VARCHAR(50) NULL,
	InputFocusedBG VARCHAR(50) NULL,
	Title VARCHAR(100) NOT NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	TextLinkColor VARCHAR(50) NULL,
	ListHeaderTextColor VARCHAR(50) NULL,
	ListHeaderBG VARCHAR(50) NULL,
	Bytes INTEGER NULL,
	IsDeleted BIT NULL,
	WarningColorLiteBG VARCHAR(50) NULL,
	ErrorColorLiteBG VARCHAR(50) NULL,
	SuccessColorLiteBG VARCHAR(50) NULL,
	CssCode VARCHAR(MAX) NULL,
	BodyClasses VARCHAR(100) NULL,
	TextTitle1Color VARCHAR(50) NULL,
	TextTitle2Color VARCHAR(50) NULL,
	ListItemOverBG VARCHAR(50) NULL,
	UserProfileInSideMenu BIT NULL,
	IconsDefaultColor VARCHAR(50) NULL,
	ControlFillColorDefault VARCHAR(50) NULL,
	GuidModule UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secCompUISetting ADD CONSTRAINT pksecCompUISetting
	PRIMARY KEY (GuidCompUISetting);

/* Add Comments */
EXEC sp_addextendedproperty 'MS_Description', 'Color de controles que necesitan ser llenados, por ejemplo el caso de los checkbox', 'schema', 'dbo', 
	'table', 'secCompUISetting', 'column', 'ControlFillColorDefault';


/******************** Add Table: dbo.secCompanies ************************/

/* Build Table Structure */
CREATE TABLE dbo.secCompanies
(
	Name VARCHAR(300) NOT NULL,
	GuidCompanyType UniqueIdentifier NULL,
	GuidCompany UniqueIdentifier DEFAULT newid() NOT NULL,
	CompanyParentGuid UniqueIdentifier NULL,
	UpdatedDate DATETIME NULL,
	CreatedDate DATETIME NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	IsDeleted BIT NULL,
	GuidFileLogo UniqueIdentifier NULL,
	GuidCountry UniqueIdentifier NULL,
	GuidState UniqueIdentifier NULL,
	GuidCity UniqueIdentifier NULL,
	GuidUserOwner UniqueIdentifier NULL,
	Description VARCHAR(1000) NULL,
	CanChildMoreChildren BIT NULL,
	CanChildsAdminRoles BIT NULL,
	IntegrationID UniqueIdentifier NULL,
	TimeZoneNameID VARCHAR(255) NULL,
	ColorPrimary VARCHAR(100) NULL,
	ColorBGApp VARCHAR(100) NULL,
	ColorBGForm VARCHAR(100) NULL,
	Bytes INTEGER NULL,
	HidePlatformBrand BIT NULL,
	CustomDomain VARCHAR(255) NULL,
	CustomEmailSender VARCHAR(255) NULL,
	NameKey VARCHAR(100) NULL,
	GuidCompUISetting UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secCompanies ADD CONSTRAINT Company_PK
	PRIMARY KEY (GuidCompany);

/* Add Indexes */
CREATE NONCLUSTERED INDEX _dta_index_secCompanies_15_437576597__K6_K9_K2_K3_K4_K14_1_5_7_8_10_11_12_13_15_16_17_18_19 ON dbo.secCompanies (Name, UpdatedDate, UpdatedBy, CreatedBy, GuidFileLogo, GuidCountry, GuidState, GuidCity, Description, CanChildMoreChildren, CanChildsAdminRoles, IntegrationID, TimeZoneNameID, CreatedDate, IsDeleted, GuidCompanyType, GuidCompany, CompanyParentGuid, GuidUserOwner);

CREATE NONCLUSTERED INDEX company_customdomain ON dbo.secCompanies (Name, UpdatedDate, UpdatedBy, CreatedBy, GuidFileLogo, GuidCountry, GuidState, GuidCity, Description, CanChildMoreChildren, CanChildsAdminRoles, IntegrationID, TimeZoneNameID, CreatedDate, IsDeleted, GuidCompanyType, GuidCompany, CompanyParentGuid, GuidUserOwner, CustomDomain);

CREATE NONCLUSTERED INDEX secCompanies_FullStatics_Idx ON dbo.secCompanies (Bytes, GuidCompany, CreatedDate, UpdatedDate, CreatedBy, IsDeleted);

CREATE NONCLUSTERED INDEX secCompanies_GuidCompany_CompanyParentGuid_IsDeleted_Idx ON dbo.secCompanies (GuidCompany, CompanyParentGuid, IsDeleted);

CREATE NONCLUSTERED INDEX secCompanies_NameKey ON dbo.secCompanies (GuidCompany, NameKey, CustomDomain);


/******************** Add Table: dbo.secCompanyConfigurations ************************/

/* Build Table Structure */
CREATE TABLE dbo.secCompanyConfigurations
(
	GuidCompany UniqueIdentifier NOT NULL,
	GuidReusableCatalog UniqueIdentifier NOT NULL,
	ValueString VARCHAR(20) NULL,
	ValueInt INTEGER NULL,
	ValueBoolean BIT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secCompanyConfigurations ADD CONSTRAINT pksecCompanyConfigurations
	PRIMARY KEY (GuidCompany, GuidReusableCatalog);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secCompanyConfigurations_FullStatics_Idx ON dbo.secCompanyConfigurations (Bytes, GuidCompany, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secCompanyExtraData ************************/

/* Build Table Structure */
CREATE TABLE dbo.secCompanyExtraData
(
	GuidExtraData UniqueIdentifier NOT NULL,
	PaypalIdOrEmail VARCHAR(200) NULL,
	UpdatedDate DATETIME NULL,
	CreatedDate DATETIME NULL,
	PayInstructionsPhone VARCHAR(1000) NULL,
	PayInstructionsPaypal VARCHAR(1000) NULL,
	PayInstructionsCash VARCHAR(1000) NULL,
	PayInstructionsPreCard VARCHAR(1000) NULL,
	LogoFileName VARCHAR(300) NULL,
	LogoFileData VARBINARY(MAX) NULL,
	LogoFileSize INTEGER NULL,
	LogoFileType VARCHAR(50) NULL,
	LegalName VARCHAR(255) NULL,
	VATKey VARCHAR(12) NULL,
	Address VARCHAR(300) NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	GuidCompany UniqueIdentifier NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secCompanyExtraData ADD CONSTRAINT PK_secPaymentProviderData
	PRIMARY KEY (GuidExtraData);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secCompanyExtraData_FullStatics_Idx ON dbo.secCompanyExtraData (Bytes, GuidExtraData, CreatedDate, UpdatedDate, CreatedBy, GuidCompany);


/******************** Add Table: dbo.secCompanyLogin ************************/

/* Build Table Structure */
CREATE TABLE dbo.secCompanyLogin
(
	GuidCompanyLogin UniqueIdentifier NOT NULL,
	GuidCompany UniqueIdentifier NOT NULL,
	Microsoft BIT NULL,
	Google BIT NULL,
	LinkedIn BIT NULL,
	Facebook BIT NULL,
	Yahoo BIT NULL,
	Twitter BIT NULL,
	MicrosoftClientId VARCHAR(255) NULL,
	MicrosoftClientSecret VARCHAR(255) NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secCompanyLogin ADD CONSTRAINT pksecCompanyLogin
	PRIMARY KEY (GuidCompanyLogin);

/* Add Indexes */
CREATE UNIQUE NONCLUSTERED INDEX secCompanyLogin_GuidCompany_Idx ON dbo.secCompanyLogin (GuidCompany);


/******************** Add Table: dbo.secCompanyModules ************************/

/* Build Table Structure */
CREATE TABLE dbo.secCompanyModules
(
	GuidModule UniqueIdentifier NULL,
	GuidCompany UniqueIdentifier NULL,
	GuidCompanyModule UniqueIdentifier NOT NULL,
	TotalBytes FLOAT NULL,
	TotalDeleted INTEGER NULL,
	TotalDeletedBytes FLOAT NULL,
	TotalItems INTEGER NULL,
	UpdatedDateTotals DATETIME NULL,
	GuidAppTemplate UniqueIdentifier NULL,
	StartDate DATETIME NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	TotalUsers INTEGER NULL,
	TotalUserRoles INTEGER NULL,
	TotalAuditCatalogs INTEGER NULL,
	CompanyChildren INTEGER NULL,
	ChildrenTotalBytes FLOAT NULL,
	TotalBytesWithChildren FLOAT NULL,
	TotalUserRolesWithChildren INTEGER NULL,
	DefaultInPublic BIT NULL,
	HideFromPublic BIT NULL,
	CustomDomain VARCHAR(100) NULL,
	DisableThirdPartyProviders BIT NULL,
	FaceBookAppId VARCHAR(300) NULL,
	FacebookAppSecret VARCHAR(300) NULL,
	MicrosoftClientId VARCHAR(300) NULL,
	MicrosoftClientSecret VARCHAR(300) NULL,
	GoogleClientId VARCHAR(300) NULL,
	GoogleClientSecret VARCHAR(300) NULL,
	PreventChangeCompany BIT NULL,
	RecaptchaPublicKey VARCHAR(255) NULL,
	RecaptchaPrivateKey VARCHAR(255) NULL,
	Office365ClientId VARCHAR(255) NULL,
	Office365ClientSecret VARCHAR(255) NULL,
	Office365Authority VARCHAR(255) NULL,
	IsDeleted BIT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secCompanyModules ADD CONSTRAINT pksecCompanyModules
	PRIMARY KEY (GuidCompanyModule);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secCompanyModules_FullStatics_Idx ON dbo.secCompanyModules (Bytes, GuidCompanyModule, CreatedDate, UpdatedDate, GuidCompany);

CREATE UNIQUE NONCLUSTERED INDEX secCompanyModules_GuidModule_GuidCompany_Idx ON dbo.secCompanyModules (GuidModule, GuidCompany);


/******************** Add Table: dbo.secCompanyRoles ************************/

/* Build Table Structure */
CREATE TABLE dbo.secCompanyRoles
(
	GuidCompany UniqueIdentifier NOT NULL,
	GuidRole UniqueIdentifier NOT NULL,
	GuidCompanyRole UniqueIdentifier DEFAULT newid() NOT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secCompanyRoles ADD CONSTRAINT pksecCompanyRoles
	PRIMARY KEY (GuidCompanyRole);


/******************** Add Table: dbo.secCompanyType ************************/

/* Build Table Structure */
CREATE TABLE dbo.secCompanyType
(
	Name VARCHAR(100) NULL,
	NameKey VARCHAR(50) NULL,
	GuidCompanyType UniqueIdentifier DEFAULT newid() NOT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secCompanyType ADD CONSTRAINT PK_secCompanyType
	PRIMARY KEY (GuidCompanyType);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secCompanyType_FullStatics_Idx ON dbo.secCompanyType (Bytes, GuidCompanyType, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secContentBusinessObjects ************************/

/* Build Table Structure */
CREATE TABLE dbo.secContentBusinessObjects
(
	GuidContent UniqueIdentifier NOT NULL,
	GuidBusinessObject UniqueIdentifier NOT NULL,
	GuidContentBusinessObject UniqueIdentifier NOT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secContentBusinessObjects ADD CONSTRAINT pksecContentBusinessObjects
	PRIMARY KEY (GuidContentBusinessObject);


/******************** Add Table: dbo.secContentMenus ************************/

/* Build Table Structure */
CREATE TABLE dbo.secContentMenus
(
	GuidContent UniqueIdentifier NOT NULL,
	MenuKey VARCHAR(50) NOT NULL,
	GuidContentMenu UniqueIdentifier NOT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secContentMenus ADD CONSTRAINT PK_myContentMenus
	PRIMARY KEY (GuidContentMenu);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secContentMenus_FullStatics_Idx ON dbo.secContentMenus (Bytes, GuidContentMenu, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secContentRelations ************************/

/* Build Table Structure */
CREATE TABLE dbo.secContentRelations
(
	GuidContent UniqueIdentifier NOT NULL,
	GuidParent UniqueIdentifier NOT NULL,
	OrderParent INTEGER NULL,
	GuidContentsRelation UniqueIdentifier NOT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secContentRelations ADD CONSTRAINT PK_myContentRelations
	PRIMARY KEY (GuidContentsRelation);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secContentRelations_FullStatics_Idx ON dbo.secContentRelations (Bytes, GuidContentsRelation, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secContentTags ************************/

/* Build Table Structure */
CREATE TABLE dbo.secContentTags
(
	GuidContent UniqueIdentifier NOT NULL,
	GuidTag UniqueIdentifier NOT NULL,
	GuidContentTag UniqueIdentifier DEFAULT newid() NOT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secContentTags ADD CONSTRAINT pksecContentTags
	PRIMARY KEY (GuidContentTag);


/******************** Add Table: dbo.secContentType ************************/

/* Build Table Structure */
CREATE TABLE dbo.secContentType
(
	Name VARCHAR(255) NULL,
	ContentTypeKey VARCHAR(20) NULL,
	GuidContentType UniqueIdentifier DEFAULT newid() NOT NULL,
	Name_ES VARCHAR(255) NULL,
	Name_EN VARCHAR(255) NULL,
	PluralName VARCHAR(255) NULL,
	PluralName_ES VARCHAR(255) NULL,
	PluralName_EN VARCHAR(255) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secContentType ADD CONSTRAINT PK_myContentType
	PRIMARY KEY (GuidContentType);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secContentType_FullStatics_Idx ON dbo.secContentType (Bytes, GuidContentType, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secContents ************************/

/* Build Table Structure */
CREATE TABLE dbo.secContents
(
	GuidContent UniqueIdentifier NOT NULL,
	Title VARCHAR(150) NULL,
	LargeContent VARCHAR(MAX) NULL,
	ModuleKey VARCHAR(50) NULL,
	CreatedDate DATETIME NULL,
	CreatedUser INTEGER NULL,
	UpdatedDate DATETIME NULL,
	PropertyName VARCHAR(50) NULL,
	BusinessObjectKey VARCHAR(50) NULL,
	OrderContent INTEGER NULL,
	UseMode VARCHAR(50) NULL,
	ActionKey VARCHAR(50) NULL,
	MenuKey VARCHAR(50) NULL,
	Slug VARCHAR(255) NULL,
	GuidContentType UniqueIdentifier NULL,
	ForwardType UniqueIdentifier NULL,
	FormatType UniqueIdentifier NULL,
	TitleKey VARCHAR(400) NULL,
	GuidFile UniqueIdentifier NULL,
	GuidModule UniqueIdentifier NULL,
	GuidBusinessObject UniqueIdentifier NULL,
	DescriptionShort VARCHAR(500) NULL,
	Title_EN VARCHAR(150) NULL,
	Title_ES VARCHAR(150) NULL,
	Slug_EN VARCHAR(255) NULL,
	Slug_ES VARCHAR(255) NULL,
	LargeContent_ES VARCHAR(MAX) NULL,
	LargeContent_EN VARCHAR(MAX) NULL,
	DescriptionShort_ES VARCHAR(500) NULL,
	DescriptionShort_EN VARCHAR(500) NULL,
	GuidFile_ES UniqueIdentifier NULL,
	GuidFile_EN UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	IsDeleted BIT NULL,
	FieldDataType VARCHAR(50) NULL,
	RelationType VARCHAR(5) NULL,
	ShowImageInDetails BIT NULL,
	Published BIT NULL,
	PublishDate DATETIME NULL,
	RedirectToContent UniqueIdentifier NULL,
	ImageShowPlace UniqueIdentifier NULL,
	IdContent INTEGER NULL,
	HeaderScript VARCHAR(MAX) NULL,
	GuidReusableFeatureType UniqueIdentifier NULL,
	GuidFeatureParent UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	TextTags VARCHAR(255) NULL,
	PreventHtmlEdit BIT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secContents ADD CONSTRAINT PK_MyContents
	PRIMARY KEY (GuidContent);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secContents_FullStatics_Idx ON dbo.secContents (Bytes, GuidContent, CreatedDate, UpdatedDate, CreatedBy, IsDeleted);

CREATE UNIQUE NONCLUSTERED INDEX secContents_Slug_EN_Idx ON dbo.secContents (Slug_EN);

CREATE UNIQUE NONCLUSTERED INDEX secContents_Slug_ES_Idx ON dbo.secContents (Slug_ES);

CREATE UNIQUE NONCLUSTERED INDEX secContents_Slug_Idx ON dbo.secContents (Slug);


/******************** Add Table: dbo.secCoupon ************************/

/* Build Table Structure */
CREATE TABLE dbo.secCoupon
(
	GuidCoupon UniqueIdentifier NOT NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	IsDeleted BIT NULL,
	GuidBizPartner UniqueIdentifier NULL,
	ExpirationDate DATETIME NULL,
	CouponCode VARCHAR(36) NOT NULL,
	IsReusable BIT NULL,
	UseLimit INTEGER NULL,
	Price DECIMAL(10, 2) NULL,
	FreeCredits DECIMAL(10, 2) NULL,
	PercentDiscount DECIMAL(10, 2) NULL,
	GuidCouponType UniqueIdentifier NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secCoupon ADD CONSTRAINT pksecCoupon
	PRIMARY KEY (GuidCoupon);

/* Add Indexes */
CREATE UNIQUE NONCLUSTERED INDEX secCoupon_CouponCode_Idx ON dbo.secCoupon (CouponCode);

CREATE NONCLUSTERED INDEX secCoupon_FullStatics_Idx ON dbo.secCoupon (Bytes, GuidCoupon, CreatedDate, UpdatedDate, CreatedBy, IsDeleted);


/******************** Add Table: dbo.secDataColumn ************************/

/* Build Table Structure */
CREATE TABLE dbo.secDataColumn
(
	TableName VARCHAR(100) NULL,
	ColumnName VARCHAR(100) NULL,
	ColumnValue VARCHAR(100) NULL,
	GuidDataColumn UniqueIdentifier DEFAULT newid() NOT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secDataColumn ADD CONSTRAINT secDataColumn_PK
	PRIMARY KEY (GuidDataColumn);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secDataColumn_FullStatics_Idx ON dbo.secDataColumn (Bytes, GuidDataColumn, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secEventApp ************************/

/* Build Table Structure */
CREATE TABLE dbo.secEventApp
(
	GuidEventApp UniqueIdentifier NOT NULL,
	GuidModule UniqueIdentifier NULL,
	NameKey VARCHAR(50) NULL,
	Name VARCHAR(255) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secEventApp ADD CONSTRAINT pksecEventApp
	PRIMARY KEY (GuidEventApp);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secEventApp_FullStatics_Idx ON dbo.secEventApp (Bytes, GuidEventApp, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secEventLog ************************/

/* Build Table Structure */
CREATE TABLE dbo.secEventLog
(
	CreatedDate DATETIME NULL,
	Message VARCHAR(MAX) NOT NULL,
	Category INTEGER NULL,
	Title VARCHAR(300) NULL,
	ProcessId VARCHAR(300) NULL,
	Win32ThreadId VARCHAR(300) NULL,
	IsException BIT NULL,
	GuidMyEventLog UniqueIdentifier DEFAULT newid() NOT NULL,
	CreatedBy UniqueIdentifier NULL,
	GuidModule UniqueIdentifier NULL,
	GuidCompanyLog UniqueIdentifier NULL,
	Url VARCHAR(500) NULL,
	IsAjaxRequest BIT NULL,
	GuidBusinessObject UniqueIdentifier NULL,
	ActionTypeKey VARCHAR(10) NULL,
	IPClient VARCHAR(20) NULL,
	BrowserType VARCHAR(100) NULL,
	BrowserLanguages VARCHAR(20) NULL,
	GuidIssue UniqueIdentifier NULL,
	QueryString VARCHAR(500) NULL,
	UrlReferrer VARCHAR(100) NULL,
	Bytes INTEGER NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secEventLog ADD CONSTRAINT PK_myEventLog
	PRIMARY KEY (GuidMyEventLog);

/* Add Indexes */
CREATE NONCLUSTERED INDEX _dta_index_secEventLog_IsAjaxRequest ON dbo.secEventLog (IsAjaxRequest);

CREATE NONCLUSTERED INDEX secEventLog_CreatedDate_GuidCompanyLog_Idx ON dbo.secEventLog (GuidCompanyLog, CreatedDate);

CREATE NONCLUSTERED INDEX secEventLog_CreatedDate_Idx ON dbo.secEventLog (CreatedDate);

CREATE NONCLUSTERED INDEX secEventLog_FullStatics_Idx ON dbo.secEventLog (Bytes, GuidMyEventLog, CreatedDate, UpdatedDate, CreatedBy);


/******************** Add Table: dbo.secEventNotify ************************/

/* Build Table Structure */
CREATE TABLE dbo.secEventNotify
(
	GuidEventNotify UniqueIdentifier NOT NULL,
	GuidEventApp UniqueIdentifier NULL,
	Conditions VARCHAR(MAX) NULL,
	Title VARCHAR(255) NULL,
	Enabled BIT NULL,
	GuidCompany UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secEventNotify ADD CONSTRAINT pksecEventNotify
	PRIMARY KEY (GuidEventNotify);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secEventNotify_FullStatics_Idx ON dbo.secEventNotify (Bytes, GuidEventNotify, CreatedDate, UpdatedDate, GuidCompany);


/******************** Add Table: dbo.secEventNotifyTos ************************/

/* Build Table Structure */
CREATE TABLE dbo.secEventNotifyTos
(
	GuidEventNotifyTo UniqueIdentifier NOT NULL,
	GuidEventNotify UniqueIdentifier NULL,
	GuidUser UniqueIdentifier NULL,
	Email VARCHAR(255) NULL,
	GuidDestinataryType UniqueIdentifier NULL,
	GuidMessageTemplate UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secEventNotifyTos ADD CONSTRAINT pksecEventNotifyTo
	PRIMARY KEY (GuidEventNotifyTo);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secEventNotifyTos_FullStatics_Idx ON dbo.secEventNotifyTos (Bytes, GuidEventNotifyTo, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secFeatureConcepts ************************/

/* Build Table Structure */
CREATE TABLE dbo.secFeatureConcepts
(
	GuidFeatureConcept UniqueIdentifier NOT NULL,
	Name VARCHAR(255) NULL,
	Name_ES VARCHAR(255) NULL,
	Name_EN VARCHAR(255) NULL,
	NameKey VARCHAR(100) NULL,
	GuidModule UniqueIdentifier NULL,
	Price_USD MONEY NULL,
	Price_MXN MONEY NULL,
	Price MONEY NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secFeatureConcepts ADD CONSTRAINT pksecFeatureConcept
	PRIMARY KEY (GuidFeatureConcept);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secFeatureConcepts_FullStatics_Idx ON dbo.secFeatureConcepts (Bytes, GuidFeatureConcept, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secFeaurePrices ************************/

/* Build Table Structure */
CREATE TABLE dbo.secFeaurePrices
(
	GuidFeatureConcept UniqueIdentifier NULL,
	GuidFeaturePrice UniqueIdentifier NOT NULL,
	Min INTEGER NULL,
	Max INTEGER NULL,
	Price MONEY NULL,
	Price_USD MONEY NULL,
	Price_MXN MONEY NULL,
	PriceBy_ES VARCHAR(255) NULL,
	PriceBy VARCHAR(255) NULL,
	PriceBy_EN VARCHAR(255) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secFeaurePrices ADD CONSTRAINT pksecFeaturePrice
	PRIMARY KEY (GuidFeaturePrice);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secFeaurePrices_FullStatics_Idx ON dbo.secFeaurePrices (Bytes, GuidFeaturePrice, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secFiles ************************/

/* Build Table Structure */
CREATE TABLE dbo.secFiles
(
	GuidFile UniqueIdentifier NOT NULL,
	FileType VARCHAR(50) NULL,
	FileName NVARCHAR(200) NULL,
	FileData VARBINARY(MAX) NULL,
	FileSize INTEGER NULL,
	CreatedDate DATETIME NOT NULL,
	IsDeleted BIT NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	Tags NVARCHAR(200) NULL,
	GuidCompany UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	UpdatedDate DATETIME NULL,
	FileStorage VARCHAR(500) NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secFiles ADD CONSTRAINT PK_secFiles
	PRIMARY KEY (GuidFile);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secFiles_FullStatics_Idx ON dbo.secFiles (Bytes, GuidFile, CreatedDate, UpdatedDate, CreatedBy, GuidCompany, IsDeleted);


/******************** Add Table: dbo.secFilterQueries ************************/

/* Build Table Structure */
CREATE TABLE dbo.secFilterQueries
(
	Title VARCHAR(255) NOT NULL,
	QueryLinq VARCHAR(MAX) NULL,
	HtmlContent VARCHAR(MAX) NULL,
	IsShared BIT NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	UseMode VARCHAR(50) NULL,
	GuidBusinessObject UniqueIdentifier NULL,
	GuidFilterQuery UniqueIdentifier DEFAULT newid() NOT NULL,
	GuidCompany UniqueIdentifier NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secFilterQueries ADD CONSTRAINT XPKMyFilterQueries
	PRIMARY KEY (GuidFilterQuery);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secFilterQueries_FullStatics_Idx ON dbo.secFilterQueries (Bytes, GuidFilterQuery, CreatedDate, UpdatedDate, CreatedBy, GuidCompany);


/******************** Add Table: dbo.secGeoCities ************************/

/* Build Table Structure */
CREATE TABLE dbo.secGeoCities
(
	Name VARCHAR(300) NULL,
	OtherNames VARCHAR(500) NULL,
	GuidState UniqueIdentifier NULL,
	GuidCity UniqueIdentifier DEFAULT newid() NOT NULL,
	GeonameId INTEGER NULL,
	Asciiname VARCHAR(200) NULL,
	Latitude FLOAT NULL,
	Longitude FLOAT NULL,
	Timezone VARCHAR(40) NULL,
	SyncDate DATETIME NULL,
	AdminCode1 VARCHAR(100) NULL,
	Fcode VARCHAR(10) NULL,
	CountryCode VARCHAR(2) NULL,
	Children INTEGER NULL,
	ToponymName VARCHAR(300) NULL,
	AdminName1 VARCHAR(300) NULL,
	GuidParent UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	AdminCode2 VARCHAR(100) NULL,
	AdminCode3 VARCHAR(100) NULL,
	PostalCode VARCHAR(6) NULL,
	Population BIGINT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secGeoCities ADD CONSTRAINT PK_MyGeoCities_1
	PRIMARY KEY (GuidCity);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secGeoCities_FullStatics_Idx ON dbo.secGeoCities (Bytes, GuidCity, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secGeoCountries ************************/

/* Build Table Structure */
CREATE TABLE dbo.secGeoCountries
(
	ISO_CODE CHAR(2) NULL,
	Name VARCHAR(300) NULL,
	OtherNames VARCHAR(500) NULL,
	GuidCountry UniqueIdentifier DEFAULT newid() NOT NULL,
	ISO_CODE3 VARCHAR(3) NULL,
	ISO_NUMERIC INTEGER NULL,
	fips VARCHAR(2) NULL,
	Capital VARCHAR(100) NULL,
	Area DECIMAL(10, 2) NULL,
	Continent VARCHAR(2) NULL,
	GeonameId INTEGER NULL,
	SyncDate DATETIME NULL,
	CurrencyCode VARCHAR(3) NULL,
	CurrencyName VARCHAR(100) NULL,
	PhoneCode VARCHAR(10) NULL,
	Languages VARCHAR(500) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	ZipCode VARCHAR(10) NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secGeoCountries ADD CONSTRAINT PK_MyGeoCountries
	PRIMARY KEY (GuidCountry);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secGeoCountries_FullStatics_Idx ON dbo.secGeoCountries (Bytes, GuidCountry, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secGeoStates ************************/

/* Build Table Structure */
CREATE TABLE dbo.secGeoStates
(
	Name VARCHAR(300) NOT NULL,
	OtherNames VARCHAR(500) NULL,
	Code NCHAR(4) NULL,
	GuidCountry UniqueIdentifier NULL,
	GuidState UniqueIdentifier DEFAULT newid() NOT NULL,
	GeonameId INTEGER NULL,
	Asciiname VARCHAR(200) NULL,
	Latitude FLOAT NULL,
	Longitude FLOAT NULL,
	Timezone VARCHAR(40) NULL,
	ModificationDate DATETIME NULL,
	SyncDate DATETIME NULL,
	Children INTEGER NULL,
	ToponymName VARCHAR(300) NULL,
	AdminName1 VARCHAR(300) NULL,
	CountryCode VARCHAR(2) NULL,
	AdminCode1 VARCHAR(100) NULL,
	Fcode VARCHAR(10) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secGeoStates ADD CONSTRAINT PK_MyGeoStates_1
	PRIMARY KEY (GuidState);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secGeoStates_FullStatics_Idx ON dbo.secGeoStates (Bytes, GuidState, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secGeoZipCode ************************/

/* Build Table Structure */
CREATE TABLE dbo.secGeoZipCode
(
	GuidZipCode UniqueIdentifier NOT NULL,
	AdminCode1 VARCHAR(10) NULL,
	AdminCode2 VARCHAR(10) NULL,
	AdminCode3 VARCHAR(10) NULL,
	AdminName1 VARCHAR(255) NULL,
	AdminName2 VARCHAR(255) NULL,
	AdminName3 VARCHAR(255) NULL,
	Lng FLOAT NULL,
	Lat FLOAT NULL,
	CountryCode VARCHAR(5) NULL,
	PostalCode VARCHAR(10) NULL,
	PlaceName VARCHAR(255) NULL,
	GuidGeoZipCodeItem UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secGeoZipCode ADD CONSTRAINT pksecGeoZipCode
	PRIMARY KEY (GuidZipCode);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secGeoZipCode_GuidGeoZipCodeItem_Idx ON dbo.secGeoZipCode (GuidGeoZipCodeItem);


/******************** Add Table: dbo.secGeoZipCodeItem ************************/

/* Build Table Structure */
CREATE TABLE dbo.secGeoZipCodeItem
(
	GuidGeoZipCodeItem UniqueIdentifier NOT NULL,
	ZipCode VARCHAR(7) NULL,
	SyncDate DATETIME NULL,
	CountryCode VARCHAR(4) NULL,
	GuidCountry UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secGeoZipCodeItem ADD CONSTRAINT pksecGeoZipCodeItem
	PRIMARY KEY (GuidGeoZipCodeItem);

/* Add Indexes */
CREATE UNIQUE NONCLUSTERED INDEX secGeoZipCodeItem_ZipCode_GuidCountry_Idx ON dbo.secGeoZipCodeItem (ZipCode, GuidCountry, CountryCode);


/******************** Add Table: dbo.secInvPaymentFile ************************/

/* Build Table Structure */
CREATE TABLE dbo.secInvPaymentFile
(
	GuidInvPaymentFile UniqueIdentifier NOT NULL,
	GuidInvoicePayment UniqueIdentifier NULL,
	GuidFile UniqueIdentifier NULL,
	Description NVARCHAR(1000) NULL,
	CreatedDate DATETIME NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy UniqueIdentifier NULL,
	IsDeleted BIT NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secInvPaymentFile ADD CONSTRAINT pksecInvPaymentFile
	PRIMARY KEY (GuidInvPaymentFile);


/******************** Add Table: dbo.secInvoice ************************/

/* Build Table Structure */
CREATE TABLE dbo.secInvoice
(
	GuidInvoice UniqueIdentifier NOT NULL,
	GuidCompany UniqueIdentifier NULL,
	InvoiceNum INTEGER NULL,
	InvoiceDate DATETIME NULL,
	ServicesFrom DATETIME NULL,
	ServicesTo DATETIME NULL,
	PreTotal MONEY NULL,
	Taxes MONEY NULL,
	Total MONEY NULL,
	CurrencyCode VARCHAR(5) NULL,
	GuidCompanyModule UniqueIdentifier NULL,
	Calculated BIT NULL,
	GuidModule UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	TotalDiscount MONEY NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secInvoice ADD CONSTRAINT pksecInvoice
	PRIMARY KEY (GuidInvoice);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secInvoice_FullStatics_Idx ON dbo.secInvoice (Bytes, GuidInvoice, CreatedDate, UpdatedDate, GuidCompany);


/******************** Add Table: dbo.secInvoiceDetail ************************/

/* Build Table Structure */
CREATE TABLE dbo.secInvoiceDetail
(
	GuidInvoiceDetail UniqueIdentifier NOT NULL,
	GuidInvoice UniqueIdentifier NULL,
	GuidFeatureConcept UniqueIdentifier NULL,
	UnitPrice MONEY NULL,
	Discount MONEY NULL,
	Qty DECIMAL(10, 2) NULL,
	Total MONEY NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	DiscountPercent DECIMAL(10, 2) NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secInvoiceDetail ADD CONSTRAINT pksecInvoiceDetail
	PRIMARY KEY (GuidInvoiceDetail);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secInvoiceDetail_FullStatics_Idx ON dbo.secInvoiceDetail (Bytes, GuidInvoiceDetail, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secInvoicePayment ************************/

/* Build Table Structure */
CREATE TABLE dbo.secInvoicePayment
(
	GuidInvoicePayment UniqueIdentifier NOT NULL,
	PaymentDate DATETIME NULL,
	Verified BIT NULL,
	GuidInvoice UniqueIdentifier NULL,
	Amount MONEY NULL,
	CreatedBy UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	CompanyPayment UniqueIdentifier NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	IsDeleted BIT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secInvoicePayment ADD CONSTRAINT pksecInvoicePayment
	PRIMARY KEY (GuidInvoicePayment);


/******************** Add Table: dbo.secIssueRelation ************************/

/* Build Table Structure */
CREATE TABLE dbo.secIssueRelation
(
	GuidIssueRelation UniqueIdentifier NOT NULL,
	CreatedDate DATETIME NULL,
	CreatedBy UniqueIdentifier NULL,
	IsDeleted BIT NULL,
	GuidIssue UniqueIdentifier NULL,
	GuidIssueOther UniqueIdentifier NULL,
	GuidStatus UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secIssueRelation ADD CONSTRAINT pksecIssueRelation
	PRIMARY KEY (GuidIssueRelation);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secIssueRelation_FullStatics_Idx ON dbo.secIssueRelation (Bytes, GuidIssueRelation, CreatedDate, UpdatedDate, CreatedBy, IsDeleted);


/******************** Add Table: dbo.secIssueVotes ************************/

/* Build Table Structure */
CREATE TABLE dbo.secIssueVotes
(
	GuidIssueVote UniqueIdentifier NOT NULL,
	CreatedDate DATETIME NULL,
	CreatedBy UniqueIdentifier NULL,
	VoteValue BIT NULL,
	Comments VARCHAR(MAX) NULL,
	GuidUser UniqueIdentifier NULL,
	GuidIssue UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secIssueVotes ADD CONSTRAINT PK_secIssueVotes
	PRIMARY KEY (GuidIssueVote);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secIssueVotes_FullStatics_Idx ON dbo.secIssueVotes (Bytes, GuidIssueVote, CreatedDate, UpdatedDate, CreatedBy);


/******************** Add Table: dbo.secIssues ************************/

/* Build Table Structure */
CREATE TABLE dbo.secIssues
(
	GuidIssue UniqueIdentifier NOT NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	IsDeleted BIT NULL,
	Title VARCHAR(255) NULL,
	Description VARCHAR(MAX) NULL,
	GuidUserReported UniqueIdentifier NULL,
	GuidUserAsigned UniqueIdentifier NULL,
	GuidIssueType UniqueIdentifier NULL,
	GuidIssueLevel UniqueIdentifier NULL,
	GuidModule UniqueIdentifier NULL,
	[Public] BIT NULL,
	GuidIssueRelated UniqueIdentifier NULL,
	GuidBusinessObject UniqueIdentifier NULL,
	GuidStatus UniqueIdentifier NULL,
	Num INTEGER NULL,
	ErrorStartMethod VARCHAR(50) NULL,
	ErrorStartFile VARCHAR(100) NULL,
	ErrorStartLine INTEGER NULL,
	ErrorEndMethod VARCHAR(50) NULL,
	ErrorEndFile VARCHAR(100) NULL,
	ErrorEndLine INTEGER NULL,
	ErrorTypeException VARCHAR(100) NULL,
	ErrorFirstMessage VARCHAR(255) NULL,
	ErrorOccurrences INTEGER NULL,
	ErrorStartInstanceName VARCHAR(100) NULL,
	ErrorEndInstanceName VARCHAR(100) NULL,
	CommentOfIssue UniqueIdentifier NULL,
	Priority INTEGER NULL,
	GuidReusable_RepositoryCode UniqueIdentifier NULL,
	RepoID VARCHAR(100) NULL,
	RepoRevisionNum INTEGER NULL,
	Bytes INTEGER NULL,
	TimeEstimated DECIMAL(10, 2) NULL,
	TimeReal DECIMAL(10, 2) NULL,
	ProduceCost BIT NULL,
	GuidCompanyOwner UniqueIdentifier NULL,
	GuidUserAcepted UniqueIdentifier NULL,
	Progress INTEGER NULL,
	DateStarted DATETIME NULL,
	DateEnded DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secIssues ADD CONSTRAINT PK_secIssues
	PRIMARY KEY (GuidIssue);

/* Add Indexes */
CREATE NONCLUSTERED INDEX _dta_index_secIssues_23_1333579789__K6 ON dbo.secIssues (IsDeleted);

CREATE NONCLUSTERED INDEX dta_index_secIssues_full_sql_recomendation ON dbo.secIssues (CreatedDate, UpdatedDate, CreatedBy, UpdatedBy, GuidUserAsigned, [Public], Num, CommentOfIssue, Priority, IsDeleted, GuidBusinessObject, GuidIssue, GuidModule, GuidIssueLevel, GuidIssueType, GuidStatus);

CREATE NONCLUSTERED INDEX secIssues_CreatedDate_IsDeleted_GuidIssueType_Idx ON dbo.secIssues (CreatedDate, IsDeleted, GuidIssueType, GuidStatus);

CREATE NONCLUSTERED INDEX secIssues_FullStatics_Idx ON dbo.secIssues (Bytes, GuidIssue, CreatedDate, UpdatedDate, CreatedBy, IsDeleted);


/******************** Add Table: dbo.secLoginProviders ************************/

/* Build Table Structure */
CREATE TABLE dbo.secLoginProviders
(
	Name VARCHAR(20) NULL,
	Url VARCHAR(20) NULL,
	Description VARCHAR(20) NULL,
	GuidLoginProvider UniqueIdentifier DEFAULT newid() NOT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secLoginProviders ADD CONSTRAINT XPKsecLoginProviders
	PRIMARY KEY (GuidLoginProvider);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secLoginProviders_FullStatics_Idx ON dbo.secLoginProviders (Bytes, GuidLoginProvider, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secMemLevelFeatures ************************/

/* Build Table Structure */
CREATE TABLE dbo.secMemLevelFeatures
(
	GuidFeatureConcept UniqueIdentifier NULL,
	GuidMembershipLevel UniqueIdentifier NULL,
	GuidMemLevelFeature UniqueIdentifier NOT NULL,
	ValueBoolean BIT NULL,
	ValueInt INTEGER NULL,
	ValueUnlimited BIT NULL,
	ValueLimited BIT NULL,
	ValueDecimal DECIMAL(16, 2) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secMemLevelFeatures ADD CONSTRAINT pksecMemLevelFeature
	PRIMARY KEY (GuidMemLevelFeature);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secMemLevelFeatures_FullStatics_Idx ON dbo.secMemLevelFeatures (Bytes, GuidMemLevelFeature, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secMemberModuleComp ************************/

/* Build Table Structure */
CREATE TABLE dbo.secMemberModuleComp
(
	GuidMemberModuleComp UniqueIdentifier NOT NULL,
	GuidCompanyUse UniqueIdentifier NULL,
	StartDate DATETIME NULL,
	StartDateFree DATETIME NULL,
	DiscountAmount DECIMAL(16, 2) NULL,
	DiscountPercent DECIMAL(16, 2) NULL,
	UpdatedDate DATETIME NULL,
	CreatedDate DATETIME NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	IsDeleted BIT NULL,
	GuidMembershipModule UniqueIdentifier NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secMemberModuleComp ADD CONSTRAINT PK_secMemberModuleComp
	PRIMARY KEY (GuidMemberModuleComp);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secMemberModuleComp_FullStatics_Idx ON dbo.secMemberModuleComp (Bytes, GuidMemberModuleComp, CreatedDate, UpdatedDate, CreatedBy, IsDeleted);


/******************** Add Table: dbo.secMemberModuleCompCover ************************/

/* Build Table Structure */
CREATE TABLE dbo.secMemberModuleCompCover
(
	GuidMemModuleCompCover UniqueIdentifier NOT NULL,
	GuidMemberModuleComp UniqueIdentifier NULL,
	StartDate DATETIME NULL,
	Months INTEGER NULL,
	EndDate DATETIME NULL,
	GuidMovement UniqueIdentifier NOT NULL,
	UpdatedDate DATETIME NULL,
	CreatedDate DATETIME NOT NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secMemberModuleCompCover ADD CONSTRAINT PK_secMemberModuleCompCover
	PRIMARY KEY (GuidMemModuleCompCover);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secMemberModuleCompCover_FullStatics_Idx ON dbo.secMemberModuleCompCover (Bytes, GuidMemModuleCompCover, CreatedDate, UpdatedDate, CreatedBy);


/******************** Add Table: dbo.secMembershipLevel ************************/

/* Build Table Structure */
CREATE TABLE dbo.secMembershipLevel
(
	GuidMembershipLevel UniqueIdentifier NOT NULL,
	Name VARCHAR(300) NULL,
	NameKey VARCHAR(300) NULL,
	MembershipLevel INTEGER NULL,
	Name_ES VARCHAR(300) NULL,
	Name_EN VARCHAR(300) NULL,
	UpdatedDate DATETIME NULL,
	CreatedDate DATETIME NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	DescriptionShort NVARCHAR(500) NULL,
	DescriptionShort_ES NVARCHAR(500) NULL,
	DescriptionShort_EN NVARCHAR(500) NULL,
	Price MONEY NULL,
	Price_USD MONEY NULL,
	Price_MXN MONEY NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secMembershipLevel ADD CONSTRAINT PK_secMembershipLevel
	PRIMARY KEY (GuidMembershipLevel);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secMembershipLevel_FullStatics_Idx ON dbo.secMembershipLevel (Bytes, GuidMembershipLevel, CreatedDate, UpdatedDate, CreatedBy);


/******************** Add Table: dbo.secMembershipModule ************************/

/* Build Table Structure */
CREATE TABLE dbo.secMembershipModule
(
	GuidModule UniqueIdentifier NULL,
	GuidMembershipLevel UniqueIdentifier NULL,
	Name VARCHAR(300) NULL,
	Name_ES VARCHAR(300) NULL,
	Name_EN VARCHAR(300) NULL,
	Price MONEY NULL,
	DaysFree INTEGER NULL,
	RequireCardFree BIT NULL,
	GuidMembershipModule UniqueIdentifier NOT NULL,
	UpdatedDate DATETIME NULL,
	CreatedDate DATETIME NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	Price_USD MONEY NULL,
	Price_MXN MONEY NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secMembershipModule ADD CONSTRAINT PK_secMembershipModule
	PRIMARY KEY (GuidMembershipModule);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secMembershipModule_FullStatics_Idx ON dbo.secMembershipModule (Bytes, GuidMembershipModule, CreatedDate, UpdatedDate, CreatedBy);


/******************** Add Table: dbo.secMenuForms ************************/

/* Build Table Structure */
CREATE TABLE dbo.secMenuForms
(
	Url VARCHAR(300) NULL,
	FormKey VARCHAR(255) NOT NULL,
	Title VARCHAR(300) NULL,
	GuidModule UniqueIdentifier NULL,
	GuidBusinessObject UniqueIdentifier NULL,
	GuidPermission UniqueIdentifier NULL,
	GuidForm UniqueIdentifier DEFAULT newid() NOT NULL,
	ParentGuidForm UniqueIdentifier NULL,
	ActionName VARCHAR(50) NULL,
	OverrideApp VARCHAR(50) NULL,
	UseMode VARCHAR(50) NULL,
	LangResource VARCHAR(2000) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secMenuForms ADD CONSTRAINT PK_secMenuForms
	PRIMARY KEY (GuidForm);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secMenuForms_FullStatics_Idx ON dbo.secMenuForms (Bytes, GuidForm, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secMessageNotificationTemplates ************************/

/* Build Table Structure */
CREATE TABLE dbo.secMessageNotificationTemplates
(
	GuidMessageTemplate UniqueIdentifier NOT NULL,
	FromEmail VARCHAR(255) NULL,
	TemplateHtml NVARCHAR(MAX) NULL,
	FromName NVARCHAR(255) NULL,
	GuidMessageNotification UniqueIdentifier NULL,
	IsBase BIT NULL,
	GuidCompany UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	IsDeleted BIT NULL,
	ActionGroupKey VARCHAR(100) NULL,
	Title NVARCHAR(200) NULL,
	MessageSubject NVARCHAR(400) NULL,
	ToCC NVARCHAR(700) NULL,
	Description_RU VARCHAR(300) NULL,
	Description_EN VARCHAR(300) NULL,
	TitleMessage_EN VARCHAR(300) NULL,
	TitleMessage_RU VARCHAR(300) NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secMessageNotificationTemplates ADD CONSTRAINT PK_secMessageNotificationTemplates
	PRIMARY KEY (GuidMessageTemplate);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secMessageNotificationTemplates_FullStatics_Idx ON dbo.secMessageNotificationTemplates (Bytes, GuidMessageTemplate, CreatedDate, UpdatedDate, CreatedBy, GuidCompany, IsDeleted);


/******************** Add Table: dbo.secMessageNotifications ************************/

/* Build Table Structure */
CREATE TABLE dbo.secMessageNotifications
(
	GuidMessageNotification UniqueIdentifier NOT NULL,
	GuidBusinessObject UniqueIdentifier NULL,
	ActionKey VARCHAR(100) NULL,
	TitleMessage NVARCHAR(200) NULL,
	Description NVARCHAR(500) NULL,
	GuidModule UniqueIdentifier NULL,
	Description_RU VARCHAR(300) NULL,
	Description_EN VARCHAR(300) NULL,
	TitleMessage_EN VARCHAR(300) NULL,
	TitleMessage_RU VARCHAR(300) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secMessageNotifications ADD CONSTRAINT PK_secMessageNotifications
	PRIMARY KEY (GuidMessageNotification);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secMessageNotifications_FullStatics_Idx ON dbo.secMessageNotifications (Bytes, GuidMessageNotification, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secMessageToUsers ************************/

/* Build Table Structure */
CREATE TABLE dbo.secMessageToUsers
(
	GuidMessage UniqueIdentifier NOT NULL,
	GuidUser UniqueIdentifier NOT NULL,
	Readed DATETIME NULL,
	GuidMessageToUser UniqueIdentifier NOT NULL,
	Notified BIT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secMessageToUsers ADD CONSTRAINT PK_secMessageToUsers
	PRIMARY KEY (GuidMessageToUser);

/* Add Indexes */
CREATE NONCLUSTERED INDEX IX_secMessageToUsers ON dbo.secMessageToUsers (GuidUser);

CREATE NONCLUSTERED INDEX secMessageToUsers_FullStatics_Idx ON dbo.secMessageToUsers (Bytes, GuidMessageToUser, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secMessages ************************/

/* Build Table Structure */
CREATE TABLE dbo.secMessages
(
	GuidUser UniqueIdentifier NULL,
	TitleMessage NVARCHAR(300) NULL,
	ContentMessage NVARCHAR(MAX) NULL,
	SendDate DATETIME NULL,
	ReadDate DATETIME NULL,
	ToUser UniqueIdentifier NULL,
	ToEmail VARCHAR(100) NULL,
	ToCC VARCHAR(300) NULL,
	GuidMessage UniqueIdentifier NOT NULL,
	FromCompany UniqueIdentifier NULL,
	IsDeleted BIT NULL,
	IsDraft BIT NULL,
	IsProcessed BIT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secMessages ADD CONSTRAINT PK_secMessages
	PRIMARY KEY (GuidMessage);

/* Add Indexes */
CREATE NONCLUSTERED INDEX _dta_index_secMessages_GuidUser_IsProcessed_Isdeleted ON dbo.secMessages (GuidUser, IsProcessed, IsDeleted);

CREATE NONCLUSTERED INDEX secMessages_FullStatics_Idx ON dbo.secMessages (Bytes, GuidMessage, CreatedDate, UpdatedDate, IsDeleted);


/******************** Add Table: dbo.secModComOptions ************************/

/* Build Table Structure */
CREATE TABLE dbo.secModComOptions
(
	GuidModCompOption UniqueIdentifier NOT NULL,
	GuidCompany UniqueIdentifier NULL,
	ValueInt INTEGER NULL,
	ValueString NVARCHAR(300) NULL,
	ValueBoolean BIT NULL,
	ValueDecimal DECIMAL(10, 2) NULL,
	ValueDateTime DATETIME NULL,
	GuidModuleOption UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secModComOptions ADD CONSTRAINT pksecModComOptions
	PRIMARY KEY (GuidModCompOption);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secModComOptions_FullStatics_Idx ON dbo.secModComOptions (Bytes, GuidModCompOption, CreatedDate, UpdatedDate, GuidCompany);


/******************** Add Table: dbo.secModule ************************/

/* Build Table Structure */
CREATE TABLE dbo.secModule
(
	Name VARCHAR(300) NULL,
	PathModule VARCHAR(300) NULL,
	ModuleParentId INTEGER NULL,
	TypeFullObject NVARCHAR(300) NULL,
	ModuleKey VARCHAR(50) NOT NULL,
	ExtensibleInfo XML NULL,
	ModuleNamespace VARCHAR(300) NULL,
	GuidModule UniqueIdentifier DEFAULT newid() NOT NULL,
	IsAllowed BIT NULL,
	Name_EN VARCHAR(300) NULL,
	Name_ES VARCHAR(300) NULL,
	DescriptionShort VARCHAR(500) NULL,
	DescriptionShort_ES VARCHAR(500) NULL,
	DescriptionShort_EN VARCHAR(500) NULL,
	DomainApp VARCHAR(300) NULL,
	GuidAdminRole UniqueIdentifier NULL,
	Slogan VARCHAR(1000) NULL,
	AllowAutoService BIT NULL,
	ListIDNewsletter VARCHAR(50) NULL,
	Langs VARCHAR(255) NULL,
	WithPublicPage BIT DEFAULT 'false' NOT NULL,
	GuidAppTemplate UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	IsTest BIT NULL,
	FaceBookAppId VARCHAR(300) NULL,
	FacebookAppSecret VARCHAR(300) NULL,
	MicrosoftClientId VARCHAR(300) NULL,
	MicrosoftClientSecret VARCHAR(300) NULL,
	GoogleClientId VARCHAR(300) NULL,
	GoogleClientSecret VARCHAR(300) NULL,
	GuidAutoServiceRole UniqueIdentifier NULL,
	DisableCustDomainCompany BIT NULL,
	CustomDomain VARCHAR(255) NULL,
	UsePersonalCompDefault BIT NULL,
	HomeAppPath VARCHAR(255) NULL,
	HomePublicPath VARCHAR(255) NULL,
	HomeDefaultPath VARCHAR(255) NULL,
	GuidCompUISetting UniqueIdentifier NULL,
	RecaptchaPublicKey VARCHAR(255) NULL,
	RecaptchaPrivateKey VARCHAR(255) NULL,
	DisableThirdPartyProviders BIT NULL,
	HidePlatformBrand BIT NULL,
	UseOwnUserRepo BIT NULL,
	GuidDefaultCompany UniqueIdentifier NULL,
	PreventDomainByCompany BIT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secModule ADD CONSTRAINT Module_PK
	PRIMARY KEY (GuidModule);

/* Add Unique Constraints */
ALTER TABLE dbo.secModule
	ADD CONSTRAINT IX_Module_ModuleKey UNIQUE (ModuleKey);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secModule_FullStatics_Idx ON dbo.secModule (Bytes, GuidModule, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secModuleObjectPermission ************************/

/* Build Table Structure */
CREATE TABLE dbo.secModuleObjectPermission
(
	GuidModule UniqueIdentifier NOT NULL,
	GuidBusinessObject UniqueIdentifier NOT NULL,
	GuidPermission UniqueIdentifier NOT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secModuleObjectPermission ADD CONSTRAINT PK_secModuleObjectPermission
	PRIMARY KEY (GuidModule, GuidBusinessObject, GuidPermission);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secModuleObjectPermission_FullStatics_Idx ON dbo.secModuleObjectPermission (Bytes, GuidModule, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secModuleOptions ************************/

/* Build Table Structure */
CREATE TABLE dbo.secModuleOptions
(
	GuidModuleOption UniqueIdentifier NOT NULL,
	GuidModule UniqueIdentifier NULL,
	Name VARCHAR(300) NOT NULL,
	NameKey VARCHAR(200) NOT NULL,
	OptionDataType VARCHAR(10) NULL,
	DefaultValueString VARCHAR(300) NULL,
	DefaultValueDecimal DECIMAL(10, 2) NULL,
	DefaultValueDateTime DATETIME NULL,
	DefaultValueBoolean BIT NULL,
	DefaultValueInt BIGINT NULL,
	Description VARCHAR(500) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secModuleOptions ADD CONSTRAINT pksecModuleOptions
	PRIMARY KEY (GuidModuleOption);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secModuleOptions_FullStatics_Idx ON dbo.secModuleOptions (Bytes, GuidModuleOption, CreatedDate, UpdatedDate);

CREATE NONCLUSTERED INDEX secModuleOptions_NameKey_Idx ON dbo.secModuleOptions (NameKey);


/******************** Add Table: dbo.secModulePermissions ************************/

/* Build Table Structure */
CREATE TABLE dbo.secModulePermissions
(
	GuidModule UniqueIdentifier NOT NULL,
	GuidPermission UniqueIdentifier NOT NULL,
	GuidModulePermission UniqueIdentifier DEFAULT newid() NOT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secModulePermissions ADD CONSTRAINT PK_secModulePermissions
	PRIMARY KEY (GuidModule, GuidPermission);


/******************** Add Table: dbo.secModuleRole ************************/

/* Build Table Structure */
CREATE TABLE dbo.secModuleRole
(
	GuidModuleRole UniqueIdentifier NOT NULL,
	GuidModule UniqueIdentifier NULL,
	GuidRole UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secModuleRole ADD CONSTRAINT pksecModuleRole
	PRIMARY KEY (GuidModuleRole);


/******************** Add Table: dbo.secModuleSettings ************************/

/* Build Table Structure */
CREATE TABLE dbo.secModuleSettings
(
	GuidModuleSetting UniqueIdentifier NOT NULL,
	GuidModule UniqueIdentifier NULL,
	GuidSetting UniqueIdentifier NULL,
	GuidSettingVaueDefault UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	ValueInt INTEGER NULL,
	ValueBoolean BIT NULL,
	ValueDecimal DECIMAL(10, 2) NULL,
	ValueString VARCHAR(4000) NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secModuleSettings ADD CONSTRAINT pksecModuleSettings
	PRIMARY KEY (GuidModuleSetting);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secModuleSettings_FullStatics_Idx ON dbo.secModuleSettings (Bytes, GuidModuleSetting, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secModuleUser ************************/

/* Build Table Structure */
CREATE TABLE dbo.secModuleUser
(
	GuidModuleUser UniqueIdentifier NOT NULL,
	GuidModule UniqueIdentifier NULL,
	GuidUser UniqueIdentifier NULL,
	AppNotificationToken VARCHAR(300) NULL,
	NewNotifications INTEGER NULL,
	TotalNotifications INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secModuleUser ADD CONSTRAINT pksecModuleUser
	PRIMARY KEY (GuidModuleUser);


/******************** Add Table: dbo.secModuleUserCompany ************************/

/* Build Table Structure */
CREATE TABLE dbo.secModuleUserCompany
(
	GuidModuleUserCompany UniqueIdentifier NOT NULL,
	GuidModule UniqueIdentifier NULL,
	GuidCompany UniqueIdentifier NULL,
	GuidUser UniqueIdentifier NULL,
	NewNotifications INTEGER NULL,
	TotalNotifications INTEGER NULL,
	NewMessages INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secModuleUserCompany ADD CONSTRAINT pksecModuleUserCompany
	PRIMARY KEY (GuidModuleUserCompany);


/******************** Add Table: dbo.secModuleUserDevice ************************/

/* Build Table Structure */
CREATE TABLE dbo.secModuleUserDevice
(
	GuidModuleUserDevice UniqueIdentifier NOT NULL,
	GuidModuleUser UniqueIdentifier NULL,
	OS VARCHAR(10) NULL,
	AppFirebaseNotificationToken VARCHAR(300) NULL,
	DeviceID VARCHAR(35) NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secModuleUserDevice ADD CONSTRAINT pksecModuleUserDevice
	PRIMARY KEY (GuidModuleUserDevice);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secModuleUserDevice_GuidModuleUserDevice_GuidModuleUser_DeviceID_Idx ON dbo.secModuleUserDevice (GuidModuleUserDevice, GuidModuleUser, DeviceID);


/******************** Add Table: dbo.secMoneyMovementTypes ************************/

/* Build Table Structure */
CREATE TABLE dbo.secMoneyMovementTypes
(
	NameKey VARCHAR(50) NULL,
	Name VARCHAR(2550) NOT NULL,
	GuidMoneyMovementType UniqueIdentifier DEFAULT newid() NOT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secMoneyMovementTypes ADD CONSTRAINT PK_secMoneyMovementTypes
	PRIMARY KEY (GuidMoneyMovementType);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secMoneyMovementTypes_FullStatics_Idx ON dbo.secMoneyMovementTypes (Bytes, GuidMoneyMovementType, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secMoneyMovements ************************/

/* Build Table Structure */
CREATE TABLE dbo.secMoneyMovements
(
	GuidMovement UniqueIdentifier NOT NULL,
	DateMovement DATETIME NOT NULL,
	Amount DECIMAL(14, 4) NOT NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	Comments VARCHAR(255) NULL,
	GuidUserPayment UniqueIdentifier NULL,
	GuidCompanyAdd UniqueIdentifier NULL,
	GuidCompanyCharge UniqueIdentifier NULL,
	GuidUserCharge UniqueIdentifier NULL,
	GuidUserAdd UniqueIdentifier NULL,
	GuidMoneyMovementType UniqueIdentifier NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secMoneyMovements ADD CONSTRAINT PK_secMoneyMovements
	PRIMARY KEY (GuidMovement);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secMoneyMovements_FullStatics_Idx ON dbo.secMoneyMovements (Bytes, GuidMovement, CreatedDate, UpdatedDate, CreatedBy);


/******************** Add Table: dbo.secMoneyPayments ************************/

/* Build Table Structure */
CREATE TABLE dbo.secMoneyPayments
(
	Name VARCHAR(255) NULL,
	NameKey VARCHAR(50) NOT NULL,
	GuidPaymentType UniqueIdentifier DEFAULT newid() NOT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secMoneyPayments ADD CONSTRAINT PK_secMoneyPayments
	PRIMARY KEY (GuidPaymentType);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secMoneyPayments_FullStatics_Idx ON dbo.secMoneyPayments (Bytes, GuidPaymentType, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secNoSQLLog ************************/

/* Build Table Structure */
CREATE TABLE dbo.secNoSQLLog
(
	GuidNoSQLLog UniqueIdentifier NOT NULL,
	GuidBusinessObject UniqueIdentifier NULL,
	GuidNoSQLMovement UniqueIdentifier NULL,
	Success BIT NULL,
	Message VARCHAR(MAX) NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secNoSQLLog ADD CONSTRAINT pksecNoSQLLog
	PRIMARY KEY (GuidNoSQLLog);


/******************** Add Table: dbo.secNoSQLMovement ************************/

/* Build Table Structure */
CREATE TABLE dbo.secNoSQLMovement
(
	GuidNoSQLMovement UniqueIdentifier NOT NULL,
	GuidBusinessObject UniqueIdentifier NULL,
	ItemsForBulk INTEGER NULL,
	PlaninglForMove INTEGER NULL,
	TotalMove INTEGER NULL,
	UpdatedDate DATETIME NULL,
	CreatedDate DATETIME NULL,
	GuidReusableStorageSource UniqueIdentifier NULL,
	GuidReusableStorageTarget UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secNoSQLMovement ADD CONSTRAINT pksecNoSQLMovement
	PRIMARY KEY (GuidNoSQLMovement);


/******************** Add Table: dbo.secNoSQLOption ************************/

/* Build Table Structure */
CREATE TABLE dbo.secNoSQLOption
(
	GuidNoSQLOption UniqueIdentifier NOT NULL,
	Name VARCHAR(255) NOT NULL,
	NameKey VARCHAR(100) NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secNoSQLOption ADD CONSTRAINT pksecNoSQLOption
	PRIMARY KEY (GuidNoSQLOption);


/******************** Add Table: dbo.secNotification ************************/

/* Build Table Structure */
CREATE TABLE dbo.secNotification
(
	GuidNotification UniqueIdentifier NOT NULL,
	ToUser UniqueIdentifier NULL,
	GuidNotificationPriority UniqueIdentifier NULL,
	Title VARCHAR(255) NULL,
	Body VARCHAR(4000) NULL,
	Priority VARCHAR(30) NULL,
	Sound VARCHAR(30) NULL,
	ToCustom VARCHAR(255) NULL,
	GuidModule UniqueIdentifier NULL,
	UriActionIOS VARCHAR(255) NULL,
	UriActionAndroid VARCHAR(255) NULL,
	UriActionWeb VARCHAR(255) NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secNotification ADD CONSTRAINT pksecNotification
	PRIMARY KEY (GuidNotification);


/******************** Add Table: dbo.secNotificationPriority ************************/

/* Build Table Structure */
CREATE TABLE dbo.secNotificationPriority
(
	GuidNotificationPriority UniqueIdentifier NOT NULL,
	Name VARCHAR(255) NOT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secNotificationPriority ADD CONSTRAINT pksecNotificationPriority
	PRIMARY KEY (GuidNotificationPriority);


/******************** Add Table: dbo.secPaymentMethods ************************/

/* Build Table Structure */
CREATE TABLE dbo.secPaymentMethods
(
	Name VARCHAR(255) NULL,
	NameKey VARCHAR(50) NOT NULL,
	GuidPaymentMethod UniqueIdentifier DEFAULT newid() NOT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secPaymentMethods ADD CONSTRAINT PK_secPaymentMethods
	PRIMARY KEY (GuidPaymentMethod);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secPaymentMethods_FullStatics_Idx ON dbo.secPaymentMethods (Bytes, GuidPaymentMethod, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secPermission ************************/

/* Build Table Structure */
CREATE TABLE dbo.secPermission
(
	Name VARCHAR(300) NOT NULL,
	NameLocalizable XML NULL,
	PermissionKey VARCHAR(50) NOT NULL,
	GuidPermission UniqueIdentifier DEFAULT newid() NOT NULL,
	Name_ES VARCHAR(300) NULL,
	Name_EN VARCHAR(300) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secPermission ADD CONSTRAINT Permission_PK
	PRIMARY KEY (GuidPermission);

/* Add Unique Constraints */
ALTER TABLE dbo.secPermission
	ADD CONSTRAINT IX_Permission_PermissionKey UNIQUE (PermissionKey);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secPermission_FullStatics_Idx ON dbo.secPermission (Bytes, GuidPermission, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secProcessQueue ************************/

/* Build Table Structure */
CREATE TABLE dbo.secProcessQueue
(
	GuidsecProcessQueue UniqueIdentifier NOT NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	GuidCompany UniqueIdentifier NULL,
	IsDeleted BIT NULL,
	StartDateTime DATETIME NOT NULL,
	EndDateTime DATETIME NULL,
	Description VARCHAR(500) NULL,
	IdProcess VARCHAR(100) NULL,
	PercentCompleted INTEGER NULL,
	Title VARCHAR(200) NULL,
	Finished BIT NOT NULL,
	TypeResult VARCHAR(150) NULL,
	ExtraValues VARCHAR(2000) NULL,
	FinishedUI BIT NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secProcessQueue ADD CONSTRAINT pksecProcessQueue
	PRIMARY KEY (GuidsecProcessQueue);

/* Add Indexes */
CREATE NONCLUSTERED INDEX _dta_index_secProcessQueue_23_2133582639__K2_K14_K7_1_3_4_5_6_8_9_10_11_12_13_15 ON dbo.secProcessQueue (GuidsecProcessQueue, UpdatedBy, CreatedDate, UpdatedDate, GuidCompany, StartDateTime, EndDateTime, Description, IdProcess, PercentCompleted, Title, TypeResult, CreatedBy, Finished, IsDeleted);

CREATE NONCLUSTERED INDEX nci_wi_secProcessQueue_0B3E51F975EA0EBA07B8A193EA57210A ON dbo.secProcessQueue (Bytes, CreatedDate, Description, EndDateTime, ExtraValues, Finished, GuidCompany, IdProcess, IsDeleted, PercentCompleted, StartDateTime, Title, TypeResult, UpdatedBy, UpdatedDate, CreatedBy, FinishedUI);

CREATE NONCLUSTERED INDEX secProcessQueue_FullStatics_Idx ON dbo.secProcessQueue (Bytes, GuidsecProcessQueue, CreatedDate, UpdatedDate, CreatedBy, GuidCompany, IsDeleted);


/******************** Add Table: dbo.secProfile ************************/

/* Build Table Structure */
CREATE TABLE dbo.secProfile
(
	FirstName VARCHAR(300) NULL,
	LastName VARCHAR(300) NULL,
	LastName2 VARCHAR(300) NULL,
	ActualAddress VARCHAR(500) NULL,
	BirthDay DATETIME NULL,
	HomePhone VARCHAR(50) NULL,
	WorkPhone VARCHAR(50) NULL,
	MobilePhone VARCHAR(50) NULL,
	Email VARCHAR(50) NULL,
	WebAddress VARCHAR(300) NULL,
	IM_msn VARCHAR(300) NULL,
	IM_yahoo VARCHAR(300) NULL,
	IM_AIM VARCHAR(300) NULL,
	IM_google VARCHAR(300) NULL,
	Sex INTEGER NULL,
	ExtensibleInfo XML NULL,
	IdCompanyFavorite INTEGER NULL,
	LocalizacionFavorite CHAR(4) NULL,
	GuidActualCountry UniqueIdentifier NULL,
	GuidWorkCountry UniqueIdentifier NULL,
	GuidActualState UniqueIdentifier NULL,
	GuidWorkState UniqueIdentifier NULL,
	GuidActualCity UniqueIdentifier NULL,
	GuidWorkCity UniqueIdentifier NULL,
	GuidUser UniqueIdentifier NOT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secProfile ADD CONSTRAINT pksecProfile
	PRIMARY KEY (GuidUser);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secProfile_FullStatics_Idx ON dbo.secProfile (Bytes, GuidUser, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secReusableCatalog ************************/

/* Build Table Structure */
CREATE TABLE dbo.secReusableCatalog
(
	GuidReusableCatalog UniqueIdentifier NOT NULL,
	NameKey VARCHAR(100) NULL,
	DataType UniqueIdentifier NULL,
	Title VARCHAR(300) NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secReusableCatalog ADD CONSTRAINT PK_secReusableCatalog
	PRIMARY KEY (GuidReusableCatalog);

/* Add Indexes */
CREATE UNIQUE NONCLUSTERED INDEX secDynamicCatalog_NameKey_Idx ON dbo.secReusableCatalog (NameKey);


/******************** Add Table: dbo.secReusableCatalogValues ************************/

/* Build Table Structure */
CREATE TABLE dbo.secReusableCatalogValues
(
	GuidReusableCatalogValue UniqueIdentifier NOT NULL,
	GuidReusableCatalog UniqueIdentifier NULL,
	ValueString VARCHAR(100) NULL,
	ValueInt INTEGER NULL,
	ValueBoolean BIT NULL,
	ValueDecimal DECIMAL(16, 2) NULL,
	OrderOption INTEGER NULL,
	Title VARCHAR(300) NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secReusableCatalogValues ADD CONSTRAINT PK_secDynamicCatalogValues
	PRIMARY KEY (GuidReusableCatalogValue);


/******************** Add Table: dbo.secRoleDataPermission ************************/

/* Build Table Structure */
CREATE TABLE dbo.secRoleDataPermission
(
	GuidRole UniqueIdentifier NOT NULL,
	GuidDataColumn UniqueIdentifier NOT NULL,
	GuidPermission UniqueIdentifier NOT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secRoleDataPermission ADD CONSTRAINT pksecRoleDataPermission
	PRIMARY KEY (GuidPermission, GuidRole, GuidDataColumn);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secRoleDataPermission_FullStatics_Idx ON dbo.secRoleDataPermission (Bytes, GuidRole, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secRoleModuleObjectPermission ************************/

/* Build Table Structure */
CREATE TABLE dbo.secRoleModuleObjectPermission
(
	IsAllowed BIT NULL,
	UpdatedDate DATETIME NULL,
	CreatedDate DATETIME NULL,
	GuidModule UniqueIdentifier NOT NULL,
	GuidBusinessObject UniqueIdentifier NOT NULL,
	GuidRole UniqueIdentifier NOT NULL,
	GuidPermission UniqueIdentifier NOT NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secRoleModuleObjectPermission ADD CONSTRAINT PK_secRoleModuleObjectPermission_1
	PRIMARY KEY (GuidModule, GuidBusinessObject, GuidRole, GuidPermission);

/* Add Indexes */
CREATE NONCLUSTERED INDEX nci_wi_secRoleModuleObjectPermission_24C605B955A405CFD2D08226824ECA5E ON dbo.secRoleModuleObjectPermission (Bytes, CreatedBy, CreatedDate, IsAllowed, UpdatedBy, UpdatedDate, GuidRole);

CREATE NONCLUSTERED INDEX secRoleModuleObjectPermission_FullStatics_Idx ON dbo.secRoleModuleObjectPermission (Bytes, GuidModule, CreatedDate, UpdatedDate, CreatedBy);


/******************** Add Table: dbo.secRoleModulePermissions ************************/

/* Build Table Structure */
CREATE TABLE dbo.secRoleModulePermissions
(
	UpdatedDate DATETIME NULL,
	CreatedDate DATETIME NULL,
	GuidModule UniqueIdentifier NOT NULL,
	GuidRole UniqueIdentifier NOT NULL,
	GuidPermission UniqueIdentifier NOT NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	IsAllowed BIT NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secRoleModulePermissions ADD CONSTRAINT PK_secRoleModulePermissions
	PRIMARY KEY (GuidModule, GuidRole, GuidPermission);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secRoleModulePermissions_FullStatics_Idx ON dbo.secRoleModulePermissions (Bytes, GuidModule, CreatedDate, UpdatedDate, CreatedBy);


/******************** Add Table: dbo.secRoleTree ************************/

/* Build Table Structure */
CREATE TABLE dbo.secRoleTree
(
	IdRole INTEGER NOT NULL,
	ParentIdRole INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secRoleTree ADD CONSTRAINT secRoleTree_PK
	PRIMARY KEY (IdRole);


/******************** Add Table: dbo.secRoles ************************/

/* Build Table Structure */
CREATE TABLE dbo.secRoles
(
	RoleId UniqueIdentifier NULL,
	RoleName VARCHAR(100) NULL,
	LoweredRoleName VARCHAR(100) NULL,
	UpdatedDate DATETIME NULL,
	CreatedDate DATETIME NULL,
	GuidRole UniqueIdentifier DEFAULT newid() NOT NULL,
	ParentGuidRole UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	RoleName_ES VARCHAR(300) NULL,
	RoleName_EN VARCHAR(300) NULL,
	Description VARCHAR(1000) NULL,
	Description_EN VARCHAR(1000) NULL,
	OwnerCompany UniqueIdentifier NULL,
	IsDeleted BIT NULL,
	IsHeritable BIT DEFAULT 'false' NOT NULL,
	UrlStartForced VARCHAR(500) NULL,
	NameKey VARCHAR(255) NULL,
	Bytes INTEGER NULL,
	IsFullAccess BIT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secRoles ADD CONSTRAINT Roles_PK
	PRIMARY KEY (GuidRole);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secRoles_FullStatics_Idx ON dbo.secRoles (Bytes, GuidRole, CreatedDate, UpdatedDate, CreatedBy, IsDeleted);


/******************** Add Table: dbo.secSetting ************************/

/* Build Table Structure */
CREATE TABLE dbo.secSetting
(
	GuidSetting UniqueIdentifier NOT NULL,
	NameKey VARCHAR(100) NULL,
	Name VARCHAR(255) NULL,
	Description VARCHAR(255) NULL,
	GuidModule UniqueIdentifier NULL,
	GuidSettingVaue UniqueIdentifier NULL,
	TypeDataOption VARCHAR(50) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secSetting ADD CONSTRAINT pksecSetting
	PRIMARY KEY (GuidSetting);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secSetting_FullStatics_Idx ON dbo.secSetting (Bytes, GuidSetting, CreatedDate, UpdatedDate);

CREATE UNIQUE NONCLUSTERED INDEX secSetting_NameKey_GuidModule_Idx ON dbo.secSetting (NameKey, GuidModule);


/******************** Add Table: dbo.secSettingValue ************************/

/* Build Table Structure */
CREATE TABLE dbo.secSettingValue
(
	GuidSettingVaue UniqueIdentifier NOT NULL,
	GuidSetting UniqueIdentifier NULL,
	ValueString VARCHAR(100) NULL,
	Title VARCHAR(255) NULL,
	Description VARCHAR(5000) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secSettingValue ADD CONSTRAINT pksecSettingValue
	PRIMARY KEY (GuidSettingVaue);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secSettingValue_FullStatics_Idx ON dbo.secSettingValue (Bytes, GuidSettingVaue, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secSyncIntegrator ************************/

/* Build Table Structure */
CREATE TABLE dbo.secSyncIntegrator
(
	GuidSyncIntegrator UniqueIdentifier NOT NULL,
	GuidSyncMatchDef UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	CreatedBy UniqueIdentifier NULL,
	OwnerCompany UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secSyncIntegrator ADD CONSTRAINT pksecSyncIntegrator
	PRIMARY KEY (GuidSyncIntegrator);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secSyncIntegrator_FullStatics_Idx ON dbo.secSyncIntegrator (Bytes, GuidSyncIntegrator, CreatedDate, UpdatedDate, CreatedBy);


/******************** Add Table: dbo.secSyncItems ************************/

/* Build Table Structure */
CREATE TABLE dbo.secSyncItems
(
	GuidSyncItem UniqueIdentifier NOT NULL,
	GuidSyncMatchDefObject UniqueIdentifier NULL,
	OrigId UniqueIdentifier NOT NULL,
	GuidSyncIntegrator UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secSyncItems ADD CONSTRAINT pksecSyncItems
	PRIMARY KEY (GuidSyncItem);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secSyncItems_FullStatics_Idx ON dbo.secSyncItems (Bytes, GuidSyncItem, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secSyncMatchDef ************************/

/* Build Table Structure */
CREATE TABLE dbo.secSyncMatchDef
(
	GuidSyncMatchDef UniqueIdentifier NOT NULL,
	Name VARCHAR(255) NOT NULL,
	CreatedBy UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	UpdatedBy UniqueIdentifier NULL,
	UpdatedDate DATETIME NULL,
	TypeSync VARCHAR(255) NULL,
	UniqueDirectionObject UniqueIdentifier NULL,
	UseSameId BIT DEFAULT 'false' NOT NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secSyncMatchDef ADD CONSTRAINT pksecSyncMatchDef
	PRIMARY KEY (GuidSyncMatchDef);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secSyncMatchDef_FullStatics_Idx ON dbo.secSyncMatchDef (Bytes, GuidSyncMatchDef, CreatedDate, UpdatedDate, CreatedBy);


/******************** Add Table: dbo.secSyncMatchDefObjects ************************/

/* Build Table Structure */
CREATE TABLE dbo.secSyncMatchDefObjects
(
	GuidSyncMatchDefObject UniqueIdentifier NOT NULL,
	GuidSyncMatchDef UniqueIdentifier NULL,
	GuidBusinessObject UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secSyncMatchDefObjects ADD CONSTRAINT pksecSyncMatchDefObjects
	PRIMARY KEY (GuidSyncMatchDefObject);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secSyncMatchDefObjects_FullStatics_Idx ON dbo.secSyncMatchDefObjects (Bytes, GuidSyncMatchDefObject, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secSyncMatchDefProps ************************/

/* Build Table Structure */
CREATE TABLE dbo.secSyncMatchDefProps
(
	GuidSyncMacthDefProp UniqueIdentifier NOT NULL,
	PropertyMacthName VARCHAR(255) NULL,
	GuidSyncMatchDef UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secSyncMatchDefProps ADD CONSTRAINT pksecSyncMatchDefProps
	PRIMARY KEY (GuidSyncMacthDefProp);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secSyncMatchDefProps_FullStatics_Idx ON dbo.secSyncMatchDefProps (Bytes, GuidSyncMacthDefProp, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secSyncMatchProperty ************************/

/* Build Table Structure */
CREATE TABLE dbo.secSyncMatchProperty
(
	GuidSyncMatchProp UniqueIdentifier NOT NULL,
	GuidSyncMacthDefProp UniqueIdentifier NULL,
	GuidBizObjProperty UniqueIdentifier NULL,
	GuidSyncMatchDefObjects UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secSyncMatchProperty ADD CONSTRAINT pksecSyncMatchProperty
	PRIMARY KEY (GuidSyncMatchProp);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secSyncMatchProperty_FullStatics_Idx ON dbo.secSyncMatchProperty (Bytes, GuidSyncMatchProp, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secTags ************************/

/* Build Table Structure */
CREATE TABLE dbo.secTags
(
	GuidTag UniqueIdentifier NOT NULL,
	Title VARCHAR(100) NOT NULL,
	Title_EN VARCHAR(100) NULL,
	Title_ES VARCHAR(100) NULL,
	TagKey VARCHAR(50) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secTags ADD CONSTRAINT pksecTags
	PRIMARY KEY (GuidTag);

/* Add Indexes */
CREATE NONCLUSTERED INDEX TagKey ON dbo.secTags (TagKey);

CREATE NONCLUSTERED INDEX secTags_FullStatics_Idx ON dbo.secTags (Bytes, GuidTag, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secTask ************************/

/* Build Table Structure */
CREATE TABLE dbo.secTask
(
	GuidTask UniqueIdentifier NOT NULL,
	StartDT DATETIME NULL,
	RepeatEachHr INTEGER NULL,
	UrlEndPoint VARCHAR(1000) NULL,
	CompanyOwner UniqueIdentifier NULL,
	GuidModule UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secTask ADD CONSTRAINT pksecTask
	PRIMARY KEY (GuidTask);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secTask_FullStatics_Idx ON dbo.secTask (Bytes, GuidTask, CreatedDate, UpdatedDate, CreatedBy);


/******************** Add Table: dbo.secTaskHistory ************************/

/* Build Table Structure */
CREATE TABLE dbo.secTaskHistory
(
	GuidTaskHistory UniqueIdentifier NOT NULL,
	StartTime DATETIME NULL,
	EndTime DATETIME NULL,
	GuidTask UniqueIdentifier NULL,
	UrlReponse VARCHAR(MAX) NULL,
	ResponseCodeN INTEGER NULL,
	IsManual BIT DEFAULT 'false' NOT NULL,
	CreatedBy UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	Bytes INTEGER NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secTaskHistory ADD CONSTRAINT pksecTaskHistory
	PRIMARY KEY (GuidTaskHistory);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secTaskHistory_FullStatics_Idx ON dbo.secTaskHistory (Bytes, GuidTaskHistory, CreatedDate, UpdatedDate, CreatedBy);


/******************** Add Table: dbo.secTimeZone ************************/

/* Build Table Structure */
CREATE TABLE dbo.secTimeZone
(
	GuidTimeZone UniqueIdentifier NOT NULL,
	CountryCode VARCHAR(4) NULL,
	Name VARCHAR(35) NULL,
	ZoneID INTEGER NULL,
	CreatedDate DATETIME NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedDate DATETIME NULL,
	UpdatedBy UniqueIdentifier NULL,
	UseDST BIT NULL,
	StartDST DATETIME NULL,
	EndDST DATETIME NULL,
	HrsOffsetDST INTEGER NULL,
	HrsOffset INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secTimeZone ADD CONSTRAINT pksecTimeZone
	PRIMARY KEY (GuidTimeZone);


/******************** Add Table: dbo.secTutorial ************************/

/* Build Table Structure */
CREATE TABLE dbo.secTutorial
(
	GuidTutorial UniqueIdentifier NOT NULL,
	Name VARCHAR(255) NULL,
	NameKey VARCHAR(20) NULL,
	GuidModule UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	IsDeleted BIT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secTutorial ADD CONSTRAINT pksecTutorial
	PRIMARY KEY (GuidTutorial);


/******************** Add Table: dbo.secTutorialItem ************************/

/* Build Table Structure */
CREATE TABLE dbo.secTutorialItem
(
	GuidTutorialItem UniqueIdentifier NOT NULL,
	OrderItem INTEGER NULL,
	GuidTutorial UniqueIdentifier NULL,
	ImageUrl VARCHAR(500) NULL,
	OrderContentHtml VARCHAR(8000) NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	IsDeleted BIT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secTutorialItem ADD CONSTRAINT pksecTutorialItem
	PRIMARY KEY (GuidTutorialItem);


/******************** Add Table: dbo.secUpdate ************************/

/* Build Table Structure */
CREATE TABLE dbo.secUpdate
(
	GuidUpdate UniqueIdentifier NOT NULL,
	VersionID DECIMAL(13, 4) NOT NULL,
	VersionName VARCHAR(255) NULL,
	ScriptSQL VARCHAR(MAX) NULL,
	CreatedDate DATETIME NULL,
	ExecutionResult VARCHAR(MAX) NULL,
	ExecutionWithError BIT NULL,
	UpdatedDate DATETIME NULL,
	GuidModule UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secUpdate ADD CONSTRAINT pksecUpdate
	PRIMARY KEY (GuidUpdate);


/******************** Add Table: dbo.secUserCompanies ************************/

/* Build Table Structure */
CREATE TABLE dbo.secUserCompanies
(
	GuidCompany UniqueIdentifier NOT NULL,
	GuidUser UniqueIdentifier NULL,
	GuidUserCompany UniqueIdentifier NOT NULL,
	CompanyAccepted BIT NULL,
	Useraccepted BIT NULL,
	CreatedBy UniqueIdentifier NULL,
	CompanyUser UniqueIdentifier NULL,
	CreatedDate DATETIME NULL,
	Disabled BIT NULL,
	IsDeleted BIT NULL,
	GuidRole UniqueIdentifier NULL,
	LastSelectedDate DATETIME NULL,
	GuidModule UniqueIdentifier NULL,
	ENewsLetterSync BIT NULL,
	TotalItems INTEGER NULL,
	UpdatedDateTotalItems DATETIME NULL,
	Bytes INTEGER NULL,
	UpdatedDate DATETIME NULL,
	NewNotifications INTEGER NULL,
	TotalNotifications INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secUserCompanies ADD CONSTRAINT pksecUserCompanies
	PRIMARY KEY (GuidUserCompany);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secUserCompanies_FullStatics_Idx ON dbo.secUserCompanies (Bytes, GuidUserCompany, CreatedDate, UpdatedDate, CreatedBy, GuidCompany, IsDeleted);

CREATE NONCLUSTERED INDEX secUserCompanies_GuidCompany_GuidUser_GuidRole_Idx ON dbo.secUserCompanies (GuidCompany, GuidUser, GuidRole);


/******************** Add Table: dbo.secUserConfigurations ************************/

/* Build Table Structure */
CREATE TABLE dbo.secUserConfigurations
(
	GuidUser UniqueIdentifier NOT NULL,
	GuidReusableCatalog UniqueIdentifier NOT NULL,
	ValueString VARCHAR(20) NULL,
	ValueInt INTEGER NULL,
	ValueBoolean BIT NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secUserConfigurations ADD CONSTRAINT PK_secUserConfigurations
	PRIMARY KEY (GuidUser, GuidReusableCatalog);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secUserConfigurations_FullStatics_Idx ON dbo.secUserConfigurations (Bytes, GuidUser, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secUserPayments ************************/

/* Build Table Structure */
CREATE TABLE dbo.secUserPayments
(
	GuidUserPayment UniqueIdentifier NOT NULL,
	Amount DECIMAL(14, 4) NULL,
	UpdatedDate DATETIME NULL,
	CreatedDate DATETIME NULL,
	Comments VARCHAR(255) NULL,
	GuidCompany UniqueIdentifier NULL,
	GuidPaymentMethod UniqueIdentifier NULL,
	GuidUser UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secUserPayments ADD CONSTRAINT PK_secUserPayments
	PRIMARY KEY (GuidUserPayment);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secUserPayments_FullStatics_Idx ON dbo.secUserPayments (Bytes, GuidUserPayment, CreatedDate, UpdatedDate, CreatedBy, GuidCompany);


/******************** Add Table: dbo.secUser_LoginProviders ************************/

/* Build Table Structure */
CREATE TABLE dbo.secUser_LoginProviders
(
	UrlProfile VARCHAR(200) NULL,
	UserName VARCHAR(50) NULL,
	FavoriteName VARCHAR(50) NULL,
	FirstName VARCHAR(50) NULL,
	LastName VARCHAR(50) NULL,
	Email VARCHAR(50) NULL,
	IsEmailValid BIT NULL,
	GuidUser UniqueIdentifier NULL,
	GuidUserLoginProvider UniqueIdentifier DEFAULT newid() NOT NULL,
	GuidLoginProvider UniqueIdentifier NULL,
	IdUserProvider VARCHAR(200) NULL,
	Bytes INTEGER NULL,
	CreatedDate DATETIME NULL,
	UpdatedDate DATETIME NULL,
	GuidFile UniqueIdentifier NULL,
	IsDeleted BIT NULL,
	AccessToken VARCHAR(3000) NULL,
	AvatarUrl VARCHAR(500) NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secUser_LoginProviders ADD CONSTRAINT XPKsecUser_LoginProviders
	PRIMARY KEY (GuidUserLoginProvider);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secUser_LoginProviders_FullStatics_Idx ON dbo.secUser_LoginProviders (Bytes, GuidUserLoginProvider, CreatedDate, UpdatedDate);


/******************** Add Table: dbo.secUsers ************************/

/* Build Table Structure */
CREATE TABLE dbo.secUsers
(
	UserId UniqueIdentifier NULL,
	UserName VARCHAR(50) NULL,
	LoweredUserName VARCHAR(50) NULL,
	IsAnonymous BIT NULL,
	LastActivityDate DATETIME NULL,
	LastName VARCHAR(300) NULL,
	FirstName VARCHAR(300) NULL,
	Password VARCHAR(500) NULL,
	Email VARCHAR(300) NULL,
	ExtensibleInfo XML NULL,
	UpdatedDate DATETIME NULL,
	CreatedDate DATETIME NULL,
	DisplayName VARCHAR(100) NULL,
	EmailVerified BIT NULL,
	GuidUser UniqueIdentifier DEFAULT newid() NOT NULL,
	UpdatedBy UniqueIdentifier NULL,
	CreatedBy UniqueIdentifier NULL,
	GuidFilePhoto UniqueIdentifier NULL,
	Bio VARCHAR(MAX) NULL,
	IsInvited BIT NULL,
	EmailCodeVerirication VARCHAR(32) NULL,
	ENewsLetterSync BIT NULL,
	Lang VARCHAR(2) NULL,
	CountryCode VARCHAR(2) NULL,
	IntegrationID UniqueIdentifier NULL,
	GuidAddedBy UniqueIdentifier NULL,
	Bytes INTEGER NULL,
	IsDeleted BIT NULL,
	Token VARCHAR(100) NULL,
	TimeZoneId VARCHAR(100) NULL,
	InactiveByCode BIT NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secUsers ADD CONSTRAINT Users_PK
	PRIMARY KEY (GuidUser);

/* Add Unique Constraints */
ALTER TABLE dbo.secUsers
	ADD CONSTRAINT UserUserId UNIQUE (UserId);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secUsers_FreeText_Idx ON dbo.secUsers (GuidUser, UserName, Email, FirstName, LastName, UpdatedDate);

CREATE NONCLUSTERED INDEX secUsers_FullStatics_Idx ON dbo.secUsers (Bytes, GuidUser, CreatedDate, UpdatedDate, CreatedBy);

CREATE UNIQUE NONCLUSTERED INDEX secUsers_GuidUser_IsDeleted_Token_Idx ON dbo.secUsers (GuidUser, IsDeleted, Token);

CREATE NONCLUSTERED INDEX secUsers_UserName_LastName_FirstName_Email_GuidUser_IsDeleted_Token_Idx ON dbo.secUsers (UserName, LastName, FirstName, Email, GuidUser, IsDeleted, Token);


/******************** Add Table: dbo.secWFActivity ************************/

/* Build Table Structure */
CREATE TABLE dbo.secWFActivity
(
	GuidWFActivity UniqueIdentifier NOT NULL,
	Title VARCHAR(255) NOT NULL,
	CreatedDate DATETIME NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	UpdatedDate DATETIME NULL,
	IsDeleted BIT NULL,
	GuidProcess UniqueIdentifier NULL,
	DecisionYes UniqueIdentifier NULL,
	DecisionNo UniqueIdentifier NULL,
	GuidFromState UniqueIdentifier NULL,
	GuidReusable_ActivityType UniqueIdentifier NULL,
	OrderActivity INTEGER NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secWFActivity ADD CONSTRAINT pksecWFActivity
	PRIMARY KEY (GuidWFActivity);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secWFActivity_FullStatics_Idx ON dbo.secWFActivity (Bytes, GuidWFActivity, CreatedDate, UpdatedDate, CreatedBy, IsDeleted);


/******************** Add Table: dbo.secWFActivityUserLog ************************/

/* Build Table Structure */
CREATE TABLE dbo.secWFActivityUserLog
(
	GuidWFActivityUserLog UniqueIdentifier NOT NULL,
	CreatedDate DATETIME NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	UpdatedDate DATETIME NULL,
	GuidCompany UniqueIdentifier NULL,
	IsDeleted BIT NULL,
	GuidUser UniqueIdentifier NULL,
	GuidStateBefore UniqueIdentifier NULL,
	Decision BIT NOT NULL,
	Comments VARCHAR(MAX) NULL,
	GuidBusinessObject UniqueIdentifier NULL,
	OrigId UniqueIdentifier NULL,
	GuidWFActivity UniqueIdentifier NULL,
	GuidStateAfter UniqueIdentifier NULL,
	GuidWFActivityUser UniqueIdentifier NULL,
	Waiting BIT DEFAULT 'true' NOT NULL,
	Completed BIT NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secWFActivityUserLog ADD CONSTRAINT pksecWFStateUserLog
	PRIMARY KEY (GuidWFActivityUserLog);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secWFActivityUserLog_FullStatics_Idx ON dbo.secWFActivityUserLog (Bytes, GuidWFActivityUserLog, CreatedDate, UpdatedDate, CreatedBy, GuidCompany, IsDeleted);


/******************** Add Table: dbo.secWFActivityUsers ************************/

/* Build Table Structure */
CREATE TABLE dbo.secWFActivityUsers
(
	GuidWFActivityUser UniqueIdentifier NOT NULL,
	CreatedDate DATETIME NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	UpdatedDate DATETIME NULL,
	GuidCompany UniqueIdentifier NULL,
	IsDeleted BIT NULL,
	GuidUser UniqueIdentifier NULL,
	GuidWFActivity UniqueIdentifier NULL,
	OrderDecision INTEGER NULL,
	GetUsersFromBizObj BIT NULL,
	GuidBizObjPropertyUsers UniqueIdentifier NULL,
	Title VARCHAR(255) NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secWFActivityUsers ADD CONSTRAINT pksecWFActivityUsers
	PRIMARY KEY (GuidWFActivityUser);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secWFActivityUsers_FullStatics_Idx ON dbo.secWFActivityUsers (Bytes, GuidWFActivityUser, CreatedDate, UpdatedDate, CreatedBy, GuidCompany, IsDeleted);


/******************** Add Table: dbo.secWFConnector ************************/

/* Build Table Structure */
CREATE TABLE dbo.secWFConnector
(
	GuidWFConnector UniqueIdentifier NOT NULL,
	GuidWFActivityFrom UniqueIdentifier NULL,
	GuidWFActivityTo UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secWFConnector ADD CONSTRAINT pksecWFConnector
	PRIMARY KEY (GuidWFConnector);


/******************** Add Table: dbo.secWFProcess ************************/

/* Build Table Structure */
CREATE TABLE dbo.secWFProcess
(
	GuidProcess UniqueIdentifier NOT NULL,
	Title VARCHAR(255) NOT NULL,
	GuidBusinessObject UniqueIdentifier NOT NULL,
	CreatedDate DATETIME NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	UpdatedDate DATETIME NULL,
	IsDeleted BIT NULL,
	ProcessKey VARCHAR(100) NULL,
	GuidBizObjProperty UniqueIdentifier NULL,
	GuidDefaultState UniqueIdentifier NULL,
	GuidPropertyUserWaiting UniqueIdentifier NULL,
	GuiBusinessObjectUsersWaiting UniqueIdentifier NULL,
	AutoStart BIT DEFAULT 'false' NOT NULL,
	GuidPropertyUsersWaiting UniqueIdentifier NULL,
	GuidPropertyAuthor UniqueIdentifier NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secWFProcess ADD CONSTRAINT pksecWFProcess
	PRIMARY KEY (GuidProcess);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secWFProcess_FullStatics_Idx ON dbo.secWFProcess (Bytes, GuidProcess, CreatedDate, UpdatedDate, CreatedBy, IsDeleted);


/******************** Add Table: dbo.secWFStates ************************/

/* Build Table Structure */
CREATE TABLE dbo.secWFStates
(
	GuidWFState UniqueIdentifier NOT NULL,
	Title VARCHAR(255) NOT NULL,
	CreatedDate DATETIME NULL,
	CreatedBy UniqueIdentifier NULL,
	UpdatedBy UniqueIdentifier NULL,
	UpdatedDate DATETIME NULL,
	IsDeleted BIT NULL,
	GuidWorkFlow UniqueIdentifier NULL,
	StateOrder INTEGER NULL,
	ColorClassName VARCHAR(255) NULL,
	SetPropertyValue VARCHAR(MAX) NULL,
	StateKey VARCHAR(100) NULL,
	GuidPropertySetTrue UniqueIdentifier NULL,
	ColorClassNameRow VARCHAR(255) NULL,
	GuidPropertySetFalse UniqueIdentifier NULL,
	Bytes INTEGER NULL
);

/* Add Primary Key */
ALTER TABLE dbo.secWFStates ADD CONSTRAINT pksecWFStates
	PRIMARY KEY (GuidWFState);

/* Add Indexes */
CREATE NONCLUSTERED INDEX secWFStates_FullStatics_Idx ON dbo.secWFStates (Bytes, GuidWFState, CreatedDate, UpdatedDate, CreatedBy, IsDeleted);







/************ Add Foreign Keys ***************/

/* Add Foreign Key: fk_secAudit_secBusinessObject */
ALTER TABLE dbo.secAudit ADD CONSTRAINT fk_secAudit_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secAudit_secCompanies */
ALTER TABLE dbo.secAudit ADD CONSTRAINT fk_secAudit_secCompanies
	FOREIGN KEY (GuidCompany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_myAuditProperties_myAudit */
ALTER TABLE dbo.secAuditProperties ADD CONSTRAINT FK_myAuditProperties_myAudit
	FOREIGN KEY (AuditId) REFERENCES dbo.secAudit (AuditId)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secBizObjProperty_secBusinessObject */
ALTER TABLE dbo.secBizObjProperty ADD CONSTRAINT fk_secBizObjProperty_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secBizPartner_secUsers */
ALTER TABLE dbo.secBizPartner ADD CONSTRAINT fk_secBizPartner_secUsers
	FOREIGN KEY (GuidUser) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secBizPropertyDescriptions_secBizObjProperty */
ALTER TABLE dbo.secBizPropertyDescriptions ADD CONSTRAINT fk_secBizPropertyDescriptions_secBizObjProperty
	FOREIGN KEY (GuidBizObjProperty) REFERENCES dbo.secBizObjProperty (GuidBizObjProperty)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secBizPropertyDescriptions_secBusinessObject */
ALTER TABLE dbo.secBizPropertyDescriptions ADD CONSTRAINT fk_secBizPropertyDescriptions_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secBizPropertyDescriptions_secCompanies */
ALTER TABLE dbo.secBizPropertyDescriptions ADD CONSTRAINT fk_secBizPropertyDescriptions_secCompanies
	FOREIGN KEY (OwnerComptany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secBusinessObject_secModule */
ALTER TABLE dbo.secBusinessObject ADD CONSTRAINT FK_secBusinessObject_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_ReusableStorageType */
ALTER TABLE dbo.secBusinessObject ADD CONSTRAINT fk_ReusableStorageType
	FOREIGN KEY (GuidReusableStoragePrimary) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_Reusable_StorafgeForGet */
ALTER TABLE dbo.secBusinessObject ADD CONSTRAINT fk_Reusable_StorafgeForGet
	FOREIGN KEY (GuidReusableStorageForGet) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secBusinessObject_secBusinessObject */
ALTER TABLE dbo.secBusinessObject ADD CONSTRAINT fk_secBusinessObject_secBusinessObject
	FOREIGN KEY (UsemodeFrom) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secChatGroup_secModule */
ALTER TABLE dbo.secChatGroup ADD CONSTRAINT fk_secChatGroup_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secChatGroup_secUserCompanies */
ALTER TABLE dbo.secChatGroup ADD CONSTRAINT fk_secChatGroup_secUserCompanies
	FOREIGN KEY (GuidUserCompany) REFERENCES dbo.secUserCompanies (GuidUserCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secChatGroupUser_secChatGroup */
ALTER TABLE dbo.secChatGroupUser ADD CONSTRAINT fk_secChatGroupUser_secChatGroup
	FOREIGN KEY (GuidChatGroup) REFERENCES dbo.secChatGroup (GuidChatGroup)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secChatGroupUser_secUsers */
ALTER TABLE dbo.secChatGroupUser ADD CONSTRAINT fk_secChatGroupUser_secUsers
	FOREIGN KEY (GuidUser) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secComModSetting_secCompanyModules */
ALTER TABLE dbo.secComModSetting ADD CONSTRAINT fk_secComModSetting_secCompanyModules
	FOREIGN KEY (GuidCompanyModule) REFERENCES dbo.secCompanyModules (GuidCompanyModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secComModSetting_secSetting */
ALTER TABLE dbo.secComModSetting ADD CONSTRAINT fk_secComModSetting_secSetting
	FOREIGN KEY (GuidSetting) REFERENCES dbo.secSetting (GuidSetting)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secComModSetting_secSettingValue */
ALTER TABLE dbo.secComModSetting ADD CONSTRAINT fk_secComModSetting_secSettingValue
	FOREIGN KEY (GuidSettingVaue) REFERENCES dbo.secSettingValue (GuidSettingVaue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCompAppBizObject_secBusinessObject */
ALTER TABLE dbo.secCompAppBizObject ADD CONSTRAINT fk_secCompAppBizObject_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCompAppBizObject_secCompanyModules */
ALTER TABLE dbo.secCompAppBizObject ADD CONSTRAINT fk_secCompAppBizObject_secCompanyModules
	FOREIGN KEY (GuidCompanyModule) REFERENCES dbo.secCompanyModules (GuidCompanyModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCompAppFeature_secCompanies */
ALTER TABLE dbo.secCompAppFeature ADD CONSTRAINT fk_secCompAppFeature_secCompanies
	FOREIGN KEY (GuidCompany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCompAppFeature_secCompanyModules */
ALTER TABLE dbo.secCompAppFeature ADD CONSTRAINT fk_secCompAppFeature_secCompanyModules
	FOREIGN KEY (GuidCompanyModule) REFERENCES dbo.secCompanyModules (GuidCompanyModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCompAppFeature_secFeatureConcepts */
ALTER TABLE dbo.secCompAppFeature ADD CONSTRAINT fk_secCompAppFeature_secFeatureConcepts
	FOREIGN KEY (GuidFeatureConcept) REFERENCES dbo.secFeatureConcepts (GuidFeatureConcept)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCompAppFeature_secModule */
ALTER TABLE dbo.secCompAppFeature ADD CONSTRAINT fk_secCompAppFeature_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCompAppHistory_secCompanyModules */
ALTER TABLE dbo.secCompAppHistory ADD CONSTRAINT fk_secCompAppHistory_secCompanyModules
	FOREIGN KEY (GuidCompanyModule) REFERENCES dbo.secCompanyModules (GuidCompanyModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_Reusable_CompanyModuleConfig */
ALTER TABLE dbo.secCompModConfig ADD CONSTRAINT fk_Reusable_CompanyModuleConfig
	FOREIGN KEY (GuidReusable_CompModConfig) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCompanyModuleSetting_secCompanyModules */
ALTER TABLE dbo.secCompModConfig ADD CONSTRAINT fk_secCompanyModuleSetting_secCompanyModules
	FOREIGN KEY (GuidCompanyModule) REFERENCES dbo.secCompanyModules (GuidCompanyModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCompUISetting_secCompanies */
ALTER TABLE dbo.secCompUISetting ADD CONSTRAINT fk_secCompUISetting_secCompanies
	FOREIGN KEY (GuidCompany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCompUISetting_secModule */
ALTER TABLE dbo.secCompUISetting ADD CONSTRAINT fk_secCompUISetting_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_ParentCompanies */
ALTER TABLE dbo.secCompanies ADD CONSTRAINT FK_ParentCompanies
	FOREIGN KEY (CompanyParentGuid) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secCompanies_secCompanyType */
ALTER TABLE dbo.secCompanies ADD CONSTRAINT FK_secCompanies_secCompanyType
	FOREIGN KEY (GuidCompanyType) REFERENCES dbo.secCompanyType (GuidCompanyType)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secCompanies_secFiles */
ALTER TABLE dbo.secCompanies ADD CONSTRAINT FK_secCompanies_secFiles
	FOREIGN KEY (GuidFileLogo) REFERENCES dbo.secFiles (GuidFile)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCompanies_secCompUISetting */
ALTER TABLE dbo.secCompanies ADD CONSTRAINT fk_secCompanies_secCompUISetting
	FOREIGN KEY (GuidCompUISetting) REFERENCES dbo.secCompUISetting (GuidCompUISetting)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCompanies_secUsers_owner */
ALTER TABLE dbo.secCompanies ADD CONSTRAINT fk_secCompanies_secUsers_owner
	FOREIGN KEY (GuidUserOwner) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secCompanyConfigurations_secCompanies */
ALTER TABLE dbo.secCompanyConfigurations ADD CONSTRAINT FK_secCompanyConfigurations_secCompanies
	FOREIGN KEY (GuidCompany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secCompanyConfigurations_secReusableCatalog */
ALTER TABLE dbo.secCompanyConfigurations ADD CONSTRAINT FK_secCompanyConfigurations_secReusableCatalog
	FOREIGN KEY (GuidReusableCatalog) REFERENCES dbo.secReusableCatalog (GuidReusableCatalog)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secCompanyExtraData_secCompanies */
ALTER TABLE dbo.secCompanyExtraData ADD CONSTRAINT FK_secCompanyExtraData_secCompanies
	FOREIGN KEY (GuidCompany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCompanyLogin_secCompanies */
ALTER TABLE dbo.secCompanyLogin ADD CONSTRAINT fk_secCompanyLogin_secCompanies
	FOREIGN KEY (GuidCompany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secCompanyModules_secCompanies */
ALTER TABLE dbo.secCompanyModules ADD CONSTRAINT FK_secCompanyModules_secCompanies
	FOREIGN KEY (GuidCompany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secCompanyModules_secModule */
ALTER TABLE dbo.secCompanyModules ADD CONSTRAINT FK_secCompanyModules_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCompanyModules_secAppTemplate */
ALTER TABLE dbo.secCompanyModules ADD CONSTRAINT fk_secCompanyModules_secAppTemplate
	FOREIGN KEY (GuidAppTemplate) REFERENCES dbo.secAppTemplate (GuidAppTemplate)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: Company_CompanyRoles_FK1 */
ALTER TABLE dbo.secCompanyRoles ADD CONSTRAINT Company_CompanyRoles_FK1
	FOREIGN KEY (GuidCompany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: aspnet_Roles_CompanyRoles_FK1 */
ALTER TABLE dbo.secCompanyRoles ADD CONSTRAINT aspnet_Roles_CompanyRoles_FK1
	FOREIGN KEY (GuidRole) REFERENCES dbo.secRoles (GuidRole)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secContentBusinessObjects_MyContents */
ALTER TABLE dbo.secContentBusinessObjects ADD CONSTRAINT FK_secContentBusinessObjects_MyContents
	FOREIGN KEY (GuidContent) REFERENCES dbo.secContents (GuidContent)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secContentBusinessObjects_secBusinessObject */
ALTER TABLE dbo.secContentBusinessObjects ADD CONSTRAINT FK_secContentBusinessObjects_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secContentMenus_secContents */
ALTER TABLE dbo.secContentMenus ADD CONSTRAINT FK_secContentMenus_secContents
	FOREIGN KEY (GuidContent) REFERENCES dbo.secContents (GuidContent)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secContentRelations_secContents_GuidContent */
ALTER TABLE dbo.secContentRelations ADD CONSTRAINT FK_secContentRelations_secContents_GuidContent
	FOREIGN KEY (GuidContent) REFERENCES dbo.secContents (GuidContent)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secContentRelations_secContents_GuidParent */
ALTER TABLE dbo.secContentRelations ADD CONSTRAINT FK_secContentRelations_secContents_GuidParent
	FOREIGN KEY (GuidParent) REFERENCES dbo.secContents (GuidContent)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secContentTags_secContents */
ALTER TABLE dbo.secContentTags ADD CONSTRAINT fk_secContentTags_secContents
	FOREIGN KEY (GuidContent) REFERENCES dbo.secContents (GuidContent)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secContentTags_secTags_1 */
ALTER TABLE dbo.secContentTags ADD CONSTRAINT fk_secContentTags_secTags_1
	FOREIGN KEY (GuidTag) REFERENCES dbo.secTags (GuidTag)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secContents_secContentType1 */
ALTER TABLE dbo.secContents ADD CONSTRAINT FK_secContents_secContentType1
	FOREIGN KEY (GuidContentType) REFERENCES dbo.secContentType (GuidContentType)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_Feature_parent */
ALTER TABLE dbo.secContents ADD CONSTRAINT fk_Feature_parent
	FOREIGN KEY (GuidFeatureParent) REFERENCES dbo.secContents (GuidContent)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_Reusable_FeatureType */
ALTER TABLE dbo.secContents ADD CONSTRAINT fk_Reusable_FeatureType
	FOREIGN KEY (GuidReusableFeatureType) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secContents_ImageShowPlace */
ALTER TABLE dbo.secContents ADD CONSTRAINT fk_secContents_ImageShowPlace
	FOREIGN KEY (ImageShowPlace) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secContents_secBusinessObject */
ALTER TABLE dbo.secContents ADD CONSTRAINT fk_secContents_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secContents_secContents_1 */
ALTER TABLE dbo.secContents ADD CONSTRAINT fk_secContents_secContents_1
	FOREIGN KEY (RedirectToContent) REFERENCES dbo.secContents (GuidContent)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secContents_secFiles */
ALTER TABLE dbo.secContents ADD CONSTRAINT fk_secContents_secFiles
	FOREIGN KEY (GuidFile) REFERENCES dbo.secFiles (GuidFile)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secContents_secFiles_EN */
ALTER TABLE dbo.secContents ADD CONSTRAINT fk_secContents_secFiles_EN
	FOREIGN KEY (GuidFile_EN) REFERENCES dbo.secFiles (GuidFile)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secContents_secFiles_ES */
ALTER TABLE dbo.secContents ADD CONSTRAINT fk_secContents_secFiles_ES
	FOREIGN KEY (GuidFile_ES) REFERENCES dbo.secFiles (GuidFile)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secContents_secModule */
ALTER TABLE dbo.secContents ADD CONSTRAINT fk_secContents_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secContents_secReusableCatalogValues_ForwardType */
ALTER TABLE dbo.secContents ADD CONSTRAINT fk_secContents_secReusableCatalogValues_ForwardType
	FOREIGN KEY (ForwardType) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secContents_secReusablecCatalogValues_FormatType */
ALTER TABLE dbo.secContents ADD CONSTRAINT fk_secContents_secReusablecCatalogValues_FormatType
	FOREIGN KEY (FormatType) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: CouponType_secCoupon_secReusableCatalogValues */
ALTER TABLE dbo.secCoupon ADD CONSTRAINT CouponType_secCoupon_secReusableCatalogValues
	FOREIGN KEY (GuidCouponType) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secCoupon_secBizPartner */
ALTER TABLE dbo.secCoupon ADD CONSTRAINT fk_secCoupon_secBizPartner
	FOREIGN KEY (GuidBizPartner) REFERENCES dbo.secBizPartner (GuidBizPartner)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secEvent_secModule_1 */
ALTER TABLE dbo.secEventApp ADD CONSTRAINT fk_secEvent_secModule_1
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secEventLog_secCompanies */
ALTER TABLE dbo.secEventLog ADD CONSTRAINT fk_secEventLog_secCompanies
	FOREIGN KEY (GuidCompanyLog) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secEventLog_secIssues */
ALTER TABLE dbo.secEventLog ADD CONSTRAINT fk_secEventLog_secIssues
	FOREIGN KEY (GuidIssue) REFERENCES dbo.secIssues (GuidIssue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secEventLog_secModule */
ALTER TABLE dbo.secEventLog ADD CONSTRAINT fk_secEventLog_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secEventNotify_secEvent_1 */
ALTER TABLE dbo.secEventNotify ADD CONSTRAINT fk_secEventNotify_secEvent_1
	FOREIGN KEY (GuidEventApp) REFERENCES dbo.secEventApp (GuidEventApp)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secEventNotifyTos_secEventNotify_1 */
ALTER TABLE dbo.secEventNotifyTos ADD CONSTRAINT fk_secEventNotifyTos_secEventNotify_1
	FOREIGN KEY (GuidEventNotify) REFERENCES dbo.secEventNotify (GuidEventNotify)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secEventNotifyTos_secReusableCatalogValues_1 */
ALTER TABLE dbo.secEventNotifyTos ADD CONSTRAINT fk_secEventNotifyTos_secReusableCatalogValues_1
	FOREIGN KEY (GuidDestinataryType) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secFeatureConcepts_secModule */
ALTER TABLE dbo.secFeatureConcepts ADD CONSTRAINT fk_secFeatureConcepts_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secPriceDetails_secPriceConcepts_1 */
ALTER TABLE dbo.secFeaurePrices ADD CONSTRAINT fk_secPriceDetails_secPriceConcepts_1
	FOREIGN KEY (GuidFeatureConcept) REFERENCES dbo.secFeatureConcepts (GuidFeatureConcept)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: R_42_1 */
ALTER TABLE dbo.secFilterQueries ADD CONSTRAINT R_42_1
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_MyGeoCities_MyGeoStates */
ALTER TABLE dbo.secGeoCities ADD CONSTRAINT FK_MyGeoCities_MyGeoStates
	FOREIGN KEY (GuidState) REFERENCES dbo.secGeoStates (GuidState)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secGeoCities_secGeoCities */
ALTER TABLE dbo.secGeoCities ADD CONSTRAINT fk_secGeoCities_secGeoCities
	FOREIGN KEY (GuidParent) REFERENCES dbo.secGeoCities (GuidCity)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_MyGeoStates_MyGeoCountries */
ALTER TABLE dbo.secGeoStates ADD CONSTRAINT FK_MyGeoStates_MyGeoCountries
	FOREIGN KEY (GuidCountry) REFERENCES dbo.secGeoCountries (GuidCountry)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secGeoZipCode_secGeoZipCodeItem */
ALTER TABLE dbo.secGeoZipCode ADD CONSTRAINT fk_secGeoZipCode_secGeoZipCodeItem
	FOREIGN KEY (GuidGeoZipCodeItem) REFERENCES dbo.secGeoZipCodeItem (GuidGeoZipCodeItem)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secGeoZipCodeItem_secGeoCountries */
ALTER TABLE dbo.secGeoZipCodeItem ADD CONSTRAINT fk_secGeoZipCodeItem_secGeoCountries
	FOREIGN KEY (GuidCountry) REFERENCES dbo.secGeoCountries (GuidCountry)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secInvPaymentFile_secFiles */
ALTER TABLE dbo.secInvPaymentFile ADD CONSTRAINT fk_secInvPaymentFile_secFiles
	FOREIGN KEY (GuidFile) REFERENCES dbo.secFiles (GuidFile)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secInvPaymentFile_secInvoicePayment */
ALTER TABLE dbo.secInvPaymentFile ADD CONSTRAINT fk_secInvPaymentFile_secInvoicePayment
	FOREIGN KEY (GuidInvoicePayment) REFERENCES dbo.secInvoicePayment (GuidInvoicePayment)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secInvoice_secCompanies */
ALTER TABLE dbo.secInvoice ADD CONSTRAINT fk_secInvoice_secCompanies
	FOREIGN KEY (GuidCompany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secInvoice_secCompanyModules */
ALTER TABLE dbo.secInvoice ADD CONSTRAINT fk_secInvoice_secCompanyModules
	FOREIGN KEY (GuidCompanyModule) REFERENCES dbo.secCompanyModules (GuidCompanyModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secInvoice_secModule */
ALTER TABLE dbo.secInvoice ADD CONSTRAINT fk_secInvoice_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secInvoiceDetail_secFeatureConcepts */
ALTER TABLE dbo.secInvoiceDetail ADD CONSTRAINT fk_secInvoiceDetail_secFeatureConcepts
	FOREIGN KEY (GuidFeatureConcept) REFERENCES dbo.secFeatureConcepts (GuidFeatureConcept)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secInvoiceDetail_secInvoice */
ALTER TABLE dbo.secInvoiceDetail ADD CONSTRAINT fk_secInvoiceDetail_secInvoice
	FOREIGN KEY (GuidInvoice) REFERENCES dbo.secInvoice (GuidInvoice)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secInvoicePayment_secInvoice */
ALTER TABLE dbo.secInvoicePayment ADD CONSTRAINT fk_secInvoicePayment_secInvoice
	FOREIGN KEY (GuidInvoice) REFERENCES dbo.secInvoice (GuidInvoice)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secIssueRelated_secIssues */
ALTER TABLE dbo.secIssueRelation ADD CONSTRAINT fk_secIssueRelated_secIssues
	FOREIGN KEY (GuidIssue) REFERENCES dbo.secIssues (GuidIssue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secIssuse_OtherRelation */
ALTER TABLE dbo.secIssueRelation ADD CONSTRAINT fk_secIssuse_OtherRelation
	FOREIGN KEY (GuidIssueOther) REFERENCES dbo.secIssues (GuidIssue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secReusableStatus */
ALTER TABLE dbo.secIssueRelation ADD CONSTRAINT fk_secReusableStatus
	FOREIGN KEY (GuidStatus) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secIssueVotes_secIssues_1 */
ALTER TABLE dbo.secIssueVotes ADD CONSTRAINT fk_secIssueVotes_secIssues_1
	FOREIGN KEY (GuidIssue) REFERENCES dbo.secIssues (GuidIssue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_Issue_Reusable_RepositoryCode */
ALTER TABLE dbo.secIssues ADD CONSTRAINT fk_Issue_Reusable_RepositoryCode
	FOREIGN KEY (GuidReusable_RepositoryCode) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secIssue_secUser_UserAcepted */
ALTER TABLE dbo.secIssues ADD CONSTRAINT fk_secIssue_secUser_UserAcepted
	FOREIGN KEY (GuidUserAcepted) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secIssues_secBusinessObject_1 */
ALTER TABLE dbo.secIssues ADD CONSTRAINT fk_secIssues_secBusinessObject_1
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secIssues_secCompanies */
ALTER TABLE dbo.secIssues ADD CONSTRAINT fk_secIssues_secCompanies
	FOREIGN KEY (GuidCompanyOwner) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secIssues_secIssues_IssueRelated */
ALTER TABLE dbo.secIssues ADD CONSTRAINT fk_secIssues_secIssues_IssueRelated
	FOREIGN KEY (GuidIssueRelated) REFERENCES dbo.secIssues (GuidIssue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secIssues_secModule_1 */
ALTER TABLE dbo.secIssues ADD CONSTRAINT fk_secIssues_secModule_1
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secIssues_secReusableCatalogValues_IssueLevel */
ALTER TABLE dbo.secIssues ADD CONSTRAINT fk_secIssues_secReusableCatalogValues_IssueLevel
	FOREIGN KEY (GuidIssueLevel) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secIssues_secReusableCatalogValues_IssueType */
ALTER TABLE dbo.secIssues ADD CONSTRAINT fk_secIssues_secReusableCatalogValues_IssueType
	FOREIGN KEY (GuidIssueType) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secIssues_secReusableCatalogValues_Status */
ALTER TABLE dbo.secIssues ADD CONSTRAINT fk_secIssues_secReusableCatalogValues_Status
	FOREIGN KEY (GuidStatus) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secMemLevelDetails_secFeatureConcepts_1 */
ALTER TABLE dbo.secMemLevelFeatures ADD CONSTRAINT fk_secMemLevelDetails_secFeatureConcepts_1
	FOREIGN KEY (GuidFeatureConcept) REFERENCES dbo.secFeatureConcepts (GuidFeatureConcept)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secMemLevelDetails_secMembershipLevel_1 */
ALTER TABLE dbo.secMemLevelFeatures ADD CONSTRAINT fk_secMemLevelDetails_secMembershipLevel_1
	FOREIGN KEY (GuidMembershipLevel) REFERENCES dbo.secMembershipLevel (GuidMembershipLevel)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMemberModuleComp_secCompanies */
ALTER TABLE dbo.secMemberModuleComp ADD CONSTRAINT FK_secMemberModuleComp_secCompanies
	FOREIGN KEY (GuidCompanyUse) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMemberModuleComp_secMembershipModule */
ALTER TABLE dbo.secMemberModuleComp ADD CONSTRAINT FK_secMemberModuleComp_secMembershipModule
	FOREIGN KEY (GuidMembershipModule) REFERENCES dbo.secMembershipModule (GuidMembershipModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMembershipModule_secMembershipLevel */
ALTER TABLE dbo.secMembershipModule ADD CONSTRAINT FK_secMembershipModule_secMembershipLevel
	FOREIGN KEY (GuidMembershipLevel) REFERENCES dbo.secMembershipLevel (GuidMembershipLevel)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMembershipModule_secModule */
ALTER TABLE dbo.secMembershipModule ADD CONSTRAINT FK_secMembershipModule_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMenuForms_secBusinessObject */
ALTER TABLE dbo.secMenuForms ADD CONSTRAINT FK_secMenuForms_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMenuForms_secMenuForms */
ALTER TABLE dbo.secMenuForms ADD CONSTRAINT FK_secMenuForms_secMenuForms
	FOREIGN KEY (ParentGuidForm) REFERENCES dbo.secMenuForms (GuidForm)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMenuForms_secModule */
ALTER TABLE dbo.secMenuForms ADD CONSTRAINT FK_secMenuForms_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMenuForms_secPermission */
ALTER TABLE dbo.secMenuForms ADD CONSTRAINT FK_secMenuForms_secPermission
	FOREIGN KEY (GuidPermission) REFERENCES dbo.secPermission (GuidPermission)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMessageNotificationTemplates_secMessageNotifications */
ALTER TABLE dbo.secMessageNotificationTemplates ADD CONSTRAINT FK_secMessageNotificationTemplates_secMessageNotifications
	FOREIGN KEY (GuidMessageNotification) REFERENCES dbo.secMessageNotifications (GuidMessageNotification)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMessageNotifications_secBusinessObject */
ALTER TABLE dbo.secMessageNotifications ADD CONSTRAINT FK_secMessageNotifications_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMessageNotifications_secModule */
ALTER TABLE dbo.secMessageNotifications ADD CONSTRAINT FK_secMessageNotifications_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMessageToUsers_secMessages */
ALTER TABLE dbo.secMessageToUsers ADD CONSTRAINT FK_secMessageToUsers_secMessages
	FOREIGN KEY (GuidMessage) REFERENCES dbo.secMessages (GuidMessage)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMessageToUsers_secUsers */
ALTER TABLE dbo.secMessageToUsers ADD CONSTRAINT FK_secMessageToUsers_secUsers
	FOREIGN KEY (GuidUser) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMessages_secUsers */
ALTER TABLE dbo.secMessages ADD CONSTRAINT FK_secMessages_secUsers
	FOREIGN KEY (GuidUser) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMessages_secUsers1 */
ALTER TABLE dbo.secMessages ADD CONSTRAINT FK_secMessages_secUsers1
	FOREIGN KEY (ToUser) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secOptions_secCompanies */
ALTER TABLE dbo.secModComOptions ADD CONSTRAINT fk_secOptions_secCompanies
	FOREIGN KEY (GuidCompany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secOptions_secModuleOptions */
ALTER TABLE dbo.secModComOptions ADD CONSTRAINT fk_secOptions_secModuleOptions
	FOREIGN KEY (GuidModuleOption) REFERENCES dbo.secModuleOptions (GuidModuleOption)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: Admin_secModule_secRoles */
ALTER TABLE dbo.secModule ADD CONSTRAINT Admin_secModule_secRoles
	FOREIGN KEY (GuidAdminRole) REFERENCES dbo.secRoles (GuidRole)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_AutoServiceRole */
ALTER TABLE dbo.secModule ADD CONSTRAINT fk_AutoServiceRole
	FOREIGN KEY (GuidAutoServiceRole) REFERENCES dbo.secRoles (GuidRole)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secModule_secAppTemplate */
ALTER TABLE dbo.secModule ADD CONSTRAINT fk_secModule_secAppTemplate
	FOREIGN KEY (GuidAppTemplate) REFERENCES dbo.secAppTemplate (GuidAppTemplate)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secModule_secCompUISetting */
ALTER TABLE dbo.secModule ADD CONSTRAINT fk_secModule_secCompUISetting
	FOREIGN KEY (GuidCompUISetting) REFERENCES dbo.secCompUISetting (GuidCompUISetting)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secModuleObjectPermission_secBusinessObject */
ALTER TABLE dbo.secModuleObjectPermission ADD CONSTRAINT FK_secModuleObjectPermission_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: R_50 */
ALTER TABLE dbo.secModuleObjectPermission ADD CONSTRAINT R_50
	FOREIGN KEY (GuidPermission) REFERENCES dbo.secPermission (GuidPermission)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: R_51 */
ALTER TABLE dbo.secModuleObjectPermission ADD CONSTRAINT R_51
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secModuleOptions_secModule */
ALTER TABLE dbo.secModuleOptions ADD CONSTRAINT fk_secModuleOptions_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: Module_ModulePermissions_FK1 */
ALTER TABLE dbo.secModulePermissions ADD CONSTRAINT Module_ModulePermissions_FK1
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: Permission_ModulePermissions_FK1 */
ALTER TABLE dbo.secModulePermissions ADD CONSTRAINT Permission_ModulePermissions_FK1
	FOREIGN KEY (GuidPermission) REFERENCES dbo.secPermission (GuidPermission)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secModuleRole_secModule */
ALTER TABLE dbo.secModuleRole ADD CONSTRAINT fk_secModuleRole_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secModuleRole_secRoles */
ALTER TABLE dbo.secModuleRole ADD CONSTRAINT fk_secModuleRole_secRoles
	FOREIGN KEY (GuidRole) REFERENCES dbo.secRoles (GuidRole)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secModuleSettings_secModule */
ALTER TABLE dbo.secModuleSettings ADD CONSTRAINT fk_secModuleSettings_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secModuleSettings_secSetting */
ALTER TABLE dbo.secModuleSettings ADD CONSTRAINT fk_secModuleSettings_secSetting
	FOREIGN KEY (GuidSetting) REFERENCES dbo.secSetting (GuidSetting)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secModuleSettings_secSettingValue */
ALTER TABLE dbo.secModuleSettings ADD CONSTRAINT fk_secModuleSettings_secSettingValue
	FOREIGN KEY (GuidSettingVaueDefault) REFERENCES dbo.secSettingValue (GuidSettingVaue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secModuleUser_secModule */
ALTER TABLE dbo.secModuleUser ADD CONSTRAINT fk_secModuleUser_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secModuleUser_secUsers */
ALTER TABLE dbo.secModuleUser ADD CONSTRAINT fk_secModuleUser_secUsers
	FOREIGN KEY (GuidUser) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secModuleUserCompany_secCompanies */
ALTER TABLE dbo.secModuleUserCompany ADD CONSTRAINT fk_secModuleUserCompany_secCompanies
	FOREIGN KEY (GuidCompany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secModuleUserCompany_secModule */
ALTER TABLE dbo.secModuleUserCompany ADD CONSTRAINT fk_secModuleUserCompany_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secModuleUserCompany_secUsers */
ALTER TABLE dbo.secModuleUserCompany ADD CONSTRAINT fk_secModuleUserCompany_secUsers
	FOREIGN KEY (GuidUser) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secModuleUserDevice_secModuleUser */
ALTER TABLE dbo.secModuleUserDevice ADD CONSTRAINT fk_secModuleUserDevice_secModuleUser
	FOREIGN KEY (GuidModuleUser) REFERENCES dbo.secModuleUser (GuidModuleUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMoneyMovements_secCompanies */
ALTER TABLE dbo.secMoneyMovements ADD CONSTRAINT FK_secMoneyMovements_secCompanies
	FOREIGN KEY (GuidCompanyAdd) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMoneyMovements_secCompanies1 */
ALTER TABLE dbo.secMoneyMovements ADD CONSTRAINT FK_secMoneyMovements_secCompanies1
	FOREIGN KEY (GuidCompanyCharge) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMoneyMovements_secMoneyMovementTypes */
ALTER TABLE dbo.secMoneyMovements ADD CONSTRAINT FK_secMoneyMovements_secMoneyMovementTypes
	FOREIGN KEY (GuidMoneyMovementType) REFERENCES dbo.secMoneyMovementTypes (GuidMoneyMovementType)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMoneyMovements_secUserPayments */
ALTER TABLE dbo.secMoneyMovements ADD CONSTRAINT FK_secMoneyMovements_secUserPayments
	FOREIGN KEY (GuidUserPayment) REFERENCES dbo.secUserPayments (GuidUserPayment)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMoneyMovements_secUsers */
ALTER TABLE dbo.secMoneyMovements ADD CONSTRAINT FK_secMoneyMovements_secUsers
	FOREIGN KEY (GuidUserCharge) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secMoneyMovements_secUsers1 */
ALTER TABLE dbo.secMoneyMovements ADD CONSTRAINT FK_secMoneyMovements_secUsers1
	FOREIGN KEY (GuidUserAdd) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secNoSQLLog_secBusinessObject */
ALTER TABLE dbo.secNoSQLLog ADD CONSTRAINT fk_secNoSQLLog_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secNoSQLLog_secNoSQLMovement */
ALTER TABLE dbo.secNoSQLLog ADD CONSTRAINT fk_secNoSQLLog_secNoSQLMovement
	FOREIGN KEY (GuidNoSQLMovement) REFERENCES dbo.secNoSQLMovement (GuidNoSQLMovement)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secNoSQLMovement_secBusinessObject */
ALTER TABLE dbo.secNoSQLMovement ADD CONSTRAINT fk_secNoSQLMovement_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secNotification_secModule */
ALTER TABLE dbo.secNotification ADD CONSTRAINT fk_secNotification_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secNotification_secNotificationPriority */
ALTER TABLE dbo.secNotification ADD CONSTRAINT fk_secNotification_secNotificationPriority
	FOREIGN KEY (GuidNotificationPriority) REFERENCES dbo.secNotificationPriority (GuidNotificationPriority)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secProfile_secGeoCities */
ALTER TABLE dbo.secProfile ADD CONSTRAINT FK_secProfile_secGeoCities
	FOREIGN KEY (GuidActualCity) REFERENCES dbo.secGeoCities (GuidCity)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secProfile_secGeoCities1 */
ALTER TABLE dbo.secProfile ADD CONSTRAINT FK_secProfile_secGeoCities1
	FOREIGN KEY (GuidWorkCity) REFERENCES dbo.secGeoCities (GuidCity)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secProfile_secGeoCountries */
ALTER TABLE dbo.secProfile ADD CONSTRAINT FK_secProfile_secGeoCountries
	FOREIGN KEY (GuidActualCountry) REFERENCES dbo.secGeoCountries (GuidCountry)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secProfile_secGeoCountries1 */
ALTER TABLE dbo.secProfile ADD CONSTRAINT FK_secProfile_secGeoCountries1
	FOREIGN KEY (GuidWorkCountry) REFERENCES dbo.secGeoCountries (GuidCountry)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secProfile_secGeoStates */
ALTER TABLE dbo.secProfile ADD CONSTRAINT FK_secProfile_secGeoStates
	FOREIGN KEY (GuidActualState) REFERENCES dbo.secGeoStates (GuidState)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secProfile_secGeoStates1 */
ALTER TABLE dbo.secProfile ADD CONSTRAINT FK_secProfile_secGeoStates1
	FOREIGN KEY (GuidWorkState) REFERENCES dbo.secGeoStates (GuidState)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secReusableCatalog_secReusableCatalogValues */
ALTER TABLE dbo.secReusableCatalog ADD CONSTRAINT fk_secReusableCatalog_secReusableCatalogValues
	FOREIGN KEY (DataType) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secReusableCatalogValues_secReusableCatalog */
ALTER TABLE dbo.secReusableCatalogValues ADD CONSTRAINT FK_secReusableCatalogValues_secReusableCatalog
	FOREIGN KEY (GuidReusableCatalog) REFERENCES dbo.secReusableCatalog (GuidReusableCatalog)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: secDataColumn_secRoleDataPermission_FK1 */
ALTER TABLE dbo.secRoleDataPermission ADD CONSTRAINT secDataColumn_secRoleDataPermission_FK1
	FOREIGN KEY (GuidDataColumn) REFERENCES dbo.secDataColumn (GuidDataColumn)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: secRoles_secRoleDataPermission_FK1 */
ALTER TABLE dbo.secRoleDataPermission ADD CONSTRAINT secRoles_secRoleDataPermission_FK1
	FOREIGN KEY (GuidRole) REFERENCES dbo.secRoles (GuidRole)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secRoleModuleObjectPermission_secBusinessObject */
ALTER TABLE dbo.secRoleModuleObjectPermission ADD CONSTRAINT FK_secRoleModuleObjectPermission_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secRoleModuleObjectPermission_secModule */
ALTER TABLE dbo.secRoleModuleObjectPermission ADD CONSTRAINT FK_secRoleModuleObjectPermission_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secRoleModuleObjectPermission_secPermission */
ALTER TABLE dbo.secRoleModuleObjectPermission ADD CONSTRAINT FK_secRoleModuleObjectPermission_secPermission
	FOREIGN KEY (GuidPermission) REFERENCES dbo.secPermission (GuidPermission)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secRoleModuleObjectPermission_secRoles */
ALTER TABLE dbo.secRoleModuleObjectPermission ADD CONSTRAINT FK_secRoleModuleObjectPermission_secRoles
	FOREIGN KEY (GuidRole) REFERENCES dbo.secRoles (GuidRole)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: Module_RoleModulePermissions_FK1 */
ALTER TABLE dbo.secRoleModulePermissions ADD CONSTRAINT Module_RoleModulePermissions_FK1
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: Permission_RoleModulePermissions_FK1 */
ALTER TABLE dbo.secRoleModulePermissions ADD CONSTRAINT Permission_RoleModulePermissions_FK1
	FOREIGN KEY (GuidPermission) REFERENCES dbo.secPermission (GuidPermission)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: Roles_RoleModulePermissions_FK1 */
ALTER TABLE dbo.secRoleModulePermissions ADD CONSTRAINT Roles_RoleModulePermissions_FK1
	FOREIGN KEY (GuidRole) REFERENCES dbo.secRoles (GuidRole)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secRoles_secRoles */
ALTER TABLE dbo.secRoles ADD CONSTRAINT FK_secRoles_secRoles
	FOREIGN KEY (ParentGuidRole) REFERENCES dbo.secRoles (GuidRole)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secSetting_secModule */
ALTER TABLE dbo.secSetting ADD CONSTRAINT fk_secSetting_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secSetting_secSettingValue */
ALTER TABLE dbo.secSetting ADD CONSTRAINT fk_secSetting_secSettingValue
	FOREIGN KEY (GuidSettingVaue) REFERENCES dbo.secSettingValue (GuidSettingVaue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secSettingValue_secSetting */
ALTER TABLE dbo.secSettingValue ADD CONSTRAINT fk_secSettingValue_secSetting
	FOREIGN KEY (GuidSetting) REFERENCES dbo.secSetting (GuidSetting)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secSyncIntegrator_secCompanies */
ALTER TABLE dbo.secSyncIntegrator ADD CONSTRAINT fk_secSyncIntegrator_secCompanies
	FOREIGN KEY (OwnerCompany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secSyncIntegrator_secSyncMatchDef */
ALTER TABLE dbo.secSyncIntegrator ADD CONSTRAINT fk_secSyncIntegrator_secSyncMatchDef
	FOREIGN KEY (GuidSyncMatchDef) REFERENCES dbo.secSyncMatchDef (GuidSyncMatchDef)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secSyncItems_secSyncIntegrator */
ALTER TABLE dbo.secSyncItems ADD CONSTRAINT fk_secSyncItems_secSyncIntegrator
	FOREIGN KEY (GuidSyncIntegrator) REFERENCES dbo.secSyncIntegrator (GuidSyncIntegrator)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secSyncItems_secSyncMatchDefObjects */
ALTER TABLE dbo.secSyncItems ADD CONSTRAINT fk_secSyncItems_secSyncMatchDefObjects
	FOREIGN KEY (GuidSyncMatchDefObject) REFERENCES dbo.secSyncMatchDefObjects (GuidSyncMatchDefObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secSyncMatchDef_secSyncMatchDefObjects */
ALTER TABLE dbo.secSyncMatchDef ADD CONSTRAINT fk_secSyncMatchDef_secSyncMatchDefObjects
	FOREIGN KEY (UniqueDirectionObject) REFERENCES dbo.secSyncMatchDefObjects (GuidSyncMatchDefObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secSyncMatchDefObjects_secBusinessObject */
ALTER TABLE dbo.secSyncMatchDefObjects ADD CONSTRAINT fk_secSyncMatchDefObjects_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secSyncMatchDefObjects_secSyncMatchDef */
ALTER TABLE dbo.secSyncMatchDefObjects ADD CONSTRAINT fk_secSyncMatchDefObjects_secSyncMatchDef
	FOREIGN KEY (GuidSyncMatchDef) REFERENCES dbo.secSyncMatchDef (GuidSyncMatchDef)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secSyncMatchProps_secSyncMatchDef */
ALTER TABLE dbo.secSyncMatchDefProps ADD CONSTRAINT fk_secSyncMatchProps_secSyncMatchDef
	FOREIGN KEY (GuidSyncMatchDef) REFERENCES dbo.secSyncMatchDef (GuidSyncMatchDef)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secSyncMatchProperty_secBizObjProperty */
ALTER TABLE dbo.secSyncMatchProperty ADD CONSTRAINT fk_secSyncMatchProperty_secBizObjProperty
	FOREIGN KEY (GuidBizObjProperty) REFERENCES dbo.secBizObjProperty (GuidBizObjProperty)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secSyncMatchProperty_secSyncMatchDefObjects */
ALTER TABLE dbo.secSyncMatchProperty ADD CONSTRAINT fk_secSyncMatchProperty_secSyncMatchDefObjects
	FOREIGN KEY (GuidSyncMatchDefObjects) REFERENCES dbo.secSyncMatchDefObjects (GuidSyncMatchDefObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secSyncMatchProps_secSyncMatchDefProps */
ALTER TABLE dbo.secSyncMatchProperty ADD CONSTRAINT fk_secSyncMatchProps_secSyncMatchDefProps
	FOREIGN KEY (GuidSyncMacthDefProp) REFERENCES dbo.secSyncMatchDefProps (GuidSyncMacthDefProp)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secTask_secModule */
ALTER TABLE dbo.secTask ADD CONSTRAINT fk_secTask_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secTaskHistory_secTask */
ALTER TABLE dbo.secTaskHistory ADD CONSTRAINT fk_secTaskHistory_secTask
	FOREIGN KEY (GuidTask) REFERENCES dbo.secTask (GuidTask)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secTutorial_secModule */
ALTER TABLE dbo.secTutorial ADD CONSTRAINT fk_secTutorial_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secTutorialItem_secTutorial */
ALTER TABLE dbo.secTutorialItem ADD CONSTRAINT fk_secTutorialItem_secTutorial
	FOREIGN KEY (GuidTutorial) REFERENCES dbo.secTutorial (GuidTutorial)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secUpdate_secModule */
ALTER TABLE dbo.secUpdate ADD CONSTRAINT fk_secUpdate_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secUserCompanies_secCompanies */
ALTER TABLE dbo.secUserCompanies ADD CONSTRAINT fk_secUserCompanies_secCompanies
	FOREIGN KEY (GuidCompany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secUserCompanies_secModule */
ALTER TABLE dbo.secUserCompanies ADD CONSTRAINT fk_secUserCompanies_secModule
	FOREIGN KEY (GuidModule) REFERENCES dbo.secModule (GuidModule)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secUserCompanies_secRoles */
ALTER TABLE dbo.secUserCompanies ADD CONSTRAINT fk_secUserCompanies_secRoles
	FOREIGN KEY (GuidRole) REFERENCES dbo.secRoles (GuidRole)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secUserCompanies_secUsers */
ALTER TABLE dbo.secUserCompanies ADD CONSTRAINT fk_secUserCompanies_secUsers
	FOREIGN KEY (GuidUser) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secUserConfigurations_secReusablecCatalog */
ALTER TABLE dbo.secUserConfigurations ADD CONSTRAINT FK_secUserConfigurations_secReusablecCatalog
	FOREIGN KEY (GuidReusableCatalog) REFERENCES dbo.secReusableCatalog (GuidReusableCatalog)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secUserConfigurations_secUsers */
ALTER TABLE dbo.secUserConfigurations ADD CONSTRAINT FK_secUserConfigurations_secUsers
	FOREIGN KEY (GuidUser) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secUserPayments_secCompanies */
ALTER TABLE dbo.secUserPayments ADD CONSTRAINT FK_secUserPayments_secCompanies
	FOREIGN KEY (GuidCompany) REFERENCES dbo.secCompanies (GuidCompany)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secUserPayments_secPaymentMethods */
ALTER TABLE dbo.secUserPayments ADD CONSTRAINT FK_secUserPayments_secPaymentMethods
	FOREIGN KEY (GuidPaymentMethod) REFERENCES dbo.secPaymentMethods (GuidPaymentMethod)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secUserPayments_secUsers */
ALTER TABLE dbo.secUserPayments ADD CONSTRAINT FK_secUserPayments_secUsers
	FOREIGN KEY (GuidUser) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secUser_LoginProviders_secLoginProviders */
ALTER TABLE dbo.secUser_LoginProviders ADD CONSTRAINT FK_secUser_LoginProviders_secLoginProviders
	FOREIGN KEY (GuidLoginProvider) REFERENCES dbo.secLoginProviders (GuidLoginProvider)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: R_42 */
ALTER TABLE dbo.secUser_LoginProviders ADD CONSTRAINT R_42
	FOREIGN KEY (GuidUser) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secUser_LoginProviders_secFiles */
ALTER TABLE dbo.secUser_LoginProviders ADD CONSTRAINT fk_secUser_LoginProviders_secFiles
	FOREIGN KEY (GuidFile) REFERENCES dbo.secFiles (GuidFile)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: FK_secUsers_secFiles */
ALTER TABLE dbo.secUsers ADD CONSTRAINT FK_secUsers_secFiles
	FOREIGN KEY (GuidFilePhoto) REFERENCES dbo.secFiles (GuidFile)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_AddedBy_secUser */
ALTER TABLE dbo.secUsers ADD CONSTRAINT fk_AddedBy_secUser
	FOREIGN KEY (GuidAddedBy) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_DecisionNO_secWFStates */
ALTER TABLE dbo.secWFActivity ADD CONSTRAINT fk_DecisionNO_secWFStates
	FOREIGN KEY (DecisionNo) REFERENCES dbo.secWFStates (GuidWFState)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_DecisionYES_secWFStates */
ALTER TABLE dbo.secWFActivity ADD CONSTRAINT fk_DecisionYES_secWFStates
	FOREIGN KEY (DecisionYes) REFERENCES dbo.secWFStates (GuidWFState)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_FromState_secWFStates */
ALTER TABLE dbo.secWFActivity ADD CONSTRAINT fk_FromState_secWFStates
	FOREIGN KEY (GuidFromState) REFERENCES dbo.secWFStates (GuidWFState)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_Reusable_ActivityType */
ALTER TABLE dbo.secWFActivity ADD CONSTRAINT fk_Reusable_ActivityType
	FOREIGN KEY (GuidReusable_ActivityType) REFERENCES dbo.secReusableCatalogValues (GuidReusableCatalogValue)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFStates_secWFProcess */
ALTER TABLE dbo.secWFActivity ADD CONSTRAINT fk_secWFStates_secWFProcess
	FOREIGN KEY (GuidProcess) REFERENCES dbo.secWFProcess (GuidProcess)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFActivityUserLog_secWFActivity */
ALTER TABLE dbo.secWFActivityUserLog ADD CONSTRAINT fk_secWFActivityUserLog_secWFActivity
	FOREIGN KEY (GuidWFActivity) REFERENCES dbo.secWFActivity (GuidWFActivity)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFActivityUserLog_secWFActivityUsers */
ALTER TABLE dbo.secWFActivityUserLog ADD CONSTRAINT fk_secWFActivityUserLog_secWFActivityUsers
	FOREIGN KEY (GuidWFActivityUser) REFERENCES dbo.secWFActivityUsers (GuidWFActivityUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFStateUserLog_secBusinessObject */
ALTER TABLE dbo.secWFActivityUserLog ADD CONSTRAINT fk_secWFStateUserLog_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFStateUserLog_secUsers */
ALTER TABLE dbo.secWFActivityUserLog ADD CONSTRAINT fk_secWFStateUserLog_secUsers
	FOREIGN KEY (GuidUser) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFStateUserLog_secWFStates */
ALTER TABLE dbo.secWFActivityUserLog ADD CONSTRAINT fk_secWFStateUserLog_secWFStates
	FOREIGN KEY (GuidStateBefore) REFERENCES dbo.secWFStates (GuidWFState)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_state_after_secWFStates */
ALTER TABLE dbo.secWFActivityUserLog ADD CONSTRAINT fk_state_after_secWFStates
	FOREIGN KEY (GuidStateAfter) REFERENCES dbo.secWFStates (GuidWFState)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFActivityUsers_secBizObjProperty */
ALTER TABLE dbo.secWFActivityUsers ADD CONSTRAINT fk_secWFActivityUsers_secBizObjProperty
	FOREIGN KEY (GuidBizObjPropertyUsers) REFERENCES dbo.secBizObjProperty (GuidBizObjProperty)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFStateUsers_secUsers */
ALTER TABLE dbo.secWFActivityUsers ADD CONSTRAINT fk_secWFStateUsers_secUsers
	FOREIGN KEY (GuidUser) REFERENCES dbo.secUsers (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFStateUsers_secWFActivity */
ALTER TABLE dbo.secWFActivityUsers ADD CONSTRAINT fk_secWFStateUsers_secWFActivity
	FOREIGN KEY (GuidWFActivity) REFERENCES dbo.secWFActivity (GuidWFActivity)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_wf_connector_from */
ALTER TABLE dbo.secWFConnector ADD CONSTRAINT fk_wf_connector_from
	FOREIGN KEY (GuidWFActivityFrom) REFERENCES dbo.secWFActivity (GuidWFActivity)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_wf_connector_to */
ALTER TABLE dbo.secWFConnector ADD CONSTRAINT fk_wf_connector_to
	FOREIGN KEY (GuidWFActivityTo) REFERENCES dbo.secWFActivity (GuidWFActivity)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_Author_secWFProcess_secBizObjProperty */
ALTER TABLE dbo.secWFProcess ADD CONSTRAINT fk_Author_secWFProcess_secBizObjProperty
	FOREIGN KEY (GuidPropertyAuthor) REFERENCES dbo.secBizObjProperty (GuidBizObjProperty)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_PropertyUserWaiting_secBizObjProperty */
ALTER TABLE dbo.secWFProcess ADD CONSTRAINT fk_PropertyUserWaiting_secBizObjProperty
	FOREIGN KEY (GuidPropertyUserWaiting) REFERENCES dbo.secBizObjProperty (GuidBizObjProperty)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_PropertyUsersWaiting_secBizObjProperty */
ALTER TABLE dbo.secWFProcess ADD CONSTRAINT fk_PropertyUsersWaiting_secBizObjProperty
	FOREIGN KEY (GuidPropertyUsersWaiting) REFERENCES dbo.secBizObjProperty (GuidBizObjProperty)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFProcess_secBizObjProperty */
ALTER TABLE dbo.secWFProcess ADD CONSTRAINT fk_secWFProcess_secBizObjProperty
	FOREIGN KEY (GuidBizObjProperty) REFERENCES dbo.secBizObjProperty (GuidBizObjProperty)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFProcess_secBusinessObject_UsersWaiting */
ALTER TABLE dbo.secWFProcess ADD CONSTRAINT fk_secWFProcess_secBusinessObject_UsersWaiting
	FOREIGN KEY (GuiBusinessObjectUsersWaiting) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFProcess_secWFStates */
ALTER TABLE dbo.secWFProcess ADD CONSTRAINT fk_secWFProcess_secWFStates
	FOREIGN KEY (GuidDefaultState) REFERENCES dbo.secWFStates (GuidWFState)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWorkFlows_secBusinessObject */
ALTER TABLE dbo.secWFProcess ADD CONSTRAINT fk_secWorkFlows_secBusinessObject
	FOREIGN KEY (GuidBusinessObject) REFERENCES dbo.secBusinessObject (GuidBusinessObject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFState_secBizObjProperty_SetFalse */
ALTER TABLE dbo.secWFStates ADD CONSTRAINT fk_secWFState_secBizObjProperty_SetFalse
	FOREIGN KEY (GuidPropertySetFalse) REFERENCES dbo.secBizObjProperty (GuidBizObjProperty)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFStates_secBizObjProperty */
ALTER TABLE dbo.secWFStates ADD CONSTRAINT fk_secWFStates_secBizObjProperty
	FOREIGN KEY (GuidPropertySetTrue) REFERENCES dbo.secBizObjProperty (GuidBizObjProperty)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_secWFStates_secWorkFlows */
ALTER TABLE dbo.secWFStates ADD CONSTRAINT fk_secWFStates_secWorkFlows
	FOREIGN KEY (GuidWorkFlow) REFERENCES dbo.secWFProcess (GuidProcess)
	ON UPDATE NO ACTION ON DELETE NO ACTION;