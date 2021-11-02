using Entities;
using System.Collections.Generic;

namespace Data.Abstract
{
    public interface IDishIngredientRepository : IGenericRepository<DishIngredientsEntity, int>
    {
        List<DishIngredientsEntity> GetByDishId(int id);
    }
}
