    using SlappyApi.Data;
    using SlappyApi.DTO;
    using Microsoft.EntityFrameworkCore;

    namespace SlappyApi.Services
    {
        public class CartaMazoService
        {
            private readonly AppDbContext _context;

            public CartaMazoService(AppDbContext context)
            {
                _context = context;
            }

            public async Task<List<CartaMazo>> GetAllAsync()
            {
                return await _context.CartasMazos.ToListAsync();
            }
        }
    }



