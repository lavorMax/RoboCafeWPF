using Data.Abstract;
using Entities;

namespace Data.Implementation
{
    public class MeasurementUnitRepository : GenericRepository<MeasurementUnitEntity, int>, IMeasurementUnitRepository
    {
        public MeasurementUnitRepository(RoboCafeDBContext contextFactory) : base(contextFactory)
        {
        }
    }
}
