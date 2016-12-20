using System;

namespace Employees.Salaries
{
    [Serializable]
    public class FixedMonthlySalaryEmployee : Employee
    {
        public decimal SalaryPerMonth { get; set; }

        public override decimal GetAverageMonthlySalary()
        {
            return SalaryPerMonth;
        }
    }
}