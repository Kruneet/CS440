using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Water_Quality_And_Flood_Control.Models;

namespace Water_Quality_And_Flood_Control.Controllers
{
    public class HomeTrialController : Controller
    {
        // GET: HomeTrial
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home Page
        public ActionResult Home()
        {
            return View();
        }

        // GET: Sensor Interface
        public ActionResult SensorInterface()
        {
            SensorData SensorInputInfo = new SensorData
            {
                AreaName = "Area 11",
                Resistance = 4,
                Voltage = 4,
                Temperature = 32,
                PHValue = 7,
                DissolvedOxygen = 12,
                RadioIsotopeLevel = "R Isotope",
                StableIsotopeLevel = "S Isotope", 
                TimeStamp = DateTime.Now,
                CurrentSpeed = 20,
                WaterLevel = 10
            };
            return View(SensorInputInfo);
        }

        // GET: User Interface
        public ActionResult UserInterface()
        {
            return View();
        }

        // GET: PublicUser Interface
        public ActionResult PublicUser()
        {
            return View();
        }

        // GET: LaboratoryUser Interface
        public ActionResult LaboratoryUser()
        {
            return View();
        }
    }
}