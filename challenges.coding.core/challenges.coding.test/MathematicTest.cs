using challenges.coding.core.services;
using System.Collections.Generic;
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
        var response = math.primeCount(1000000000000000000);

        Assert.Equal(16, response);
    }

    [Fact]
    public void ConnectionTowns_Test_Success()
    {
        var response = math.ConnectionTowns(4, new List<int> { 3,4,5 });

        Assert.Equal(16, response);
    }
}
