﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonEntities.BaseClasses;
using CommonEntities;

namespace DAL
{
    public class SQLDataAccessLayerManager : DALManagerBase
    {
        public override Employee GetEmployeeById(int employeeId)
        {
            //should write here the actual implementation which
            //gets an employee by id from SQL database

            Employee dummyEmployee = new Employee();
            dummyEmployee.Id = 1;
            dummyEmployee.Name = "Ahmed from SQL";
            dummyEmployee.Age = 27;

            return dummyEmployee;
        }
        public override EmployeeCollection GetEmployeesByName(string employeeName)
        {
            //should write here the actual implementation which
            //gets a collection of employees by name from SQL database

            EmployeeCollection dummyEmployeeCollection = new EmployeeCollection();
            dummyEmployeeCollection.Add(new Employee() { Id = 1, Name = "Ahmed 1 from SQL", Age = 27 });
            dummyEmployeeCollection.Add(new Employee() { Id = 2, Name = "Ahmed 2 from SQL", Age = 27 });
            dummyEmployeeCollection.Add(new Employee() { Id = 3, Name = "Ahmed 3 from SQL", Age = 27 });

            return dummyEmployeeCollection;
        }
    }
}
