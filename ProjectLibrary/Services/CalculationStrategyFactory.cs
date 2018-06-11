using ProjectLibrary.Entities;

namespace ProjectLibrary.Services
{
    public class CalculationStrategyFactory
    {
        private readonly SalaryOverview _salary;

        public CalculationStrategyFactory(SalaryOverview data)
        {
            _salary = data;
        }

        public ICalculationStrategy Salary()
        {
            if (_salary.CurrentSalary >= 0 && _salary.CurrentSalary <= _salary.BasicSalary)
                return new CurrentSalaryLessBasicSalaryCalculationStrategy();
            if (_salary.CurrentSalary > _salary.BasicSalary && _salary.CurrentSalary <= 5 * _salary.BasicSalary)
                return new CurrentSalaryMoreThanBSLessThan5BSCalculationStrategy();
            if (_salary.CurrentSalary > 5 * _salary.BasicSalary && _salary.CurrentSalary <= 10 * _salary.BasicSalary)
                return new CurrentSalaryMoreThan5BSLessThan10BSCalculationStrategy();
            return new CurrentSalaryMoreThan10BSCalculationStrategy();
        }
    }
}
