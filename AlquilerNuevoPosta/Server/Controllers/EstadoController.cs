using Alquiler.BD.Data.Entidades;
using Alquiler.BD;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlquilerNuevoPosta.Server.Controllers
{
    [Route("api/Estado")]
    [ApiController]
    public class EstadoController : ControllerBase
    {

        private readonly BdContext context;

        public EstadoController(BdContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Estado>>> Get()
        {

            return await context.Estados.ToListAsync();


        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Estado>> Get(int id)
        {
            var estado = await context.Estados

                .Where(e => e.Id == id)
                .Include(m => m.Productos)
               .FirstOrDefaultAsync();


            if (estado == null)

            {
                return NotFound($"No existe la Foto de Id= {id}");

            }

            return estado;

        }





        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Estado Estad)
        {


            if (id != Estad.Id)
            {
                return BadRequest("No existe el producto");
            }

            var est = context.Estados.Where(e => e.Id == id).FirstOrDefault();
            var produ = context.Productos.Where(e => e.Id == id).FirstOrDefault();


            if (est == null)
            {
                return NotFound("No existe el producto");
            }

            est.Estados = Estad.Estados;



            try
            {
                //throw(new Exception(""));
                context.Estados.Update(est);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no han sido actualizados por: {e.Message}");
            }
        }



    }
    }
