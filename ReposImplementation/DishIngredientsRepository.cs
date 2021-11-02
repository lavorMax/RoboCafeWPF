using Data.Abstract;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Data.Implementation
{
    public class DishIngredientsRepository : GenericRepository<DishIngredientsEntity, int>, IDishIngredientRepository
    {
        public DishIngredientsRepository(RoboCafeDBContext context) : base(context)
        {
        }

        public List<DishIngredientsEntity> GetByDishId(int id)
        {
            List<DishIngredientsEntity> dishIng = new List<DishIngredientsEntity>();
            foreach (DishIngredientsEntity d in context.Set<DishIngredientsEntity>().ToList())
            {
                if (d.dishId == id)
                {
                    dishIng.Add(d);
                }
            }
            return dishIng;
        }
    }
}
