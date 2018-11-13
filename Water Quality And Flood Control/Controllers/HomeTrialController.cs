﻿using System;
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
            //MOCK Sensor Input. The data passes from sensor to controller to view. 
            //View Validates. 
            //If Validation successful, then data passes from view to controller to database(insert).
            SensorData SensorInputInfo = new SensorData
            {
                AreaName = "Area 11",
                TimeStamp = DateTime.Now,
                Resistance = 4,
                Voltage = 4,
                Temperature = 32,
                PHValue = 7,
                DissolvedOxygen = 12,
                RadioIsotopeLevel = "R Isotope",
                StableIsotopeLevel = "S Isotope", 
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
            //MOCK Value retrival from database. Data passes from database to controller to view.
            SensorData PublicUserInfo = new SensorData
            {
                AreaName = "Area 21",
                TimeStamp = DateTime.Now,
                Temperature = 39,
                PHValue = 5,
                CurrentSpeed = 14,
                WaterLevel = 13
            };
            return View(PublicUserInfo);
        }

        // GET: LaboratoryUser Interface
        public ActionResult LaboratoryUser()
        {
            //MOCK Value retrival from database. Data passes from database to controller to view.
            //View validates.
            //If validation successfull, then data passes from view to controller to database(update).
            SensorData LabUserInfo = new SensorData
            {
                AreaName = "Area 13",
                TimeStamp = DateTime.Now,
                Resistance = 11,
                Voltage = 19,
                Temperature = 39,
                PHValue = 5,
                DissolvedOxygen = 10,
                RadioIsotopeLevel = "R2 Isotope",
                StableIsotopeLevel = "S2 Isotope",
                CurrentSpeed = 14,
                WaterLevel = 13
            };
            return View(LabUserInfo);
        }
    }
}