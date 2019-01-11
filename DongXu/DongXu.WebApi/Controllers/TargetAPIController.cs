using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DongXu.WebApi.Controllers
{
    using DongXu.IServices;
    using DongXu.Entity;
    [RoutePrefix("DongXu")]
    public class TargetAPIController : ApiController
    {
        public ITargetServices TargetServices { get; set; }
        [HttpGet]
        [Route("GetTargets")]
        public List<Target> GetTargets()
        {
            return TargetServices.GetTargets();
        }

    }
}
