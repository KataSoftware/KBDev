using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using SFS.Core.Api;
using SFS.Core.Api.Models;
using SFS.Core.Entities;
using SFS.Core.My;

namespace KS.Time.Api
{

    public class Startup
    {
        public static AppVersion GetVersionValues()
        {
            AppVersion result = new AppVersion();
          
            result.Commit = "token-commit";
            result.BuildID = "token-build-id";

        

            AppVersion appVersion = null;
            try
            {
                // File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "\TDS.Time.Version.json");
                string content = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "TDS.Time.Version.json");
                appVersion = Newtonsoft.Json.JsonConvert.DeserializeObject<AppVersion>(content);
                if (appVersion != null)
                {
                    result.ReleaseName = appVersion.ReleaseName;
                }
            }
            catch (Exception ex)
            {

            }
            // }
            return result;
        }
        private byte[] LoadFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            byte[] buffer = new byte[(int)fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            fs.Close();

            return buffer;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly CustomResolver(object sender, ResolveEventArgs args)
        {
           
            Assembly assembly=null;
            if(args.Name.Contains("Polly"))
            {
                AppDomain domain = AppDomain.CurrentDomain;
                byte[] rawAssembly = LoadFile(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Polly.dll"));
                assembly = domain.Load(rawAssembly);
            }
            else if(args.Name.Contains("GoogleMaps.LocationServices"))
            {
                AppDomain domain = AppDomain.CurrentDomain;
                byte[] rawAssembly = LoadFile(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "GoogleMaps.LocationServices.dll"));
                assembly = domain.Load(rawAssembly);

            }
          

            return assembly;
        }
        public void Start(object sender, IServiceCollection services)
        {
            try
            {
                //System.Threading.Thread.Sleep(30000);
                AppDomain currentDomain = AppDomain.CurrentDomain;
                currentDomain.AssemblyResolve += CustomResolver;
               
                string appNamespace = "KS.Time";
                Guid guidCompany = Guid.Parse("F8A6AAE5-624F-4D42-AF85-C1E71F6D769A");
                string nameCompany = "Kata Software";
                string userAdminEmail = "emirdevx+kstime-op@gmail.com";
                string userAdminPassword = "Time.1";
                Guid guidAdminRole = Guid.Parse("FD385E50-E344-4260-98D8-44E99BEF5CEC");

                SFS.Core.Security.BR.secModulesBR br = new SFS.Core.Security.BR.secModulesBR(true);
                var secModule = br.GetBy(p => p.ModuleNamespace == appNamespace, new ContextRequest()).FirstOrDefault();
                if (secModule == null)
                {
                    secModule = new SFS.Core.Security.BusinessObjects.secModule();
                    secModule.ModuleNamespace = appNamespace;
                    secModule.ModuleKey = secModule.ModuleNamespace.Replace(".", "");
                    secModule.Name = "KSTime";
                    secModule.IsAllowed = true;
                   

                    secModule = br.Create(secModule, new ContextRequest());
                }
                SFS.Core.Security.BR.secCompaniesBR brCompanies = new SFS.Core.Security.BR.secCompaniesBR(true);
                var company = brCompanies.GetBy(p => p.GuidCompany == guidCompany, new ContextRequest()).FirstOrDefault();
                if (company == null)
                {
                    company = new SFS.Core.Security.BusinessObjects.secCompany();
                    company.Name = nameCompany;
                    company.GuidCompany = guidCompany;

                    company = brCompanies.Create(company, new ContextRequest());

                }
                SFS.Core.Security.BR.secUserCompaniesBR brUserCompanies = new SFS.Core.Security.BR.secUserCompaniesBR(true);
                SFS.Core.Security.BR.secUsersBR brUsers = new SFS.Core.Security.BR.secUsersBR(true);

                
                SFS.Core.Security.BR.secRolesBR brRoles = new SFS.Core.Security.BR.secRolesBR(true);
             

                
                var contextRole = new ContextRequest();
                contextRole.PreventInterceptors = true;
                var userOperator = brRoles.GetBy(p => p.NameKey == "KSTime-operator", contextRole).FirstOrDefault();
                if (userOperator == null)
                {
                    userOperator = new SFS.Core.Security.BusinessObjects.secRole();
                    userOperator.NameKey = "KSTime-operator";
                    userOperator.RoleName = "Operador KSTime";
                    //userOperator.OwnerCompany = guidCompany;
                    userOperator.GuidRole = Guid.NewGuid();
                    contextRole = new ContextRequest();
                    contextRole.PreventInterceptors = true;
                    userOperator = brRoles.Create(userOperator, contextRole);
                }
                contextRole = new ContextRequest();
                contextRole.PreventInterceptors = true;
                BR.KstProxyRolesBR brProxyRoles = new BR.KstProxyRolesBR(true);
                var userOperatorProxy = brProxyRoles.GetBy(p=> p.GuidRole == userOperator.GuidRole, contextRole).FirstOrDefault();
                if (userOperatorProxy == null)
                {
                    userOperatorProxy = new BusinessObjects.KstProxyRole();
                    userOperatorProxy.GuidRole = userOperator.GuidRole;
                    userOperatorProxy.RoleName = userOperator.RoleName;
                    userOperatorProxy.NameKey = userOperator.NameKey;
                    brProxyRoles.Create(userOperatorProxy, contextRole);
                }

                contextRole = new ContextRequest();
                contextRole.PreventInterceptors = true;
                var userEmployee = brRoles.GetBy(p => p.NameKey == "KSTime-employee", contextRole).FirstOrDefault();
                if (userEmployee == null)
                {
                    userEmployee = new SFS.Core.Security.BusinessObjects.secRole();
                    userEmployee.NameKey = "KSTime-employee";
                    userEmployee.RoleName = "Empleado";
                    //userEmployee.OwnerCompany = guidCompany;
                    userEmployee.GuidRole = Guid.NewGuid();
                    userEmployee.IsFullAccess = true;
                    contextRole = new ContextRequest();
                    contextRole.PreventInterceptors = true;
                    userEmployee = brRoles.Create(userEmployee, contextRole);
                }
                 var userEmployeeProxy = brProxyRoles.GetBy(p => p.GuidRole == userEmployee.GuidRole, contextRole).FirstOrDefault();
                if (userEmployeeProxy == null)
                {
                    userEmployeeProxy = new BusinessObjects.KstProxyRole();
                    userEmployeeProxy.GuidRole = userEmployee.GuidRole;
                    userEmployeeProxy.RoleName = userEmployee.RoleName;
                    userEmployeeProxy.NameKey = userEmployee.NameKey;
                    brProxyRoles.Create(userEmployeeProxy, contextRole);
                }



                var contextUser = new ContextRequest();
                contextUser.PreventInterceptors = true;
                //agregar usuario
                var userAdmin = brUsers.GetBy(p => p.Email == userAdminEmail, contextUser).FirstOrDefault();
                if (userAdmin == null)
                {
                    contextUser = new ContextRequest();
                    contextUser.PreventInterceptors = true;

                    userAdmin = new SFS.Core.Security.BusinessObjects.secUser();
                    userAdmin.GuidUser = Guid.NewGuid();
                    userAdmin.UserId = Guid.NewGuid();
                    userAdmin.Email = userAdminEmail;
                    userAdmin.Password = SFS.Core.Globals.Security.EncryptString(userAdminPassword);
                    userAdmin.UserName = userAdminEmail;
                    userAdmin.FirstName = "First name";
                    userAdmin.LastName = "Last name";
                    userAdmin = brUsers.Create(userAdmin, contextUser);

                }
                else
                {
                    userAdmin.Password = SFS.Core.Globals.Security.EncryptString(userAdminPassword);
                    brUsers.UpdateAgile(userAdmin, "Password");
                }
                // agregar superadmin a modulo app
                var contextUserCompany = new ContextRequest();
                contextUserCompany.PreventInterceptors = true;

                var adminUserComapny = brUserCompanies.GetBy(p => p.GuidUser == userAdmin.GuidUser && p.GuidModule == secModule.GuidModule && p.GuidCompany == guidCompany && p.GuidRole == guidAdminRole, contextUserCompany).FirstOrDefault();
                if (adminUserComapny == null)
                {
                    contextUserCompany = new ContextRequest();
                    contextUserCompany.PreventInterceptors = true;
                    adminUserComapny = new SFS.Core.Security.BusinessObjects.secUserCompany();
                    adminUserComapny.GuidCompany = guidCompany;
                    adminUserComapny.GuidRole = guidAdminRole;
                    adminUserComapny.GuidUser = userAdmin.GuidUser;
                    adminUserComapny.GuidModule = secModule.GuidModule;
                    adminUserComapny = brUserCompanies.Create(adminUserComapny, contextUserCompany);
                }


                AddEntities.AddOrUpdateEntitiesAsync();


            }
            catch(Exception ex)
            {
                SFS.Core.My.EventLog.Exception(ex);
            }
        }

       

        public void Configure(object sender, IApplicationBuilder app, IHostingEnvironment env)
        {

            //RecurringJob.AddOrUpdate(() => BR.CARInboxesBR.Instance.CheckEmail(new SFS.Core.My.ContextRequest()),
            //Cron.Minutely);
        }

    }

    //[Area("SFSCoreSecurity")]
    //public class ControllerEventArgs<T> : EventArgs where T : class
    //{
    //    public ControllerEventArgs()
    //    {
    //        this.RedirectValues = new Dictionary<string, object>();
    //    }
    //    public Dictionary<string, object> RedirectValues { get; set; }
    //    public T Item { get; set; }
    //    public bool Cancel { get; set; }
    //    public bool ReplaceResult { get; set; }
    //    public ActionResult ActionResult { get; set; }
    //    public string Id { get; set; }
    //}
    public partial class ControllerBase<T> : SFS.Core.Api.Controllers.ControllerBase<T> where T : class
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        protected void LayoutSettings(object sender, MyEventArgs<UIModel<T>> e)
        {

            OnLayoutSettings(sender, e);
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        protected override void OnVirtualLayoutSettings(object sender, MyEventArgs<UIModel<T>> e)
        {
            OnLayoutSettings(sender, e);
        }

        partial void OnLayoutSettings(object sender, MyEventArgs<UIModel<T>> e);
        [ApiExplorerSettings(IgnoreApi = true)]
        partial void OnLayoutSettings(object sender, MyEventArgs<UIModel<T>> e)
        {



        }

    }
}
