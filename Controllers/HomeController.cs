﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            // ViewBag.Message = "Your application description page.";
            ViewBag.json = new Client.Client().getJson();
            //System.Diagnostics.Debug.WriteLine(ViewBag.json);
            ViewBag.cases = new Client.Client().getCases();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}