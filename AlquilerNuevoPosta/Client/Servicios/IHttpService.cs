using Alquiler.BD.Data.Entidades;

namespace AlquilerNuevoPosta.Client.Servicios
{
    public interface IHttpService
    {
        List<Estado> Estados { get; set; }

        List<ProductoPublicado> Productos { get; set; }

      
        Task<HttpRespuesta<T>> Get<T>(string url);
        Task<HttpRespuesta<Categoria>> GetCategoria<Categoria>(string categoriaurl);
        Task<HttpRespuesta<object>> Post<T>(string url, T enviar);
        Task<HttpRespuesta<object>> Put<T>(string url, T enviar);
        Task<HttpRespuesta<object>> Delete(string url);
        Task<HttpRespuesta<Categoria>> GetProductos<Categoria>(string categoriaurl);
    }
}