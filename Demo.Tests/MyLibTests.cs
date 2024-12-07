using FluentAssertions;

namespace Demo.Tests;

public class MyLibTests
{
    [Theory]
    [InlineData(10, "child")]
    [InlineData(20, "adult")]
    public void DoMagic_Super_Test(int input, string expected)
    {
        MyLib.DoMagic(input).Should().Be(expected);
    }
}