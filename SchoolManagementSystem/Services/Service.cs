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

        public string SaveCourse(Course objCourse)
        {
            Course course = _repository.SaveCourse(objCourse);
            string strSaveMessage = "Course created successfully. Course ID. : " + course.CourseId + ". Course name : " + course.Name;

            return strSaveMessage;
        }

        public CourseVM SearchCourse(Course objCourse)
        {
            Course course = _repository.SearchCourse(objCourse);

            CourseVM objCourseVM = new CourseVM();
            objCourseVM.CourseId = course.CourseId;
            objCourseVM.Name = course.Name;
            
            return objCourseVM;
        }

        public string DeleteCourse(CourseVM objCourseVM)
        {
            Course objCourse = new Course();
            objCourse.CourseId = objCourseVM.CourseId;
            objCourse.Name = objCourseVM.Name;

            Course course = _repository.DeleteCourse(objCourse);
            string strDeleteMessage = "Course deleted successfully. Course ID. : " + course.CourseId + ". Course Name : " + course.Name;

            return strDeleteMessage;
        }
        
    }
}
