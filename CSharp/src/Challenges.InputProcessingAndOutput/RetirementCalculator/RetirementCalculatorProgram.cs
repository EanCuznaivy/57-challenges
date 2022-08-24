using Challenges.Core;
using Spectre.Console;

namespace Challenges.InputProcessingAndOutput.RetirementCalculator;

public class RetirementCalculatorProgram : IChallengeProgram
{
    public Task RunAsync()
    {
        var age = AnsiConsole.Ask<int>("What is your current age?");
        var retireAge = AnsiConsole.Ask<int>("At what age would you like to retire?");
        var leftYears = retireAge - age;
        if (leftYears > 0)
        {
            var currentYear = DateTime.Now.Year;
            AnsiConsole.WriteLine($"You have {leftYears} years left until you can retire.");
            AnsiConsole.WriteLine($"It's {currentYear}, so you can retire in {currentYear + leftYears}.");
        }
        else
        {
            AnsiConsole.WriteLine("You can already retire.");
        }

        return Task.CompletedTask;
    }
}