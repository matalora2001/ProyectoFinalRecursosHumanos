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
    
    public partial class Licencia
    {
        public int Id_licencia { get; set; }
        public int Id_Empleado { get; set; }
        public System.DateTime Inicio_Permiso { get; set; }
        public System.DateTime Fin_Permiso { get; set; }
        public string Motivo { get; set; }
        public string Comentario { get; set; }
    
        public virtual Empleado Empleado { get; set; }
    }
}
