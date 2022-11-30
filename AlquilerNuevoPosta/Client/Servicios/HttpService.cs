using Alquiler.BD.Data.Entidades;
using System.Text.Json;
using AlquilerNuevoPosta.Client.Pages;
using System.Text;
using Alquiler.BD;
using Microsoft.EntityFrameworkCore;

namespace AlquilerNuevoPosta.Client.Servicios
{
    public class HttpService : IHttpService 
    {
        private readonly HttpClient http;

        private readonly BdContext context;

        public HttpService(BdContext context)
        {
            this.context = context;
        }

        public HttpService(HttpClient http)
        {
            this.http = http;
        }

        public List<Estado> Estados { get; set; } = new List<Estado>();
        public List<ProductoPublicado> Productos { get; set; } = new List<ProductoPublicado>();

        public async Task<HttpRespuesta<T>> Get<T>(string url)
        {

            var response = await http.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {

                var respuesta = await DeserializarRepuesta<T>(response);
                return new HttpRespuesta<T>(respuesta, false, response);
            }
            else
            {
                return new HttpRespuesta<T>(default, true, response);
            }
        }



        public async Task<HttpRespuesta<object>> Post<T>(string url, T enviar)
        {

            try
            {
                var enviarJson = JsonSerializer.Serialize(enviar);
                var enviarContent = new StringContent(enviarJson,
                                                     Encoding.UTF8,
                                                     "application/json");
                var respuesta = await http.PostAsync(url, enviarContent);
                return new HttpRespuesta<object>(null,
                                                 !respuesta.IsSuccessStatusCode,
                                                 respuesta);

            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async Task<HttpRespuesta<object>> Put<T>(string url, T enviar)
        {
            try
            {
                var enviarJson = JsonSerializer.Serialize(enviar);
                var enviarContent = new StringContent(enviarJson,
                                                      Encoding.UTF8,
                                                      "application/json");
                var respuesta = await http.PutAsync(url, enviarContent);
                return new HttpRespuesta<object>(null,
                                                 !respuesta.IsSuccessStatusCode,
                                                 respuesta);
            }
            catch (Exception e) { throw; }
        }

        public async Task<HttpRespuesta<object>> Delete(string url)

        {
            var respuesta = await http.DeleteAsync(url);
            return new HttpRespuesta<object>(null,
                                             !respuesta.IsSuccessStatusCode,
                                             respuesta);

        }


        private async Task<T> DeserializarRepuesta<T>(HttpResponseMessage response)
        {
            var respuestaStr = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(respuestaStr,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }



        public async Task<HttpRespuesta<Categoria>> GetCategoria<Categoria>(string categoriaurl)
        {

            var response = await http.GetAsync(categoriaurl);
            if (response.IsSuccessStatusCode)
            {

                var respuesta = await DeserializarRepuesta<Categoria>(response);
                return new HttpRespuesta<Categoria>(respuesta, false, response);
            }
            else
            {
                return new HttpRespuesta<Categoria>(default, true, response);
            }
        }

        public async Task<HttpRespuesta<T>> GetProductos<T>(string categoriaurl)
        {

            var response = await http.GetAsync(categoriaurl);
            if (response.IsSuccessStatusCode)
            {

                var respuesta = await DeserializarRepuesta<T>(response);
                return new HttpRespuesta<T>(respuesta, false, response);
            }
            else
            {
                return new HttpRespuesta<T>(default, true, response);
            }
        }


    }

}