using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DongXu.WebApi.Controllers
{
    using DongXu.Entity;
    using DongXu.IServices;
    using DongXu.Services;
    [RoutePrefix("DongXu")]
    public class EmploYeeAPIController : ApiController
    {
        public IEmploYeeServices EmploYeeServices { get; set; }
        [Route("AddEmploYee")]
        [HttpPost]
        public int AddEmploYee(EmploYee emploYee)
        {
            return EmploYeeServices.AddEmploYee(emploYee);
        }
    }
}
