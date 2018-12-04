﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital_Privado.Models
{
	public class LaboratoriosModels
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Laboratorio { get; set; }
		public string Descripcion { get; set; }
	}
}