using Data.Abstract;
using Domain;
using Mappers;
using Services.Abstract;
using System.Collections.Generic;

namespace Services.Implementation
{
    public class OrderService : IOrderService
    {
        public IUnitOfWork uw { get; set; }
        public OrderService(IUnitOfWork uw)
        {
            this.uw = uw;
        }

        public void Add(Order order)
        {
            order.dishes.ForEach(i => ChangeWeights(i));
            uw.orderRepository.AddOrder(order.ModelToEntity());
            uw.Save();
        }

        public void ChangeWeights(Dish dish)
        {
            foreach (KeyValuePair<int, Ingredient> kv in dish.ingredients)
            {
                uw.ingredientRepository.ChangeWeights(kv.Value.id, kv.Key);
            }
            uw.Save();

        }
    }
}
