using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Repositories
{
    public class Repository : IRepository
    {
        public Student SaveStudent(Student student)
        {
            student.RollNo = 5;
            return student;
        }

        public Course SaveCourse(Course course)
        {
            course.CourseId = 3;
            return course;
        }
    }
}
