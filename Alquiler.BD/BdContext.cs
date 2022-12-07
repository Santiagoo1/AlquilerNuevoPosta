using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alquiler.BD.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Alquiler.BD
{
    public class BdContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria
                { 
                    Id = 1,
                    nombre="Electrodomestico",
                    Url= "electrodomestico"
                },
                new Categoria
                {
                    Id = 2,
                    nombre = "Herramientas",
                    Url = "herramientas"
                },
                new Categoria
                {
                    Id = 3,
                    nombre = "Tecnologia",
                    Url = "tecnologia"
                },
                new Categoria
                {
                    Id = 4,
                    nombre = "Juguetes",
                    Url = "juguete"
                }

                );
        }

        public BdContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Persona> Personas { get; set; }

        public DbSet<ProductoPublicado> ProductosPublicados { get; set; }

        

        public DbSet<Direccion> Direcciones { get; set; }

        public DbSet<TipoDocumento> TipoDocumentos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Estado> Estados { get; set; }


    }
}
