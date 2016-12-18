using System;
using Employees.Salaries;

namespace Employees
{
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ISalary Salary { get; set; }
    }
}