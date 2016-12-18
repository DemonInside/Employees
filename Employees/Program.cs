using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Serializers;

namespace Employees
{
    class Program
    {
        private const string FileName = "employees.dat";
        private const int AmountOfFirstEmployees = 5;
        private const int AmountOfLastEmployeesIds = 3;

        static void Main(string[] args)
        {
            List<Employee> employees = LoadEmployeesList();

            Console.WriteLine();
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

        private static List<Employee> LoadEmployeesList()
        {
            var employees = new List<Employee>();
            var employeesService = new EmployeesService();
            bool fileExists = File.Exists(FileName);
            var serializer = new BinarySerializer();
            if (fileExists)
            {
                try
                {
                    employees = serializer.Deserialize<List<Employee>>(FileName);
                    Console.WriteLine($"List of employees loaded from file {FileName}");
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"Error during deserialization. StackTrace: {exception.StackTrace}");
                    return new List<Employee>();
                }
            }
            else
            {
                employees = employeesService.CreateDefaultEmployeesList();
                try
                {
                    serializer.Serialize(employees, FileName);
                    Console.WriteLine($"List of employees loaded from default list and saved to file {FileName}");
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"Error during serialization. StackTrace: {exception.StackTrace}");
                    return new List<Employee>();
                }
            }
            return employees;
        }
    }
}