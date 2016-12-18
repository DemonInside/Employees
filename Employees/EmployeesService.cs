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
                new Employee { Id = 0, Name = "Rick", Salary = new FixedMonthlySalary { SalaryPerMonth = 30000m } },
                new Employee { Id = 1, Name = "Jhon", Salary = new FixedMonthlySalary { SalaryPerMonth = 30000m } },
                new Employee { Id = 2, Name = "Jack", Salary = new HourlySalary { SalaryPerHour = 210.34m } },
                new Employee { Id = 3, Name = "Sam", Salary = new HourlySalary { SalaryPerHour = 150.24m } }
            };
        }
    }
}