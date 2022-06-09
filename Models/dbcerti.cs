using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AppWEB.Models
{
    public partial class dbcerti : DbContext
    {
        public dbcerti()
            : base("name=dbcerti")
        {
        }

        public virtual DbSet<Certificado> Certificado { get; set; }
        public virtual DbSet<Solicitante> Solicitante { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<TipoTramite> TipoTramite { get; set; }
        public virtual DbSet<Tramite> Tramite { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Certificado>()
                .Property(e => e.ubicacion_predio)
                .IsUnicode(false);

            modelBuilder.Entity<Certificado>()
                .Property(e => e.validar_pago)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitante>()
                .Property(e => e.numero_doc)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitante>()
                .Property(e => e.fechanac)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitante>()
                .Property(e => e.fechaemi)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitante>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitante>()
                .Property(e => e.apellidop)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitante>()
                .Property(e => e.apellidom)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitante>()
                .Property(e => e.celular)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitante>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<Solicitante>()
                .Property(e => e.confirmar_correo)
                .IsUnicode(false);

            modelBuilder.Entity<TipoDocumento>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoTramite>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoTramite>()
                .Property(e => e.costo)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Tramite>()
                .Property(e => e.descripcion)
                .IsUnicode(false);
        }
    }
}
