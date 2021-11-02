namespace Entities
{
    public class OrderDishEntity : BaseEntity<int>
    {
        public OrderEntity order { get; set; }
        public int orderId { get; set; }
        public DishEntity dish { get; set; }
        public int dishId { get; set; }
        public int amount { get; set; }
        public OrderDishEntity(OrderEntity order, DishEntity dish, int amount)
        {
            this.order = order;
            this.dish = dish;
            this.amount = amount;
        }
        public OrderDishEntity()
        {
        }
    }
}
