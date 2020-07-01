 
 
PRINT 'Table KstEmailTemplate, entity KstEmailTemplate'
-- GuidCompany
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstEmailTemplate', N'U'),'GuidCompany','ColumnId') is null
begin 
  alter table Kst.KstEmailTemplate 
  add GuidCompany uniqueidentifier null 
end
GO

-- CreatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstEmailTemplate', N'U'),'CreatedBy','ColumnId') is null
begin 
  alter table Kst.KstEmailTemplate 
  add CreatedBy uniqueidentifier null 
end
GO
-- UpdatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstEmailTemplate', N'U'),'UpdatedBy','ColumnId') is null
begin 
  alter table Kst.KstEmailTemplate 
  add UpdatedBy uniqueidentifier null 
end
GO

-- IsDeleted
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstEmailTemplate', N'U'),'IsDeleted','ColumnId') is null
begin 
  alter table Kst.KstEmailTemplate 
  add IsDeleted [bit] null DEFAULT ('false') 
end
GO

-- BizKeyEngine

if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstEmailTemplate', N'U'),'BizKeyEngine','ColumnId') is null
begin 
  alter table Kst.KstEmailTemplate 
  add BizKeyEngine VARCHAR(32) null 
end
GO

-- CreatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstEmailTemplate', N'U'),'CreatedDate','ColumnId') is null
begin 
  alter table Kst.KstEmailTemplate 
  add CreatedDate DATETIME null 
end
GO
-- UpdatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstEmailTemplate', N'U'),'UpdatedDate','ColumnId') is null
begin 
  alter table Kst.KstEmailTemplate 
  add UpdatedDate DATETIME null 
end
GO

-- Bytes
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstEmailTemplate', N'U'),'Bytes','ColumnId') is null
begin 
  alter table Kst.KstEmailTemplate 
  add Bytes [int] null 
end
GO





PRINT 'Table KstActivity, entity KstActivity'
-- GuidCompany
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstActivity', N'U'),'GuidCompany','ColumnId') is null
begin 
  alter table Kst.KstActivity 
  add GuidCompany uniqueidentifier null 
end
GO

-- CreatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstActivity', N'U'),'CreatedBy','ColumnId') is null
begin 
  alter table Kst.KstActivity 
  add CreatedBy uniqueidentifier null 
end
GO
-- UpdatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstActivity', N'U'),'UpdatedBy','ColumnId') is null
begin 
  alter table Kst.KstActivity 
  add UpdatedBy uniqueidentifier null 
end
GO

-- IsDeleted
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstActivity', N'U'),'IsDeleted','ColumnId') is null
begin 
  alter table Kst.KstActivity 
  add IsDeleted [bit] null DEFAULT ('false') 
end
GO

-- BizKeyEngine

if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstActivity', N'U'),'BizKeyEngine','ColumnId') is null
begin 
  alter table Kst.KstActivity 
  add BizKeyEngine VARCHAR(32) null 
end
GO

-- CreatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstActivity', N'U'),'CreatedDate','ColumnId') is null
begin 
  alter table Kst.KstActivity 
  add CreatedDate DATETIME null 
end
GO
-- UpdatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstActivity', N'U'),'UpdatedDate','ColumnId') is null
begin 
  alter table Kst.KstActivity 
  add UpdatedDate DATETIME null 
end
GO

-- Bytes
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstActivity', N'U'),'Bytes','ColumnId') is null
begin 
  alter table Kst.KstActivity 
  add Bytes [int] null 
end
GO





PRINT 'Table KstProject, entity KstProject'
-- GuidCompany
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProject', N'U'),'GuidCompany','ColumnId') is null
begin 
  alter table Kst.KstProject 
  add GuidCompany uniqueidentifier null 
end
GO

-- CreatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProject', N'U'),'CreatedBy','ColumnId') is null
begin 
  alter table Kst.KstProject 
  add CreatedBy uniqueidentifier null 
end
GO
-- UpdatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProject', N'U'),'UpdatedBy','ColumnId') is null
begin 
  alter table Kst.KstProject 
  add UpdatedBy uniqueidentifier null 
end
GO

-- IsDeleted
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProject', N'U'),'IsDeleted','ColumnId') is null
begin 
  alter table Kst.KstProject 
  add IsDeleted [bit] null DEFAULT ('false') 
end
GO

-- BizKeyEngine

if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProject', N'U'),'BizKeyEngine','ColumnId') is null
begin 
  alter table Kst.KstProject 
  add BizKeyEngine VARCHAR(32) null 
end
GO

-- CreatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProject', N'U'),'CreatedDate','ColumnId') is null
begin 
  alter table Kst.KstProject 
  add CreatedDate DATETIME null 
end
GO
-- UpdatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProject', N'U'),'UpdatedDate','ColumnId') is null
begin 
  alter table Kst.KstProject 
  add UpdatedDate DATETIME null 
end
GO

-- Bytes
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProject', N'U'),'Bytes','ColumnId') is null
begin 
  alter table Kst.KstProject 
  add Bytes [int] null 
end
GO





