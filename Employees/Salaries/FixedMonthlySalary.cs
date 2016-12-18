namespace Employees.Salaries
{
    public class FixedMonthlySalary : ISalary
    {
        public decimal SalaryPerMonth { get; set; }

        public decimal GetAverageMonthlySalary()
        {
            return SalaryPerMonth;
        }
    }
}