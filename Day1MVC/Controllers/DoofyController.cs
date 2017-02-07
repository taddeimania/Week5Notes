using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1MVC.Controllers
{
    public class DoofyController : Controller
    {
        // GET: Doofy
        public ActionResult Index()
        {
            ViewBag.myInts = new List<int>() { 1, 2, 3, 4, 5 };
            return View();
        }
    }
}