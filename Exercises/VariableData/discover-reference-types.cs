using System.ComponentModel;
using System.Dynamic;
using System.Reflection.Metadata;
using System;
using System.IO;
using System.Globalization;

namespace Exercises.VariableData
{
    public static class DiscoverReferenceTypes
    {
        public static void Run()
        {
            int[] arrayOfNumbers1 = new int[2];
            int[] arrayOfNumbers2 = new int[2];

            arrayOfNumbers1 = [3, 4];
            arrayOfNumbers2 = [1, 2];
            arrayOfNumbers2 = arrayOfNumbers1;

            arrayOfNumbers2[0] = 42;

            Console.WriteLine($"{arrayOfNumbers1[0]}, {arrayOfNumbers1[1]}");

        }
    }
}