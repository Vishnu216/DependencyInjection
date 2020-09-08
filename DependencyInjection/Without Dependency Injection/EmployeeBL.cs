using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Without_Dependency_Injection
{
    public class EmployeeBL
    {
        public EmployeeDAL employeeDAL;
        public List<Employee> GetAllEmployees()
        {
            employeeDAL = new EmployeeDAL();
            return employeeDAL.SelectAllEmployees();
        }
    }

}
