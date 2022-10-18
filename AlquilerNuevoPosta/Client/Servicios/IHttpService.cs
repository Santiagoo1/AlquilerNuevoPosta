using Alquiler.BD.Data.Entidades;

namespace AlquilerNuevoPosta.Client.Servicios
{
    public interface IHttpService
    {
        List<Estado> Estados { get; set; }

        Task<HttpRespuesta<T>> Get<T>(string url);
        Task<HttpRespuesta<object>> Post<T>(string url, T enviar);
        Task<HttpRespuesta<object>> Put<T>(string url, T enviar);
    }
}