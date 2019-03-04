using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Repositories
{
    public interface IRepository
    {
        Student SaveStudent(Student student);
        Student SearchStudent(Student student);
        Student DeleteStudent(Student student);
        Student UpdateStudent(Student student);

        Course SaveCourse(Course course);
        Course SearchCourse(Course course);
        Course DeleteCourse(Course course);        
    }
}
