using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonEntities.Interfaces
{
    public interface IDALManager
    {
        Employee GetEmployeeById(int employeeId);
        EmployeeCollection GetEmployeesByName(string employeeName);
    }
}
