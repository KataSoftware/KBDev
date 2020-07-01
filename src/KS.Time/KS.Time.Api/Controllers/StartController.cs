using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using KS.Time.BR;
using System.Linq;
using KS.Time.BusinessObjects;
using SFS.Core.Entities;
using SFS.Core.Api.Models;

namespace KS.Time.Api.Controllers
{
    [Area("KSTime")]
    [Route("[area]/[controller]")]
    [ApiController]
    public class StartController : KS.Time.Api.ControllerBase<ModelBase>
    {
        [HttpGet]
        [Route("[action]")]
        public  ActionResult AppVersion()
        {

            return Json(Startup.GetVersionValues());
        }
    }
}
