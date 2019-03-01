using System;
using System.Collections.Generic;
using System.Text;

using SchoolManagementSystem.Models;

namespace Services
{
    public interface IService
    {
        int SaveStudent(Student obj);
    }
}
