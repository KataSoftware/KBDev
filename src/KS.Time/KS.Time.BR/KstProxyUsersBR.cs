using KS.Time.BusinessObjects;
using SFS.Core.BR;
using SFS.Core.My;
using SFS.Core.Security.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KS.Time.BR
{
    public partial class KstProxyUsersBR
    {
        public void DisableUser(Guid guidUser, ContextRequest contextRequest)
        {

        }
        partial void OnDeleting(object sender, BusinessRulesEventArgs<KstProxyUser> e)
        {

        }
        partial void OnDeleted(object sender, BusinessRulesEventArgs<KstProxyUser> e)
        {
            foreach (var item in e.Items)
            {
                Guid? guidUser = item.GuidUser;
                var sysUser = SFS.Core.Security.BR.secUsersBR.Instance.GetBy(p => p.GuidUser == guidUser, e.ContextRequest).FirstOrDefault();

                SFS.Core.Security.BR.secUsersBR.Instance.Delete(sysUser, e.ContextRequest);
                var userCompanies = SFS.Core.Security.BR.secUserCompaniesBR.Instance.GetBy(p => p.GuidUser == guidUser, e.ContextRequest);
                SFS.Core.Security.BR.secUserCompaniesBR.Instance.Delete(userCompanies, e.ContextRequest);

            }

        }

        partial void OnGetting(object sender, BusinessRulesEventArgs<KstProxyUser> e)
        {
            if (e.ContextRequest.UseMode == "my-account")
            {
                e.Filter.AppendFilter($"GuidUser = \"{e.ContextRequest?.User?.GuidUser}\"");
            }
        }

        partial void OnUpdating(object sender, BusinessRulesEventArgs<KstProxyUser> e)
        {
            this.Updating(e.Item, e.ContextRequest);

            var propertyPassword = e.ContextRequest.CustomQuery.SpecificProperties.FirstOrDefault(p => p == "Password");
            if (propertyPassword != null)
            {
                e.ContextRequest.CustomQuery.SpecificProperties.Remove(propertyPassword);
            }
        }
        partial void OnCreating(object sender, BusinessRulesEventArgs<KstProxyUser> e)
        {
            #region
            secUser sysUser = new secUser();
            sysUser.UserName = e.Item.Email;
            sysUser.FirstName = e.Item.FirstName;
            sysUser.LastName = e.Item.LastName;
            e.Item.DisplayName = e.Item.FirstName + " " + e.Item.LastName;
            sysUser.DisplayName = e.Item.DisplayName;
            #endregion
            if (e.Item.Password != null )
                sysUser.Password = SFS.Core.Globals.Security.EncryptString( e.Item.Password);
            sysUser.Email = e.Item.Email;
            sysUser.Password = e.Item.Password;
            sysUser = SFS.Core.Security.BR.secUsersBR.Instance.Create(sysUser, e.ContextRequest);

            e.Item.GuidUser = sysUser.GuidUser;
           


        }
        partial void OnCreated(object sender, BusinessRulesEventArgs<KstProxyUser> e)
        {
           
            var contextRequest = e.ContextRequest;

           
            var user = new secUser() { GuidUser = e.Item.GuidUser };

            e.ContextRequest.PreventInterceptors = true;
            var role = SFS.Core.Security.BR.secRolesBR.Instance.GetBy(p => p.GuidRole == e.Item.GuidRole , e.ContextRequest).FirstOrDefault();
          
            Guid? guidCompany = contextRequest.Company.GuidCompany;
            var module = SFS.Core.Cache.Caching.SystemObjects.GetModuleByKey("KSTime");
            Guid? guidModule = module.GuidModule;
            var userCompanyRole = SFS.Core.Security.BR.secUserCompaniesBR.Instance.GetBy(p => p.GuidUser == user.GuidUser && p.GuidCompany == guidCompany && p.GuidModule == guidModule).FirstOrDefault();

            userCompanyRole = new SFS.Core.Security.BusinessObjects.secUserCompany();
            userCompanyRole.GuidUser = user.GuidUser;
            userCompanyRole.GuidRole = role.GuidRole;
            userCompanyRole.GuidModule = guidModule;
            userCompanyRole.GuidCompany = guidCompany.Value;

            userCompanyRole = SFS.Core.Security.BR.secUserCompaniesBR.Instance.Create(userCompanyRole, contextRequest);
       
        

            this.NotifyUserAsync(new secUser() { GuidUser = e.Item.GuidUser, Email = e.Item.Email, FirstName = e.Item.FirstName, LastName = e.Item.LastName }, role.RoleName, contextRequest);
        }

    public void NotifyUserAsync(secUser user, string roleName, ContextRequest contextRequest)
        {
            Task.Run(() => {
                this.NotifyUser(user, roleName, contextRequest);
            });
        }

        public void NotifyUser(secUser user, string roleName, ContextRequest contextRequest)
        {
            var template = KstEmailTemplatesBR.Instance.GetBy(p => p.TitleKey == "user-added", contextRequest.CopySafe()).FirstOrDefault();
            //var layoutTemplate = ubiEmailTemplatesBR.Instance.GetBy(p => p.TitleKey == "email-template", contextRequest.CopySafe()).FirstOrDefault();

            if (template != null && template.Content != null)
            {
                string content = template.Content;

                string code = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);
                user.EmailCodeVerirication = code;
                SFS.Core.Security.BR.secUsersBR.Instance.UpdateAgile(user, contextRequest, secUser.PropertyNames.EmailCodeVerirication);

                content = content.Replace("{APP-NAME}", contextRequest.Module.Name);
                content = content.Replace("{FROM-USER-NAME}", contextRequest.User.FirstName );
                content = content.Replace("{ROLE-NAME}", roleName);
                content = content.Replace("{URL-LINK}", $"{contextRequest.CurrentContext.ApplicationHome}/App/#/set-password/email/{user.Email}/code/{user.EmailCodeVerirication}");
                var module = SFS.Core.Cache.Caching.SystemObjects.GetModuleByKey("KSTime");

                SFS.Core.Net.Mail.SendMailAsync(user.Email, "Bienvenido a " + module.Name, content, contextRequest);
            }
        }
        partial void OnUpdatingAgile(object sender, BusinessRulesEventArgs<KstProxyUser> e)
        {

            this.Updating(e.Item, e.ContextRequest);

            var propertyPassword = e.ContextRequest.CustomQuery.SpecificProperties.FirstOrDefault(p => p == "Password");
            if (propertyPassword != null)
            {
                e.ContextRequest.CustomQuery.SpecificProperties.Remove(propertyPassword);
            }

        }


        partial void OnUpdated(object sender, BusinessRulesEventArgs<KstProxyUser> e)
        {
            //throw new NotImplementedException();

        }
        partial void OnUpdatedAgile(object sender, BusinessRulesEventArgs<KstProxyUser> e)
        {

        }

        private void Updating(KstProxyUser user, ContextRequest contextRequest)
        {
            Guid? guidUser = user.GuidUser;
            var sysUser = SFS.Core.Security.BR.secUsersBR.Instance.GetBy(p => p.GuidUser == guidUser, contextRequest).FirstOrDefault();
            if (sysUser != null)
            {
                List<string> props = new List<string>();
                sysUser.UserName = user.Username;
                if (contextRequest.CustomQuery.SpecificProperties.Contains(KstProxyUser.PropertyNames.Username))
                    props.Add("UserName");
                sysUser.FirstName = user.FirstName;
                if (contextRequest.CustomQuery.SpecificProperties.Contains(KstProxyUser.PropertyNames.FirstName))
                    props.Add("FirstName");
                sysUser.LastName = user.LastName;
                if (contextRequest.CustomQuery.SpecificProperties.Contains(KstProxyUser.PropertyNames.LastName))
                    props.Add("LastName");

                if (!string.IsNullOrEmpty(user.Password))
                {
                    if (contextRequest.CustomQuery.SpecificProperties.Contains(KstProxyUser.PropertyNames.Password))
                        props.Add("Password");
                    sysUser.Password = SFS.Core.Globals.Security.EncryptString(user.Password);
                    user.Password = null;
                }
                sysUser.Email = user.Email;
                if (contextRequest.CustomQuery.SpecificProperties.Contains(KstProxyUser.PropertyNames.Email))
                    props.Add("Email");
                SFS.Core.Security.BR.secUsersBR.Instance.UpdateAgile(sysUser, contextRequest.CopySafe(), props.ToArray());

            }



            if (user.GuidRole != null)
            {
                Guid? guidCompany = contextRequest.Company.GuidCompany;
                var module = SFS.Core.Cache.Caching.SystemObjects.GetModuleByKey("KSTime");
                Guid? guidModule = module.GuidModule;
                var userCompanyRole = SFS.Core.Security.BR.secUserCompaniesBR.Instance.GetBy(p => p.GuidUser == guidUser && p.GuidCompany == guidCompany && p.GuidModule == guidModule).FirstOrDefault();

                if (userCompanyRole != null)
                {
                    userCompanyRole.GuidRole = user.GuidRole;
                    SFS.Core.Security.BR.secUserCompaniesBR.Instance.UpdateAgile(userCompanyRole, contextRequest.CopySafe(), "GuidRole");
                }
                else
                {
                    userCompanyRole = new SFS.Core.Security.BusinessObjects.secUserCompany();
                    userCompanyRole.GuidUser = guidUser;
                    userCompanyRole.GuidRole = user.GuidRole;
                    userCompanyRole.GuidModule = guidModule;
                    userCompanyRole.GuidCompany = guidCompany.Value;

                    userCompanyRole = SFS.Core.Security.BR.secUserCompaniesBR.Instance.Create(userCompanyRole, contextRequest);


                }
            }

        }
    }
}
