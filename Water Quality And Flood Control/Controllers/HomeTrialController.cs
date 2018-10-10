using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Water_Quality_And_Flood_Control.Controllers
{
    public class HomeTrialController : Controller
    {
        // GET: HomeTrial
        public ActionResult Index()
        {
            return View();
        }

        // GET: Sensor Interface
        public ActionResult SensorInterface()
        {
            return View();
        }

        // GET: User Interface
        public ActionResult UserInterface()
        {
            return View();
        }
    }
}