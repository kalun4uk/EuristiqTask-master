using System.Text;
using ProjectLibrary.Entities;

namespace ProjectLibrary.Services
{
	public class SalaryCalculator
	{
		private readonly ICalculationStrategy _strategy;
		private readonly SalaryOverview _salary;

		public SalaryCalculator(SalaryOverview data)
		{
			_salary = data;
		    _strategy = new CalculationStrategyFactory(data).Salary();
		}

		private double GetCurrentSalary() => _salary.CurrentSalary - CalculationObligantPayment();

		private double CalculationObligantPayment()
		{
			return _strategy.Calculate(_salary);
		}

		public override string ToString()
		{
			var sb = new StringBuilder();

			sb.AppendLine("Basic Salary: " + _salary.BasicSalary);
			sb.AppendLine("Current Salary (Bruto): " + _salary.CurrentSalary);
			sb.AppendLine("Taxes to pay: " + CalculationObligantPayment());
			sb.AppendLine("Current Salary​ (Netto): " + GetCurrentSalary());
			return sb.ToString();
		}
	}
}