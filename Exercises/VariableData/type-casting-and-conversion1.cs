namespace Exercises.VariableData
{
    public static class TypeCastingAndConversion1
    {
        public static void Run()
        {
            // converting numbers to a string
            int number1 = 5;
            int number2 = 7;

            string concatNumbers = "";

            concatNumbers += number1.ToString();
            concatNumbers += number2.ToString();

            Console.WriteLine(concatNumbers);

            // parsing string type numbers into a number type

            int numberSum = 0;
            foreach (char i in concatNumbers)
            {
                if (int.TryParse(i.ToString(), out int parsedNumber))
                {
                    numberSum += parsedNumber;
                }
            }

            Console.WriteLine(numberSum);

            // in a more performant way, this works because C# treats char as 16-bit numeric values
            numberSum = 0;
            foreach (char i in concatNumbers)
            {
                // in the first iteration of i, the ascii value of '5' is 53, the ascii value of '0' is 48 -> 53 - 48 = 5
                numberSum += (i - '0');
            }

            Console.WriteLine(numberSum);


            // casting vs converting

            int narrowingCast = (int)3.14m; // truncates
            int narrowingConversion = Convert.ToInt32(3.65m); // rounds
            Console.WriteLine($"casting to int:     {narrowingCast}");
            Console.WriteLine($"conversion to int:     {narrowingConversion}");

        }
    }
}