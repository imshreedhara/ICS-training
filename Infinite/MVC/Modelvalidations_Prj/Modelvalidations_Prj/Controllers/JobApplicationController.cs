﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Modelvalidations_Prj.Controllers
{
    public class JobApplicationController : Controller
    {
        // GET: JobApplication
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Models.JobApplication JA)
        {
            if (ModelState.IsValid)
                ViewBag.Result = "Form Submitted Successfully";
            else
                ViewBag.Result = "Invalid Entries, Check and Re do";
            return View();
        }
    }
}