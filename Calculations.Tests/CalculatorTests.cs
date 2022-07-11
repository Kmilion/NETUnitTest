using Xunit;

namespace Calculations.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_GivenTwoIntValues_ReturnsInt()
    {
        var result = Calculator.Add(1, 2);
        Assert.Equal(3, result);
    }

    [Fact]
    public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
    {
        var result = Calculator.AddDouble(1.23, 3.55);
        Assert.Equal(4.78, result, 2);
    }
}