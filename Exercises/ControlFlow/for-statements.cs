namespace Exercises.ControlFlow
{
    public static class ForStatements
    {
        public static void Run()
        {
            // for (initializer; condition; iterator) { body }
            for (int i = 0; i < 10; i += 3)
            {
                Console.WriteLine(i);
                if (i == 6) break;
            }
        }

    }
}

