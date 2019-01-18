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
        public IRunning runningservices { get; set; }
        /// <summary>
        /// 显示目标详情信息
        /// </summary>
        /// <returns></returns>
        [Route("GetTargetDetails")]
        [HttpGet]
        public PageBox GetTargetDetails(string TargetName,string IndexLevelId,string targettypename,string BlocName,string DutyMan,int pageindex=1)
        {
            PageBox pageBox = new PageBox();
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
            pageBox.PageIndex = pageindex;
            pageBox.PageSize = 5;
            pageBox.PageCount = targetDetailslist.Count / pageBox.PageSize + (targetDetailslist.Count % pageBox.PageSize == 0 ? 0 : 1);
            pageBox.Data = targetDetailslist.Skip((pageBox.PageIndex - 1) * pageBox.PageSize).Take(pageBox.PageSize).ToList();
            return pageBox;
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
        /// 显示运行情况
        /// </summary>
        /// <returns></returns>
        [Route("GetRunnings")]
        [HttpGet]
        public List<TargetDetails> GetRunnings()
        {
            var runningserviceslist = runningservices.GetRunnings();
            return runningserviceslist;
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
        [Route("AddTargetDetails")]
        [HttpPost]
        public int AddTargetDetails(TargetDetails targetDetails)
        {
            return targetDetailsServices.AddTargetDetails(targetDetails);
        }
        [Route("AddTarget1")]
        [HttpPost]
        public int AddTarget(Target t)
        {
            return targetDetailsServices.AddTarget(t);
        }
        [Route("GetStatuses")]
        [HttpGet]
        public List<Status> GetStatuses()
        {
            return targetDetailsServices.GetStatuses();
        }
           [Route("GetNum")]
        [HttpGet]
        public List<FeedbackNum> GetFeedbackNums()
        {
            return targetDetailsServices.GetFeedbackNums();
        }

    }
}
 