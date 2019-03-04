using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please Enter Student RollNo")]
        public int RollNo { get; set; }

        [Required(ErrorMessage = "Please Enter Student Standard")]
        public int Standard { get; set; }

        [Required(ErrorMessage = "Please Enter Student Name")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Min. Length 3, Max. Length 20")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Student ContactNo")]
        public string ContactNo { get; set; }
    }
}
