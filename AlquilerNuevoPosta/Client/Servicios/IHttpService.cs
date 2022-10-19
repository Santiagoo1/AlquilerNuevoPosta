using Alquiler.BD.Data.Entidades;

namespace AlquilerNuevoPosta.Client.Servicios
{
    public interface IHttpService
    {
        List<Estado> Estados { get; set; }
        List<Foto> Fotos { get; set; }
        List<Producto> Productos { get; set; }

      
        Task<HttpRespuesta<T>> Get<T>(string url);
        Task<HttpRespuesta<object>> Post<T>(string url, T enviar);
        Task<HttpRespuesta<object>> Put<T>(string url, T enviar);
        Task<HttpRespuesta<object>> Delete(string url);
    }
}