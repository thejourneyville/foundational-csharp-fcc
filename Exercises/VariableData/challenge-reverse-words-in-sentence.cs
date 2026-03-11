using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

namespace Exercises.VariableData
{
    public static class ReverseWordsInSentence
    {
        public static void Run()
        {
            // Write the code necessary to reverse the letters of each word in place and display the result.

            // In other words, don't just reverse every letter in the variable pangram. Instead, you need to reverse just the letters in each word, but print the reversed word in its original position in the message.

            // Your code must produce the following output:

            // Output
            // ehT kciuq nworb xof spmuj revo eht yzal god

            string pangram = "The quick brown fox jumps over the lazy dog.";

            string[] words = pangram.Split(" ");
            string[] output = new string[words.Length];
            int index = 0;

            foreach (string word in words)
            {
                if (word != null)
                {
                    char[] charWord = word.ToCharArray();
                    Array.Reverse(charWord);
                
                    if (charWord != null)
                    {
                        output[index] = new string(charWord);
                    }
                    
                    index++;
                }
            }

            Console.WriteLine(String.Join(" ", output));
        }
    }
}