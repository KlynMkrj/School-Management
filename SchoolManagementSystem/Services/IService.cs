using System;
using System.Collections.Generic;
using System.Text;

using SchoolManagementSystem.Models;
using SchoolManagementSystem.ViewModels;

namespace SchoolManagementSystem.Services
{
    public interface IService
    {
        Student SaveStudent(Student student);
        StudentVM SearchStudent(Student student);
        string DeleteStudent(StudentVM objStudentVM);
        string UpdateStudent(StudentVM objStudentVM);

        string SaveCourse(Course course);
        CourseVM SearchCourse(Course course);
        string DeleteCourse(CourseVM objCourseVM);        
    }
}
