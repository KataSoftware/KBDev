using KS.Time.BusinessObjects;
using SFS.Core.BR;
using SFS.Core.My;
using SFS.Core.Security.BR;
using SFS.Core.Security.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KS.Time.BR
{
    public partial class IntegrationAppsBR
    {

        partial void OnGetting(IntegrationDataEventArgs e)
        {
            if (e.EntityTpe == EntityTypes.User)
            {
                e.Items = KstProxyUsersBR.Instance.GetBy("", e.ContextRequest).Cast<Object>().ToList();
                e.Cancel = true;

            }

        }
        private string Decrypt(string password)
        {
            string result = password;
            try
            {
                result = SFS.Core.Globals.Security.DecryptString(password);
            }
            catch (Exception ex)
            {
                result = password;
            }

            return result;
        }
        partial void OnUserLoging(UserLoginEventArgs e)
        {
            ContextRequest contextRequest = new ContextRequest();
            string userOrEmail = e.Username;
            if (string.IsNullOrEmpty(userOrEmail))
            {
                userOrEmail = e.Email;
            }
            if (!string.IsNullOrEmpty(userOrEmail))
            {
                userOrEmail = userOrEmail.ToLower();
            }

            
            
            contextRequest.UseMode = "withPassword";
            var userProxy = KstProxyUsersBR.Instance.GetBy(p => (p.Username != null && p.Username.ToLower() == userOrEmail) || (p.Email != null && p.Email.ToLower() == userOrEmail), contextRequest).FirstOrDefault();
            bool findInCore = false;
            if (userProxy != null)
            {
                if (userProxy.Password == null)
                {
                    findInCore = true;
                }
                else if (e.Password == Decrypt(userProxy.Password))
                {
                    if (string.IsNullOrEmpty(userProxy.Username))
                    {
                        userProxy.Username = userProxy.Email;
                    }
                    // si existe el usuario
                    e.Result = new secUser() { GuidUser = userProxy.GuidUser, FirstName = userProxy.FirstName, LastName = userProxy.LastName, DisplayName = userProxy.DisplayName, Email = userProxy.Email, UserName = userProxy.Username };
                }
                else
                {
                    findInCore = true;
                }
            }
            else
            {
                findInCore = true;
            }
            if (findInCore)
            {
                if (!string.IsNullOrEmpty(e.Password) && e.User == null)
                {
                    string encryptedPassword = SFS.Core.Globals.Security.EncryptString(e.Password);
                    secUsersBR brUser = new secUsersBR(true);
                    e.Result = brUser.GetBy(p => (p.LoweredUserName == userOrEmail && p.Password == encryptedPassword) || (p.Email.ToLower() == userOrEmail && p.Password == encryptedPassword), contextRequest).FirstOrDefault();
                }
            }
            if (userProxy != null)
            {
                //var customer = BR.ubiCustomersBR.Instance.GetBy(p => p.GuidUser == userProxy.GuidUser, contextRequest).FirstOrDefault();
                //if (customer != null)
                //{
                //    e.SetParam("GuidCustomer", customer.GuidCustomer);
                //    e.SetParam("NumAddresses", BR.ubiAddressesBR.Instance.GetCount(p => p.GuidCustomer == customer.GuidCustomer, contextRequest));

                //}
            }

            // e.PreventGlobalHtml = true;

        }


        partial void OnPasswordRecovery(UserLoginEventArgs e)
        {
            e.ContextRequest.SetParam("prevent-email", true);


            var template = KstEmailTemplatesBR.Instance.GetBy(p => p.TitleKey == "recovery-password").FirstOrDefault();
            var layoutTemplate = KstEmailTemplatesBR.Instance.GetBy(p => p.TitleKey == "email-template", e.ContextRequest.CopySafe()).FirstOrDefault();
            if (template != null &&  template.Content != null )
            {
                string content = "Reestablece tu contraseña desde <a href=\"{URL}\">aquí</a>";
                if (template != null)
                {

                    content = template.Content;
                }
                string code = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);
                e.User.EmailCodeVerirication = code;
                SFS.Core.Security.BR.secUsersBR.Instance.UpdateAgile(e.User, e.ContextRequest, secUser.PropertyNames.EmailCodeVerirication);
                //content = content.Replace("{{NOMBRE-COMPLETO}}", e.User.FirstName + " " + e.User.LastName);
                string url = $"{e.ContextRequest.CurrentContext.ApplicationHome}/App/#/set-password/email/{e.User.Email}/code/{e.User.EmailCodeVerirication}";

                content = content.Replace("{{URL}}", url);
                content = content.Replace("{{CLICK-AQUI}}", $"<a href=\"{url}\">Click aquí</a>");
                //content = content.Replace(Environment.NewLine, "<br />");
                //content = content.Replace("\n", "<br />");
                string layoutContent = content;
                if (layoutTemplate != null)
                {
                    layoutTemplate.Content = layoutTemplate.Content.Replace("{{CONTENT}}", content);
                    layoutContent = layoutTemplate.Content;
                }

                layoutContent = layoutContent.Replace("{{URL-LINK}}", $"{e.ContextRequest.CurrentContext.ApplicationHome}/App/#/set-password/email/{e.User.Email}/code/{e.User.EmailCodeVerirication}");

                SFS.Core.Net.Mail.SendMailAsync(e.User.Email, "Kstbio de contraseña", layoutContent, e.ContextRequest);

            }

        }



        public void NotifyUserAsync(secUser user, ContextRequest contextRequest)
        {
            Task.Run(() => {
                this.NotifyUser(user, contextRequest);
            });
        }

        public void NotifyUser(secUser user, ContextRequest contextRequest)
        {
            var template = KstEmailTemplatesBR.Instance.GetBy(p => p.TitleKey == "welcome", contextRequest.CopySafe()).FirstOrDefault();
            //var layoutTemplate = ubiEmailTemplatesBR.Instance.GetBy(p => p.TitleKey == "email-template", contextRequest.CopySafe()).FirstOrDefault();

            if (template != null   && template.Content != null )
            {
                string content = template.Content;

                string code = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);
                user.EmailCodeVerirication = code;
                SFS.Core.Security.BR.secUsersBR.Instance.UpdateAgile(user, contextRequest, secUser.PropertyNames.EmailCodeVerirication);
                //content = content.Replace("{{NOMBRE-COMPLETO}}", user.FirstName + " " + user.LastName);

                content = content.Replace("{{URL-LINK}}", $"{contextRequest.CurrentContext.ApplicationHome}/App/#/activate-account/email/{user.Email}/code/{user.EmailCodeVerirication}");
                content = content.Replace("{{URL}}", $"{contextRequest.CurrentContext.ApplicationHome}/App/#/activate-account/email/{user.Email}/code/{user.EmailCodeVerirication}");
                content = content.Replace("{{EMAIL}}", user.Email);


                SFS.Core.Net.Mail.SendMailAsync(user.Email, "Bienvenid@ a TodoSí",content, contextRequest);
            }
        }
        partial void OnRoleCreated(IntegrationDataEventArgs e)
        {

            //var systemRole = (secRole)e.Item;

            //accProxyRole proxyRole = new CARProxyRole();
            //proxyRole.GuidRole = systemRole.GuidRole;
            //proxyRole.Name = systemRole.RoleName;
            //proxyRole.NameKey = systemRole.NameKey;

            //BR.CARProxyRolesBR.Instance.Create(proxyRole, e.ContextRequest);
        }

        partial void OnUserUpdated(IntegrationDataEventArgs e)
        {
            // se está actualizando un usuario
            var userSystem = (secUser)e.Item;
            //var userProxy = BR.CARProxyUsersBR.Instance.GetBy(p=> p.GuidUser == userSystem.GuidUser, e.ContextRequest).FirstOrDefault();
            KstProxyUser userProxy = new KstProxyUser();
            userProxy.GuidUser = userSystem.GuidUser;
            userProxy.FirstName = userSystem.FirstName;
            userProxy.LastName = userSystem.LastName;
            userProxy.Email = userSystem.Email;

            KstProxyUsersBR.Instance.UpdateAgile(userProxy, e.ContextRequest, "FirstName", "LastName", "Email");

        }

        partial void OnRoleUpdated(IntegrationDataEventArgs e)
        {
            // se esta actualizando un rol
            //var systemRole = (secRole)e.Item;

            //CARProxyRole proxyRole = BR.CARProxyRolesBR.Instance.GetBy(p => p.GuidRole == systemRole.GuidRole, e.ContextRequest).FirstOrDefault();
            //if (proxyRole != null)
            //{
            //    proxyRole.GuidRole = systemRole.GuidRole;
            //    proxyRole.Name = systemRole.RoleName;
            //    proxyRole.NameKey = systemRole.NameKey;

            //    BR.CARProxyRolesBR.Instance.UpdateAgile(proxyRole, e.ContextRequest, "Name", "NameKey");
            //}
            //else
            //{
            //    proxyRole = new CARProxyRole();
            //    proxyRole.GuidRole = systemRole.GuidRole;
            //    proxyRole.Name = systemRole.RoleName;
            //    proxyRole.NameKey = systemRole.NameKey;

            //    BR.CARProxyRolesBR.Instance.Create(proxyRole, e.ContextRequest);
            //}
        }

        partial void OnUserCompanyCreated(IntegrationDataEventArgs e)
        {
            //var systemUserRole = (secUserCompany)e.Item;

            //var systemRole = SFS.Core.Security.BR.secRolesBR.Instance.GetBy(p=> p.GuidRole == systemUserRole.;

            e.ContextRequest.SetParam("prevent-email", true);
        }

        partial void OnUserCompanyUpdated(IntegrationDataEventArgs e)
        {

        }
    }
}
