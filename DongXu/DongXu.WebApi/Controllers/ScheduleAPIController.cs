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
        public ITargetServices TargetServices { get; set; }
        /// <summary>
        /// 显示目标详情信息
        /// </summary>
        /// <returns></returns>
        [Route("GetTargetDetails")]
        [HttpGet]
        public List<TargetDetails> GetTargetDetails(string TargetName,string IndexLevelId,string targettypename,string BlocName,string DutyMan)
        {
            var targetDetailslist = targetDetailsServices.GetTargetDetails();
            if (!string.IsNullOrEmpty(TargetName))
            {
                targetDetailslist = targetDetailslist.Where(r => r.TargetName.Contains(TargetName)).ToList();
            }
            if (!string.IsNullOrEmpty(IndexLevelId))
            {
                targetDetailslist = targetDetailslist.Where(r => r.IndexLevelId == IndexLevelId).ToList();
            }
            if (!string.IsNullOrEmpty(targettypename))
            {
                targetDetailslist = targetDetailslist.Where(r => r.targettypename == targettypename).ToList();
            }
            if (!string.IsNullOrEmpty(BlocName))
            {
                targetDetailslist = targetDetailslist.Where(r => r.BlocName.Contains(BlocName)).ToList();
            }
            if (!string.IsNullOrEmpty(DutyMan))
            {
                targetDetailslist = targetDetailslist.Where(r => r.DutyMan.Contains(DutyMan)).ToList();
            }
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
        /// <summary>
        /// 根据Id显示内容
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("GetTargetDetailsById")]
        [HttpGet]
        public List<TargetDetails> GetTargetDetailsById(int Id)
        {
            return targetDetailsServices.GetTargetDetailsById(Id);
        }
        [Route("DeleteTarget")]
        [HttpGet]
        public int DeleteTarget(int Id)
        {
            return TargetServices.DeleteTarget(Id);
        }
    }
}
 