using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers= new List<int>();
        Console.WriteLine("Please enter a number.");
        string entry=Console.ReadLine();
        int number=int.Parse(entry);
        numbers.Add(number);
        while (number!=0)
        {
            Console.WriteLine("Please enter another number.");
            string entry2=Console.ReadLine();
            number=int.Parse(entry2);
            numbers.Add(number);
        }
        Console.WriteLine($"The Total is {numbers.Sum()}");
        Console.WriteLine($"The Average is {numbers.Average()}");
        Console.WriteLine($"The Max is {numbers.Max()}");
    }
}