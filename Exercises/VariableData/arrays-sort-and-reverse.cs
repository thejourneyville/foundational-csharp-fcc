namespace Exercises.VariableData
{
    public static class ArraysSortAndReverse
    {
        public static void Run()
        {
            string[] pallets = ["B14", "A11", "B12", "A13"];

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Console.WriteLine("Using Array method Clear...");
            Array.Clear(pallets, 2, 1);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Console.WriteLine("Trying to access a cleared index in an array...");
            Console.WriteLine($"pallets[2]: {pallets[2]}");

            Console.WriteLine("");
            Console.WriteLine("Getting length of array after using array method Clear...");
            Console.WriteLine($"pallets array length: {pallets.Length}");

            Console.WriteLine("");
            Console.WriteLine("Verifying pallets cleaed index is available...");
            try
            {
                Console.WriteLine($"pallets[2].ToLower(): {pallets[2].ToLower()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }

        }
    }
}