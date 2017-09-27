using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using CommonEntities.BaseClasses;
using CommonEntities.Enums;
using DAL.Factories;
using CommonEntities;

namespace BLL
{
    public class BusinessLogicLayerManager
    {
        private DALManagerBase dALMngr;

        public BusinessLogicLayerManager(DALManagerType dALMngrType)
        {
            dALMngr = DataAccessLayerManagerFactory.GetDALManager(dALMngrType);
        }
        public Employee GetEmployeeById(int employeeId)
        {
            return dALMngr.GetEmployeeById(employeeId);
        }
        public EmployeeCollection GetEmployeesByName(string employeeName)
        {
            return dALMngr.GetEmployeesByName(employeeName);
        }
    }
}
