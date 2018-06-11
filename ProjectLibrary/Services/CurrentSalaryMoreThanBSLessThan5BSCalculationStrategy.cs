using ProjectLibrary.Entities;

namespace ProjectLibrary.Services
{
    public class CurrentSalaryMoreThanBSLessThan5BSCalculationStrategy : ICalculationStrategy
    {
        public double Calculate(SalaryOverview salary)
        {
            return salary.CurrentSalary * 0.15;
        }
    }
}
