using System;

namespace ExerciseFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> rptNum = new List<string>();
            Console.WriteLine("inter number greater than 100:");
            long bigNum = Convert.ToInt64(Console.ReadLine());
            while (bigNum < 100)
            {
                    Console.WriteLine("the number entered is less than 100. Re-enter:");
                    bigNum = Convert.ToInt64(Console.ReadLine());
            }
            Console.WriteLine("Now inter single digit number:");
            int shrtNum = Convert.ToByte(Console.ReadLine());
            while (shrtNum > 10)
            {
                Console.WriteLine("the number entered is greater than 10. Re-enter:");
                shrtNum = Convert.ToByte(Console.ReadLine());
            }
            for (long i = bigNum; i > 1; i /= 10)
            {
                if (i % 10 == shrtNum)
                {
                    rptNum.Add($"{shrtNum} repeated");
                }
            }
            Console.WriteLine($"number {shrtNum} reapet {rptNum.Count} times in number {bigNum}");
        }
    }
}