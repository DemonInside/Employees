using System;
using System.Collections.Generic;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesService = new EmployeesService();

            List<Employee> employees = employeesService.CreateDefaultEmployeesList();
            ShowEmployeesData(employees);

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