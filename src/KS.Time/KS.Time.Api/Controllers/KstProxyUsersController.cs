using KS.Time.BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using SFS.Core.Api;
using SFS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KS.Time.Api.Controllers
{
    public partial class KstProxyUsersController
    {
        [HttpPost]
        [Route("[action]")]
        [MyAPIAuthorizeFilter]
        public ActionResult DisableUser([FromBody] ApiWrapper<KstProxyUser> data)
        {
            try
            {
                Guid guidUser = Guid.Parse(data.GetParam<string>("IdUser"));
                BR.KstProxyUsersBR.Instance.DisableUser(guidUser, this.ContextRequest);
                return ResolveApiResponse("success", null, null, null);
            }
            catch (Exception ex)
            {
                SFS.Core.My.EventLog.Exception(ex, this.ContextRequest);
                return ResolveApiResponse("error", null, null, ex.ToString());
            }
        }

        [HttpPost]
        [Route("[action]")]
        [MyAPIAuthorizeFilter]
        public ActionResult GetAllUsers([FromBody] ApiWrapper<KstProxyUser> data)
        {
            try
            {
                var contextRequest = this.ContextRequest;

                List<KstActivity> activiyies =  SFS.Core.Cache.Caching.Get("all-activities") as List<KstActivity>;
                if (activiyies == null)
                {
                    activiyies = BR.KstActivitiesBR.Instance.GetBy(p=> true, contextRequest);
                    SFS.Core.Cache.Caching.Insert("all-activites", activiyies);
                }
               

                return ResolveApiResponse("success", null, null, null);
            }
            catch (Exception ex)
            {
                SFS.Core.My.EventLog.Exception(ex, this.ContextRequest);
                return ResolveApiResponse("error", null, null, ex.ToString());
            }
        }

    }
}
