//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_Empleados.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpleadoProyecto
    {
        public int idEmpleado { get; set; }
        public int idProyecto { get; set; }
        public int horas { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual Proyecto Proyecto { get; set; }
    }
}
