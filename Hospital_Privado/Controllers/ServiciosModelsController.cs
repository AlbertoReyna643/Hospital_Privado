using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hospital_Privado.Models;

namespace Hospital_Privado.Controllers
{
    public class ServiciosModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ServiciosModels
        public ActionResult Index()
        {
            return View(db.ServiciosModels.ToList());
        }

        // GET: ServiciosModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiciosModels serviciosModels = db.ServiciosModels.Find(id);
            if (serviciosModels == null)
            {
                return HttpNotFound();
            }
            return View(serviciosModels);
        }

        // GET: ServiciosModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiciosModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Servicios")] ServiciosModels serviciosModels)
        {
            if (ModelState.IsValid)
            {
                db.ServiciosModels.Add(serviciosModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(serviciosModels);
        }

        // GET: ServiciosModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiciosModels serviciosModels = db.ServiciosModels.Find(id);
            if (serviciosModels == null)
            {
                return HttpNotFound();
            }
            return View(serviciosModels);
        }

        // POST: ServiciosModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Servicios")] ServiciosModels serviciosModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviciosModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(serviciosModels);
        }

        // GET: ServiciosModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiciosModels serviciosModels = db.ServiciosModels.Find(id);
            if (serviciosModels == null)
            {
                return HttpNotFound();
            }
            return View(serviciosModels);
        }

        // POST: ServiciosModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiciosModels serviciosModels = db.ServiciosModels.Find(id);
            db.ServiciosModels.Remove(serviciosModels);
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
