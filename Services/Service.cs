using System;

namespace Services
{
    public class Service : IService
    {
        IService iObj;
        public Service(IService iObj)
        {

        }

        public int SaveStudent(Student obj)
        {
            return 1;
        }
    }
}
