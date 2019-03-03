using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Courses
    {
        public Courses()
        {
            Schedule = new HashSet<Schedule>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}
