using Entities;

namespace Data.Abstract
{
    public interface IIngredientRepository : IGenericRepository<IngredientEntity, int>
    {
        void ChangeWeights(int id, int weight);
    }
}
