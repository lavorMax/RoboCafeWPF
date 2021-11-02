using Data.Abstract;
using Entities;

namespace Data.Implementation
{
    public class OrderRepository : GenericRepository<OrderEntity, int>, IOrderRepository
    {
        public OrderRepository(RoboCafeDBContext context) : base(context)
        {
        }

        public void AddOrder(OrderEntity order)
        {
            foreach(OrderDishEntity d in order.orDishes)
            {
                DishEntity orderedDish = context.dishes.Find(d.dishId);
                d.dish = orderedDish;
                d.dishId = orderedDish.id;
                context.orderDish.Add(d);
            }
            context.orders.Add(order);
        }
    }
}
