using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

namespace Exercises.VariableData
{
    public static class IndexOfAny
    {
        public static void Run()
        {
            string message1 = "(What if) there are (more than) one (set of parentheses)?";

            while (true)
            {
                int openingIdx = message1.IndexOf('(');
                if (openingIdx == -1) break;

                int closingIdx = message1.IndexOf(')');

                int firstCharIdx = openingIdx + 1;
                int length = closingIdx - firstCharIdx;

                Console.WriteLine(message1.Substring(firstCharIdx, length));

                message1 = message1.Substring(closingIdx + 1);
            }

            Console.WriteLine("==============================");

            string message2 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
            int openingIdx2 = 0;


            while (openingIdx2 >= 0)
            {
                char[] possibleSymbols = { '(', '[', '{' };

                openingIdx2 = message2.IndexOfAny(possibleSymbols);
                if (openingIdx2 == -1) break;
                
                string openingSymbol = message2.Substring(openingIdx2, 1);
                char closingSymbol = ' ';

                switch (openingSymbol)
                {
                    case "(":
                        closingSymbol = ')';
                        break;

                    case "[":
                        closingSymbol = ']';
                        break;

                    case "{":
                        closingSymbol = '}';
                        break;
                }

                int closingIdx2 = message2.IndexOf(closingSymbol);
                int stringLength = closingIdx2 - openingIdx2;
                Console.WriteLine(message2.Substring(openingIdx2 + 1, stringLength - 1));

                message2 = message2.Substring(closingIdx2);

            }
        }
    }
}