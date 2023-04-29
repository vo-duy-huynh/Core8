using WebCore.Models;

namespace WebCore.DataAccess.Repositories.IRepository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);
    }
}
