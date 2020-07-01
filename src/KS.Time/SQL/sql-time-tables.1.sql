

/************ Update: Tables ***************/

/******************** Add Table: Kst.KstActivity ************************/

/* Build Table Structure */
CREATE TABLE Kst.KstActivity
(
	GuidActivity UniqueIdentifier NOT NULL,
	Name VARCHAR(255) NULL,
	GuidProject UniqueIdentifier NULL,
	IsCustomByUser BIT DEFAULT 'false' NOT NULL
);

/* Add Primary Key */
ALTER TABLE Kst.KstActivity ADD CONSTRAINT pkKstActivity
	PRIMARY KEY (GuidActivity);


/******************** Add Table: Kst.KstProject ************************/

/* Build Table Structure */
CREATE TABLE Kst.KstProject
(
	GuidProject UniqueIdentifier NOT NULL,
	Name VARCHAR(255) NOT NULL
);

/* Add Primary Key */
ALTER TABLE Kst.KstProject ADD CONSTRAINT pkKstProject
	PRIMARY KEY (GuidProject);


/******************** Add Table: Kst.KstProjectUser ************************/

/* Build Table Structure */
CREATE TABLE Kst.KstProjectUser
(
	GuidProjectUser UniqueIdentifier NOT NULL,
	GuidProject UniqueIdentifier NULL,
	GuidUser UniqueIdentifier NULL,
	StartDate DATETIME NULL,
	EndDate DATETIME NULL
);

/* Add Primary Key */
ALTER TABLE Kst.KstProjectUser ADD CONSTRAINT pkKstProjectUser
	PRIMARY KEY (GuidProjectUser);


/******************** Add Table: Kst.KstWorkTime ************************/

/* Build Table Structure */
CREATE TABLE Kst.KstWorkTime
(
	GuidWorkTime UniqueIdentifier NOT NULL,
	Title VARCHAR(255) NULL,
	Comments VARCHAR(500) NULL,
	Hours DECIMAL(10, 2) NULL,
	GuidProject UniqueIdentifier NULL,
	GuidActivity UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE Kst.KstWorkTime ADD CONSTRAINT pkKstWorkTime
	PRIMARY KEY (GuidWorkTime);





/************ Add Foreign Keys ***************/

/* Add Foreign Key: fk_KstActivity_KstProject */
ALTER TABLE Kst.KstActivity ADD CONSTRAINT fk_KstActivity_KstProject
	FOREIGN KEY (GuidProject) REFERENCES Kst.KstProject (GuidProject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_KstProjectUser_KstProject */
ALTER TABLE Kst.KstProjectUser ADD CONSTRAINT fk_KstProjectUser_KstProject
	FOREIGN KEY (GuidProject) REFERENCES Kst.KstProject (GuidProject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_KstProjectUser_KstProxyUser */
ALTER TABLE Kst.KstProjectUser ADD CONSTRAINT fk_KstProjectUser_KstProxyUser
	FOREIGN KEY (GuidUser) REFERENCES Kst.KstProxyUser (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_KstWorkTime_KstActivity */
ALTER TABLE Kst.KstWorkTime ADD CONSTRAINT fk_KstWorkTime_KstActivity
	FOREIGN KEY (GuidActivity) REFERENCES Kst.KstActivity (GuidActivity)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_KstWorkTime_KstProject */
ALTER TABLE Kst.KstWorkTime ADD CONSTRAINT fk_KstWorkTime_KstProject
	FOREIGN KEY (GuidProject) REFERENCES Kst.KstProject (GuidProject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;