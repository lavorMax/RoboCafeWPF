using Entities;
using System.Data.Entity;

namespace Data.Implementation
{
    public class RoboCafeDBContext : DbContext
    {
        public DbSet<DishEntity> dishes { get; set; }
        public DbSet<IngredientEntity> ingredients { get; set; }
        public DbSet<SheduleEntity> days { get; set; }
        public DbSet<MeasurementUnitEntity> mu { get; set; }
        public DbSet<DishIngredientsEntity> dishIngs { get; set; }
        public DbSet<MenuEntity> types { get; set; }
        public DbSet<OrderDishEntity> orderDish { get; set; }
        public DbSet<OrderEntity> orders { get; set; }
        public DbSet<RestaurantEntity> restaurants { get; set; }

        public RoboCafeDBContext() : base("RoboCafeDatabase13")
        {
        }
        
    }
}