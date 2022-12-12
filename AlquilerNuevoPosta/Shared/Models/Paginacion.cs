using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerNuevoPosta.Shared.Models
{
    public class Paginacion
    {
        public int Pagina { get; set; } = 1;
        public int CantidadAMostrar { get; set; } = 10;
    }
}
