using System;
using System.Collections.Generic;
using System.Linq;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesService = new EmployeesService();

            List<Employee> employees = employeesService.CreateDefaultEmployeesList();

            Console.WriteLine("Not sorted list");
            ShowEmployeesData(employees);
            Console.WriteLine();

            Console.WriteLine("Sorted list");
            ShowEmployeesData(
                employees.OrderByDescending(e => e.Salary.GetAverageMonthlySalary()).ThenBy(e => e.Name).ToList()
            );
            Console.WriteLine();

            Console.ReadLine();
        }

        private static void ShowEmployeesData(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Id: {employee.Id} Name: {employee.Name} Salary: {employee.Salary.GetAverageMonthlySalary()}");
            }
        }
    }
}