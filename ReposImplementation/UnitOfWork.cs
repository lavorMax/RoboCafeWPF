using Data.Abstract;

namespace Data.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RoboCafeDBContext db;
        public IIngredientRepository ingredientRepository { get; set; }
        public IDishRepository dishRepository { get; set; }
        public ISheduleRepositiry sheduleRepository { get; set; }
        public IMeasurementUnitRepository measurementUnitRepository { get; set; }
        public IMenuRepository typesRepository { get; set; }
        public IDishIngredientRepository dishIngredientRepository { get; set; }
        public IRestaurantRepository restaurantRepository { get; set; }
        public IDishOrderRepository dishOrderRepository { get; set; }
        public IOrderRepository orderRepository { get; set; }

        public UnitOfWork(RoboCafeDBContext db,
                            IIngredientRepository ingredientRepository,
                            IDishRepository dishRepository,
                            ISheduleRepositiry sheduleRepository,
                            IMeasurementUnitRepository measurementUnitRepository,
                            IMenuRepository typesRepository, 
                            IDishIngredientRepository dishIngredientRepository,
                            IRestaurantRepository restaurantRepository, 
                            IDishOrderRepository dishOrderRepository, 
                            IOrderRepository orderRepository)
        {
            this.db = db;
            this.ingredientRepository = ingredientRepository;
            this.dishRepository = dishRepository;
            this.sheduleRepository = sheduleRepository;
            this.measurementUnitRepository = measurementUnitRepository;
            this.typesRepository = typesRepository;
            this.dishIngredientRepository = dishIngredientRepository;
            this.restaurantRepository = restaurantRepository;
            this.dishOrderRepository = dishOrderRepository;
            this.orderRepository = orderRepository;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
