using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zeh201731950157.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            ViewBag.aaa = "这是我控制器的Index动作的内容";
            return View();
        }
    }
}