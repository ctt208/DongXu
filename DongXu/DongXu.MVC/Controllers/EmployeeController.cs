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
        public ActionResult Index()
        {
            return View();
        }
        /**//// <summary>
            /// MD5 16位加密 加密后密码为大写
            /// </summary>
            /// <param name="ConvertString"></param>
            /// <returns></returns>
            [HttpPost]
        public string GetMd5Str(string EmployeePwd)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(EmployeePwd)), 4, 8);
            t2 = t2.Replace("-", "");
            return t2;
        }
    }
}