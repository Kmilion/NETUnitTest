using Xunit;

namespace Calculations.Tests;

public class NamesTest
{
    [Fact]
    public void MakeFullNameTest()
    {
        var result = Names.MakeFullName("Gonzalo", "Ceballos");
        Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
    }

    [Fact]
    public void NickName_MustBeNull()
    {
        var names = new Names
        {
            NickName = "Strong Man"
        };
        Assert.NotNull(names.NickName);
    }

    [Fact]
    public void MakeFullName_AlwaysReturnValue()
    {
        var result = Names.MakeFullName("Gonzalo", "Ceballos");
        Assert.NotNull(result);
        Assert.False(string.IsNullOrEmpty(result));
    }
}