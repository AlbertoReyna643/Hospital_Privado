using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Privado.Models
{
	public class PacientesModels
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Nombre_Paciente { get; set; }
		[Required]
		public string Apellido_Paterno { get; set; }
		[Required]
		public string Apellido_Materno { get; set; }
		[Required]
		public int Edad { get; set; }
		[Required]
		public string Fecha_Nacimiento { get; set; }
		[Required]
		public string Domicilio { get; set; }
		[Required]
		public string Estado { get; set; }
		[Required]
		public string Ciudad { get; set; }
		[Required]
		public string Curp { get; set; }

		public TipoUsuariosModels Tipo { get; set; }
		public int? TipoId { get; set; }
	}
}