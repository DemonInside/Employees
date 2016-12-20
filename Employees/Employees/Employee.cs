using System;

namespace Employees
{
    [Serializable]
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract decimal GetAverageMonthlySalary();
    }
}