﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PurpleBricksCodeEvaluation.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Index()
        {
            return View("Login");
        }

    }
}
