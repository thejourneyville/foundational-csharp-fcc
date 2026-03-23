using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

namespace Exercises.VariableData
{
    public static class ApplyStringInterpolation
    {
        public static void Run()
        {
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            // Your logic here
            Console.WriteLine($"Dear {customerName},");
            Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
            Console.WriteLine($"Currently, you own {currentShares.ToString("N2")} shares at a return of {currentReturn.ToString("0.##%")}.\n");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn.ToString("0.##%")}. Given your current volume, your potential would be {newProfit:C}.\n");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            // Your logic here
            comparisonMessage = $"{currentProduct.PadRight(20)}{currentReturn.ToString("0.##%").PadLeft(10)}{"".PadRight(3)}{currentProfit:C}\n{newProduct.PadRight(20)}{newReturn.ToString("0.##%").PadLeft(10)}{"".PadRight(3)}{newProfit:C}";

            Console.WriteLine(comparisonMessage);
        }
    }
}