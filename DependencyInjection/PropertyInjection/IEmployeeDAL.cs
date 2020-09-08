using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.PropertyInjection
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}
