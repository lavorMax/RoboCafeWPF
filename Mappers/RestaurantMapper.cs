using Domain;
using Entities;
using System.Collections.Generic;

namespace Mappers
{
    public static class RestaurantMapper
    {
        public static RestaurantEntity ModelToEntity(this Restaurant restaurant)
        {
            
            List<SheduleEntity> shedules = new List<SheduleEntity>();
            foreach (Shedule s in restaurant.shedules)
            {
                shedules.Add(s.ModelToEntity());
            }

            List<MenuEntity> menus = new List<MenuEntity>();
            foreach (Menu s in restaurant.menus)
            {
                menus.Add(s.ModelToEntity());
            }

            return new RestaurantEntity(restaurant.name)
            {
                shedules = shedules,
                menus = menus,
                id = restaurant.id,
            };
        }
        public static Restaurant EntityToModel(this RestaurantEntity restaurant)
        {
            List<Shedule> shedules = new List<Shedule>();
            foreach (SheduleEntity s in restaurant.shedules)
            {
                shedules.Add(s.EntityToModel());
            }

            List<Menu> menus = new List<Menu>();
            foreach (MenuEntity s in restaurant.menus)
            {
                menus.Add(s.EntityToModel());
            }

            return new Restaurant(restaurant.name)
            {
                id = restaurant.id,
                menus = menus,
                shedules = shedules,
            };
        }
    }
}
