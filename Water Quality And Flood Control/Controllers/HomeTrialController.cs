using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Water_Quality_And_Flood_Control.Controllers;
using System.Diagnostics;


namespace Water_Quality_And_Flood_Control.Controllers
{
    [HandleError]
    public class HomeTrialController : Controller
    {
        

        // GET: HomeTrial
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminView
        public ActionResult AdminView()
        {
            return View();
        }

        // GET: Home Page
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult MapsLeaflet()
        {
            return View();
        }

        // GET: Sensor Interface
        public ActionResult SensorInterface()
        {
            //MOCK Sensor Input. The data passes from sensor/API to controller(this) to view(SensorInterface). 
            //View Validates . 
            //If Validation successful, then data passes from view(SensorInterface) to controller(this) to database(Controller/SensorData --> SE_CodingProject).
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

        // GET: Public User Landing Page
        public ActionResult LabGraphReportGen()
        {
            return View();
        }

        // GET: Public User Landing Page
        public ActionResult PublicUserLandingPage()
        {
            return View();
        }

        // GET: Laboratory User Landing Page
        public ActionResult LaboratoryUserLandingPage()
        {
            return View();
        }

        public ActionResult UserInterface()
        {
            return View();
        }

        // GET: PublicUser Interface
        public ActionResult PublicUser()
        {
            //MOCK Value retrival from database(/Controller/SensorData and LocationData  ---> SE_CodingProject). 
            //Data passes from database(SE_CodingProject) to controller(this) to view(PublicUser).
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
            //MOCK Value retrival from database(/controller/SensorData ---> SE_CodingProject). 
            //Data passes from database(SE_CodingProject) to controller to view(LaboratoryUser).
            //View validates(LaboratoryUser).
            //If validation successfull, then data passes from view(LaboratoryUser) to controller(this) to database(/Controller/SensorData --> SE_CodingProject).
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
        
        public ActionResult drawTempGraph() //method that draws the temperature graph when called
        {
            
                var myChart = new Chart(width: 200, height: 200)
                    .AddTitle("Voltage Readings")
                      .AddSeries(
                      name: "Voltage Over Time",
                      xValue: new[] { "11/1/18 9:17:22", "11/2/18 9:18:22", "11/3/18 9:19:22", "11/4/18 14:11:22", "11/5/18 14:11:22","11/6/18 14:11:22","11/7/18 14:11:22","11/8/18 14:11:22","11/9/18 14:11:22","11/10/18 14:11:22","11/11/18 14:11:22","11/12/18 14:11:00","11/13/18 14:11:22","11/15/18 14:11:22","11/16/18 14:11:22" },
                      yValues: new[] { "39",
"33",
"31",
"40",
"36",
"35",
"35",
"31",
"39",
"33",
"39",
"39",
"38",
"36",
"31",
})
                    .Write("PNG");


                return null;
            



        }

        public ActionResult drawWaterLevelGraph()
        {
            var myChart = new Chart(width: 200, height: 200)
                    .AddTitle("Water Level Above Warning Level")
                      .AddSeries(
                      name: "Voltage Over Time",
                      xValue: new[] { "11/1/18 9:17:22", "11/2/18 9:18:22", "11/3/18 9:19:22", "11/4/18 14:11:22", "11/5/18 14:11:22", "11/6/18 14:11:22", "11/7/18 14:11:22", "11/8/18 14:11:22", "11/9/18 14:11:22", "11/10/18 14:11:22", "11/11/18 14:11:22", "11/12/18 14:11:00", "11/13/18 14:11:22", "11/15/18 14:11:22", "11/16/18 14:11:22" },
                      yValues: new[] { "16",
"20",
"9",
"1",
"13",
"13",
"14",
"17",
"17",
"5",
"16",
"10",
"16",
"20",
"9",
})
                    .Write("PNG");


            return null;
        }

        public ActionResult drawO2Graph()
        {
            var myChart = new Chart(width: 200, height: 200)
                    .AddTitle("Dissolved O2 Readings")
                      .AddSeries(
                      name: "Voltage Over Time",
                      xValue: new[] { "11/1/18 9:17:22", "11/2/18 9:18:22", "11/3/18 9:19:22", "11/4/18 14:11:22", "11/5/18 14:11:22", "11/6/18 14:11:22", "11/7/18 14:11:22", "11/8/18 14:11:22", "11/9/18 14:11:22", "11/10/18 14:11:22", "11/11/18 14:11:22", "11/12/18 14:11:00", "11/13/18 14:11:22", "11/15/18 14:11:22", "11/16/18 14:11:22" },
                      yValues: new[] { "4",
"7",
"8",
"20",
"6",
"6",
"1",
"2",
"4",
"1",
"3",
"10",
"15",
"3",
"1",
})
                    .Write("PNG");


            return null;
        }

        public ActionResult drawpHGraph()
        {
            var myChart = new Chart(width: 200, height: 200)
                    .AddTitle("pH Readings")
                      .AddSeries(
                      name: "Voltage Over Time",
                      xValue: new[] { "11/1/18 9:17:22", "11/2/18 9:18:22", "11/3/18 9:19:22", "11/4/18 14:11:22", "11/5/18 14:11:22", "11/6/18 14:11:22", "11/7/18 14:11:22", "11/8/18 14:11:22", "11/9/18 14:11:22", "11/10/18 14:11:22", "11/11/18 14:11:22", "11/12/18 14:11:00", "11/13/18 14:11:22", "11/15/18 14:11:22", "11/16/18 14:11:22" },
                      yValues: new[] { "4",
"6",
"7",
"3",
"7",
"13",
"9",
"11",
"5",
"12",
"10",
"7",
"7",
"4",
"2",
})
                    .Write("PNG");


            return null;
        }

        public ActionResult drawCurrentGraph()
        {
            var myChart = new Chart(width: 200, height: 200)
                    .AddTitle("Current Speed Readings")
                      .AddSeries(
                      name: "Voltage Over Time",
                      xValue: new[] { "11/1/18 9:17:22", "11/2/18 9:18:22", "11/3/18 9:19:22", "11/4/18 14:11:22", "11/5/18 14:11:22", "11/6/18 14:11:22", "11/7/18 14:11:22", "11/8/18 14:11:22", "11/9/18 14:11:22", "11/10/18 14:11:22", "11/11/18 14:11:22", "11/12/18 14:11:00", "11/13/18 14:11:22", "11/15/18 14:11:22", "11/16/18 14:11:22" },
                      yValues: new[] { "30",
"7",
"7",
"6",
"17",
"12",
"1",
"16",
"13",
"1",
"14",
"10",
"25",
"4",
"25"
})
                    .Write("PNG");


            return null;
        }


    }

    
}