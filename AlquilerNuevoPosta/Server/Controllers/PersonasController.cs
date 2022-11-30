using Alquiler.BD.Data.Entidades;
using Alquiler.BD;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlquilerNuevoPosta.Server.Controllers
{
    [ApiController]
    [Route("api/Personas")]

    public class PersonasController : ControllerBase
    {
        private readonly BdContext context;

        public PersonasController(BdContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Persona>>> Get()
        {

            return await context.Personas


                  .ToListAsync();


        }


        [HttpGet("{id:int}")]
        public async Task<ActionResult<Persona>> Get(int id)
        {
            var person = await context.Personas

                .Where(e => e.Id == id)

                .FirstOrDefaultAsync();


            if (person == null)

            {
                return NotFound($"No existe la Persona de Id= {id}");

            }

            return person;

        }


        [HttpPost]

        public async Task<ActionResult<int>> Post(Persona person)
        {
            try
            {


                context.Personas.Add(person);
                await context.SaveChangesAsync();
                return person.Id;

            }
            catch (Exception m)
            {
                return BadRequest(m.Message);
            }


        }




        [HttpGet("PersonasPorNombre/{nombre}")]

        public async Task<ActionResult<Persona>> PersonasPorNombre(string nombre)
        {
            var person = await context.Personas

             .Where(x => x.Nombre == nombre)


           .FirstOrDefaultAsync();


            if (person == null)

            {
                return NotFound($"No existe el nombre = {nombre}");

            }

            return person;

        }




        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] Persona Cargo)
        {


            if (id != Cargo.Id)
            {
                return BadRequest("No existe la Persona");
            }

            var carg = context.Personas.Where(e => e.Id == id).FirstOrDefault();
            var emplead = context.Direcciones.Where(e => e.Id == id).FirstOrDefault();
            var doc = context.TipoDocumentos.Where(e => e.Id == id).FirstOrDefault();

            if (carg == null)
            {
                return NotFound("No existe la Persona");
            }

            carg.Nombre = Cargo.Nombre;

            carg.DNI = Cargo.DNI;





            try
            {
                //throw(new Exception(""));
                context.Personas.Update(carg);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no han sido actualizados por: {e.Message}");
            }
        }



        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var carg = context.Personas.Where(x => x.Id == id).FirstOrDefault();

            if (carg == null)
            {
                return NotFound($"La Persona {id} no fue encontrado");
            }

            try
            {
                context.Personas.Remove(carg);
                context.SaveChanges();
                return Ok($"El registro de {carg.Nombre} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por: {e.Message}");
            }
        }
    }
}

