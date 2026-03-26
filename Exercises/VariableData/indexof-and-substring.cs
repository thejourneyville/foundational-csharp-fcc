using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

namespace Exercises.VariableData
{
    public static class IndexOfAndSubString
    {
        public static void Run()
        {
            string message = "Find what is (inside the parentheses)";

            string startingChar = "(";
            string endingChar = ")";

            int openingPosition = message.IndexOf(startingChar) + 1;
            int endingPosition = message.IndexOf(endingChar);
            int substringLength = endingPosition - openingPosition;

            string output = message.Substring(openingPosition, substringLength);

            Console.WriteLine(output);
        }
    }
}