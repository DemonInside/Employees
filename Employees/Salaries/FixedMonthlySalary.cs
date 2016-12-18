using System;

namespace Employees.Salaries
{
    [Serializable]
    public class FixedMonthlySalary : ISalary
    {
        public decimal SalaryPerMonth { get; set; }

        public decimal GetAverageMonthlySalary()
        {
            return SalaryPerMonth;
        }
    }
}