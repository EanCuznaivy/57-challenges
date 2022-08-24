using Shouldly;

namespace Challenges.TurningProblemsIntoCode.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(10, 15, 1.5)]
    [InlineData(11.25, 15, 1.69)]
    public void CalculateTipTest(decimal bill, decimal tipPercentage, decimal tip)
    {
        new TipInfo(bill, tipPercentage).CalculateTip().ShouldBe(tip);
    }
}