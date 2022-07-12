namespace Calculations.Tests;

public class CalculatorFixture : IDisposable
{
    public Calculator Calc => new();

    public void Dispose()
    {
        // Clean
    }
}