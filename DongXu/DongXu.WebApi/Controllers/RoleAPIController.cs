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
    [RoutePrefix("Role")]
    public class RoleAPIController : ApiController
    {
        public IRoleService roleService { get; set; }
        [HttpGet]
        [Route("GetRoles")]
        public List<Roles> GetRoles(string name)
        {
            return roleService.GetRoles(name);
        }
        [HttpPost]
        [Route("AddRoles")]
        public int AddRoles(Roles role)
        {
            return roleService.AddRoles(role);
        }
        [HttpGet]
        [Route("RolesByID")]
        public List<ShowRoles> RolesByID(int id)
        {
            return roleService.RolesByID(id);
        }
        [HttpPost]
        [Route("UpdateRoles")]
        public int UpdateRoles(Roles role)
        {
            return roleService.UpdateRoles(role);
        }
        //public List<Roles> GetSearch(string name)
        //{
        //    return roleService.GetSearch(name);
        //}
        [HttpGet]
        [Route("DelRoles")]
        public int DelRoles(int id)
        {
            return roleService.DelRoles(id);
        }
    }
}
