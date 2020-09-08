using DependencyInjection.Without_Dependency_Injection;
using System;
using System.Collections.Generic;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            /// With no dependency injection applied

            //EmployeeBL employeeBL = new EmployeeBL();
            //List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            //foreach (Employee emp in ListEmployee)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            //}
            //Console.ReadKey();


            /// With Constructor Injection dependency injection applied
            ///  In Constructor Injection, we supply the dependency object through the client class constructor.

            // ConstructorInjectionDependencyInjection.EmployeeBL employeeBL = new ConstructorInjectionDependencyInjection.
            //    EmployeeBL(new ConstructorInjectionDependencyInjection.EmployeeDAL());
            //List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            //foreach (Employee emp in ListEmployee)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            //}
            //Console.ReadKey();


            ///With Property Injection applied 
            ///In Property Dependency Injection, we need to supply the dependency object through a
            ///public property of the client class.

            //PropertyInjection.EmployeeBL employeeBL = new PropertyInjection.EmployeeBL();
            //employeeBL.employeeDataObject = new PropertyInjection.EmployeeDAL();
            //List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            //foreach (Employee emp in ListEmployee)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            //}
            //Console.ReadKey();


            ///With Method Injection Applied
            ///In Method Injection,  we supply the dependency object through a public method of the client class
           
            MethodInjection.EmployeeBL employeeBL = new MethodInjection.EmployeeBL(new MethodInjection.EmployeeDAL());
            List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", emp.ID, emp.Name, emp.Department);
            }
            Console.ReadKey();

        }
    }
}
