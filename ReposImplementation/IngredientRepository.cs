using Data.Abstract;
using Entities;
using System.Data.Entity;
using System.Linq;

namespace Data.Implementation
{
    public class IngredientRepository : GenericRepository<IngredientEntity, int>, IIngredientRepository
    {
        public IngredientRepository(RoboCafeDBContext context) : base(context)
        {
        }

        public void ChangeWeights(int id, int weight)
        {
            IngredientEntity ingredient = context.Set<IngredientEntity>().Find(id);
            ingredient.weight -= weight;
        }
    }
}
