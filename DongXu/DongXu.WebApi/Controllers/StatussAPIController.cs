using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DongXu.WebApi.Controllers
{
    using DongXu.Common;
    using DongXu.Entity;
    using DongXu.Services;
    using DongXu.IServices;
    [RoutePrefix("Statuss")]
    public class StatussAPIController : ApiController
    {
        public IStatussService statussService { get; set; }
        [HttpGet]
        [Route("GetStatusses")]
        public List<Statuss> GetStatusses()
        {
            return statussService.GetStatusses();
        }
    }
}
