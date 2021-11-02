
namespace Model
{
    public class MeasurementUnitModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public MeasurementUnitModel(string name)
        {
            this.name = name;
        }
    }
}
