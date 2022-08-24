using Challenges.Core;
using Challenges.TurningProblemsIntoCode;
using Spectre.Console;

while (true)
{
    // Input
    var tipInfo = new TipInfo(
        AnsiConsole.Prompt(new TextPrompt<decimal>("What is the bill?")
            .ValidationErrorMessage("Please enter a valid number for the bill amount.")
            .Validate(CommonMethods.NegativeValueValidator)),
        AnsiConsole.Prompt(new TextPrompt<decimal>("What is the tip percentage?")
            .ValidationErrorMessage("Please enter a valid number for the tip percentage.")
            .Validate(CommonMethods.NegativeValueValidator))
    );

// Processing
    var tip = tipInfo.CalculateTip();
    var total = tip + tipInfo.Bill;

// Output
    AnsiConsole.WriteLine($"The tip is ${tip}");
    AnsiConsole.WriteLine($"The total is ${total}");
}
