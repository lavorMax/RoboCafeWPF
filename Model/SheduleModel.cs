using System;

namespace Model
{
    public class SheduleModel
    {
        public int id { get; set; }
        public DayOfWeek day { get; set; }
        public TimeSpan open { get; set; }
        public TimeSpan close { get; set; }

        public SheduleModel(DayOfWeek day, TimeSpan open, TimeSpan close)
        {
            this.day = day;
            this.open = open;
            this.close = close;
        }
    }
}
