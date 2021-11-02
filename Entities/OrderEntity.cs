using System.Collections.Generic;

namespace Entities
{
    public class OrderEntity : BaseEntity<int>
    {
        public virtual List<OrderDishEntity> orDishes { get; set; }
        public OrderEntity()
        {
            orDishes = new List<OrderDishEntity>();
        }
    }
}
