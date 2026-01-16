namespace Exercises.ControlFlow
{
    public static class DoWhileStatements
    {
        public static void Run()
        {
            /*
            Code challenge - write code to implement the game rules
            Here are the rules for the battle game that you need to implement in your code project:

            You must use either the do-while statement or the while statement as an outer game loop.
            The hero and the monster start with 10 health points.
            All attacks are a value between 1 and 10.
            The hero attacks first.
            Print the amount of health the monster lost and their remaining health.
            If the monster's health is greater than 0, it can attack the hero.
            Print the amount of health the hero lost and their remaining health.
            Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
            Print the winner.
            */

            Random random = new Random();
            int hero = 10;
            int monster = 10;

            do
            {
                // hero strikes first!
                Console.WriteLine("The Hero draws back his sword and swings!");
                Console.ReadLine();
                int heroStrike = random.Next(1, 11);
                monster -= heroStrike;
                Console.WriteLine($"Monster was damaged and lost {heroStrike} health and now has {monster} health.");
                
                if (monster <= 0)
                {
                    Console.WriteLine("Hero wins!");
                    continue;
                }
                
                Console.WriteLine("The monster screams and slashes out with its claws!");
                Console.ReadLine();
                int monsterStrike = random.Next(1, 11);
                hero -= monsterStrike;
                Console.WriteLine($"Hero was damaged and lost {monsterStrike} health and now has {hero} health.");

                if (hero <= 0)
                {
                    Console.WriteLine("Monster wins!");
                }
            } while (hero > 0 && monster > 0);
        }
    }
}

