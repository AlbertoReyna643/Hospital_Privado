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
    public class ConsultasModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ConsultasModels
        public ActionResult Index()
        {
            var consultasModels = db.ConsultasModels.Include(c => c.Consultorios).Include(c => c.Doctores).Include(c => c.Laboratorios).Include(c => c.Pacientes).Include(c => c.Servicios);
            return View(consultasModels.ToList());
        }

        // GET: ConsultasModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsultasModels consultasModels = db.ConsultasModels.Find(id);
            if (consultasModels == null)
            {
                return HttpNotFound();
            }
            return View(consultasModels);
        }

        // GET: ConsultasModels/Create
        public ActionResult Create()
        {
            ViewBag.ConsultoriosId = new SelectList(db.ConsultoriosModels, "Id", "Consultorios");
            ViewBag.DoctoresId = new SelectList(db.DoctoresModels, "Id", "Nombre_Doctor");
            ViewBag.LaboratoriosId = new SelectList(db.LaboratoriosModels, "Id", "Laboratorio");
            ViewBag.PacientesId = new SelectList(db.PacientesModels, "Id", "Nombre_Paciente");
            ViewBag.ServiciosId = new SelectList(db.ServiciosModels, "Id", "Servicios");
            return View();
        }

        // POST: ConsultasModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descripcion,DoctoresId,PacientesId,LaboratoriosId,ConsultoriosId,ServiciosId,Hora_Atencion,Fecha_Atencion")] ConsultasModels consultasModels)
        {
            if (ModelState.IsValid)
            {
                db.ConsultasModels.Add(consultasModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ConsultoriosId = new SelectList(db.ConsultoriosModels, "Id", "Consultorios", consultasModels.ConsultoriosId);
            ViewBag.DoctoresId = new SelectList(db.DoctoresModels, "Id", "Nombre_Doctor", consultasModels.DoctoresId);
            ViewBag.LaboratoriosId = new SelectList(db.LaboratoriosModels, "Id", "Laboratorio", consultasModels.LaboratoriosId);
            ViewBag.PacientesId = new SelectList(db.PacientesModels, "Id", "Nombre_Paciente", consultasModels.PacientesId);
            ViewBag.ServiciosId = new SelectList(db.ServiciosModels, "Id", "Servicios", consultasModels.ServiciosId);
            return View(consultasModels);
        }

        // GET: ConsultasModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsultasModels consultasModels = db.ConsultasModels.Find(id);
            if (consultasModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.ConsultoriosId = new SelectList(db.ConsultoriosModels, "Id", "Consultorios", consultasModels.ConsultoriosId);
            ViewBag.DoctoresId = new SelectList(db.DoctoresModels, "Id", "Nombre_Doctor", consultasModels.DoctoresId);
            ViewBag.LaboratoriosId = new SelectList(db.LaboratoriosModels, "Id", "Laboratorio", consultasModels.LaboratoriosId);
            ViewBag.PacientesId = new SelectList(db.PacientesModels, "Id", "Nombre_Paciente", consultasModels.PacientesId);
            ViewBag.ServiciosId = new SelectList(db.ServiciosModels, "Id", "Servicios", consultasModels.ServiciosId);
            return View(consultasModels);
        }

        // POST: ConsultasModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descripcion,DoctoresId,PacientesId,LaboratoriosId,ConsultoriosId,ServiciosId,Hora_Atencion,Fecha_Atencion")] ConsultasModels consultasModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consultasModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ConsultoriosId = new SelectList(db.ConsultoriosModels, "Id", "Consultorios", consultasModels.ConsultoriosId);
            ViewBag.DoctoresId = new SelectList(db.DoctoresModels, "Id", "Nombre_Doctor", consultasModels.DoctoresId);
            ViewBag.LaboratoriosId = new SelectList(db.LaboratoriosModels, "Id", "Laboratorio", consultasModels.LaboratoriosId);
            ViewBag.PacientesId = new SelectList(db.PacientesModels, "Id", "Nombre_Paciente", consultasModels.PacientesId);
            ViewBag.ServiciosId = new SelectList(db.ServiciosModels, "Id", "Servicios", consultasModels.ServiciosId);
            return View(consultasModels);
        }

        // GET: ConsultasModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsultasModels consultasModels = db.ConsultasModels.Find(id);
            if (consultasModels == null)
            {
                return HttpNotFound();
            }
            return View(consultasModels);
        }

        // POST: ConsultasModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConsultasModels consultasModels = db.ConsultasModels.Find(id);
            db.ConsultasModels.Remove(consultasModels);
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
