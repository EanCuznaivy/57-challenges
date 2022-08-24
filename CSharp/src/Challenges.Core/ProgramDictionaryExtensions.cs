using Spectre.Console;

namespace Challenges.Core;

public static class ProgramDictionaryExtensions
{
    public static void RunSelectedProgram(this ProgramMap programMap)
    {
        while (true)
        {
            var programName = AnsiConsole.Prompt(new SelectionPrompt<string>()
                .Title("Select a program to run.")
                .PageSize(7)
                .MoreChoicesText("[grey](Move up and down to reveal more programs)[/]")
                .AddChoices(programMap.Keys));
            if (programMap.TryGetValue(programName, out var program))
            {
                ((IChallengeProgram)Activator.CreateInstance(program)!).RunAsync();
            }
        }
    }
}