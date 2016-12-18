using Employees.Salaries;

namespace Employees
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ISalary Salary { get; set; }
    }
}