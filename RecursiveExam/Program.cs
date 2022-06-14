using System;
using System.Collections.Generic;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter string: ");
            string? word = Console.ReadLine().ToLower();
            pCheck(word);
        }

        public static void pCheck(string str)
        {
            int m = 0;
            int n = str.Length - 1;


            if (str.Length == 3 && str[0] == str[2])
            {
                Console.WriteLine("true");
            }
            else if (str.Length == 2 && str[0] == str[1])
            {
                Console.WriteLine("true");
            }
            else
            {
                if (str[0] == str[str.Length - 1])
                {
                    pCheck(str.Substring(m + 1, n - m - 1));
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }

    }
}