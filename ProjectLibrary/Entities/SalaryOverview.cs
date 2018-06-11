using System;

namespace ProjectLibrary.Entities
{
	public class SalaryOverview
	{
		public double BasicSalary { get; }
		public double CurrentSalary { get; }

		public SalaryOverview(double basicSalary, double currentSalary)
		{
			if (basicSalary < 0) throw new ArgumentException();
			if (currentSalary < 0) throw new ArgumentException();
			
			BasicSalary = basicSalary;
			CurrentSalary = currentSalary;
		}
	}
}