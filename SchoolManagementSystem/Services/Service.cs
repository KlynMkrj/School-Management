using System;

using SchoolManagementSystem.Repositories;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.ViewModels;

namespace SchoolManagementSystem.Services
{
    public class Service : IService
    {
        IRepository _repository;

        public Service(IRepository irepository)
        {
            _repository = irepository;
        }


        public Student SaveStudent(Student student)
        {
            return _repository.SaveStudent(student);
        }

        public StudentVM SearchStudent(Student objStudent)
        {
            Student student = _repository.SearchStudent(objStudent);

            StudentVM objStudentVM = new StudentVM();
            objStudentVM.ContactNo = student.ContactNo;
            objStudentVM.Name = student.Name;

            return objStudentVM;            
        }

        public Course SaveCourse(Course course)
        {
            return _repository.SaveCourse(course);
        }

        public CourseVM SearchCourse(Course objCourse)
        {
            Course course = _repository.SearchCourse(objCourse);

            CourseVM objCourseVM = new CourseVM();
            objCourseVM.CourseId = course.CourseId;
            objCourseVM.Name = course.Name;
            
            return objCourseVM;
        }
    }
}
