﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WSRN.Controllers
{
    public class PVPController : Controller
    {
        // GET: PVP
        public ActionResult News()
        {
            return View();
        }

        public ActionResult Articles()
        {
            return View();
        }

        public ActionResult Discussion()
        {
            return View();
        }
    }
}