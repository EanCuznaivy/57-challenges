using Challenges.TurningProblemsIntoCode;
using Spectre.Console;

// Input
var tipInfo = new TipInfo(
    AnsiConsole.Prompt(new TextPrompt<decimal>("What is the bill?")
        .ValidationErrorMessage("Please enter a valid number for the bill amount.")
        .Validate(NegativeValueValidator)),
    AnsiConsole.Prompt(new TextPrompt<decimal>("What is the tip percentage?")
        .ValidationErrorMessage("Please enter a valid number for the tip percentage.")
        .Validate(NegativeValueValidator))
);

// Processing
var tip = tipInfo.CalculateTip();
var total = tip + tipInfo.Bill;

// Output
AnsiConsole.WriteLine($"The tip is ${tip}");
AnsiConsole.WriteLine($"The total is ${total}");

ValidationResult NegativeValueValidator(decimal value)
{
    return value switch
    {
        < 0 => ValidationResult.Error("Input cannot be negative."),
        _ => ValidationResult.Success()
    };
}