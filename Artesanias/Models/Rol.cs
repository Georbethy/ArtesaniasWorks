//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Artesanias.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rol
    {
        public int RolId { get; set; }
        public string NombreRol { get; set; }
        public int ClienteId { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
