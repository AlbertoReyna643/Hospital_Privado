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
    public class LaboratoriosModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: LaboratoriosModels
        public ActionResult Index()
        {
            return View(db.LaboratoriosModels.ToList());
        }

        // GET: LaboratoriosModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaboratoriosModels laboratoriosModels = db.LaboratoriosModels.Find(id);
            if (laboratoriosModels == null)
            {
                return HttpNotFound();
            }
            return View(laboratoriosModels);
        }

        // GET: LaboratoriosModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LaboratoriosModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Laboratorio")] LaboratoriosModels laboratoriosModels)
        {
            if (ModelState.IsValid)
            {
                db.LaboratoriosModels.Add(laboratoriosModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(laboratoriosModels);
        }

        // GET: LaboratoriosModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaboratoriosModels laboratoriosModels = db.LaboratoriosModels.Find(id);
            if (laboratoriosModels == null)
            {
                return HttpNotFound();
            }
            return View(laboratoriosModels);
        }

        // POST: LaboratoriosModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Laboratorio")] LaboratoriosModels laboratoriosModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(laboratoriosModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(laboratoriosModels);
        }

        // GET: LaboratoriosModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LaboratoriosModels laboratoriosModels = db.LaboratoriosModels.Find(id);
            if (laboratoriosModels == null)
            {
                return HttpNotFound();
            }
            return View(laboratoriosModels);
        }

        // POST: LaboratoriosModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LaboratoriosModels laboratoriosModels = db.LaboratoriosModels.Find(id);
            db.LaboratoriosModels.Remove(laboratoriosModels);
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
