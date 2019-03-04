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
            // DB activity for save

            student.RollNo = 5;

            return student;
        }

        public Student SearchStudent(Student student)
        {
            // DB activity for search

            student.Name = "KM";
            student.ContactNo = "(9133)26533096";

            return student;
        }

        public Course SaveCourse(Course course)
        {
            // DB activity for save

            course.CourseId = 3;

            return course;
        }

        public Course SearchCourse(Course course)
        {
            // DB activity for search

            course.CourseId = 3;

            return course;
        }

        public Course DeleteCourse(Course course)
        {
            // DB activity for delete

            return course;
        }

        public Student DeleteStudent(Student student)
        {
            // DB activity for delete

            return student;
        }

        public Student UpdateStudent(Student student)
        {
            // DB activity for update

            return student;
        }
    }
}
