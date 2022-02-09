using MarsRover;
using Xunit;

namespace MarsRoverTest;

public class TestCases
{
    [Fact]
    public void TestCase1()
    {
        string dimensions = "5x5";
        string commandList = "FFRFLFLF";

        var actualResult=  RoverTask.PerformRoverTask(dimensions, commandList);
        var expectedResult = "1,1,West";
        Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void TestCase2()
    {
        string dimensions = "5x5";
        string commandList = "RFFFFFFFFFFFFR";

        var actualResult = RoverTask.PerformRoverTask(dimensions, commandList);
        var expectedResult = "1,5,South";
        Assert.Equal(expectedResult, actualResult);
    }
}

