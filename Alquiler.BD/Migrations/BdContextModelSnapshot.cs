﻿// <auto-generated />
using System;
using Alquiler.BD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Alquiler.BD.Migrations
{
    [DbContext(typeof(BdContext))]
    partial class BdContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Alquiler.BD.Data.Entidades.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Provincia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Direcciones");
                });

            modelBuilder.Entity("Alquiler.BD.Data.Entidades.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Estados")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Alquiler.BD.Data.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("DireccionId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int?>("TipoDocumentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DireccionId");

                    b.HasIndex("TipoDocumentoId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Alquiler.BD.Data.Entidades.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DetallesProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("PrecioProducto")
                        .HasColumnType("int");

                    b.Property<string>("foto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Alquiler.BD.Data.Entidades.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NombreTipoDocumento")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("TipoDocumentos");
                });

            modelBuilder.Entity("Alquiler.BD.Data.Entidades.Persona", b =>
                {
                    b.HasOne("Alquiler.BD.Data.Entidades.Direccion", null)
                        .WithMany("Personas")
                        .HasForeignKey("DireccionId");

                    b.HasOne("Alquiler.BD.Data.Entidades.TipoDocumento", null)
                        .WithMany("Personas")
                        .HasForeignKey("TipoDocumentoId");
                });

            modelBuilder.Entity("Alquiler.BD.Data.Entidades.Producto", b =>
                {
                    b.HasOne("Alquiler.BD.Data.Entidades.Estado", "Estado")
                        .WithMany("Productos")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Alquiler.BD.Data.Entidades.Persona", "Persona")
                        .WithMany("productos")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("Alquiler.BD.Data.Entidades.Direccion", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Alquiler.BD.Data.Entidades.Estado", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Alquiler.BD.Data.Entidades.Persona", b =>
                {
                    b.Navigation("productos");
                });

            modelBuilder.Entity("Alquiler.BD.Data.Entidades.TipoDocumento", b =>
                {
                    b.Navigation("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
