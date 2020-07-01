
/************ Update: Tables ***************/

/******************** Add Table: Kst.KstFile ************************/

/* Build Table Structure */
CREATE TABLE Kst.KstFile
(
	GuidFile UniqueIdentifier NOT NULL,
	FileName VARCHAR(255) NOT NULL,
	FileType VARCHAR(255) NULL,
	FileData VARBINARY(MAX) NULL,
	FileStorage VARCHAR(500) NULL,
	ContainerStorage VARCHAR(255) NULL,
	FileThumbSizes VARCHAR(255) NULL,
	FileSize BIGINT NULL
);

/* Add Primary Key */
ALTER TABLE Kst.KstFile ADD CONSTRAINT pkKstFile
	PRIMARY KEY (GuidFile);


/******************** Add Table: Kst.KstProjectFile ************************/

/* Build Table Structure */
CREATE TABLE Kst.KstProjectFile
(
	GuidProjectFile UniqueIdentifier NOT NULL,
	GuidProject UniqueIdentifier NULL,
	GuidFile UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE Kst.KstProjectFile ADD CONSTRAINT pkKstProjectFile
	PRIMARY KEY (GuidProjectFile);




/******************** Add Table: Kst.KstUserFile ************************/

/* Build Table Structure */
CREATE TABLE Kst.KstUserFile
(
	GuidUserFile UniqueIdentifier NOT NULL,
	GuidUser UniqueIdentifier NULL,
	GuidFile UniqueIdentifier NULL,
	IsProfileDefault BIT NULL
);

/* Add Primary Key */
ALTER TABLE Kst.KstUserFile ADD CONSTRAINT pkKstUserFile
	PRIMARY KEY (GuidUserFile);


/******************** Add Table: Kst.KstWorkTimeFile ************************/

/* Build Table Structure */
CREATE TABLE Kst.KstWorkTimeFile
(
	GuidWorkTimeFile UniqueIdentifier NOT NULL,
	GuidWorkTime UniqueIdentifier NULL,
	GuidFile UniqueIdentifier NULL
);

/* Add Primary Key */
ALTER TABLE Kst.KstWorkTimeFile ADD CONSTRAINT pkKstWorkTimeFile
	PRIMARY KEY (GuidWorkTimeFile);





/************ Add Foreign Keys ***************/

/* Add Foreign Key: fk_KstProjectFile_KstFile */
ALTER TABLE Kst.KstProjectFile ADD CONSTRAINT fk_KstProjectFile_KstFile
	FOREIGN KEY (GuidFile) REFERENCES Kst.KstFile (GuidFile)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_KstProjectFile_KstProject */
ALTER TABLE Kst.KstProjectFile ADD CONSTRAINT fk_KstProjectFile_KstProject
	FOREIGN KEY (GuidProject) REFERENCES Kst.KstProject (GuidProject)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_KstUserFile_KstFile */
ALTER TABLE Kst.KstUserFile ADD CONSTRAINT fk_KstUserFile_KstFile
	FOREIGN KEY (GuidFile) REFERENCES Kst.KstFile (GuidFile)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_KstUserFile_KstProxyUser */
ALTER TABLE Kst.KstUserFile ADD CONSTRAINT fk_KstUserFile_KstProxyUser
	FOREIGN KEY (GuidUser) REFERENCES Kst.KstProxyUser (GuidUser)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_KstWorkTimeFile_KstFile */
ALTER TABLE Kst.KstWorkTimeFile ADD CONSTRAINT fk_KstWorkTimeFile_KstFile
	FOREIGN KEY (GuidFile) REFERENCES Kst.KstFile (GuidFile)
	ON UPDATE NO ACTION ON DELETE NO ACTION;

/* Add Foreign Key: fk_KstWorkTimeFile_KstWorkTime */
ALTER TABLE Kst.KstWorkTimeFile ADD CONSTRAINT fk_KstWorkTimeFile_KstWorkTime
	FOREIGN KEY (GuidWorkTime) REFERENCES Kst.KstWorkTime (GuidWorkTime)
	ON UPDATE NO ACTION ON DELETE NO ACTION;