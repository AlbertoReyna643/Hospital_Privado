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
    public class TipoUsuariosModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoUsuariosModels
        public ActionResult Index()
        {
            return View(db.TipoUsuariosModels.ToList());
        }

        // GET: TipoUsuariosModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoUsuariosModels tipoUsuariosModels = db.TipoUsuariosModels.Find(id);
            if (tipoUsuariosModels == null)
            {
                return HttpNotFound();
            }
            return View(tipoUsuariosModels);
        }

        // GET: TipoUsuariosModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoUsuariosModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tipo,Descripcion")] TipoUsuariosModels tipoUsuariosModels)
        {
            if (ModelState.IsValid)
            {
                db.TipoUsuariosModels.Add(tipoUsuariosModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoUsuariosModels);
        }

        // GET: TipoUsuariosModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoUsuariosModels tipoUsuariosModels = db.TipoUsuariosModels.Find(id);
            if (tipoUsuariosModels == null)
            {
                return HttpNotFound();
            }
            return View(tipoUsuariosModels);
        }

        // POST: TipoUsuariosModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Tipo,Descripcion")] TipoUsuariosModels tipoUsuariosModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoUsuariosModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoUsuariosModels);
        }

        // GET: TipoUsuariosModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoUsuariosModels tipoUsuariosModels = db.TipoUsuariosModels.Find(id);
            if (tipoUsuariosModels == null)
            {
                return HttpNotFound();
            }
            return View(tipoUsuariosModels);
        }

        // POST: TipoUsuariosModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoUsuariosModels tipoUsuariosModels = db.TipoUsuariosModels.Find(id);
            db.TipoUsuariosModels.Remove(tipoUsuariosModels);
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
