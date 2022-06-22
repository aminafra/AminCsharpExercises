using System;

namespace ExerciseFour
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("inter s1:");
            //string s1 = Console.ReadLine();
            //Console.Write("inser s2:");
            //string s2 = Console.ReadLine();
            //bool found = false;
            //for (int i = 0; i < s2.Length; i++)
            //{
            //    foreach (char ch in s1)
            //    {
            //        if (ch == s2[i])
            //        {
            //            found = true;
            //            Console.WriteLine($"{ch} ba character {i}om reshte s2 moshtarek ast");
            //            break;
            //        }

            //    }
            //}
            //if (found == false)
            //{
            //    Console.WriteLine("character moshtarek peyda nashod!!!");
            //}

            //===================true solution=========================
            Console.Write("enter s1:");
            string? s1 = Console.ReadLine();
            Console.Write("enter s2:");
            string? s2 = Console.ReadLine();
            bool isFound = false;

            for (int i = 0; i <= s1.Length - s2.Length; i++)
            {
                string sub = s1.Substring(i, s2.Length);
                if (sub == s2)
                {
                    isFound = true;
                    Console.WriteLine("true");
                    break;
                }
            }
            if (isFound == false)
            {
                Console.WriteLine(false);
            }
        }
    }
}