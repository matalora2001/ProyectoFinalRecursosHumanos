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
    
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            this.Licencias = new HashSet<Licencia>();
            this.Permisoes = new HashSet<Permiso>();
            this.Salida_Empleado = new HashSet<Salida_Empleado>();
            this.Vacacions = new HashSet<Vacacion>();
        }
    
        public int Id_Empleado { get; set; }
        public string CodigoEmpleado { get; set; }
        public string Nombre_Empleado { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public int Id_Depto { get; set; }
        public int Id_Cargo { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public decimal Salario { get; set; }
        public bool status { get; set; }
    
        public virtual Cargo Cargo { get; set; }
        public virtual Departamento Departamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Licencia> Licencias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permiso> Permisoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salida_Empleado> Salida_Empleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vacacion> Vacacions { get; set; }
    }
}