using System.Runtime.CompilerServices;

namespace Exercises.VariableData
{
    public static class CombineStringArray
    {
        public static void Run()
        {
            // start code
            string[] values = { "12.3", "45", "ABC", "11", "DEF"};
            
            string message = "";
            float sum = 0;
            float result = 0;
            
            foreach (string value in values)
            {
                bool isNumber = float.TryParse(value, out result);

                if (isNumber)
                {
                    sum += result;
                }
                else
                {
                    message += value;
                }
            }

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {sum}");
            
        }
    }
}