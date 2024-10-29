using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Ncf> Ncf { get; set; }
        public DbSet<TipoNcf> TipoNcf { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Tables

            modelBuilder.Entity<Cliente>()
            .ToTable("Clientes");

            modelBuilder.Entity<Factura>()
            .ToTable("Facturas");

            modelBuilder.Entity<DetalleFactura>()
            .ToTable("DetalleFacturas");

            modelBuilder.Entity<Producto>()
            .ToTable("Productos");

            modelBuilder.Entity<Ncf>()
            .ToTable("Ncfs");

            modelBuilder.Entity<TipoNcf>()
            .ToTable("TipoNcfs");


            #endregion



            #region "Primary Key"

            modelBuilder.Entity<Cliente>()
            .HasKey(c => c.Id);

            modelBuilder.Entity<Factura>()
            .HasKey(f => f.Id);

            modelBuilder.Entity<DetalleFactura>()
            .HasKey(df => df.Id);

            modelBuilder.Entity<Producto>()
            .HasKey(p => p.Id);

            modelBuilder.Entity<Ncf>()
            .HasKey(n => n.Id);

            modelBuilder.Entity<TipoNcf>()
            .HasKey(tn => tn.Id);

            #endregion

            #region Relationships

            modelBuilder.Entity<Cliente>()
            .HasMany(c => c.Facturas)
            .WithOne(f => f.Cliente)
            .HasForeignKey(f => f.ClienteId)
            .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Ncf>()
            .HasOne(n => n.Factura)
            .WithOne(f => f.Ncf)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TipoNcf>()
            .HasMany(tn => tn.Ncfs)
            .WithOne(n => n.TipoNcf)
            .HasForeignKey(n => n.TipoNcfId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DetalleFactura>()
            .HasOne(df => df.Factura)
            .WithMany(f => f.Productos)
            .HasForeignKey(df => df.FacturaId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DetalleFactura>()
            .HasOne(df => df.Producto)
            .WithMany(p => p.Facturas)
            .HasForeignKey(df => df.ProductoId)
            .OnDelete(DeleteBehavior.NoAction);



            #endregion

        }
    }
}