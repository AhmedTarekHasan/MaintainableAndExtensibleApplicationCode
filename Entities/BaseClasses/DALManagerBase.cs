using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonEntities.Interfaces;

namespace CommonEntities.BaseClasses
{
    public abstract class DALManagerBase : IDALManager
    {
        public abstract Employee GetEmployeeById(int employeeId);
        public abstract EmployeeCollection GetEmployeesByName(string employeeName);
    }
}
