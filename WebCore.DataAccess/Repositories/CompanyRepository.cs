using WebCore.DataAccess.Data;
using WebCore.DataAccess.Repositories;
using WebCore.DataAccess.Repositories.IRepository;
using WebCore.Models;

namespace WebCore.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}