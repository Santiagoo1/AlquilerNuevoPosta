using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.BD.Data.Entidades
{
    public class Producto
    {

        public int Id { get; set; }

        [Required]

        public string NombreProducto { get; set; }



        [Required]

        public int PrecioProducto { get; set; }


        [Required]

        public string DetallesProducto { get; set; }



        public List<Foto> Fotos { get; set; }

        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
    }
}
