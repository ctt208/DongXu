using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DongXu.MVC.Controllers
{
    public class DxPageController : Controller
    {
        // GET: DxPage
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Backlog()
        {
            return View();
        }
    }
}