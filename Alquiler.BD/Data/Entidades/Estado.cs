using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.BD.Data.Entidades
{
    public class Estado
    {
        public int Id { get; set; }

        public string Estados { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
