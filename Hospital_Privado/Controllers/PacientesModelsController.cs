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
    public class PacientesModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PacientesModels
        public ActionResult Index()
        {
            var pacientesModels = db.PacientesModels.Include(p => p.Tipo);
            return View(pacientesModels.ToList());
        }

        // GET: PacientesModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PacientesModels pacientesModels = db.PacientesModels.Find(id);
            if (pacientesModels == null)
            {
                return HttpNotFound();
            }
            return View(pacientesModels);
        }

        // GET: PacientesModels/Create
        public ActionResult Create()
        {
            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo");
            return View();
        }

        // POST: PacientesModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre_Paciente,Apellido_Paterno,Apellido_Materno,Edad,Fecha_Nacimiento,Domicilio,Estado,Ciudad,Curp,TipoId")] PacientesModels pacientesModels)
        {
            if (ModelState.IsValid)
            {
                db.PacientesModels.Add(pacientesModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo", pacientesModels.TipoId);
            return View(pacientesModels);
        }

        // GET: PacientesModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PacientesModels pacientesModels = db.PacientesModels.Find(id);
            if (pacientesModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo", pacientesModels.TipoId);
            return View(pacientesModels);
        }

        // POST: PacientesModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre_Paciente,Apellido_Paterno,Apellido_Materno,Edad,Fecha_Nacimiento,Domicilio,Estado,Ciudad,Curp,TipoId")] PacientesModels pacientesModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pacientesModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo", pacientesModels.TipoId);
            return View(pacientesModels);
        }

        // GET: PacientesModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PacientesModels pacientesModels = db.PacientesModels.Find(id);
            if (pacientesModels == null)
            {
                return HttpNotFound();
            }
            return View(pacientesModels);
        }

        // POST: PacientesModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PacientesModels pacientesModels = db.PacientesModels.Find(id);
            db.PacientesModels.Remove(pacientesModels);
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
