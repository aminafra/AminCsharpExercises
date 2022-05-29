using System;

namespace ExerciseFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("inter s1:");
            string s1 = Console.ReadLine();
            Console.Write("inser s2:");
            string s2 = Console.ReadLine();
            for(int i = 0; i < s2.Length; i++)
            {
                foreach (char ch in s1)
                {
                    if (ch == s2[i])
                    {
                        Console.WriteLine($"{ch} ba character {i}om reshte s2 moshtarek ast");
                        break;
                    }
                }
            }
        }
    }
}