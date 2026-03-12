using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

namespace Exercises.VariableData
{
    public static class ParseOrders
    {
        public static void Run()
        {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            string[] orderStreamArray = orderStream.Split(",");
            Array.Sort(orderStreamArray);
            
            bool IdError;
            for (int i = 0; i < orderStreamArray.Length; i++)
            {
                if (orderStreamArray[i].Length < 4 || orderStreamArray[i].Length > 4)
                {
                    IdError = true;
                }
                else
                {
                    IdError = false;
                }

                Console.WriteLine($"{orderStreamArray[i]}{(IdError == true ? "\t - Error" : "")}");
            }
        }
    }
}