 
 
 
using SFS.Core.My;
using SFS.Core.Security.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KS.Time.Api
{
   public class AddEntities
    {
        public static void AddOrUpdateEntitiesAsync()
        {
            System.Threading.Tasks.Task.Run(() =>
                            AddOrUpdateEntities()
                        );
        }

        public static void AddOrUpdateEntities()
        {
            try
            {
                //SFS.Core.My.EventLog.Action("creating entities");
                secModule module = SFS.Core.Cache.Caching.SystemObjects.GetModuleByKey("KSTime");
                SFS.Core.Security.BR.secBusinessObjectsBR brObjects = new SFS.Core.Security.BR.secBusinessObjectsBR(true);
                ContextRequest context = new ContextRequest();
                context.User = new secUser();
                context.Company = new secCompany();
				secBusinessObject entity;
				if (brObjects.GetCount(p => p.BusinessObjectKey == "KstEmailTemplate" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "KstEmailTemplate";
					entity.EntitySetName = "KstEmailTemplates";
                    entity.BusinessObjectKey = "KstEmailTemplate";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "KstProxyGeoCity" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "KstProxyGeoCity";
					entity.EntitySetName = "KstProxyGeoCities";
                    entity.BusinessObjectKey = "KstProxyGeoCity";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "KstProxyGeoCountry" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "KstProxyGeoCountry";
					entity.EntitySetName = "KstProxyGeoCountries";
                    entity.BusinessObjectKey = "KstProxyGeoCountry";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "KstProxyGeoState" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "KstProxyGeoState";
					entity.EntitySetName = "KstProxyGeoStates";
                    entity.BusinessObjectKey = "KstProxyGeoState";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "KstActivity" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "KstActivity";
					entity.EntitySetName = "KstActivities";
                    entity.BusinessObjectKey = "KstActivity";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "KstProject" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "KstProject";
					entity.EntitySetName = "KstProjects";
                    entity.BusinessObjectKey = "KstProject";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "KstProjectUser" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "KstProjectUser";
					entity.EntitySetName = "KstProjectUsers";
                    entity.BusinessObjectKey = "KstProjectUser";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "KstWorkTime" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "KstWorkTime";
					entity.EntitySetName = "KstWorkTimes";
                    entity.BusinessObjectKey = "KstWorkTime";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "KstFile" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "KstFile";
					entity.EntitySetName = "KstFiles";
                    entity.BusinessObjectKey = "KstFile";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "KstProjectFile" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "KstProjectFile";
					entity.EntitySetName = "KstProjectFiles";
                    entity.BusinessObjectKey = "KstProjectFile";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "KstUserFile" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "KstUserFile";
					entity.EntitySetName = "KstUserFiles";
                    entity.BusinessObjectKey = "KstUserFile";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "KstWorkTimeFile" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "KstWorkTimeFile";
					entity.EntitySetName = "KstWorkTimeFiles";
                    entity.BusinessObjectKey = "KstWorkTimeFile";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "KstProxyRole" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "KstProxyRole";
					entity.EntitySetName = "KstProxyRoles";
                    entity.BusinessObjectKey = "KstProxyRole";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "KstProxyUser" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "KstProxyUser";
					entity.EntitySetName = "KstProxyUsers";
                    entity.BusinessObjectKey = "KstProxyUser";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "unProxyBusinessObject" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "unProxyBusinessObject";
					entity.EntitySetName = "unProxyBusinessObjects";
                    entity.BusinessObjectKey = "unProxyBusinessObject";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "unProxyEvent" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "unProxyEvent";
					entity.EntitySetName = "unProxyEvents";
                    entity.BusinessObjectKey = "unProxyEvent";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "unProxySetting" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "unProxySetting";
					entity.EntitySetName = "unProxySettings";
                    entity.BusinessObjectKey = "unProxySetting";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	
				if (brObjects.GetCount(p => p.BusinessObjectKey == "UploadFileResult" && p.secModule.GuidModule == module.GuidModule, context) == 0)
                {
					entity = new secBusinessObject();
                    entity.GuidModule = module.GuidModule;
                    entity.Name = "UploadFileResult";
					entity.EntitySetName = "UploadFileResult";
                    entity.BusinessObjectKey = "UploadFileResult";
                    entity = SFS.Core.Security.BR.secBusinessObjectsBR.Instance.Create(entity, context);
                }
	

   }
            catch (Exception ex)
            {
                SFS.Core.My.EventLog.Exception(ex);
            }

        }
    }
}
