using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Privado.Models
{
	public class CalificacionesModels
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Comentarios { get; set; }
		[Required]
		public int Calificacion { get; set; }

		public DoctoresModels Doctor { get; set; }
		public int? DoctorId { get; set; }
	}
}