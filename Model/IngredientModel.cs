namespace Model
{
    public class IngredientModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public double weight { get; set; }
        public bool isRaw { get; set; }
        public MeasurementUnitModel measurementUnit { get; set; }

        public IngredientModel(string name, double weight, bool isRaw, MeasurementUnitModel measurementUnit)
        {
            this.name = name;
            this.weight = weight;
            this.isRaw = isRaw;
            this.measurementUnit = measurementUnit;
        }
    }
}