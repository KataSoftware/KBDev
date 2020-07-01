using System;
using System.Collections.Generic;
using System.Text;
using KS.Time.BusinessObjects;
using SFS.Core.BR;
using SFS.Core.Security.BusinessObjects;
using SFS.Core.Security;
using System.Linq;
using SFS.Core.Security.BR;
namespace KS.Time.BR
{
    public partial class unProxySettingsBR
    {
        partial void OnGetting(object sender, BusinessRulesEventArgs<unProxySetting> e)
        {

            this.OnGettingSettings(sender, e);
            
        }
        

        partial void OnUpdatingAgile(object sender, BusinessRulesEventArgs<unProxySetting> e)
        {
            this.OnUpdatingAgileSettings(sender, e);


        }
    }
}
