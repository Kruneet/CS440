using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Water_Quality_And_Flood_Control.Models;

namespace Water_Quality_And_Flood_Control.Controllers
{
    public class SensorsDataController : Controller
    {
        // GET: SensorsData/Random
        public ActionResult Random()
        {
            var sensorData = new SensorData()
            {
                Resistance = 10
            };
            return View(sensorData);
        }
    }
}