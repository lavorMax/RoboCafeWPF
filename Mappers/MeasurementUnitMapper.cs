using Domain;
using Entities;

namespace Mappers
{
    public static class MeasurementUnitMapper
    {
        public static MeasurementUnitEntity ModelToEntity(this MeasurementUnit mu)
        {
            return new MeasurementUnitEntity(mu.name)
            {
                id = mu.id,
            };
        }
        public static MeasurementUnit EntityToModel(this MeasurementUnitEntity mu)
        {
            if (mu == null) { return null; }
            return new MeasurementUnit(mu.name)
            {
                id = mu.id,
            };
        }
    }
}
