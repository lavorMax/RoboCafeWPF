using Domain;
using Entities;

namespace Mappers
{
    public static class IngredientMapper
    {
        public static IngredientEntity ModelToEntity(this Ingredient ingredient)
        {
            return new IngredientEntity(ingredient.name, ingredient.weight,
                        ingredient.isRaw, ingredient.measurementUnit.ModelToEntity())
            {
                id = ingredient.id,
            };
        }
        public static Ingredient EntityToModel(this IngredientEntity ingredient)
        {
            return new Ingredient(ingredient.name, ingredient.weight, ingredient.isRaw, 
                                ingredient.measurementUnit.EntityToModel())
            {
                id = ingredient.id,
            };
        }
    }
}
