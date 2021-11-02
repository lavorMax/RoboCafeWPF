using Domain;
using Entities;
using System.Collections.Generic;

namespace Mappers
{
    public static class OrderMapper
    {
        public static OrderEntity ModelToEntity(this Order order)
        {
            List<OrderDishEntity> dishs = new List<OrderDishEntity>();
            OrderEntity or = new OrderEntity()
            {
                id = order.id,
            };
            foreach (Dish s in order.dishes)
            {
                dishs.Add(new OrderDishEntity(or, s.ModelToEntity(), 1) 
                { dishId = s.id });
            }
            or.orDishes = dishs;
            return or;
        }
        public static Order EntityToModel(this OrderEntity order)
        {
            List<Dish> dishes = new List<Dish>();
            foreach (OrderDishEntity s in order.orDishes)
            {
                dishes.Add(s.dish.EntityToModel());
            }
            return new Order()
            {
                id = order.id,
                dishes = dishes,
            };

        }
    }
}
