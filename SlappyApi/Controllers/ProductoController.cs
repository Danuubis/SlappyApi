using Microsoft.AspNetCore.Mvc;
using SlappyApi.DTO;
using SlappyApi.Services;

namespace SlappyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoService _productoService;

        public ProductoController(ProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Producto>>> Get()
        {
            var producto = await _productoService.GetAllAsync();
            return Ok(producto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> Get(int id)
        {
            var producto = await _productoService.GetByIdAsync(id);

            if (producto == null)
            {
                return NotFound(new { message = $"Producto con ID {id} no encontrado." });
            }

            return Ok(producto);
        }
    }
}

