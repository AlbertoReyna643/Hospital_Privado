using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hospital_Privado.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Hospital_Privado.Controllers
{
    public class TipoUsuariosModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoUsuariosModels
        public ActionResult Index()
        {
			if (Request.IsAuthenticated)
			{
				var currentUserId = User.Identity.GetUserId();
				var manager = new UserManager<Hospital_Privado.Models.ApplicationUser>(new UserStore<Hospital_Privado.Models.ApplicationUser>(new Hospital_Privado.Models.ApplicationDbContext()));
				var currentUser = manager.FindById(currentUserId);
				var RolId = currentUser.RolID;
				ViewBag.rol = RolId;
				var user = currentUser.UserName;
				ViewBag.user = user;
				var nombre = currentUser.Nombre;
				ViewBag.nom = nombre;
			}
			return View(db.TipoUsuariosModels.ToList());
        }

        // GET: TipoUsuariosModels/Details/5
        public ActionResult Details(int? id)
        {
			if (Request.IsAuthenticated)
			{
				var currentUserId = User.Identity.GetUserId();
				var manager = new UserManager<Hospital_Privado.Models.ApplicationUser>(new UserStore<Hospital_Privado.Models.ApplicationUser>(new Hospital_Privado.Models.ApplicationDbContext()));
				var currentUser = manager.FindById(currentUserId);
				var RolId = currentUser.RolID;
				ViewBag.rol = RolId;
				var user = currentUser.UserName;
				ViewBag.user = user;
				var nombre = currentUser.Nombre;
				ViewBag.nom = nombre;
			}
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
			if (Request.IsAuthenticated)
			{
				var currentUserId = User.Identity.GetUserId();
				var manager = new UserManager<Hospital_Privado.Models.ApplicationUser>(new UserStore<Hospital_Privado.Models.ApplicationUser>(new Hospital_Privado.Models.ApplicationDbContext()));
				var currentUser = manager.FindById(currentUserId);
				var RolId = currentUser.RolID;
				ViewBag.rol = RolId;
				var user = currentUser.UserName;
				ViewBag.user = user;
				var nombre = currentUser.Nombre;
				ViewBag.nom = nombre;
			}
			return View();
        }

        // POST: TipoUsuariosModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Tipo,Descripcion")] TipoUsuariosModels tipoUsuariosModels)
        {
			if (Request.IsAuthenticated)
			{
				var currentUserId = User.Identity.GetUserId();
				var manager = new UserManager<Hospital_Privado.Models.ApplicationUser>(new UserStore<Hospital_Privado.Models.ApplicationUser>(new Hospital_Privado.Models.ApplicationDbContext()));
				var currentUser = manager.FindById(currentUserId);
				var RolId = currentUser.RolID;
				ViewBag.rol = RolId;
				var user = currentUser.UserName;
				ViewBag.user = user;
				var nombre = currentUser.Nombre;
				ViewBag.nom = nombre;
			}
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
			if (Request.IsAuthenticated)
			{
				var currentUserId = User.Identity.GetUserId();
				var manager = new UserManager<Hospital_Privado.Models.ApplicationUser>(new UserStore<Hospital_Privado.Models.ApplicationUser>(new Hospital_Privado.Models.ApplicationDbContext()));
				var currentUser = manager.FindById(currentUserId);
				var RolId = currentUser.RolID;
				ViewBag.rol = RolId;
				var user = currentUser.UserName;
				ViewBag.user = user;
				var nombre = currentUser.Nombre;
				ViewBag.nom = nombre;
			}
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
			if (Request.IsAuthenticated)
			{
				var currentUserId = User.Identity.GetUserId();
				var manager = new UserManager<Hospital_Privado.Models.ApplicationUser>(new UserStore<Hospital_Privado.Models.ApplicationUser>(new Hospital_Privado.Models.ApplicationDbContext()));
				var currentUser = manager.FindById(currentUserId);
				var RolId = currentUser.RolID;
				ViewBag.rol = RolId;
				var user = currentUser.UserName;
				ViewBag.user = user;
				var nombre = currentUser.Nombre;
				ViewBag.nom = nombre;
			}
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
			if (Request.IsAuthenticated)
			{
				var currentUserId = User.Identity.GetUserId();
				var manager = new UserManager<Hospital_Privado.Models.ApplicationUser>(new UserStore<Hospital_Privado.Models.ApplicationUser>(new Hospital_Privado.Models.ApplicationDbContext()));
				var currentUser = manager.FindById(currentUserId);
				var RolId = currentUser.RolID;
				ViewBag.rol = RolId;
				var user = currentUser.UserName;
				ViewBag.user = user;
				var nombre = currentUser.Nombre;
				ViewBag.nom = nombre;
			}
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
			if (Request.IsAuthenticated)
			{
				var currentUserId = User.Identity.GetUserId();
				var manager = new UserManager<Hospital_Privado.Models.ApplicationUser>(new UserStore<Hospital_Privado.Models.ApplicationUser>(new Hospital_Privado.Models.ApplicationDbContext()));
				var currentUser = manager.FindById(currentUserId);
				var RolId = currentUser.RolID;
				ViewBag.rol = RolId;
				var user = currentUser.UserName;
				ViewBag.user = user;
				var nombre = currentUser.Nombre;
				ViewBag.nom = nombre;
			}
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
