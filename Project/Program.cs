using System;
using ProjectLibrary;
using ProjectLibrary.Entities;
using ProjectLibrary.Services;

namespace Project
{
	internal static class Program
	{
		private static void Main()
		{
            A:
		    try
		    {

		        double basicSalary, currentSalary;
		         Console.WriteLine("Enter BS - Basic Salary ");
		         basicSalary = double.Parse(Console.ReadLine());

		         Console.WriteLine("Enter CS - Current Salary ");
		         currentSalary = double.Parse(Console.ReadLine());

		         var action = new SalaryCalculator(new SalaryOverview(basicSalary, currentSalary));
		         Console.WriteLine(action);
		    }

		    catch (FormatException)
		    {
		        //if (!basicSalary.IsNumeric() || !currentSalary.IsNumeric())
		        //{
		        Console.WriteLine("Entered value is not numeric");
		        goto A;
		        //}
		    }

		    Console.ReadKey();
		}
	}
}