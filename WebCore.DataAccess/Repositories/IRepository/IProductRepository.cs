using WebCore.Models;

namespace WebCore.DataAccess.Repositories.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
