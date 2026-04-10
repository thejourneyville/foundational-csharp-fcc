using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

namespace Exercises.VariableData
{
    public static class IndexOfAndSubString
    {
        public static void Run()
        {
            string message1 = "Find what is (inside the parentheses)";

            string startingChar = "(";
            string endingChar = ")";

            int openingPosition = message1.IndexOf(startingChar) + 1;
            int endingPosition = message1.IndexOf(endingChar);
            int substringLength = endingPosition - openingPosition;

            string output = message1.Substring(openingPosition, substringLength);

            Console.WriteLine(output);

            // ============

            string message2 = "what is value <span>between the tags</span>?";

            const string openSpan = "<span>";
            const string closedSpan = "</span>";

            int openingPosition1 = message2.IndexOf(openSpan) + openSpan.Length;
            int endingPosition1 = message2.IndexOf(closedSpan);

            Console.WriteLine($"{message2.Substring(openingPosition1, endingPosition1 - openingPosition1)}");
            

        }
    }
}