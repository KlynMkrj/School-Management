using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Repositories
{
    public class Repository : IRepository
    {
        public Student SaveStudent(Student obj)
        {
            obj.RollNo = 5;
            return obj;
        }
    }
}
