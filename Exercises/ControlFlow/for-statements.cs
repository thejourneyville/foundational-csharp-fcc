namespace Exercises.ControlFlow
{
    public static class ForStatements
    {
        public static void Run()
        {
            // for (initializer; condition; iterator) { body }
            // for (int i = 0; i < 10; i += 3)
            // {
            //     Console.WriteLine(i);
            //     if (i == 6) break;
            // }

            string[] names = new string[4];
            names[0] = "a";
            names[1] = "b";
            names[2] = "c";
            names[3] = "d";
            // names[4] = "e";
            //names[5] = "f";

            for (int i = names.Length - 1; i >= 0; i--)
            {
                if (names[i] == "b") names[i] = "benny";
            }

            foreach (var name in names) Console.WriteLine($"{name}");
        }

    }
}

