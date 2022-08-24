using Challenges.Core;
using Spectre.Console;

namespace Challenges.InputProcessingAndOutput.SimpleMath;

public class SimpleMathProgram : IChallengeProgram
{
    public Task RunAsync()
    {
        var first = AnsiConsole.Prompt(new TextPrompt<decimal>("What is the first number?")
            .Validate(CommonMethods.NegativeValueValidator));
        var second = AnsiConsole.Prompt(new TextPrompt<decimal>("What is the second number?")
            .Validate(CommonMethods.NegativeValueValidator));

        var sum = first + second;
        AnsiConsole.WriteLine($"{first} + {second} = {sum}");

        var sub = first - second;
        AnsiConsole.WriteLine($"{first} - {second} = {sub}");

        var mul = first * second;
        AnsiConsole.WriteLine($"{first} * {second} = {mul}");

        var div = first / second;
        AnsiConsole.WriteLine($"{first} / {second} = {div}");
        return Task.CompletedTask;
    }
}