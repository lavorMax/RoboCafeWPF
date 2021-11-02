using Domain;
using Entities;
using System.Collections.Generic;

namespace Mappers
{
    public static class DishEntityMapper
    {
        public static DishEntity ModelToEntity(this Dish dish)
        {
            return new DishEntity(dish.name, dish.cookingTime, dish.weight, dish.dollarPrice)
            {
                id = dish.id,
            };
        }
        public static Dish EntityToModel(this DishEntity dish)
        {
            if (dish == null) { return null; }
            Dictionary<int, Ingredient> ingredients = new Dictionary<int, Ingredient>();
            foreach (DishIngredientsEntity di in dish.dishing) {
                ingredients.Add(di.amount, di.ingredient.EntityToModel());
            }
            return new Dish(dish.name, dish.cookingMinutes, dish.weight, dish.dollarPrice)
            {
                id = dish.id,
                ingredients = ingredients,
            };
        }
    }
}
