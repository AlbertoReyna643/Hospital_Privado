using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Hospital_Privado.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
		public int RolID { get; set; }
		public string Nombre { get; set; }
		public string Apellido_Paterno { get; set; }
		public string Apellido_Materno { get; set; }
		public int Edad { get; set; }
		public string Fecha_Nacimiento { get; set; }
		public string Domicilio { get; set; }
		public string Estado { get; set; }
		public string Ciudad { get; set; }
		public string Curp { get; set; }



		public DbSet<TipoUsuariosModels> TipoUsuarios { get; set; }
		public DbSet<AdministradoresModels> Administradores { get; set; }
		public DbSet<DoctoresModels> Doctores { get; set; }
		public DbSet<PacientesModels> Pacientes { get; set; }
		public DbSet<CalificacionesModels> Calificaciones { get; set; }
		public DbSet<UsuariosModels> Usuarios { get; set; }
		public DbSet<LaboratoriosModels> Laboratorios { get; set; }
		public DbSet<ConsultoriosModels> Consultorios { get; set; }
		public DbSet<ServiciosModels> Servicios { get; set; }
		public DbSet<ConsultasModels> Consultas { get; set; }




		public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("AzureConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

		public System.Data.Entity.DbSet<Hospital_Privado.Models.TipoUsuariosModels> TipoUsuariosModels { get; set; }
		
		public System.Data.Entity.DbSet<Hospital_Privado.Models.DoctoresModels> DoctoresModels { get; set; }

		public System.Data.Entity.DbSet<Hospital_Privado.Models.PacientesModels> PacientesModels { get; set; }

		public System.Data.Entity.DbSet<Hospital_Privado.Models.CalificacionesModels> CalificacionesModels { get; set; }

		public System.Data.Entity.DbSet<Hospital_Privado.Models.AdministradoresModels> AdministradoresModels { get; set; }

		public System.Data.Entity.DbSet<Hospital_Privado.Models.UsuariosModels> UsuariosModels { get; set; }

		public System.Data.Entity.DbSet<Hospital_Privado.Models.LaboratoriosModels> LaboratoriosModels { get; set; }

		public System.Data.Entity.DbSet<Hospital_Privado.Models.ConsultoriosModels> ConsultoriosModels { get; set; }

		public System.Data.Entity.DbSet<Hospital_Privado.Models.ServiciosModels> ServiciosModels { get; set; }

		public System.Data.Entity.DbSet<Hospital_Privado.Models.ConsultasModels> ConsultasModels { get; set; }

		//public System.Data.Entity.DbSet<Hospital_Privado.Models.ApplicationUser> ApplicationUsers { get; set; }

		//public System.Data.Entity.DbSet<Hospital_Privado.Models.ApplicationUser> ApplicationUsers { get; set; }
	}
}