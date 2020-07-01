
create schema Kst;
Go

/************ Update: Tables ***************/

/******************** Add Table: Kst.KstEmailTemplate ************************/

/* Build Table Structure */
CREATE TABLE Kst.KstEmailTemplate
(
	GuidEmailTemplate UniqueIdentifier NOT NULL,
	Title VARCHAR(255) NOT NULL,
	TitleKey VARCHAR(20) NULL,
	Content VARCHAR(MAX) NULL
);

/* Add Primary Key */
ALTER TABLE Kst.KstEmailTemplate ADD CONSTRAINT pkKstEmailTemplate
	PRIMARY KEY (GuidEmailTemplate);


/******************** Add Table: Kst.KstProxyGeoCity ************************/

/* Build Table Structure */
CREATE TABLE Kst.KstProxyGeoCity
(
	GuidCity UniqueIdentifier NOT NULL,
	Name VARCHAR(255) NOT NULL,
	IsDeleted BIT NULL,
	GuidState UniqueIdentifier NULL,
	GuidParent UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE Kst.KstProxyGeoCity ADD CONSTRAINT pkKstProxyGeoCity
	PRIMARY KEY (GuidCity);


/******************** Add Table: Kst.KstProxyGeoCountry ************************/

/* Build Table Structure */
CREATE TABLE Kst.KstProxyGeoCountry
(
	GuidCountry UniqueIdentifier NOT NULL,
	Name VARCHAR(255) NOT NULL,
	IsDeleted BIT NULL
);

/* Add Primary Key */
ALTER TABLE Kst.KstProxyGeoCountry ADD CONSTRAINT pkKstProxyGeoCountry
	PRIMARY KEY (GuidCountry);


/******************** Add Table: Kst.KstProxyGeoState ************************/

/* Build Table Structure */
CREATE TABLE Kst.KstProxyGeoState
(
	GuidState UniqueIdentifier NOT NULL,
	Name VARCHAR(255) NOT NULL,
	IsDeleted BIT NULL,
	GuidCountry UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE Kst.KstProxyGeoState ADD CONSTRAINT pkKstProxyGeoState
	PRIMARY KEY (GuidState);


/******************** Add Table: Kst.KstProxyRole ************************/

/* Build Table Structure */
CREATE TABLE Kst.KstProxyRole
(
	GuidRole UniqueIdentifier NOT NULL,
	RoleName VARCHAR(150) NOT NULL,
	NameKey VARCHAR(100) NOT NULL,
	 UpdatedDate DATETIME NULL,
	 CreatedDate DATETIME NULL,
	IsDeleted BIT NULL

);

/* Add Primary Key */
ALTER TABLE Kst.KstProxyRole ADD CONSTRAINT pkKstProxyRole
	PRIMARY KEY (GuidRole);


/******************** Add Table: Kst.KstProxyUser ************************/

/* Build Table Structure */
CREATE TABLE Kst.KstProxyUser
(
	GuidUser UniqueIdentifier NOT NULL,
	DisplayName VARCHAR(150) NULL,
	Username VARCHAR(100) NULL,
	Password VARCHAR(255) NULL,
	FirstName VARCHAR(255) NULL,
	LastName VARCHAR(255) NULL,
	Email VARCHAR(255) NULL,
	 [Disabled] BIT NULL,
	GuidRole UniqueIdentifier NULL,
	 UpdatedDate DATETIME NULL,
	 CreatedDate DATETIME NULL,
	 IsDeleted BIT NULL

);

/* Add Primary Key */
ALTER TABLE Kst.KstProxyUser ADD CONSTRAINT pkKstProxyUser
	PRIMARY KEY (GuidUser);






/************ Add Foreign Keys ***************/

/* Add Foreign Key: fk_KstProxyGeoCity_KstProxyGeoCity */
ALTER TABLE Kst.KstProxyGeoCity ADD CONSTRAINT fk_KstProxyGeoCity_KstProxyGeoCity
	FOREIGN KEY (GuidParent) REFERENCES Kst.KstProxyGeoCity (GuidCity)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_KstProxyGeoCity_KstProxyGeoState */
ALTER TABLE Kst.KstProxyGeoCity ADD CONSTRAINT fk_KstProxyGeoCity_KstProxyGeoState
	FOREIGN KEY (GuidState) REFERENCES Kst.KstProxyGeoState (GuidState)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_KstProxyGeoState_KstProxyGeoCountry */
ALTER TABLE Kst.KstProxyGeoState ADD CONSTRAINT fk_KstProxyGeoState_KstProxyGeoCountry
	FOREIGN KEY (GuidCountry) REFERENCES Kst.KstProxyGeoCountry (GuidCountry)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_KstProxyUser_KstProxyRole */
ALTER TABLE Kst.KstProxyUser ADD CONSTRAINT fk_KstProxyUser_KstProxyRole
	FOREIGN KEY (GuidRole) REFERENCES Kst.KstProxyRole (GuidRole)
	ON UPDATE NO ACTION ON DELETE NO ACTION;


	GO

	

INSERT INTO [Kst].[KstEmailTemplate]
           ([GuidEmailTemplate]
           ,[Title]
           ,[TitleKey]
           ,[Content])
   
     VALUES
           ('476EABDB-8E3C-4832-B3D8-16F0631973B0'
           ,'Usuario agregado'
           ,'user-added'
           ,'<p>Hola, {FROM-USER-NAME} te ha agregado a la aplicaci&oacute;n {APP-NAME} con el rol <strong>{ROLE-NAME}</strong></p><p><a href="{URL-LINK}" target="_blank" >ACTIVAR CUENTA</a></p>'
           )
GO


INSERT INTO [Kst].[KstEmailTemplate]
           ([GuidEmailTemplate]
           ,[Title]
           ,[TitleKey]
           ,[Content])
   
     VALUES
           ('ED7D535B-41CF-4A0D-9394-16C52E4572EE'
           ,'Bienvenido'
           ,'welcome'
           ,'Activa tu cuenta con el siguiente link:<BR><BR><a href="{URL-LINK}" style="" target="_blank">ACTIVAR CUENTA</a>'
           )
GO

INSERT INTO [Kst].[KstEmailTemplate]
           ([GuidEmailTemplate]
           ,[Title]
           ,[TitleKey]
           ,[Content])
   
     VALUES
           ('C2BEBDBA-F0AF-4DB7-BDC6-16F220BC1175'
           ,'Reestablecer contraseña'
           ,'recovery-password'
           ,'<p>Para restablecer tu cntraseña haz click en el siguiente link</p><p><a href="{URL-LINK}" target="_blank" rel="noopener">RESTABLECER CONTRASE&Ntilde;A</a></p>'
           )
GO

