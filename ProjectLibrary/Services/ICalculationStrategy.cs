using ProjectLibrary.Entities;

namespace ProjectLibrary.Services
{
    public interface ICalculationStrategy
    {
        double Calculate(SalaryOverview salary);
    }
}

