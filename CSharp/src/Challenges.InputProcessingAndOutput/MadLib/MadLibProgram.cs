using Challenges.Core;
using Spectre.Console;

namespace Challenges.InputProcessingAndOutput.MadLib;

public class MadLibProgram : IChallengeProgram
{
    public Task RunAsync()
    {
        AnsiConsole.WriteLine(GetStory(AnsiConsole.Ask<string>("Enter a noun:"),
            AnsiConsole.Ask<string>("Enter a verb:"),
            AnsiConsole.Ask<string>("Enter an adjective:"),
            AnsiConsole.Ask<string>("Enter an adverb:")));
        return Task.CompletedTask;
    }

    private static string GetStory(string noun, string verb, string adjective, string adverb)
    {
        return $"Do you {verb} your {adjective} {noun} {adverb}? That's hilarious!";
    }
}