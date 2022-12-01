using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquiler.BD.Data.Entidades
{
    public class Persona
    {

        [Required]

        //es la id de la persona//

        public int Id { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El DNI de la persona no debe superar los 10 caracteres")]
        public string DNI { get; set; }


        [Required]
        [MaxLength(25)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(25)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "La Contraseña no debe superar los 25 caracteres")]
        public string Contraseña { get; set; }

        public List<ProductoPublicado> productos { get; set; }


    }
}
