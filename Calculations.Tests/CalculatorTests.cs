using Xunit;
using Xunit.Abstractions;

namespace Calculations.Tests;

public class CalculatorTests : IClassFixture<CalculatorFixture>
{
    private readonly CalculatorFixture _calculatorFixture;
    private readonly MemoryStream _memoryStream;
    private readonly ITestOutputHelper _testOutputHelper;

    public CalculatorTests(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
    {
        _testOutputHelper = testOutputHelper;
        _testOutputHelper.WriteLine("Constructor");
        _memoryStream = new MemoryStream();
        _calculatorFixture = calculatorFixture;
    }

    [Fact]
    public void Add_GivenTwoIntValues_ReturnsInt()
    {
        var calc = _calculatorFixture.Calc;
        var result = calc.Add(1, 2);
        Assert.Equal(3, result);
    }

    [Fact]
    public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
    {
        var calc = _calculatorFixture.Calc;
        var result = calc.AddDouble(1.23, 3.55);
        Assert.Equal(4.78, result, 2);
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void FiboDoesNotIncludeZero()
    {
        _testOutputHelper.WriteLine("FiboDoesNotIncludeZero");
        var calc = _calculatorFixture.Calc;
        Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void FiboIncludes13()
    {
        _testOutputHelper.WriteLine("FiboIncludes13");
        var calc = _calculatorFixture.Calc;
        Assert.Contains(13, calc.FiboNumbers);
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void FiboDesNotInclude4()
    {
        _testOutputHelper.WriteLine("FiboDesNotInclude4");
        var calc = _calculatorFixture.Calc;
        Assert.DoesNotContain(4, calc.FiboNumbers);
    }

    [Fact]
    [Trait("Category", "Fibo")]
    public void CheckCollection()
    {
        _testOutputHelper.WriteLine("CheckCollection. Test Starting at {0}", DateTime.Now);
        var expectedCollection = new List<int> {1, 1, 2, 3, 5, 8, 13};
        _testOutputHelper.WriteLine("Creating an instance of Calculator class...");
        var calc = _calculatorFixture.Calc;
        _testOutputHelper.WriteLine("Asserting...");
        Assert.Equal(expectedCollection, calc.FiboNumbers);
        _testOutputHelper.WriteLine("End");
    }

    [Fact]
    public void IsOdd_GivenOddValue_ReturnsTrue()
    {
        var calc = _calculatorFixture.Calc;
        var result = calc.IsOdd(1);
        Assert.True(result);
    }

    [Fact]
    public void IsOdd_GivenEvenValue_ReturnsFalse()
    {
        var calc = _calculatorFixture.Calc;
        var result = calc.IsOdd(2);
        Assert.False(result);
    }

    [Theory]
    //[MemberData(nameof(TestDataShare.IsOddOrEvenExternalData), MemberType = typeof(TestDataShare))]
    [IsOddOrEvenData]
    public void IsOdd_TestOddAndEven(int value, bool expected)
    {
        var calc = _calculatorFixture.Calc;
        var result = calc.IsOdd(value);
        Assert.Equal(expected, result);
    }
}