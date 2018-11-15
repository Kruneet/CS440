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
    public class LocationDatasController : Controller
    {
        private WQAFDS_System db = new WQAFDS_System();

        // GET: LocationDatas
        public ActionResult Index()
        {
            return View(db.LocationDatas.ToList());
        }

        // GET: LocationDatas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocationData locationData = db.LocationDatas.Find(id);
            if (locationData == null)
            {
                return HttpNotFound();
            }
            return View(locationData);
        }

        // GET: LocationDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LocationDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AreaName,latitude,longitude")] LocationData locationData)
        {
            if (ModelState.IsValid)
            {
                db.LocationDatas.Add(locationData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(locationData);
        }

        // GET: LocationDatas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocationData locationData = db.LocationDatas.Find(id);
            if (locationData == null)
            {
                return HttpNotFound();
            }
            return View(locationData);
        }

        // POST: LocationDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AreaName,latitude,longitude")] LocationData locationData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(locationData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(locationData);
        }

        // GET: LocationDatas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocationData locationData = db.LocationDatas.Find(id);
            if (locationData == null)
            {
                return HttpNotFound();
            }
            return View(locationData);
        }

        // POST: LocationDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            LocationData locationData = db.LocationDatas.Find(id);
            db.LocationDatas.Remove(locationData);
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
