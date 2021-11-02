using Data.Abstract;
using Entities;

namespace Data.Implementation
{
    public class OrderDishRepository : GenericRepository<OrderDishEntity, int>, IDishOrderRepository
    {
        public OrderDishRepository(RoboCafeDBContext context) : base(context)
        {
        }
    }
}
