﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.PropertyInjection
{
    public class EmployeeBL
    {
        private IEmployeeDAL employeeDAL;
        public IEmployeeDAL employeeDataObject
        {
            set
            {
                this.employeeDAL = value;
            }
            get
            {
                if (employeeDataObject == null)
                {
                    throw new Exception("Employee is not initialized");
                }
                else
                {
                    return employeeDAL;
                }
            }
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.SelectAllEmployees();
        }
    }

}
