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
    using Newtonsoft.Json;

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
        public PageBox GetRoles(string currentpage, string name)
        {
            var rolelist = roleService.GetRoles(name);
            if (currentpage == null)
            {
                currentpage = "";
            }
            int totlepage = rolelist.Count / 3 + (rolelist.Count % 3 == 0 ? 0 : 1);
            rolelist = rolelist.Skip((int.Parse(currentpage) - 1) * 3).Take(3).ToList();

            PageBox pagebox = new PageBox();
            pagebox.CurrentPage = int.Parse(currentpage);
            pagebox.TotlePage = totlepage;
            pagebox.PageData = rolelist;
            return pagebox;
            
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
        //[HttpGet]
        //[Route("GetRolescha")]
        //public List<Roles> GetRolescha(string name)
        //{
        //    return roleService.GetRolescha(name);
        //}
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
