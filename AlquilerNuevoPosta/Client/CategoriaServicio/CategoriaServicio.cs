using Alquiler.BD.Data.Entidades;
using AlquilerNuevoPosta.Client.Servicios;
using Microsoft.Exchange.WebServices.Data;

namespace AlquilerNuevoPosta.Client.CategoriaServicio
{
    public class CategoriaServicio : ICategoriaServicio
    {
        public Task<HttpRespuesta<Categoria>> Get<Categoria>(string url)
        {
            throw new NotImplementedException();
        }
    }

}

