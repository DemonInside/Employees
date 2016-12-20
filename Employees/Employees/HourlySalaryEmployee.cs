using System;

namespace Employees.Salaries
{
    [Serializable]
    public class HourlySalaryEmployee : Employee
    {
        public decimal SalaryPerHour { get; set; }

        public override decimal GetAverageMonthlySalary()
        {
            return SalaryPerHour * (decimal)(WorkConsts.AverageWorkingDaysInMonth * WorkConsts.WorkingHoursInDay);
        }
    }
}