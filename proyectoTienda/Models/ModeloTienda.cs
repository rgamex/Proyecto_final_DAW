namespace proyectoTienda.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloTienda : DbContext
    {
        public ModeloTienda()
            : base("name=ModeloTienda")
        {
        }

        public virtual DbSet<carrito> carrito { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Direccion_envio> Direccion_envio { get; set; }
        public virtual DbSet<Direccion_factura> Direccion_factura { get; set; }
        public virtual DbSet<Fabricante> Fabricante { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<img_prod> img_prod { get; set; }
        public virtual DbSet<lineaPedido> lineaPedido { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioPerfiles> UsuarioPerfiles { get; set; }
        public virtual DbSet<Valoraciones> Valoraciones { get; set; }
        public virtual DbSet<UsuarioFacturas> UsuarioFacturas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorias>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Categorias>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Categorias>()
                .Property(e => e.imagen)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion_envio>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion_envio>()
                .Property(e => e.Localidad)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion_envio>()
                .Property(e => e.Provincia)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion_envio>()
                .Property(e => e.ID_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion_factura>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion_factura>()
                .Property(e => e.Localidad)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion_factura>()
                .Property(e => e.Provincia)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion_factura>()
                .Property(e => e.ID_Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Fabricante>()
                .Property(e => e.imagen)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.ID_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<img_prod>()
                .Property(e => e.ruta)
                .IsUnicode(false);

            modelBuilder.Entity<img_prod>()
                .Property(e => e.descripción)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.correoE)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<UsuarioPerfiles>()
                .Property(e => e.ID_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Valoraciones>()
                .Property(e => e.opinion)
                .IsUnicode(false);

            modelBuilder.Entity<Valoraciones>()
                .Property(e => e.ID_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<UsuarioFacturas>()
                .Property(e => e.ID_usuario)
                .IsUnicode(false);
        }
    }
}
