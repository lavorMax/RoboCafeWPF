using Domain;
using Entities;

namespace Mappers
{
    public static class SheduleMapper
    {
        public static SheduleEntity ModelToEntity(this Shedule shedule)
        {
            return new SheduleEntity(shedule.day, shedule.open, shedule.close)
            {
                id = shedule.id,
            };
        }
        public static Shedule EntityToModel(this SheduleEntity shedule)
        {
            if (shedule == null) { return null; }
            return new Shedule(shedule.day, shedule.open, shedule.close)
            {
                id = shedule.id,
            };
        }
    }
}
