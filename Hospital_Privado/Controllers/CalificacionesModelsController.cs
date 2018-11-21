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
    public class CalificacionesModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CalificacionesModels
        public ActionResult Index()
        {
            var calificacionesModels = db.CalificacionesModels.Include(c => c.Doctor);
            return View(calificacionesModels.ToList());
        }

        // GET: CalificacionesModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalificacionesModels calificacionesModels = db.CalificacionesModels.Find(id);
            if (calificacionesModels == null)
            {
                return HttpNotFound();
            }
            return View(calificacionesModels);
        }

        // GET: CalificacionesModels/Create
        public ActionResult Create()
        {
            ViewBag.DoctorId = new SelectList(db.DoctoresModels, "Id", "Nombre_Doctor");
            return View();
        }

        // POST: CalificacionesModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Comentarios,Calificacion,DoctorId")] CalificacionesModels calificacionesModels)
        {
            if (ModelState.IsValid)
            {
                db.CalificacionesModels.Add(calificacionesModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DoctorId = new SelectList(db.DoctoresModels, "Id", "Nombre_Doctor", calificacionesModels.DoctorId);
            return View(calificacionesModels);
        }

        // GET: CalificacionesModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalificacionesModels calificacionesModels = db.CalificacionesModels.Find(id);
            if (calificacionesModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.DoctorId = new SelectList(db.DoctoresModels, "Id", "Nombre_Doctor", calificacionesModels.DoctorId);
            return View(calificacionesModels);
        }

        // POST: CalificacionesModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Comentarios,Calificacion,DoctorId")] CalificacionesModels calificacionesModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calificacionesModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DoctorId = new SelectList(db.DoctoresModels, "Id", "Nombre_Doctor", calificacionesModels.DoctorId);
            return View(calificacionesModels);
        }

        // GET: CalificacionesModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalificacionesModels calificacionesModels = db.CalificacionesModels.Find(id);
            if (calificacionesModels == null)
            {
                return HttpNotFound();
            }
            return View(calificacionesModels);
        }

        // POST: CalificacionesModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CalificacionesModels calificacionesModels = db.CalificacionesModels.Find(id);
            db.CalificacionesModels.Remove(calificacionesModels);
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
