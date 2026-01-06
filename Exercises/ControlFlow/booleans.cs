namespace Exercises.ControlFlow
{
    public static class BooleanOperations
    {
        public static void Run()
        {
            // equality operator

            Console.WriteLine($"The result of (\"a\" == \"A\") is {("a" == "A")}"); // using the escape sequence \" to write a double quote as a string
            Console.WriteLine("a" == "A");

            Console.WriteLine(1 == 2);
            string myValue = "ABC";
            Console.WriteLine($"{myValue} == ABC");

        }

    }
}

