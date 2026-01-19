using System.ComponentModel;
using System.Reflection.Metadata;

namespace Exercises.ControlFlow
{
    public static class DoWhileStatements
    {
        public static void Run()
        {
            /*
            Code project 1 - write code that validates integer input
            Here are the conditions that your first coding project must implement:

            Your solution must include either a do-while or while iteration.

            Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

            Inside the iteration block:

            Your solution must use a Console.ReadLine() statement to obtain input from the user.
            Your solution must ensure that the input is a valid representation of an integer.
            If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
            Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
            Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
            */

            /* 
            bool isValidInteger;
            int userInputInteger;

            do
            {
                Console.WriteLine("Enter an integer value between 5 and 10.");
                
                string? userInput = Console.ReadLine();
                isValidInteger = int.TryParse(userInput, out userInputInteger);
                //Console.WriteLine($"DEBUG: isValidInteger:{isValidInteger}, userInputInteger:{userInputInteger}");

            } while (!isValidInteger || userInputInteger <= 5 || userInputInteger >= 10);
            
            Console.WriteLine($"Your input value ({userInputInteger}) has been accepted."); */

            
            /* 
            Code project 2 - write code that validates string input
            Here are the conditions that your second coding project must implement:

            Your solution must include either a do-while or while iteration.

            Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names:
            Administrator, Manager, or User.

            Inside the iteration block:

            Your solution must use a Console.ReadLine() statement to obtain input from the user.
            Your solution must ensure that the value entered matches one of the three role options.
            Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
            Your solution should use the ToLower() method on the input value to ignore case.
            If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
            Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
            */

            /* 
            string? roleName;

            do
            {
                Console.WriteLine("Please enter your role name (Administrator, Manager, or User):");

                roleName = Console.ReadLine();
                if (string.IsNullOrEmpty(roleName)) continue;
                roleName = roleName.Trim().ToLower();

            } while (roleName != "administrator" && roleName != "manager" && roleName != "user");

            // concatenating the first letter character capitialized with the remainder of the substring
            Console.WriteLine($"Input of ({char.ToUpper(roleName[0]) + roleName[1..]}) role name was accepted!");
            */


            /* Code project 3 - Write code that processes the contents of a string array
            Here are the conditions that your third coding project must implement:

            your solution must use the following string array to represent the input to your coding logic:

            c#
            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.

            Your solution must include an outer foreach or for loop that can be used to process each string element in the array.
            The string variable that you'll process inside the loops should be named myString.

            In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable.
            The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.

            Your solution must include an inner do-while or while loop that can be used to process the myString variable.

            In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.

            In the inner loop, your solution must not display the period character.

            In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information. */

            string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

            foreach (string myString in myStrings)
            {
                int periodIdx = myString.IndexOf('.');
                string subString = myString;
                while (true)
                {

                    if (periodIdx < 0) 
                    {
                        Console.WriteLine(subString);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(subString.Substring(0, periodIdx));

                        subString = subString.Remove(0, periodIdx+1);
                        subString = subString.TrimStart();
                        periodIdx = subString.IndexOf('.');
                        
                    }
                }
            }
        }
    }
}

