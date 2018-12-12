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
    public class DoctoresModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DoctoresModels
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
				var apepat = currentUser.Apellido_Paterno;
				ViewBag.apep = apepat;
				var apemat = currentUser.Apellido_Materno;
				ViewBag.apem = apemat;
				var edad = currentUser.Edad;
				ViewBag.edad = edad;
				var fechan = currentUser.Fecha_Nacimiento;
				ViewBag.fechan = fechan;
				var dom = currentUser.Domicilio;
				ViewBag.dom = dom;
				var edo = currentUser.Estado;
				ViewBag.edo = edo;
				var cdad = currentUser.Ciudad;
				ViewBag.cdad = cdad;
				var curp = currentUser.Curp;
				ViewBag.curp = curp;
			}
			return View(db.DoctoresModels.ToList());
        }

        // GET: DoctoresModels/Details/5
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
				var apepat = currentUser.Apellido_Paterno;
				ViewBag.apep = apepat;
				var apemat = currentUser.Apellido_Materno;
				ViewBag.apem = apemat;
				var edad = currentUser.Edad;
				ViewBag.edad = edad;
				var fechan = currentUser.Fecha_Nacimiento;
				ViewBag.fechan = fechan;
				var dom = currentUser.Domicilio;
				ViewBag.dom = dom;
				var edo = currentUser.Estado;
				ViewBag.edo = edo;
				var cdad = currentUser.Ciudad;
				ViewBag.cdad = cdad;
				var curp = currentUser.Curp;
				ViewBag.curp = curp;
			}
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
				var apepat = currentUser.Apellido_Paterno;
				ViewBag.apep = apepat;
				var apemat = currentUser.Apellido_Materno;
				ViewBag.apem = apemat;
				var edad = currentUser.Edad;
				ViewBag.edad = edad;
				var fechan = currentUser.Fecha_Nacimiento;
				ViewBag.fechan = fechan;
				var dom = currentUser.Domicilio;
				ViewBag.dom = dom;
				var edo = currentUser.Estado;
				ViewBag.edo = edo;
				var cdad = currentUser.Ciudad;
				ViewBag.cdad = cdad;
				var curp = currentUser.Curp;
				ViewBag.curp = curp;
			}
			return View();
        }

        // POST: DoctoresModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre_Doctor,Apellido_Paterno,Apellido_Materno,Edad,Fecha_Nacimiento,Domicilio,Estado,Ciudad,Curp")] DoctoresModels doctoresModels)
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
				var apepat = currentUser.Apellido_Paterno;
				ViewBag.apep = apepat;
				var apemat = currentUser.Apellido_Materno;
				ViewBag.apem = apemat;
				var edad = currentUser.Edad;
				ViewBag.edad = edad;
				var fechan = currentUser.Fecha_Nacimiento;
				ViewBag.fechan = fechan;
				var dom = currentUser.Domicilio;
				ViewBag.dom = dom;
				var edo = currentUser.Estado;
				ViewBag.edo = edo;
				var cdad = currentUser.Ciudad;
				ViewBag.cdad = cdad;
				var curp = currentUser.Curp;
				ViewBag.curp = curp;
			}
			if (ModelState.IsValid)
            {
                db.DoctoresModels.Add(doctoresModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctoresModels);
        }

        // GET: DoctoresModels/Edit/5
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
				var apepat = currentUser.Apellido_Paterno;
				ViewBag.apep = apepat;
				var apemat = currentUser.Apellido_Materno;
				ViewBag.apem = apemat;
				var edad = currentUser.Edad;
				ViewBag.edad = edad;
				var fechan = currentUser.Fecha_Nacimiento;
				ViewBag.fechan = fechan;
				var dom = currentUser.Domicilio;
				ViewBag.dom = dom;
				var edo = currentUser.Estado;
				ViewBag.edo = edo;
				var cdad = currentUser.Ciudad;
				ViewBag.cdad = cdad;
				var curp = currentUser.Curp;
				ViewBag.curp = curp;
			}
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

        // POST: DoctoresModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre_Doctor,Apellido_Paterno,Apellido_Materno,Edad,Fecha_Nacimiento,Domicilio,Estado,Ciudad,Curp")] DoctoresModels doctoresModels)
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
				var apepat = currentUser.Apellido_Paterno;
				ViewBag.apep = apepat;
				var apemat = currentUser.Apellido_Materno;
				ViewBag.apem = apemat;
				var edad = currentUser.Edad;
				ViewBag.edad = edad;
				var fechan = currentUser.Fecha_Nacimiento;
				ViewBag.fechan = fechan;
				var dom = currentUser.Domicilio;
				ViewBag.dom = dom;
				var edo = currentUser.Estado;
				ViewBag.edo = edo;
				var cdad = currentUser.Ciudad;
				ViewBag.cdad = cdad;
				var curp = currentUser.Curp;
				ViewBag.curp = curp;
			}
			if (ModelState.IsValid)
            {
                db.Entry(doctoresModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctoresModels);
        }

        // GET: DoctoresModels/Delete/5
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
				var apepat = currentUser.Apellido_Paterno;
				ViewBag.apep = apepat;
				var apemat = currentUser.Apellido_Materno;
				ViewBag.apem = apemat;
				var edad = currentUser.Edad;
				ViewBag.edad = edad;
				var fechan = currentUser.Fecha_Nacimiento;
				ViewBag.fechan = fechan;
				var dom = currentUser.Domicilio;
				ViewBag.dom = dom;
				var edo = currentUser.Estado;
				ViewBag.edo = edo;
				var cdad = currentUser.Ciudad;
				ViewBag.cdad = cdad;
				var curp = currentUser.Curp;
				ViewBag.curp = curp;
			}
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
				var apepat = currentUser.Apellido_Paterno;
				ViewBag.apep = apepat;
				var apemat = currentUser.Apellido_Materno;
				ViewBag.apem = apemat;
				var edad = currentUser.Edad;
				ViewBag.edad = edad;
				var fechan = currentUser.Fecha_Nacimiento;
				ViewBag.fechan = fechan;
				var dom = currentUser.Domicilio;
				ViewBag.dom = dom;
				var edo = currentUser.Estado;
				ViewBag.edo = edo;
				var cdad = currentUser.Ciudad;
				ViewBag.cdad = cdad;
				var curp = currentUser.Curp;
				ViewBag.curp = curp;
			}
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
