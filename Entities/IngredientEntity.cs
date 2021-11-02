namespace Entities
{
    public class IngredientEntity : BaseEntity<int>
    {
        public string name { get; set; }
        public double weight { get; set; }
        public bool isRaw { get; set; }
        public int measurementUnitId { get; set; }
        public virtual MeasurementUnitEntity measurementUnit { get; set; }

        public IngredientEntity(string name, double weight, bool isRaw, MeasurementUnitEntity measurementUnit)
        {
            this.name = name;
            this.weight = weight;
            this.isRaw = isRaw;
            this.measurementUnit = measurementUnit;
        }

        public IngredientEntity()
        {
        }
    }
}