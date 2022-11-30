using Alquiler.BD.Data.Entidades;
using Alquiler.BD;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlquilerNuevoPosta.Client.Servicios;

namespace AlquilerNuevoPosta.Server.Controllers
{
    [Route("api/Productos")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly BdContext context;
  

        public ProductosController(BdContext context)
        {
            this.context = context;
        }

       

     

        [HttpGet]
        public async Task<ActionResult<List<ProductoPublicado>>> Get()
        {
            return await context.ProductosPublicados


                                         .Include(m => m.Estado)
                                             .ToListAsync();

          
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductoPublicado>> Get(int id)
        {
            var venta = await context.ProductosPublicados
                                         .Where(e => e.Id == id)
                                         
                                         .Include(m => m.Estado)
                                         .FirstOrDefaultAsync();

            if (venta == null)
            {
                return NotFound($"No existe Producto de id: {id}");
            }
            return venta;
        }

        [HttpGet("Categoriaurl/{categoriaurl}")]
        public async Task<ActionResult<ProductoPublicado>> ProductoCategoria(int categoriaurl)
        {
            var especialidad = await context.ProductosPublicados
                                     .Where(e => e.CategoriaId == categoriaurl )
                                     .FirstOrDefaultAsync();
            if (especialidad == null)
            {
                return NotFound($"No existe la especialidad de código={categoriaurl}");
            }
            return especialidad;
        }

        [HttpPost]
        public async Task<ActionResult<List<ProductoPublicado>>> Post(ProductoPublicado producto)
        {
            try
            {

                context.ProductosPublicados.Add(producto);
                await context.SaveChangesAsync();
                return Ok(producto);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, [FromBody] ProductoPublicado producto)
        {


            if (id != producto.Id)
            {
                return BadRequest("No existe el Producto");
            }

            var produ = context.ProductosPublicados.Where(e => e.Id == id).FirstOrDefault();
           
            

            if (produ == null)
            {
                return NotFound("No existe el Producto");
            }

            produ.NombreProducto = producto.NombreProducto;
            produ.PrecioProducto = producto.PrecioProducto;
            produ.DetallesProducto = producto.DetallesProducto;
            produ.foto = producto.foto;
            produ.EstadoId = producto.EstadoId;

            try
            {
                //throw(new Exception("Cualquier Verdura"));
                context.ProductosPublicados.Update(produ);
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
            var produ = context.ProductosPublicados.Where(x => x.Id == id).FirstOrDefault();

            if (produ == null)
            {
                return NotFound($"El registro {id} no fue encontrado");
            }

            try
            {
                context.ProductosPublicados.Remove(produ);
                context.SaveChanges();
                return Ok($"El registro de {produ.NombreProducto} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por: {e.Message}");
            }
        }
    }
}