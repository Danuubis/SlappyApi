using Microsoft.EntityFrameworkCore;
using SlappyApi.Data;
using SlappyApi.DTO;

namespace SlappyApi.Services
{
    public class NoticeService
    {
        private readonly AppDbContext _context;

        public NoticeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Notice>> GetAllAsync()
        {
            return await _context.Noticias.ToListAsync();
        }
    }
}
