using System;

namespace Entities
{
    public class SheduleEntity : BaseEntity<int>
    { 
        public DayOfWeek day { get; set; }
        public TimeSpan open { get; set; }
        public TimeSpan close { get; set; }

        public SheduleEntity(DayOfWeek day, TimeSpan open, TimeSpan close)
        {
            this.day = day;
            this.open = open;
            this.close = close;
        }

        public SheduleEntity()
        {
        }
    }
}
