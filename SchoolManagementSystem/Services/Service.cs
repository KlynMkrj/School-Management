using System;

using SchoolManagementSystem.Repositories;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Services
{
    public class Service : IService
    {
        IRepository repository;

        public Service(IRepository res)
        {
            repository = res;
        }

        public int SaveStudent(Student obj)
        {
            return repository.SaveStudent(obj);
        }
    }
}
