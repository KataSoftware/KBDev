 
 
 
 
// <Template>
//   <SolutionTemplate>EF POCO 1</SolutionTemplate>
//   <Version>1.1422.1</Version>
//   <Update>True</Update>
// </Template>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using SFS.Core.Security.BusinessObjects;

using System.IO;
using SFS.Core.Cache;
using Microsoft.EntityFrameworkCore;
using  KS.Time.BusinessObjects;
using System.Data;
//using System.Data.Entity.Infrastructure;
using SFS.Core.My;


namespace KS.Time.BR
{


	      public class EFContext :  KSTimeContext
    {
        public EFContext(): base(SFS.Core.Configuration.ConfigurationSettings.GetConnectionString("KSTimeContext", "KS.Time", null))
        {
		 this.Database.SetCommandTimeout(300);
        }
        public EFContext(ContextRequest contextRequest): base(SFS.Core.Configuration.ConfigurationSettings.GetConnectionString("KSTimeContext", "KS.Time", contextRequest))
        {
		 this.Database.SetCommandTimeout(300);
        }
      


    }

}
