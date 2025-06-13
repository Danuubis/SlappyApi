using Microsoft.EntityFrameworkCore;
using SlappyApi.Data;
using SlappyApi.DTO;

namespace SlappyApi.Services
{
    public class ProductoService
    {
        private readonly AppDbContext _context;
        public ProductoService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Producto>> GetAllAsync()
        {
            return await _context.Productos.ToListAsync();
        }
        public async Task<Producto?> GetByIdAsync(int id)
        {
            return await _context.Productos.FindAsync(id);
        }
    }
}
