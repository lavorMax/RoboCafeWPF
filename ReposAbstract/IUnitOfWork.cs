using Data.Implementation;

namespace Data.Abstract
{
    public interface IUnitOfWork
    {
        IMenuRepository typesRepository { get; set; }
        IDishIngredientRepository dishIngredientRepository { get; set; }
        IIngredientRepository ingredientRepository { get; set; }
        IDishRepository dishRepository { get; set; }
        ISheduleRepositiry sheduleRepository { get; set; }
        IMeasurementUnitRepository measurementUnitRepository { get; set; }
        IRestaurantRepository restaurantRepository { get; set; }
        IDishOrderRepository dishOrderRepository { get; set; }
        IOrderRepository orderRepository { get; set; }
        void Save();
    }
}
