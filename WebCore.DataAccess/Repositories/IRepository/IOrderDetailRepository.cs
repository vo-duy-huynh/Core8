using WebCore.Models;

namespace WebCore.DataAccess.Repositories.IRepository
{
	public interface IOrderDetailRepository : IRepository<OrderDetail>
	{
		void Update(OrderDetail obj);
	}
}
