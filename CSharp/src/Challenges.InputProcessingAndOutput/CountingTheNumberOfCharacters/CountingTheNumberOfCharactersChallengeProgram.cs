using Challenges.Core;
using Spectre.Console;

namespace Challenges.InputProcessingAndOutput.CountingTheNumberOfCharacters;

public class CountingTheNumberOfCharactersChallengeProgram : IChallengeProgram
{
    public Task RunAsync()
    {
        var word = AnsiConsole.Prompt(new TextPrompt<string>("What is the input string?")
            .Validate(word =>
                string.IsNullOrWhiteSpace(word)
                    ? ValidationResult.Error("Please input a valid string.")
                    : ValidationResult.Success()));
        AnsiConsole.WriteLine($"{word} has {word.Length} characters.");
        return Task.CompletedTask;
    }
}