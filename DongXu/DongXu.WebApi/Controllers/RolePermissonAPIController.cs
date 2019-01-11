using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DongXu.WebApi.Controllers
{
    using DongXu.Entity;
    using DongXu.Services;
    using DongXu.IServices;
    using Newtonsoft;
    [RoutePrefix("RolePermisson")]
    public class RolePermissonAPIController : ApiController
    {
        public IRolePermisson rolePermisson { get; set; }
        [HttpGet]
        [Route("showRolesById")]
        public List<RolePerMission> showRolesById(int id)
        {
            return rolePermisson.showRolesById(id);
        }
    }
}
