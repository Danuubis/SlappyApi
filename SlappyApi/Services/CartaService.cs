using Microsoft.EntityFrameworkCore;
using SlappyApi.Data;
using SlappyApi.DTO;

namespace SlappyApi.Services
{
    public class CartaService
    {
        private readonly AppDbContext _context;

        public CartaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Carta>> GetAllAsync()
        {
            return await _context.Cartas.ToListAsync();
        }
    }
}
