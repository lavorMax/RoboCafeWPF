using System;
using System.Collections.Generic;

namespace Entities
{
    public class DishEntity : BaseEntity<int>
    {
        public string name { get; set; }
        public TimeSpan cookingMinutes { get; set; }
        public double weight { get; set; }
        public double dollarPrice { get; set; }
        public virtual List<DishIngredientsEntity> dishing { get; set; }

        public DishEntity()
        {
        }

        public DishEntity(string name, TimeSpan cookingMinutes, double weight, double dollarPrice)
        {
            this.name = name;
            this.cookingMinutes = cookingMinutes;
            this.weight = weight;
            this.dollarPrice = dollarPrice;
            dishing = new List<DishIngredientsEntity>();
        }
    }
}