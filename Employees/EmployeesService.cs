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
                new Employee { Id = 0, Name = "Василий", Salary = new FixedMonthlySalary { SalaryPerMonth = 30000m } },
                new Employee { Id = 0, Name = "Анна", Salary = new FixedMonthlySalary { SalaryPerMonth = 30000m } },
                new Employee { Id = 0, Name = "Анатолий", Salary = new HourlySalary { SalaryPerHour = 210.34m } },
                new Employee { Id = 0, Name = "Иван", Salary = new HourlySalary { SalaryPerHour = 150.24m } }
            };
        }
    }
}