PRINT 'Table KstProjectUser, entity KstProjectUser'
-- GuidCompany
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectUser', N'U'),'GuidCompany','ColumnId') is null
begin 
  alter table Kst.KstProjectUser 
  add GuidCompany uniqueidentifier null 
end
GO

-- CreatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectUser', N'U'),'CreatedBy','ColumnId') is null
begin 
  alter table Kst.KstProjectUser 
  add CreatedBy uniqueidentifier null 
end
GO
-- UpdatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectUser', N'U'),'UpdatedBy','ColumnId') is null
begin 
  alter table Kst.KstProjectUser 
  add UpdatedBy uniqueidentifier null 
end
GO

-- IsDeleted
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectUser', N'U'),'IsDeleted','ColumnId') is null
begin 
  alter table Kst.KstProjectUser 
  add IsDeleted [bit] null DEFAULT ('false') 
end
GO

-- BizKeyEngine

if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectUser', N'U'),'BizKeyEngine','ColumnId') is null
begin 
  alter table Kst.KstProjectUser 
  add BizKeyEngine VARCHAR(32) null 
end
GO

-- CreatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectUser', N'U'),'CreatedDate','ColumnId') is null
begin 
  alter table Kst.KstProjectUser 
  add CreatedDate DATETIME null 
end
GO
-- UpdatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectUser', N'U'),'UpdatedDate','ColumnId') is null
begin 
  alter table Kst.KstProjectUser 
  add UpdatedDate DATETIME null 
end
GO

-- Bytes
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectUser', N'U'),'Bytes','ColumnId') is null
begin 
  alter table Kst.KstProjectUser 
  add Bytes [int] null 
end
GO





PRINT 'Table KstWorkTime, entity KstWorkTime'
-- GuidCompany
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTime', N'U'),'GuidCompany','ColumnId') is null
begin 
  alter table Kst.KstWorkTime 
  add GuidCompany uniqueidentifier null 
end
GO

-- CreatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTime', N'U'),'CreatedBy','ColumnId') is null
begin 
  alter table Kst.KstWorkTime 
  add CreatedBy uniqueidentifier null 
end
GO
-- UpdatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTime', N'U'),'UpdatedBy','ColumnId') is null
begin 
  alter table Kst.KstWorkTime 
  add UpdatedBy uniqueidentifier null 
end
GO

-- IsDeleted
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTime', N'U'),'IsDeleted','ColumnId') is null
begin 
  alter table Kst.KstWorkTime 
  add IsDeleted [bit] null DEFAULT ('false') 
end
GO

-- BizKeyEngine

if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTime', N'U'),'BizKeyEngine','ColumnId') is null
begin 
  alter table Kst.KstWorkTime 
  add BizKeyEngine VARCHAR(32) null 
end
GO

-- CreatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTime', N'U'),'CreatedDate','ColumnId') is null
begin 
  alter table Kst.KstWorkTime 
  add CreatedDate DATETIME null 
end
GO
-- UpdatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTime', N'U'),'UpdatedDate','ColumnId') is null
begin 
  alter table Kst.KstWorkTime 
  add UpdatedDate DATETIME null 
end
GO

-- Bytes
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTime', N'U'),'Bytes','ColumnId') is null
begin 
  alter table Kst.KstWorkTime 
  add Bytes [int] null 
end
GO





PRINT 'Table KstFile, entity KstFile'
-- GuidCompany
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstFile', N'U'),'GuidCompany','ColumnId') is null
begin 
  alter table Kst.KstFile 
  add GuidCompany uniqueidentifier null 
end
GO

-- CreatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstFile', N'U'),'CreatedBy','ColumnId') is null
begin 
  alter table Kst.KstFile 
  add CreatedBy uniqueidentifier null 
end
GO
-- UpdatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstFile', N'U'),'UpdatedBy','ColumnId') is null
begin 
  alter table Kst.KstFile 
  add UpdatedBy uniqueidentifier null 
end
GO

-- IsDeleted
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstFile', N'U'),'IsDeleted','ColumnId') is null
begin 
  alter table Kst.KstFile 
  add IsDeleted [bit] null DEFAULT ('false') 
end
GO

-- BizKeyEngine

if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstFile', N'U'),'BizKeyEngine','ColumnId') is null
begin 
  alter table Kst.KstFile 
  add BizKeyEngine VARCHAR(32) null 
end
GO

-- CreatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstFile', N'U'),'CreatedDate','ColumnId') is null
begin 
  alter table Kst.KstFile 
  add CreatedDate DATETIME null 
end
GO
-- UpdatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstFile', N'U'),'UpdatedDate','ColumnId') is null
begin 
  alter table Kst.KstFile 
  add UpdatedDate DATETIME null 
end
GO

-- Bytes
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstFile', N'U'),'Bytes','ColumnId') is null
begin 
  alter table Kst.KstFile 
  add Bytes [int] null 
end
GO





PRINT 'Table KstProjectFile, entity KstProjectFile'
-- GuidCompany
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectFile', N'U'),'GuidCompany','ColumnId') is null
begin 
  alter table Kst.KstProjectFile 
  add GuidCompany uniqueidentifier null 
