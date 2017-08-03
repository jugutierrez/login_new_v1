using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using login.seguridad;
namespace login.Controllers
{
    public class demoController : Controller
    {
        // GET: demo
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [CustomAuthorize(Roles ="0")]
        public ActionResult work1()
        {
            return View("work1");
        }
        [CustomAuthorize(Roles = "0 , 1")]
        public ActionResult work2()
        {
            return View("work2");
        }
        [CustomAuthorize(Roles = "0 , 1 ,2")]
        public ActionResult work3()
        {
            return View("work3");
        }
    }
}