using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

namespace Exercises.VariableData
{
    public static class FormatAlphanumericData
    {
        public static void Run()
        {
            string first = "Hello,";
            string second = "World!";

            // Composite Formating
            string sentence = string.Format("{0} {1}", first, second);
            Console.WriteLine(sentence);

            // String Interpolation
            sentence = $"{first} {second}";
            Console.WriteLine(sentence);

            // Currency Format Specifier :C
            decimal price = 42.50m;
            sentence = $"{price:C}";
            Console.WriteLine($"price: {sentence}");

            // Formatting Numbers
            price = 12345.12345m;
            sentence = $"Defaults to 2 decimal places (3 on MacOS): {price:N}";
            Console.WriteLine($"{sentence}");
            sentence = $"set precision of decimal with N#: {price:N5}";
            Console.WriteLine($"{sentence}");

            // Percentages
            decimal percentage = 2/3m;
            Console.WriteLine($"An amazing {percentage:P2} discount!");
        
        }
    }
}