end
GO

-- CreatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectFile', N'U'),'CreatedBy','ColumnId') is null
begin 
  alter table Kst.KstProjectFile 
  add CreatedBy uniqueidentifier null 
end
GO
-- UpdatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectFile', N'U'),'UpdatedBy','ColumnId') is null
begin 
  alter table Kst.KstProjectFile 
  add UpdatedBy uniqueidentifier null 
end
GO

-- IsDeleted
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectFile', N'U'),'IsDeleted','ColumnId') is null
begin 
  alter table Kst.KstProjectFile 
  add IsDeleted [bit] null DEFAULT ('false') 
end
GO

-- BizKeyEngine

if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectFile', N'U'),'BizKeyEngine','ColumnId') is null
begin 
  alter table Kst.KstProjectFile 
  add BizKeyEngine VARCHAR(32) null 
end
GO

-- CreatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectFile', N'U'),'CreatedDate','ColumnId') is null
begin 
  alter table Kst.KstProjectFile 
  add CreatedDate DATETIME null 
end
GO
-- UpdatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectFile', N'U'),'UpdatedDate','ColumnId') is null
begin 
  alter table Kst.KstProjectFile 
  add UpdatedDate DATETIME null 
end
GO

-- Bytes
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstProjectFile', N'U'),'Bytes','ColumnId') is null
begin 
  alter table Kst.KstProjectFile 
  add Bytes [int] null 
end
GO





PRINT 'Table KstUserFile, entity KstUserFile'
-- GuidCompany
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstUserFile', N'U'),'GuidCompany','ColumnId') is null
begin 
  alter table Kst.KstUserFile 
  add GuidCompany uniqueidentifier null 
end
GO

-- CreatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstUserFile', N'U'),'CreatedBy','ColumnId') is null
begin 
  alter table Kst.KstUserFile 
  add CreatedBy uniqueidentifier null 
end
GO
-- UpdatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstUserFile', N'U'),'UpdatedBy','ColumnId') is null
begin 
  alter table Kst.KstUserFile 
  add UpdatedBy uniqueidentifier null 
end
GO

-- IsDeleted
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstUserFile', N'U'),'IsDeleted','ColumnId') is null
begin 
  alter table Kst.KstUserFile 
  add IsDeleted [bit] null DEFAULT ('false') 
end
GO

-- BizKeyEngine

if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstUserFile', N'U'),'BizKeyEngine','ColumnId') is null
begin 
  alter table Kst.KstUserFile 
  add BizKeyEngine VARCHAR(32) null 
end
GO

-- CreatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstUserFile', N'U'),'CreatedDate','ColumnId') is null
begin 
  alter table Kst.KstUserFile 
  add CreatedDate DATETIME null 
end
GO
-- UpdatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstUserFile', N'U'),'UpdatedDate','ColumnId') is null
begin 
  alter table Kst.KstUserFile 
  add UpdatedDate DATETIME null 
end
GO

-- Bytes
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstUserFile', N'U'),'Bytes','ColumnId') is null
begin 
  alter table Kst.KstUserFile 
  add Bytes [int] null 
end
GO





PRINT 'Table KstWorkTimeFile, entity KstWorkTimeFile'
-- GuidCompany
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTimeFile', N'U'),'GuidCompany','ColumnId') is null
begin 
  alter table Kst.KstWorkTimeFile 
  add GuidCompany uniqueidentifier null 
end
GO

-- CreatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTimeFile', N'U'),'CreatedBy','ColumnId') is null
begin 
  alter table Kst.KstWorkTimeFile 
  add CreatedBy uniqueidentifier null 
end
GO
-- UpdatedBy
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTimeFile', N'U'),'UpdatedBy','ColumnId') is null
begin 
  alter table Kst.KstWorkTimeFile 
  add UpdatedBy uniqueidentifier null 
end
GO

-- IsDeleted
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTimeFile', N'U'),'IsDeleted','ColumnId') is null
begin 
  alter table Kst.KstWorkTimeFile 
  add IsDeleted [bit] null DEFAULT ('false') 
end
GO

-- BizKeyEngine

if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTimeFile', N'U'),'BizKeyEngine','ColumnId') is null
begin 
  alter table Kst.KstWorkTimeFile 
  add BizKeyEngine VARCHAR(32) null 
end
GO

-- CreatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTimeFile', N'U'),'CreatedDate','ColumnId') is null
begin 
  alter table Kst.KstWorkTimeFile 
  add CreatedDate DATETIME null 
end
GO
-- UpdatedDate
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTimeFile', N'U'),'UpdatedDate','ColumnId') is null
begin 
  alter table Kst.KstWorkTimeFile 
  add UpdatedDate DATETIME null 
end
GO

-- Bytes
if COLUMNPROPERTY(OBJECT_ID(N'Kst.KstWorkTimeFile', N'U'),'Bytes','ColumnId') is null
begin 
  alter table Kst.KstWorkTimeFile 
  add Bytes [int] null 
end
GO






