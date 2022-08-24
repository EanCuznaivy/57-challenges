using Challenges.Core;
using Spectre.Console;

namespace Challenges.InputProcessingAndOutput.SayingHello;

public class SayingHelloChallengeProgram : IChallengeProgram
{
    public Task RunAsync()
    {
        AnsiConsole.WriteLine($"Hello, {AnsiConsole.Ask<string>("What is your name?")}, nice to meet you!");
        return Task.CompletedTask;
    }
}