using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DongXu.MVC.Controllers
{
    using DongXu.Services;
    using DongXu.Entity;
    using DongXu.IServices;
    public class BlocController : Controller
    {
        // GET: Bloc
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 集团层级树显示页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Bloc()
        {
            return View();
        }
      
       
        //public ActionResult GetDesignTreeData()
        //{
        //    var result = BlocServices();
        //    List<Bloc> treeModels = new List<Bloc>();
        //    bool open = false;
        //    foreach (var design in result.Designs)
        //    {
        //        if (design.ParentId == Guid.Empty)
        //            open = true;
        //        else open = false;
        //        treeModels.Add(new Entity.Bloc() { BlocID = design.Id.ToString(), PID = design.ParentId.ToString(), BlocName = design.Name, IsOrNo = design.Remarks ?? ""});
        //    }
        //    return Json(treeModels, JsonRequestBehavior.AllowGet);
        //}
    }
}