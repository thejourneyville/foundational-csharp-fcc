namespace Exercises.VariableData
{
    public static class TypeCastingAndConversion
    {
        public static void Run()
        {
            // int first = 2;
            // string second = "4";
            // string result = first + second;
            // Console.WriteLine(result);

            // int myInt = 3;
            // Console.WriteLine($"int: {myInt}");

            // decimal myDecimal = myInt;
            // Console.WriteLine($"decimal: {myDecimal}");

            decimal myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            // cast - a narrowing conversion
            int myInt = (int)myDecimal;
            Console.WriteLine($"int: {myInt}");

            // another narrowing conversion from decimal to float
            decimal myDecimal1 = 1.12345678123456789m;
            float myFloat1 = (float)myDecimal1;

            Console.WriteLine($"myDecimal1:     {myDecimal1}");
            Console.WriteLine($"myFloat1:       {myFloat1}");



        }
    }
}