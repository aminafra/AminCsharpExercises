using System;

namespace ExerciseFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> rptNum = new List<string>();
            int rpt = 0;
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
                    //rptNum.Add($"{shrtNum} repeated");
                    rpt += 1;
                }
            }
            Console.WriteLine($"number {shrtNum} reapet {rpt} times in number {bigNum}");
        }
    }
}