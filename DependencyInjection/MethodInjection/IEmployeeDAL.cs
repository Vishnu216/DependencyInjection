using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.MethodInjection
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}
