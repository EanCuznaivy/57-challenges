namespace Challenges.TurningProblemsIntoCode;

public static class TipInfoExtensions
{
    public static decimal CalculateTip(this TipInfo tipInfo)
    {
        return Math.Round(tipInfo.Bill * tipInfo.TipPercentage / 100, 2);
    }
}