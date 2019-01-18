using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Security.Cryptography;

namespace DongXu.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        /// <summary>
        /// 用户添加页面，左面层级关系树
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}