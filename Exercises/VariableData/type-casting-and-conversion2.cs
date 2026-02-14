namespace Exercises.VariableData
{
    public static class TypeCastingAndConversion2
    {
        public static void Run()
        {
            // TryParse example: a failed attempt

            string[] stringArray = ["1", "2", "apple", "4"];
            int result = 0;

            foreach (string i in stringArray)
            {
                if (int.TryParse(i, out result))
                {
                    Console.WriteLine($"{i} is parsable as {result}");
                }
                else
                {
                    Console.WriteLine($"{i} is not parsable - {result}");
                }

                if (result > 0) Console.WriteLine($"result outside code block:  {result}");
            }

            
        }
    }
}