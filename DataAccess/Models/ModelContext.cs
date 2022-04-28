using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cuentum> Cuenta { get; set; } = null!;
        public virtual DbSet<Transaccion> Transaccions { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("USEROSCAR")
                .UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<Cuentum>(entity =>
            {
                entity.HasKey(e => e.IdCuenta)
                    .HasName("SYS_C008329");

                entity.ToTable("CUENTA");

                entity.Property(e => e.IdCuenta)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_CUENTA");

                entity.Property(e => e.IdUser)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID_USER");

                entity.Property(e => e.NumeroCuenta)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMERO_CUENTA");

                entity.Property(e => e.Saldo)
                    .HasColumnType("FLOAT")
                    .HasColumnName("SALDO");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Cuenta)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK_ID_USER");
            });

            modelBuilder.Entity<Transaccion>(entity =>
            {
                entity.HasKey(e => e.IdTrans)
                    .HasName("SYS_C008331");

                entity.ToTable("TRANSACCION");

                entity.Property(e => e.IdTrans)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_TRANS");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FECHA");

                entity.Property(e => e.IdCuenta)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ID_CUENTA");

                entity.Property(e => e.Monto)
                    .HasColumnType("FLOAT")
                    .HasColumnName("MONTO");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIPO");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.IdCuenta)
                    .HasConstraintName("FK_ID_CUENTA2");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("SYS_C008327");

                entity.ToTable("USUARIO");

                entity.Property(e => e.IdUser)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_USER");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASS");

                entity.Property(e => e.Token)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOKEN");
            });

            modelBuilder.HasSequence("CUENTA_SEQ");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
