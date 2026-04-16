using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

namespace Exercises.VariableData
{
    public static class IndexOfAny
    {
        public static void Run()
        {
            string message = "(What if) there are (more than) one (set of parentheses)?";

            while (true) {
                int openingIdx = message.IndexOf('(');
                if (openingIdx == -1) break;
                
                int closingIdx = message.IndexOf(')');

                int firstCharIdx = openingIdx + 1;
                int length = closingIdx - firstCharIdx;
                
                Console.WriteLine(message.Substring(firstCharIdx, length));
                
                message = message.Substring(closingIdx+1);
            }

        }
    }
}