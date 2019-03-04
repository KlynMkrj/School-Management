using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Schedule
    {
        [Required(ErrorMessage = "Please Enter The Day")]
        public string DayofWeek { get; set; }

        [Required(ErrorMessage = "Please Enter RoomNo")]
        public int RoomNo { get; set; }

        [Required(ErrorMessage = "Please Enter Start Time")]
        public TimeSpan StartTime { get; set; }

        [Required(ErrorMessage = "Please Enter End Time")]
        public TimeSpan EndTime { get; set; }

        [Required(ErrorMessage = "Please Enter Course Id")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Please Enter Student Standard")]
        public int Standard { get; set; }
    }
}
