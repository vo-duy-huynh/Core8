using WebCore.DataAccess.Data;
using WebCore.DataAccess.Repositories.IRepository;
using WebCore.Models;

namespace WebCore.DataAccess.Repositories
{
	public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
	{
		private ApplicationDbContext _db;
		public OrderDetailRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}



		public void Update(OrderDetail obj)
		{
			_db.OrderDetails.Update(obj);
		}
	}
}
