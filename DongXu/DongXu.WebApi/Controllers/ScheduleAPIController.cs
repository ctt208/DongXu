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
    public class ScheduleAPIController : ApiController
    {
        public ITargetDetailsServices targetDetailsServices { get; set; }
        public ITarGetTypeServices tarGetTypeServices { get; set; }
        /// <summary>
        /// 显示目标详情信息
        /// </summary>
        /// <returns></returns>
        [Route("GetTargetDetails")]
        [HttpGet]
        public List<TargetDetails> GetTargetDetails()
        {
            var targetDetailslist = targetDetailsServices.GetTargetDetails();
            return targetDetailslist;
        }
        /// <summary>
        /// 显示目标类别信息
        /// </summary>
        /// <returns></returns>
        [Route("GetTarGetTypes")]
        [HttpGet]
        public List<TarGetType> GetTarGetTypes()
        {
            var tarGetTypeServiceslist = tarGetTypeServices.GetTarGetTypes();
            return tarGetTypeServiceslist;
        }
    }
}
 