using System;

namespace ExerciseTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int m = 5; m >= i; m--)
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