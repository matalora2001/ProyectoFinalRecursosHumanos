﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinalRecursosHumanos.Models
{
    public class Permiso
    {
        [Key]
        public int Id_Permiso { get; set; }

        public int Id_Empleado { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Inicio_Permiso { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fin_Permiso { get; set; }

        [Required]
        public String Comentario { get; set; }

        public Empleado Empleado { get; set; }
    }
}