using Microsoft.EntityFrameworkCore;

namespace AlquilerNuevoPosta.Server.Helpers
{
    public static class HttpContextExtensions
    {
        public static async Task InsertarParametrosPaginacionEnRespuesta<T>(this HttpContext context,
            IQueryable<T> queryable, int cantidadRegistrosAMostrar)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));   
            }

            double conteo = await queryable.CountAsync();
            double TotalPaginas = Math.Ceiling(conteo/ cantidadRegistrosAMostrar);
            context.Response.Headers.Add("TotalPaginas", TotalPaginas.ToString());
        }
    }
}
 