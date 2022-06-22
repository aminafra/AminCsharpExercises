using System;

namespace ExerciseTwo;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input number:");
        int k = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= k; i++)
        {
            for (int m = k; m >= i; m--)
            {
                Console.Write(" ");
            }
            for (int n = 1; n <= i; n++)
            {
                Console.Write($"{n}");
            }
            for (int j = 1; j < i; j++)
            {
                Console.Write($"{i - j}");
            }

            Console.WriteLine();
        }
        //==============T.A--Answer============================
        //Console.WriteLine("Input number:");
        //int lengh = Convert.ToInt32(Console.ReadLine());
        //for (int i = 1; i < lengh + 1; i++)
        //{
        //    string result = "";
        //    result += String.Concat(Enumerable.Repeat("*", lengh - i));
        //    for (int c = 1; c < i + 1; c++)
        //    {
        //        result += c;
        //    }
        //    for (int j = i - 1; j > 0; j--)
        //    {
        //        result += j;
        //    }

        //    result += String.Concat(Enumerable.Repeat("*", lengh - i));
        //    Console.WriteLine(result);
        //}
    }
}