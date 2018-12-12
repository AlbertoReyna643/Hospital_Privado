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
    public class PacientesModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PacientesModels
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
				var idd = currentUser.Id;
				ViewBag.idd = idd;
			}
			return View(db.PacientesModels.ToList());
        }

        // GET: PacientesModels/Details/5
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
				var idd = currentUser.Id;
				ViewBag.idd = idd;
			}
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
				var idd = currentUser.Id;
				ViewBag.idd = idd;
			}
			return View();
        }

        // POST: PacientesModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre_Paciente,Apellido_Paterno,Apellido_Materno,Edad,Fecha_Nacimiento,Domicilio,Estado,Ciudad,Curp")] PacientesModels pacientesModels)
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
				var idd = currentUser.Id;
				ViewBag.idd = idd;
			}
			if (ModelState.IsValid)
            {
                db.PacientesModels.Add(pacientesModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pacientesModels);
        }

        // GET: PacientesModels/Edit/5
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
				var idd = currentUser.Id;
				ViewBag.idd = idd;
			}
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

        // POST: PacientesModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre_Paciente,Apellido_Paterno,Apellido_Materno,Edad,Fecha_Nacimiento,Domicilio,Estado,Ciudad,Curp")] PacientesModels pacientesModels)
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
				var idd = currentUser.Id;
				ViewBag.idd = idd;
			}
			if (ModelState.IsValid)
            {
                db.Entry(pacientesModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pacientesModels);
        }

        // GET: PacientesModels/Delete/5
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
				var idd = currentUser.Id;
				ViewBag.idd = idd;
			}
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
				var idd = currentUser.Id;
				ViewBag.idd = idd;
			}
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
