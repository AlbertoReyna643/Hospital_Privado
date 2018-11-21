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
    public class UsuariosModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UsuariosModels
        public ActionResult Index()
        {
            var usuariosModels = db.UsuariosModels.Include(u => u.Tipo);
            return View(usuariosModels.ToList());
        }

        // GET: UsuariosModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
            UsuariosModels usuariosModels = db.UsuariosModels.Find(id);
            if (usuariosModels == null)
            {
                return HttpNotFound();
            }
            return View(usuariosModels);
        }

        // GET: UsuariosModels/Create
        public ActionResult Create()
        {
            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo");
			return View();
        }

        // POST: UsuariosModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Apellido_Paterno,Apellido_Materno,Edad,Fecha_Nacimiento,Domicilio,Estado,Ciudad,Curp,TipoId")] UsuariosModels usuariosModels)
        {
            if (ModelState.IsValid)
            {
                db.UsuariosModels.Add(usuariosModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo", usuariosModels.TipoId);
            return View(usuariosModels);
        }

        // GET: UsuariosModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuariosModels usuariosModels = db.UsuariosModels.Find(id);
            if (usuariosModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo", usuariosModels.TipoId);
            return View(usuariosModels);
        }

        // POST: UsuariosModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Apellido_Paterno,Apellido_Materno,Edad,Fecha_Nacimiento,Domicilio,Estado,Ciudad,Curp,TipoId")] UsuariosModels usuariosModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuariosModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipoId = new SelectList(db.TipoUsuariosModels, "Id", "Tipo", usuariosModels.TipoId);
            return View(usuariosModels);
        }

        // GET: UsuariosModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UsuariosModels usuariosModels = db.UsuariosModels.Find(id);
            if (usuariosModels == null)
            {
                return HttpNotFound();
            }
            return View(usuariosModels);
        }

        // POST: UsuariosModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UsuariosModels usuariosModels = db.UsuariosModels.Find(id);
            db.UsuariosModels.Remove(usuariosModels);
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
