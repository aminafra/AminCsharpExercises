using System;

namespace ExerciseSix;
static class Program
{
    public static void AddOddNumbers(int number)
    {
        List<int> numbers = Enumerable.Range(1, number).ToList();
        int result = numbers.Where(x => x % 2 != 0).Sum();
        numbers.ForEach(i => Console.Write($"{i}, "));
        Console.WriteLine();
        Console.WriteLine($"Addition of odd numbers: {result}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("enter number:");
        int number = Convert.ToInt32(Console.ReadLine());
        AddOddNumbers(number);

    }
}