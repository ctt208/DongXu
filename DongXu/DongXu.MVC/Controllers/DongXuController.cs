using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DongXu.MVC.Controllers
{
    using IServices;
    using Services;
    using System.Text;
    using System.Security.Cryptography;
    public class DongXuController : Controller
    {
        IntegralServices IntegralServices = new IntegralServices();
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
        /**//// <summary>
            /// MD5 16位加密 加密后密码为大写
            /// </summary>
            /// <param name="ConvertString"></param>
            /// <returns></returns>
        //[HttpPost]
        //public string GetMd5Str(string EmployeePwd)
        //{
        //    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        //    string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(EmployeePwd)), 4, 8);
        //    t2 = t2.Replace("-", "");
        //    return t2;
        //}
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
        [HttpGet]
        public JsonResult GetIntegral()
        {
            //string result =JsonConvert.SerializeObject(bll.GetSchool());
            return Json(IntegralServices.GetIntegral(),JsonRequestBehavior.AllowGet);
        }
        
    }
}