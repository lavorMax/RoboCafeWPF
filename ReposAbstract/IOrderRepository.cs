using Entities;

namespace Data.Abstract
{
    public interface IOrderRepository : IGenericRepository<OrderEntity, int>
    {
        void AddOrder(OrderEntity order);
    }
}
