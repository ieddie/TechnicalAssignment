﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    using Infrastructure;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }


    }
}
