﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TiendaEntities : DbContext
    {
        public TiendaEntities()
            : base("name=TiendaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Artesano> Artesano { get; set; }
        public virtual DbSet<Carrito> Carrito { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<DetalleCarrito> DetalleCarrito { get; set; }
        public virtual DbSet<LineaArtesnia> LineaArtesnia { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<PedidoDetalle> PedidoDetalle { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoImagen> ProductoImagen { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
    }
}
