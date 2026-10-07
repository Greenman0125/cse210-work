using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName(ref string name)
    {
        Console.WriteLine("Please enter your name: ");
        name=Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(ref int number)
    {
        Console.WriteLine("Please enter your favorite number: ");
        string reply=Console.ReadLine();
        number=int.Parse(reply);
        return number;
    }
    static int PromptUserBirthYear(out int year)
    {
        Console.WriteLine("Please enter your birth year: ");
        string reply=Console.ReadLine();
        year=int.Parse(reply);
        return year;
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name="Bob";
        int number=0;
        int year=2000;
        Console.WriteLine($"Hello {PromptUserName(ref name)}, the square of your number is {PromptUserNumber(ref number)*number}");
        Console.WriteLine($"{name}, you will turn {2026-PromptUserBirthYear(out year)} this year.");
    }
}