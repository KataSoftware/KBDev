 
 
 
// <Template>
//   <SolutionTemplate>EF POCO 1</SolutionTemplate>
//   <Version>20140213.2136</Version>
//   <Update>mas de contextRequest</Update>
// </Template>
#region using
using System;
using System.Collections.Generic;
using System.Text;
using SFS.Core.BR;
using System.Linq.Dynamic.Core;
//using EntityFrameworkCore.DynamicLinq;
using System.Collections;
using System.Linq;
using LinqKit;
using SFS.Core.Entities;
using SFS.Core.Linq;
using System.Linq.Expressions;
using System.Data;

using SFSdotNet.Framework;
using SFS.Core.My;
//using System.Data.Entity.Core.Objects.DataClasses;
//using System.Data.Entity.Core.Objects;
using KS.Time.BusinessObjects;
//using KS.Time.BusinessObjects.EFPocoAdapter;

//using EFPocoAdapter;
using SFS.Core.Entities.Trackable;
using SFS.Core.Security.BR;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using SFS.Core.Security.BusinessObjects;
//using EntityFrameworkCore.DynamicLinq;


#endregion
namespace KS.Time.BR
{

		public  class Settings{
	    
		public static String SMTPServer ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.CompanyAppSettings.GetValue("SMTPServer",  "SFSCoreSecurity", contextRequest.Company.GuidCompany, "String",  "", false);

               
            
        }
		public static Boolean SMTPSSLEnabled ( ContextRequest contextRequest ){
               
                return  (Boolean)SFS.Core.Configuration.CompanyAppSettings.GetValue("SMTPSSLEnabled",  "SFSCoreSecurity", contextRequest.Company.GuidCompany, "Boolean",  false, false);

               
            
        }
		public static String SMTPUser ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.CompanyAppSettings.GetValue("SMTPUser",  "SFSCoreSecurity", contextRequest.Company.GuidCompany, "String",  "", false);

               
            
        }
		public static String SMTPPassword ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.CompanyAppSettings.GetValue("SMTPPassword",  "SFSCoreSecurity", contextRequest.Company.GuidCompany, "String",  "", false);

               
            
        }
		public static String SMTPFromName ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.CompanyAppSettings.GetValue("SMTPFromName",  "SFSCoreSecurity", contextRequest.Company.GuidCompany, "String",  "", false);

               
            
        }
		public static String SMTPPort ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.CompanyAppSettings.GetValue("SMTPPort",  "SFSCoreSecurity", contextRequest.Company.GuidCompany, "String",  "", false);

               
            
        }
		public static String SMTPFromEmail ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.CompanyAppSettings.GetValue("SMTPFromEmail",  "SFSCoreSecurity", contextRequest.Company.GuidCompany, "String",  "", false);

               
            
        }
            
			       
			public static String AzureBlobStorageConnection ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.ModuleAppSettings.GetValue("AzureStorageConnectionString", "SFSCoreSecurity", "String", "", false);

               
            
        }
            
			       
			public static Boolean SaveBlobInAzureStorage ( ContextRequest contextRequest ){
               
                return  (Boolean)SFS.Core.Configuration.ModuleAppSettings.GetValue("save-files-blob", "KSTime", "Boolean", false, false);

               
            
        }
            
			       
			public static Boolean SaveBlobInDataBase ( ContextRequest contextRequest ){
               
                return  (Boolean)SFS.Core.Configuration.ModuleAppSettings.GetValue("save-files-db", "KSTime", "Boolean", false, false);

               
            
        }
            
			       
			public static String EngineURL ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.ModuleAppSettings.GetValue("EngineURL", "KSTime", "String", "", false);

               
            
        }
            
			       
			public static String ENGINE_API_KEY ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.ModuleAppSettings.GetValue("ENGINE_API_KEY", "KSTime", "String", "", false);

               
            
        }
            
			       
			public static String MAMBU_URL ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.ModuleAppSettings.GetValue("MAMBU_URL", "KSTime", "String", "", false);

               
            
        }
            
			       
			public static String MAMBU_USER ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.ModuleAppSettings.GetValue("MAMBU_USER", "KSTime", "String", "", false);

               
            
        }
            
			       
			public static String MAMBU_PWD ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.ModuleAppSettings.GetValue("MAMBU_PWD", "KSTime", "String", "", false);

               
            
        }
            
			       
			public static Int32 KM_MAXIMO ( ContextRequest contextRequest ){
               
                return  (Int32)SFS.Core.Configuration.ModuleAppSettings.GetValue("km-maximo", "KSTime", "Int32", 0, false);

               
            
        }
            
			       
			public static String MAP_KEY ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.ModuleAppSettings.GetValue("MAP_KEY", "KSTime", "String", "", false);

               
            
        }
            
			       
			public static String ENGINE_OAUTH_CLIENT_ID ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.ModuleAppSettings.GetValue("ENGINE_OAUTH_CLIENT_ID", "KSTime", "String", "", false);

               
            
        }
            
			       
			public static String ENGINE_OAUTH_LOGIN_URL ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.ModuleAppSettings.GetValue("ENGINE_OAUTH_LOGIN_URL", "KSTime", "String", "", false);

               
            
        }
            
			       
			public static String ENGINE_OAUTH_USERNAME ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.ModuleAppSettings.GetValue("ENGINE_OAUTH_USERNAME", "KSTime", "String", "", false);

               
            
        }
            
			       
			public static String ENGINE_OAUTH_PASSWORD ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.ModuleAppSettings.GetValue("ENGINE_OAUTH_PASSWORD", "KSTime", "String", "", false);

               
            
        }
            
			       
			public static String ENGINE_OAUTH_CLIENT_SECRET ( ContextRequest contextRequest ){
               
                return  (String)SFS.Core.Configuration.ModuleAppSettings.GetValue("ENGINE_OAUTH_CLIENT_SECRET", "KSTime", "String", "", false);

               
            
        }
       
		
	}

	}
