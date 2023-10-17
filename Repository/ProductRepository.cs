using Base_Backend.Config.Database;
using Base_Backend.Model;

namespace Base_Backend.Repository
{
    public class ProductRepository : BaseRepository<ProductEntity>, IProductRepository
    {
        private new readonly ApiDbContext _context;
        public ProductRepository(ApiDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
