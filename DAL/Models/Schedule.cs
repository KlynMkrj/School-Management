using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Schedule
    {
        public string DayOfWeek { get; set; }
        public int RoomNo { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int? CourseId { get; set; }
        public int? Standard { get; set; }

        public virtual Courses Course { get; set; }
        public virtual Classrooms RoomNoNavigation { get; set; }
    }
}
