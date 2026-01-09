using System.Security.Cryptography.X509Certificates;

namespace Exercises.ControlFlow
{
    public static class BooleanOperations
    {
        public static void Run()
        {
            Random coin = new Random();
            int flip = coin.Next(2);
            string result = flip == 0 ? "Heads" : "Tails";
            Console.WriteLine($"Flip[{flip}]: {result}");

        }

    }
}

