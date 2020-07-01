using KS.Time.BusinessObjects;
using SFS.Core.Async;
using SFS.Core.BR;
using SFS.Core.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KS.Time.BR
{
    public partial  class KstProjectUsersBR
    {
        partial void OnGetting(object sender, BusinessRulesEventArgs<KstProjectUser> e)
        {
            if (e.ContextRequest.User != null && e.ContextRequest.Company != null)
            {
                if (!e.ContextRequest.CurrentContext.IsUserInRole(
                    e.ContextRequest.User, e.ContextRequest.Company, "role-operator-ex", e.ContextRequest))
                {
                    e.Cancel = true;
                    e.ContextRequest.ReplaceApiResponse("error", "not-allowed",
                        "No es posible realizar la consulta debido a violación de la seguridad", null);
                }
            }
        }
        partial void OnCreating(object sender, BusinessRulesEventArgs<KstProjectUser> e)
        {
           if (e.Item.StartDate == null)
            {
                e.Item.StartDate = DateTime.UtcNow;
            }  
        }
        partial void OnCreated(object sender, BusinessRulesEventArgs<KstProjectUser> e)
        {
            Task.Run(()=> { 
                // Preferimos hacerlo en un hilo diferente para no detener la respuesta rápida
                var user = BR.KstProxyUsersBR.Instance.GetBy(p=> p.GuidUser == e.Item.GuidUser).FirstOrDefault();
                var project = BR.KstProjectsBR.Instance.GetBy(p=> p.GuidProject == e.Item.GuidProject).FirstOrDefault();
                SFS.Core.Net.Mail.SendMailAsync(user.Email, "Se le agregado a un proyecto", "Se le ha agregado al proyecto " + project.Name , e.ContextRequest);
            });
        }
    }
}
