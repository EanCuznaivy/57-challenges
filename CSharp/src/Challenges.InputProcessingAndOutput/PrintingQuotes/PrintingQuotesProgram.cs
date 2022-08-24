using System.Text;
using Challenges.Core;
using Spectre.Console;

namespace Challenges.InputProcessingAndOutput.PrintingQuotes;

public class PrintingQuotesProgram : IChallengeProgram
{
    public Task RunAsync()
    {
        var quote = AnsiConsole.Ask<string>("What is the quote?");
        var author = AnsiConsole.Ask<string>("Who said it?");
        AnsiConsole.WriteLine(GetQuoteOutput(quote, author));
        return Task.CompletedTask;
    }

    /// <summary>
    /// If your language supports string interpolation or string substitution,
    /// don’t use it for this exercise. Use string concatenation instead.
    /// </summary>
    /// <param name="quote"></param>
    /// <param name="author"></param>
    /// <returns></returns>
    private static string GetQuoteOutput(string quote, string author)
    {
        var output = new StringBuilder();
        output.Append(author);
        output.Append(" says, \"");
        output.Append(quote);
        output.Append('\"');
        return output.ToString();
    }
}