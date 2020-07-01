
using KS.Time.BusinessObjects;
using SFS.Core.BR;
using System;
using System.Collections.Generic;
using System.Text;

namespace KS.Time.BR
{
    public partial class KstActivitiesBR
    {
        private void UpdateCache()
        {
            SFS.Core.Cache.Caching.Remove("all-activities");
        }
        partial void OnUpdatedAgile(object sender, BusinessRulesEventArgs<KstActivity> e)
        {
            this.UpdateCache();
        }
        partial void OnCreated(object sender, BusinessRulesEventArgs<KstActivity> e)
        {
            this.UpdateCache();
        }
        partial void OnDeleted(object sender, BusinessRulesEventArgs<KstActivity> e)
        {
            this.UpdateCache();
        }

        partial void OnGetting(object sender, BusinessRulesEventArgs<KstActivity> e)
        {
            e.Filter.AppendFilter($"it.CreatedBy = \"{e.ContextRequest.User.GuidUser}\"");
        }

    }
}
