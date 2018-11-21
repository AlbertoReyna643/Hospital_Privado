using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Privado.Models
{
	public class ServiciosModels
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Servicios { get; set; }
	}
}