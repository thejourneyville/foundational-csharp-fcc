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

            Console.WriteLine();
            // using .ToLower().Trim();
            string value1 = " Apple ";
            string value2 = value1.ToLower().Trim();
            Console.WriteLine($"|{value1}| -> |{value2}|");
            
            Console.WriteLine();
            //inequality
            value1 = "A";
            value2 = "a";
            Console.WriteLine($"{value1} != {value2}: {value1 != value2}");

            Console.WriteLine();
            //comparison operator >= using dice roll
            Random roll = new Random();
            int roll1 = roll.Next(1, 7);
            Console.WriteLine(roll1);
            int roll2 = roll.Next(1, 7);
            Console.WriteLine(roll2);
            Console.WriteLine($"{roll1} >= {roll2}: {roll1 >= roll2}");
            roll1 = roll.Next(1, 7);
            roll2 = roll.Next(1, 7);
            Console.WriteLine($"{roll1} >= {roll2}: {roll1 >= roll.Next(1, 7)}");

            // using Contains
            string example1 = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine($"Contains: \"The quick brown fox jumps over the lazy dog\".Contains(\"fox\") {example1.Contains("fox")}");

            // logical negation
            string example2 = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine($"Contains: !\"The quick brown fox jumps over the lazy dog\".Contains(\"wolf\") {!example2.Contains("wolf")}");

            // Conditional Operator
            int roll3 = roll.Next(1, 7);
            string rollResult = roll3 > 3 ? "Greater than 3" : "3 or less"; 
            Console.WriteLine($"Result ({roll3}): {rollResult}");


        }

    }
}

