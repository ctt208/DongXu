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
    }
}