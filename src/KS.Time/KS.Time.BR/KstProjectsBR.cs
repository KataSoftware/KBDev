using KS.Time.BusinessObjects;
using SFS.Core.BR;
using System;
using System.Collections.Generic;
using System.Text;

namespace KS.Time.BR
{
    public partial class KstProjectsBR
    {
        partial void OnGetting(object sender, BusinessRulesEventArgs<KstProject> e)
        {
            if (e.ContextRequest.CurrentContext.IsUserInRole(e.ContextRequest.User, e.ContextRequest.Company, "KSTime-employee", e.ContextRequest)) { 
                
            }
        }
        partial void OnQuerySettings(object sender, BusinessRulesEventArgs<KstProject> e)
        {
           
            e.SetQueryComputedField(KstProject.PropertyNames.NumActivities,
               $"it.{KstProject.PropertyNames.KstActivities}.Where({SFS.Core.Linq.Dynamic.IsNotDeleted}).Count()");
              //"it.KstActivities.Where(IsDeleted = null OR IsDeleted = false).Count()"
            e.SetQueryComputedField(KstProject.PropertyNames.NumUsers,
              $"it.{KstProject.PropertyNames.KstProjectUsers}.Where({SFS.Core.Linq.Dynamic.IsNotDeleted}).Count()");

        }
    }
}
