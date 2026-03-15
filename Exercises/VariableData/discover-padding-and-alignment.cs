using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

namespace Exercises.VariableData
{
    public static class DiscoverPaddingAndAlignment
    {
        public static void Run()
        {
            string input = "Pad Left";
            Console.WriteLine(input.PadLeft(12, '>'));
            
            input = "Pad Right";
            Console.WriteLine(input.PadRight(12, '<'));

            Console.WriteLine($"{"".PadLeft(45, '-')}");

            string paymentId = "769C";
            string paymentName = "Mr. Stephen Ortega";
            int paymentAmount = 5000;

            var formattedLine = paymentId.PadRight(6);
            formattedLine += paymentName.PadRight(24);
            formattedLine += $"{paymentAmount:C}".PadLeft(15);

            Console.WriteLine(formattedLine);
        }
    }
}