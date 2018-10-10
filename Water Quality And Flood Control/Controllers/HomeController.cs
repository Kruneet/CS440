using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Water_Quality_And_Flood_Control.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SensorInterface()
        {  
                ViewBag.Message = "Your application description page";

                return View();
        }

        public ActionResult UserInterface()
        {
            ViewBag.Message = "Your contact page";
            return View();
        }

    }
}