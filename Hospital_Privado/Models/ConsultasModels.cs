using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Privado.Models
{
	public class ConsultasModels
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Descripcion { get; set; }

		public DoctoresModels Doctores { get; set; }
		public int DoctoresId { get; set; }

		public PacientesModels Pacientes { get; set; }
		public int PacientesId { get; set; }

		public LaboratoriosModels Laboratorios { get; set; }
		public int? LaboratoriosId { get; set; }

		public ConsultoriosModels Consultorios { get; set; }
		public int? ConsultoriosId { get; set; }

		public ServiciosModels Servicios { get; set; }
		public int? ServiciosId { get; set; }

		[Required]
		public int Hora_Atencion { get; set; }
		[Required]
		public string Fecha_Atencion { get; set; }
	}
}