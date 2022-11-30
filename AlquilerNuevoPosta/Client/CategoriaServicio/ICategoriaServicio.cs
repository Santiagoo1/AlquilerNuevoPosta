using Alquiler.BD.Data.Entidades;
using AlquilerNuevoPosta.Client.Servicios;
using Microsoft.Exchange.WebServices.Data;

namespace AlquilerNuevoPosta.Client.CategoriaServicio
{
    public interface ICategoriaServicio
    {
        Task<HttpRespuesta<Categoria>> Get<Categoria>(string url);
    }
}
