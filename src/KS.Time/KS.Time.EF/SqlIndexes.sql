 
 
 
IF NOT EXISTS (
    SELECT * FROM sys.tables t
    INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
    INNER JOIN sys.indexes i on i.object_id = t.object_id
    WHERE s.name = 'Kst' AND t.name = 'KstEmailTemplate' and i.name = 'KstEmailTemplate_FullStatics_Idx'
) 
    CREATE NONCLUSTERED INDEX KstEmailTemplate_FullStatics_Idx 
    on Kst.KstEmailTemplate ( 
GuidEmailTemplate 

        ,CreatedDate desc 

	,UpdatedDate desc 
		,CreatedBy 
		,GuidCompany 
		,IsDeleted desc
    ) 
	
	INCLUDE(Bytes)
	WITH (ONLINE = ON)
IF NOT EXISTS (
    SELECT * FROM sys.tables t
    INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
    INNER JOIN sys.indexes i on i.object_id = t.object_id
    WHERE s.name = 'Kst' AND t.name = 'KstActivity' and i.name = 'KstActivity_FullStatics_Idx'
) 
    CREATE NONCLUSTERED INDEX KstActivity_FullStatics_Idx 
    on Kst.KstActivity ( 
GuidActivity 

        ,CreatedDate desc 

	,UpdatedDate desc 
		,CreatedBy 
		,GuidCompany 
		,IsDeleted desc
    ) 
	
	INCLUDE(Bytes)
	WITH (ONLINE = ON)
IF NOT EXISTS (
    SELECT * FROM sys.tables t
    INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
    INNER JOIN sys.indexes i on i.object_id = t.object_id
    WHERE s.name = 'Kst' AND t.name = 'KstProject' and i.name = 'KstProject_FullStatics_Idx'
) 
    CREATE NONCLUSTERED INDEX KstProject_FullStatics_Idx 
    on Kst.KstProject ( 
GuidProject 

        ,CreatedDate desc 

	,UpdatedDate desc 
		,CreatedBy 
		,GuidCompany 
		,IsDeleted desc
    ) 
	
	INCLUDE(Bytes)
	WITH (ONLINE = ON)
IF NOT EXISTS (
    SELECT * FROM sys.tables t
    INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
    INNER JOIN sys.indexes i on i.object_id = t.object_id
    WHERE s.name = 'Kst' AND t.name = 'KstProjectUser' and i.name = 'KstProjectUser_FullStatics_Idx'
) 
    CREATE NONCLUSTERED INDEX KstProjectUser_FullStatics_Idx 
    on Kst.KstProjectUser ( 
GuidProjectUser 

        ,CreatedDate desc 

	,UpdatedDate desc 
		,CreatedBy 
		,GuidCompany 
		,IsDeleted desc
    ) 
	
	INCLUDE(Bytes)
	WITH (ONLINE = ON)
IF NOT EXISTS (
    SELECT * FROM sys.tables t
    INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
    INNER JOIN sys.indexes i on i.object_id = t.object_id
    WHERE s.name = 'Kst' AND t.name = 'KstWorkTime' and i.name = 'KstWorkTime_FullStatics_Idx'
) 
    CREATE NONCLUSTERED INDEX KstWorkTime_FullStatics_Idx 
    on Kst.KstWorkTime ( 
GuidWorkTime 

        ,CreatedDate desc 

	,UpdatedDate desc 
		,CreatedBy 
		,GuidCompany 
		,IsDeleted desc
    ) 
	
	INCLUDE(Bytes)
	WITH (ONLINE = ON)
IF NOT EXISTS (
    SELECT * FROM sys.tables t
    INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
    INNER JOIN sys.indexes i on i.object_id = t.object_id
    WHERE s.name = 'Kst' AND t.name = 'KstFile' and i.name = 'KstFile_FullStatics_Idx'
) 
    CREATE NONCLUSTERED INDEX KstFile_FullStatics_Idx 
    on Kst.KstFile ( 
GuidFile 

        ,CreatedDate desc 

	,UpdatedDate desc 
		,CreatedBy 
		,GuidCompany 
		,IsDeleted desc
    ) 
	
	INCLUDE(Bytes)
	WITH (ONLINE = ON)
IF NOT EXISTS (
    SELECT * FROM sys.tables t
    INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
    INNER JOIN sys.indexes i on i.object_id = t.object_id
    WHERE s.name = 'Kst' AND t.name = 'KstProjectFile' and i.name = 'KstProjectFile_FullStatics_Idx'
) 
    CREATE NONCLUSTERED INDEX KstProjectFile_FullStatics_Idx 
    on Kst.KstProjectFile ( 
GuidProjectFile 

        ,CreatedDate desc 

	,UpdatedDate desc 
		,CreatedBy 
		,GuidCompany 
		,IsDeleted desc
    ) 
	
	INCLUDE(Bytes)
	WITH (ONLINE = ON)
IF NOT EXISTS (
    SELECT * FROM sys.tables t
    INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
    INNER JOIN sys.indexes i on i.object_id = t.object_id
    WHERE s.name = 'Kst' AND t.name = 'KstUserFile' and i.name = 'KstUserFile_FullStatics_Idx'
) 
    CREATE NONCLUSTERED INDEX KstUserFile_FullStatics_Idx 
    on Kst.KstUserFile ( 
GuidUserFile 

        ,CreatedDate desc 

	,UpdatedDate desc 
		,CreatedBy 
		,GuidCompany 
		,IsDeleted desc
    ) 
	
	INCLUDE(Bytes)
	WITH (ONLINE = ON)
IF NOT EXISTS (
    SELECT * FROM sys.tables t
    INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
    INNER JOIN sys.indexes i on i.object_id = t.object_id
    WHERE s.name = 'Kst' AND t.name = 'KstWorkTimeFile' and i.name = 'KstWorkTimeFile_FullStatics_Idx'
) 
    CREATE NONCLUSTERED INDEX KstWorkTimeFile_FullStatics_Idx 
    on Kst.KstWorkTimeFile ( 
GuidWorkTimeFile 

        ,CreatedDate desc 

	,UpdatedDate desc 
		,CreatedBy 
		,GuidCompany 
		,IsDeleted desc
    ) 
	
	INCLUDE(Bytes)
	WITH (ONLINE = ON)

