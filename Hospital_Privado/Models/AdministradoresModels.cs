using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Privado.Models
{
	public class AdministradoresModels
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Nombre_Administrador { get; set; }
		[Required]
		public string Apellido_Paterno { get; set; }
		[Required]
		public string Apellido_Materno { get; set; }
		

	}
}