using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.ConstructorInjectionDependencyInjection
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
}
