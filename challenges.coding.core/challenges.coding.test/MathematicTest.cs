using challenges.coding.core.services;
using Xunit;

namespace challenges.coding.test;

public class MathematicTest
{
    Mathematic math = new Mathematic();

    [Fact]
    public void GameWithCells_Test_Success()
    {
        var response = math.GameWithCells(3, 4);

        Assert.Equal(4, response);
    }

    [Fact]
    public void primeCount_Test_Success()
    {
        var response = math.primeCount(500);

        Assert.Equal(4, response);
    }
}
