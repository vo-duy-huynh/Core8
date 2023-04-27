using WebCore.DataAccess.Data;
using WebCore.DataAccess.Repositories.IRepository;
using WebCore.Models;

namespace WebCore.DataAccess.Repositories
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        private ApplicationDbContext _db;
        public ProductImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(ProductImage obj)
        {
            _db.ProductImages.Update(obj);
        }
    }
}
