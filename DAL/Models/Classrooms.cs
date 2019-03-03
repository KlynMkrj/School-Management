using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Classrooms 
    {
        public Classrooms()
        {
            Schedule = new HashSet<Schedule>();
        }

        public int RoomNo { get; set; }
        public string Floor { get; set; }
        public int? Strength { get; set; }

        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}
