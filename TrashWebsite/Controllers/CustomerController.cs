﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashWebsite.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult CustomerHome()
        {
            return View();
        }
    }
}