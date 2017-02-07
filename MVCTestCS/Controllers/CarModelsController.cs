using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCTestCS.DataLayer;

namespace MVCTestCS.Controllers
{
    public class CarModelsController : Controller
    {
        private CarDealerEntities db = new CarDealerEntities();

        // GET: CarModels
        public ActionResult Index()
        {
            var carModels = db.CarModels.Include(c => c.Manifactures);
            return View(carModels.ToList());
        }

        // GET: CarModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarModels carModels = db.CarModels.Find(id);
            if (carModels == null)
            {
                return HttpNotFound();
            }
            return View(carModels);
        }

        // GET: CarModels/Create
        public ActionResult Create()
        {
            ViewBag.ManifactureId = new SelectList(db.Manifactures, "Id", "Name");
            return View();
        }

        // POST: CarModels/Create
        // Per proteggere da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per ulteriori dettagli, vedere http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ModelName,Color,Year,CarDoor,Km,IsUsed,ManifactureId")] CarModels carModels)
        {
            if (ModelState.IsValid)
            {
                db.CarModels.Add(carModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ManifactureId = new SelectList(db.Manifactures, "Id", "Name", carModels.ManifactureId);
            return View(carModels);
        }

        // GET: CarModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarModels carModels = db.CarModels.Find(id);
            if (carModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.ManifactureId = new SelectList(db.Manifactures, "Id", "Name", carModels.ManifactureId);
            return View(carModels);
        }

        // POST: CarModels/Edit/5
        // Per proteggere da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per ulteriori dettagli, vedere http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ModelName,Color,Year,CarDoor,Km,IsUsed,ManifactureId")] CarModels carModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ManifactureId = new SelectList(db.Manifactures, "Id", "Name", carModels.ManifactureId);
            return View(carModels);
        }

        // GET: CarModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarModels carModels = db.CarModels.Find(id);
            if (carModels == null)
            {
                return HttpNotFound();
            }
            return View(carModels);
        }

        // POST: CarModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarModels carModels = db.CarModels.Find(id);
            db.CarModels.Remove(carModels);
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
