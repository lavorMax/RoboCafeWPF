using Entities;
using System;

namespace Data.Abstract
{
    public interface ISheduleRepositiry : IGenericRepository<SheduleEntity, int>
    {
        SheduleEntity GetByDay(DayOfWeek weekDay);
    }
}
