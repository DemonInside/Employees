using System;
using System.Collections.Generic;
using System.Linq;

namespace Employees
{
    class Program
    {
        private const int AmountOfFirstEmployees = 5;
        private const int AmountOfLastEmployeesIds = 3;

        static void Main(string[] args)
        {
            var employeesService = new EmployeesService();

            List<Employee> employees = employeesService.CreateDefaultEmployeesList();

            Console.WriteLine("Not sorted list");
            ShowEmployeesData(employees);
            Console.WriteLine();

            var sortedEmployees = employees
                .OrderByDescending(e => e.Salary.GetAverageMonthlySalary())
                .ThenBy(e => e.Name).ToList();
            Console.WriteLine("Sorted list");
            ShowEmployeesData(sortedEmployees);
            Console.WriteLine();

            Console.WriteLine($"First {AmountOfFirstEmployees} employees in sorted list");
            ShowEmployeesData(sortedEmployees.Take(AmountOfFirstEmployees).ToList());
            Console.WriteLine();

            Console.WriteLine($"Identifiers of last {AmountOfLastEmployeesIds} employees in sorted list");
            ShowEmployeesData(sortedEmployees.Skip(sortedEmployees.Count - AmountOfLastEmployeesIds).ToList());
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