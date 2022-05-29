using System;

namespace ExerciseTwo
{
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
                    Console.Write($"{i-j}");
                }
                
                Console.WriteLine();
            }
        }
    }
}