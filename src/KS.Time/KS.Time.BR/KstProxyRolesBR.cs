using System;
using System.Collections.Generic;
using System.Text;
using SFS.Core.BR;
using KS.Time.BusinessObjects;
using System.Linq;
using SFS.Core.Security.BusinessObjects;

namespace KS.Time.BR
{
   public partial class KstProxyRolesBR
    {
        partial void OnCreating(object sender, BusinessRulesEventArgs<KstProxyRole> e)
        {
          

        }
        private void OnUpdatingAndUpdatingAgile(object sender, BusinessRulesEventArgs<KstProxyRole> e)
        {
          
        }
        partial void OnUpdating(object sender, BusinessRulesEventArgs<KstProxyRole> e)
        {
            this.OnUpdatingAndUpdatingAgile(sender, e);
        }
        partial void OnUpdatingAgile(object sender, BusinessRulesEventArgs<KstProxyRole> e)
        {
            this.OnUpdatingAndUpdatingAgile(sender, e);
        }
        partial void OnTaken(object sender, BusinessRulesEventArgs<KstProxyRole> e)
        {
   

        }
    }
}
