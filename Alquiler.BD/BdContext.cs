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

        public BdContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet<Direccion> Direcciones { get; set; }

        public DbSet<TipoDocumento> TipoDocumentos { get; set; }

        public DbSet<Foto> Fotos { get; set; }

        public DbSet<Estado> Estados { get; set; }

    }
}
