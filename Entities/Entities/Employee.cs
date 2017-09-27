using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace CommonEntities
{
    public class Employee
    {
        int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }

    public class EmployeeCollection : Collection<Employee>
    {
    }
}
