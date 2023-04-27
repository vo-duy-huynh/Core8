using WebCore.Models;

namespace WebCore.DataAccess.Repositories.IRepository
{
    public interface IProductImageRepository : IRepository<ProductImage>
    {
        void Update(ProductImage obj);
    }
}
