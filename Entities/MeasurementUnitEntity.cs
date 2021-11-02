
namespace Entities
{
    public class MeasurementUnitEntity : BaseEntity<int>
    {
        public string name { get; set; }
        public MeasurementUnitEntity(string name)
        {
            this.name = name;
        }

        public MeasurementUnitEntity()
        {
        }
    }
}
