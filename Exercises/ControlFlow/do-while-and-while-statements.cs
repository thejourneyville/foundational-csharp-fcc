using System.Reflection.Metadata;

namespace Exercises.ControlFlow
{
    public static class DoWhileStatements
    {
        public static void Run()
        {
            string? readResult;
            
            do
            {
                Console.WriteLine("Enter a string:");
                readResult = Console.ReadLine();
            } while (readResult == null || readResult == "");

            // int numericValue;
            // bool output;
            bool output = int.TryParse(readResult, out int numericValue);
            Console.WriteLine($"output: {output}, numericValue + 5: {numericValue + 5}");
        }
    }
}

