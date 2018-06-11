using System;

namespace ProjectLibrary.Exceptions
{
	public class IncorrectCalculationException : Exception
	{
		public IncorrectCalculationException(double a) : base($"Incorrect calculation operation {a}")
		{
		}
	}
}