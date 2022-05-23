using System;

namespace ExerciseThree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter as number:");

            int num = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            for (int i = 1; i <= num; i += 2)
            {
                j += i;
            }
            Console.WriteLine(j);

        }
    }
}