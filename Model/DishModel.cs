using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Model
{
    public class DishModel : INotifyPropertyChanged
    {
        public int id { get; set; }
        public string name { get; set; }
        public TimeSpan cookingTime { get; set; }
        public double weight { get; set; }
        public MeasurementUnitModel measurementUnit { get; set; }
        public double dollarPrice { get; set; }
        public Dictionary<int, IngredientModel> ingredients { get; set; }
        public DishTypeModel type { get; set; }

        public DishModel(string name, TimeSpan cookingMinutes, double weight, MeasurementUnitModel measurementUnit, double dollarPrice, DishTypeModel type)
        {
            this.name = name;
            this.cookingTime = cookingMinutes;
            this.weight = weight;
            this.measurementUnit = measurementUnit;
            this.dollarPrice = dollarPrice;
            this.ingredients = new Dictionary<int, IngredientModel>();
            this.type = type;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}