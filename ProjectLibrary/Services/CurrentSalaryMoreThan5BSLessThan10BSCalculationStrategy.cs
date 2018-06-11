using ProjectLibrary.Entities;

namespace ProjectLibrary.Services
{
    public class CurrentSalaryMoreThan5BSLessThan10BSCalculationStrategy : ICalculationStrategy
    {
        public double Calculate(SalaryOverview salary)
        {
            return CurrentSalaryMinusFiveBasicSalariesDiff(salary) * 0.17 + 5 * salary.BasicSalary * 0.15;
        }

        private double CurrentSalaryMinusFiveBasicSalariesDiff(SalaryOverview salary) => salary.CurrentSalary - 5 * salary.BasicSalary;
    }
}
