using Alquiler.BD.Data.Entidades;

namespace AlquilerNuevoPosta.Client.Servicios
{
    public interface IHttpService
    {
        List<Estado> estados { get; set; }
        List<Producto> productos { get; set; }

        Task<HttpRespuesta<T>> Get<T>(string url);
        Task<HttpRespuesta<object>> Post<T>(string url, T enviar);
    }
}