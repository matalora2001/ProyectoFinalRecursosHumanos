//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinalRecursosHumanos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vacacions
    {
        public int Id_Vacacion { get; set; }
        public int Id_Empleado { get; set; }
        public System.DateTime Inicio_Vacaciones { get; set; }
        public System.DateTime Fin_Vacaciones { get; set; }
        public int Año { get; set; }
        public string Comentario { get; set; }
    
        public virtual Empleadoes Empleadoes { get; set; }
    }
}
