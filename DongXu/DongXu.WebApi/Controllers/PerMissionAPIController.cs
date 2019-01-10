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
    public class PerMissionAPIController : ApiController
    {
        public IPerMission perMissionServices { get; set; }
        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="perMission"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddPerMission")]
        public int AddPerMission(PerMission perMission)
        {
            int i= perMissionServices.AddPerMission(perMission);
            return i;
        }
        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DeletePerMission")]
        public int DeletePerMission(int id)
        {
            int i = perMissionServices.DeletePerMission(id);
            return i;
        }
        /// <summary>
        /// 根据ID显示单个权限信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetPerMissionById")]
        public PerMission GetPerMissionById(int id)
        {
            PerMission perMission = perMissionServices.GetPerMissionById(id);
            return perMission;
        }

        /// <summary>
        /// 显示权限信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetPerMissions")]
        public List<PerMission> GetPerMissions()
        {
            var list = perMissionServices.GetPerMissions();
            return list;
        }
        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="perMission"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdatePerMission")]
        public int UpdatePerMission(PerMission perMission)
        {
            int i = perMissionServices.UpdatePerMission(perMission);
            return i;
        }
    }
}
