using Domain;
using Entities;
using System.Collections.Generic;

namespace Mappers
{
    public static class MenuMapper
    {
        public static MenuEntity ModelToEntity(this Menu type)
        {
            List<DishEntity> dishs = new List<DishEntity>();
            foreach (Dish s in type.dishes)
            {
                dishs.Add(s.ModelToEntity());
            }
            return new MenuEntity(type.name)
            {
                id = type.id,
                dishes = dishs,
            };
        }
        public static Menu EntityToModel(this MenuEntity type)
        {
            List<Dish> dishs = new List<Dish>();
            foreach (DishEntity s in type.dishes)
            {
                dishs.Add(s.EntityToModel());
            }
            return new Menu(type.name)
            {
                id = type.id,
                dishes = dishs,
            };
        }
    }
}
