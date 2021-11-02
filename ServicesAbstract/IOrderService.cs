using Data.Abstract;
using Domain;

namespace Services.Abstract
{
    public interface IOrderService
    {
        IUnitOfWork uw { get; set; }
        void Add(Order order);
        void ChangeWeights(Dish dish);
    }
}
