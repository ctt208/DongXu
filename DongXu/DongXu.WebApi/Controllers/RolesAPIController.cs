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
    [RoutePrefix("Role")]
    public class RolesAPIController : ApiController
    {
        public IRoleService roleService { get; set; }
        /// <summary>
        /// 角色显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetRoles")]
        public List<Roles> GetRoles()
        {
            return roleService.GetRoles();
        }
        /// <summary>
        /// 角色删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DelteRole")]
        public int DelteRole(int id)
        {
            return roleService.DelteRole(id);
        }
        /// <summary>
        /// 角色查询
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetRolescha")]
        public List<Roles> GetRolescha(string name)
        {
            return roleService.GetRolescha(name);
        }
        /// <summary>
        /// 角色添加
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddRoles")]
        public int AddRoles(Roles r)
        {
            return roleService.AddRoles(r);
        }
    }
}
