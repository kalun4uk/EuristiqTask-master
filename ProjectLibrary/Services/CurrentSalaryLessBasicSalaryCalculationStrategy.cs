using ProjectLibrary.Entities;

namespace ProjectLibrary.Services
{
    public class CurrentSalaryLessBasicSalaryCalculationStrategy : ICalculationStrategy
    {
        public  double Calculate(SalaryOverview salary)
        {
            return salary.CurrentSalary * 0;
        }
    }
}
