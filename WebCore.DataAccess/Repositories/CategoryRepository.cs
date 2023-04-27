using WebCore.DataAccess.Data;
using WebCore.DataAccess.Repositories.IRepository;
using WebCore.Models;

namespace WebCore.DataAccess.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
