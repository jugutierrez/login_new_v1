using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using login.ModelView;
using login.Models;
using login.seguridad;

namespace login.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [CustomAuthorize]
        public ActionResult About()
        {
            SessionPersister.username = string.Empty;
            return View();
        }

        public ActionResult Login(cuentas_viewmodel cv)
        {
            modelo_cuentas cv1 = new modelo_cuentas();
            if (string.IsNullOrEmpty(cv.cuentas.correo_electronico_persona) || string.IsNullOrEmpty(cv.cuentas.clave_persona) || cv1.login(cv.cuentas.correo_electronico_persona, cv.cuentas.clave_persona) == null)
            {
                ViewBag.Error = "cuenta invalida";
                return View("index");
            }
            SessionPersister.username = cv.cuentas.correo_electronico_persona;
            return RedirectToAction("index","demo");
        }

        [CustomAuthorize]
        public ActionResult Logout()
        {
            SessionPersister.username = string.Empty;
            return RedirectToAction("index");
        }


    }
}