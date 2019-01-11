using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DongXu.MVC.Controllers
{
    public class DongXuController : Controller
    {
        // GET: DongXu
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 登录界面
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Backlog()
        {
            return View();
        }
        /// <summary>
        /// 目标管理
        /// </summary>
        /// <returns></returns>
        public ActionResult Goal()
        {
            return View();
        }
        /// <summary>
        /// 权限管理
        /// </summary>
        /// <returns></returns>
        public ActionResult Permission()
        {
            return View();
        }
        public ActionResult RoleIndex()
        {
            return View();
        }
    }
}