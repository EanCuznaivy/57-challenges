using Spectre.Console;

namespace Challenges.Core;

public static class CommonMethods
{
    public static ValidationResult NegativeValueValidator(decimal value)
    {
        return value switch
        {
            < 0 => ValidationResult.Error("Input cannot be negative."),
            _ => ValidationResult.Success()
        };
    }
}