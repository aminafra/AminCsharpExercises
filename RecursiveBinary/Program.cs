using System;
using RecursiveBinary;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter Decimal number:");
        int dec = Convert.ToInt32(Console.ReadLine());

        Calculate Binary = new Calculate();
        Console.Write($"Binary of {dec} = ");
        Binary.DecToBin(dec);
        
    }
}