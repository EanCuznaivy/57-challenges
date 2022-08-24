using Challenges.Core;
using Challenges.InputProcessingAndOutput.CountingTheNumberOfCharacters;
using Challenges.InputProcessingAndOutput.MadLib;
using Challenges.InputProcessingAndOutput.PrintingQuotes;
using Challenges.InputProcessingAndOutput.RetirementCalculator;
using Challenges.InputProcessingAndOutput.SayingHello;
using Challenges.InputProcessingAndOutput.SimpleMath;

namespace Challenges.InputProcessingAndOutput;

public static class InputProcessingAndOutput
{
    public static readonly ProgramMap ProgramMap = new()
    {
        { "1. Saying Hello", typeof(SayingHelloChallengeProgram) },
        { "2. Counting the Number of Characters", typeof(CountingTheNumberOfCharactersChallengeProgram) },
        { "3. Printing Quotes", typeof(PrintingQuotesProgram) },
        { "4. Mad Lib", typeof(MadLibProgram) },
        { "5. Simple Math", typeof(SimpleMathProgram) },
        { "6. Retirement Calculator", typeof(RetirementCalculatorProgram) }
    };
}