﻿namespace Employees.Salaries
{
    public class HourlySalary : ISalary
    {
        public decimal SalaryPerHour { get; set; }

        public decimal GetAverageMonthlySalary()
        {
            return SalaryPerHour * (decimal)(WorkConsts.AverageWorkingDaysInMonth * WorkConsts.WorkingHoursInDay);
        }
    }
}