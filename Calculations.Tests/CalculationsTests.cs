using Xunit;

namespace Calculations.Tests;

public class CalculationsTests
{
    [Fact]
    public void FiboDoesNotIncludeZero()
    {
        Assert.All(Calculations.FiboNumbers, n => Assert.NotEqual(0, n));
    }

    [Fact]
    public void FiboIncludes13()
    {
        Assert.Contains(13, Calculations.FiboNumbers);
    }

    [Fact]
    public void FiboDesNotInclude4()
    {
        Assert.DoesNotContain(4, Calculations.FiboNumbers);
    }

    [Fact]
    public void CheckCollection()
    {
        var expectedCollection = new List<int> {1, 1, 2, 3, 5, 8, 13};
        Assert.Equal(expectedCollection, Calculations.FiboNumbers);
    }
}