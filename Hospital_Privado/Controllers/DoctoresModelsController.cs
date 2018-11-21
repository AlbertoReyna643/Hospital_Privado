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
    public class DoctoresModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DoctoresModels
        public ActionResult Index()
        {
            var doctoresModels = db.DoctoresModels.Include(d => d.Tipo);
            return View(doctoresModels.ToList());
        }

        // GET: DoctoresModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctoresModels doctoresModels = db.DoctoresModels.Find(id);
            if (doctoresModels == null)
            {
                return HttpNotFound();
            }
            return View(doctoresModels);
        }

        // GET: DoctoresModels/Create
        public ActionResult Create()
        {
            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo");
            return View();
        }

        // POST: DoctoresModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre_Doctor,Apellido_Paterno,Apellido_Materno,Edad,Fecha_Nacimiento,Domicilio,Estado,Ciudad,Curp,TipoId")] DoctoresModels doctoresModels)
        {
            if (ModelState.IsValid)
            {
                db.DoctoresModels.Add(doctoresModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo", doctoresModels.TipoId);
            return View(doctoresModels);
        }

        // GET: DoctoresModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctoresModels doctoresModels = db.DoctoresModels.Find(id);
            if (doctoresModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo", doctoresModels.TipoId);
            return View(doctoresModels);
        }

        // POST: DoctoresModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre_Doctor,Apellido_Paterno,Apellido_Materno,Edad,Fecha_Nacimiento,Domicilio,Estado,Ciudad,Curp,TipoId")] DoctoresModels doctoresModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctoresModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo", doctoresModels.TipoId);
            return View(doctoresModels);
        }

        // GET: DoctoresModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctoresModels doctoresModels = db.DoctoresModels.Find(id);
            if (doctoresModels == null)
            {
                return HttpNotFound();
            }
            return View(doctoresModels);
        }

        // POST: DoctoresModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DoctoresModels doctoresModels = db.DoctoresModels.Find(id);
            db.DoctoresModels.Remove(doctoresModels);
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
