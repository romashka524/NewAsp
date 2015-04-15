using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class MyController : Controller
    {
        //
        // GET: /My/
        public ActionResult id()
        {
            ViewBag.report = "По коду";
            return View();
        }

        public ActionResult print()
        {
            ViewBag.report = "По коду печать";
            return View();
        }

        public ActionResult category()
        {
            ViewBag.report = "По категории";
            return View();
        }

        public ActionResult date()
        {
            ViewBag.report = "По дате";
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
	}
}