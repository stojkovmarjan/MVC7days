using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC7days.Controllers
{
    public class TestController : Controller
    {
        /* GET: Test
        public ActionResult Index()
        {
            return View();
        }
        */

        public string GetString()
        {
            return "Hallo World is old now. It's time for wassup bro";
        }
        
    }
}