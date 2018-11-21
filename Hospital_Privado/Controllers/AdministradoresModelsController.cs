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
    public class AdministradoresModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AdministradoresModels
        public ActionResult Index()
        {
            var administradoresModels = db.AdministradoresModels.Include(a => a.Tipo);
            return View(administradoresModels.ToList());
        }

		// GET: AdministradoresModels/Details/5
		public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradoresModels administradoresModels = db.AdministradoresModels.Find(id);
            if (administradoresModels == null)
            {
                return HttpNotFound();
            }
            return View(administradoresModels);
        }

        // GET: AdministradoresModels/Create
        public ActionResult Create()
        {
            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo");
            return View();
        }

        // POST: AdministradoresModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre_Administrador,Apellido_Paterno,Apellido_Materno,TipoId")] AdministradoresModels administradoresModels)
        {
            if (ModelState.IsValid)
            {
                db.AdministradoresModels.Add(administradoresModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo", administradoresModels.TipoId);
            return View(administradoresModels);
        }

        // GET: AdministradoresModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradoresModels administradoresModels = db.AdministradoresModels.Find(id);
            if (administradoresModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo", administradoresModels.TipoId);
            return View(administradoresModels);
        }

        // POST: AdministradoresModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre_Administrador,Apellido_Paterno,Apellido_Materno,TipoId")] AdministradoresModels administradoresModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administradoresModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo", administradoresModels.TipoId);
            return View(administradoresModels);
        }

        // GET: AdministradoresModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdministradoresModels administradoresModels = db.AdministradoresModels.Find(id);
            if (administradoresModels == null)
            {
                return HttpNotFound();
            }
            return View(administradoresModels);
        }

        // POST: AdministradoresModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdministradoresModels administradoresModels = db.AdministradoresModels.Find(id);
            db.AdministradoresModels.Remove(administradoresModels);
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
