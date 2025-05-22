using Microsoft.AspNetCore.Mvc;
using SlappyApi.DTO;
using SlappyApi.Services;

namespace SlappyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartaMazoController : ControllerBase
    {
        private readonly CartaMazoService _cartaMazoService;

        public CartaMazoController(CartaMazoService cartaMazoService)
        {
            _cartaMazoService = cartaMazoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Carta>>> Get()
        {
            var cartaMazo = await _cartaMazoService.GetAllAsync();
            return Ok(cartaMazo);
        }
    }
}

