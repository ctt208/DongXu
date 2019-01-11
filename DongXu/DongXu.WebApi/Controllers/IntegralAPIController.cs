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
    [RoutePrefix("Integral")]
    public class IntegralAPIController : ApiController
    {
        public IIntegralServices IntegralServices { get; set; }
        [Route("GetIntegral")]
        [HttpGet]
        public List<Integral> GetIntegral()
        {
            return IntegralServices.GetIntegral();
        }
    }
}
