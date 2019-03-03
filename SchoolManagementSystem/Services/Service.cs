using System;

using SchoolManagementSystem.Repositories;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Services
{
    public class Service : IService
    {
        IRepository repository;

        public Service(IRepository irepository)
        {
            repository = irepository;
        }

        public Student SaveStudent(Student student)
        {
            return repository.SaveStudent(student);
        }

        public Course SaveCourse(Course course)
        {
            return repository.SaveCourse(course);
        }
    }
}
