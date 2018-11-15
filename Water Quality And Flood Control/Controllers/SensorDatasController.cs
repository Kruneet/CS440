using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Water_Quality_And_Flood_Control.Controllers
{
    public class SensorDatasController : Controller
    {
        private WQAFDS_System db = new WQAFDS_System();

        // GET: SensorDatas
        public ActionResult Index()
        {
            return View(db.SensorDatas.ToList());
        }

        // GET: SensorDatas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SensorData sensorData = db.SensorDatas.Find(id);
            if (sensorData == null)
            {
                return HttpNotFound();
            }
            return View(sensorData);
        }

        // GET: SensorDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SensorDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AreaName,TimeStamp,Resistance,Voltage,Temperature,PHValue,DissolvedOxygen,RadioIsotopeLevel,StableIsotopeLevel,CurrentSpeed,WaterLevel")] SensorData sensorData)
        {
            if (ModelState.IsValid)
            {
                db.SensorDatas.Add(sensorData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sensorData);
        }

        // GET: SensorDatas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SensorData sensorData = db.SensorDatas.Find(id);
            if (sensorData == null)
            {
                return HttpNotFound();
            }
            return View(sensorData);
        }

        // POST: SensorDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AreaName,TimeStamp,Resistance,Voltage,Temperature,PHValue,DissolvedOxygen,RadioIsotopeLevel,StableIsotopeLevel,CurrentSpeed,WaterLevel")] SensorData sensorData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sensorData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sensorData);
        }

        // GET: SensorDatas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SensorData sensorData = db.SensorDatas.Find(id);
            if (sensorData == null)
            {
                return HttpNotFound();
            }
            return View(sensorData);
        }

        // POST: SensorDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SensorData sensorData = db.SensorDatas.Find(id);
            db.SensorDatas.Remove(sensorData);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
