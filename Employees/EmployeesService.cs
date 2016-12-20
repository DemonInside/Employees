using System.Collections.Generic;
using Employees.Salaries;

namespace Employees
{
    public class EmployeesService
    {
        public List<Employee> CreateDefaultEmployeesList()
        {
            return new List<Employee>
            {
                new FixedMonthlySalaryEmployee { Id = 0, Name = "Rick", SalaryPerMonth = 30000m },
                new FixedMonthlySalaryEmployee { Id = 1, Name = "Jhon", SalaryPerMonth = 30000m },
                new HourlySalaryEmployee { Id = 2, Name = "Jack", SalaryPerHour = 210.34m },
                new HourlySalaryEmployee { Id = 3, Name = "Sam", SalaryPerHour = 150.24m },
                new FixedMonthlySalaryEmployee { Id = 4, Name = "Ann", SalaryPerMonth = 31000m },
                new FixedMonthlySalaryEmployee { Id = 5, Name = "Ben", SalaryPerMonth = 29902m },
                new HourlySalaryEmployee { Id = 6, Name = "Eloise", SalaryPerHour = 179m }
            };
        }
    }
}