using Alquiler.BD;
using Alquiler.BD.Data.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlquilerNuevoPosta.Server.Controllers
{
    [Route("api/Categoria")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        private readonly BdContext context;

        public CategoriaController(BdContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> Get()
        {
            return await context.Categorias.ToListAsync();

                                 
        }

    }
}
