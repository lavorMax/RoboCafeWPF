using Entities;
using System;
using Data.Abstract;
using System.Linq;

namespace Data.Implementation
{
    public class SheduleRepository : GenericRepository<SheduleEntity, int>, ISheduleRepositiry
    {
        public SheduleRepository(RoboCafeDBContext context) : base(context)
        {
        }
        public SheduleEntity GetByDay(DayOfWeek weekDay)
        {
            return context.Set<SheduleEntity>().FirstOrDefault((e) => e.day == weekDay);
        }
    }
}
