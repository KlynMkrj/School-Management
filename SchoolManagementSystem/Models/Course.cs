using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Please Enter Course Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage="Max. Length should be 20 chars")]
        public string Name { get; set; }        
    }
}
