﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace login.Controllers
{
    public class denegadoController : Controller
    {
        // GET: denegado
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    }
}