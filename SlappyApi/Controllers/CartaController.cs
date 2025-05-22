using Microsoft.AspNetCore.Mvc;
using SlappyApi.DTO;
using SlappyApi.Services;

namespace SlappyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartaController : ControllerBase
    {
        private readonly CartaService _cartaService;

        public CartaController(CartaService cartaService)
        {
            _cartaService = cartaService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Carta>>> Get()
        {
            var cartas = await _cartaService.GetAllAsync();
            return Ok(cartas);
        }
    }
}

