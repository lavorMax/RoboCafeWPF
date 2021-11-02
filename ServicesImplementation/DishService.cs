using Data.Abstract;
using Domain;
using Mappers;
using Services.Abstract;
using System;

namespace Services.Implementation
{
    public class DishService : IDishService
    {
        public IUnitOfWork uw { get; set; }
        public DishService(IUnitOfWork uw)
        {
            this.uw = uw;
        }

        public bool CheckByProducts(Dish dish)
        {
            if (uw.sheduleRepository.GetByDay(DateTime.Now.DayOfWeek) == null)
            {
                return false;
            }
            foreach (Ingredient i in dish.ingredients.Values) 
            {
                if ((i.isRaw) & (!CheckRaw(i, dish.cookingTime))) 
                {
                    return false;
                }
            }
            return true;
        }
        private bool CheckRaw(Ingredient ing, TimeSpan cooking) 
        {
            Shedule ds = uw.sheduleRepository.GetByDay(DateTime.Now.DayOfWeek).EntityToModel();
            return DateTime.Now.AddHours(1.5).Add(cooking).TimeOfDay.CompareTo(ds.close) == -1;
        }
        public bool CheckByTime(Dish dish)
        {
            if (uw.sheduleRepository.GetByDay(DateTime.Now.DayOfWeek) == null)
            {
                return false;
            }
            Shedule ds = uw.sheduleRepository.GetByDay(DateTime.Now.DayOfWeek).EntityToModel();
            if (DateTime.Now.TimeOfDay.CompareTo(ds.open) == -1 ||
                DateTime.Now.TimeOfDay.Add(dish.cookingTime).CompareTo(ds.close) == 1)
            {
                return false;
            }
            return true;
        }

    }
}
