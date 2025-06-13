using Microsoft.AspNetCore.Mvc;
using SlappyApi.DTO;
using SlappyApi.Services;

namespace SlappyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NoticeController : ControllerBase
    {
        private readonly NoticeService _noticeService;

        public NoticeController(NoticeService noticeService)
        {
            _noticeService = noticeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Notice>>> Get()
        {
            var noticias = await _noticeService.GetAllAsync();
            return Ok(noticias);
        }
    }
}

