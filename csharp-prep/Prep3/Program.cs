using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("You're trying to guess a random number between 1 and 100. What's your first guess?");
        string reply=Console.ReadLine();
        int guess=int.Parse(reply);
        Random rn=new Random();
        int number=rn.Next(1,100);
        while (guess!=number)
        {
            if (guess>number)
            {
                Console.WriteLine("Your guess was too high. Guess again.");
                string guess_next=Console.ReadLine();
                guess=int.Parse(guess_next);
            }
            else if (guess<number)
            {
               Console.WriteLine("Your guess was too low. Guess again.");
                string guess_next=Console.ReadLine();
                guess=int.Parse(guess_next); 
            }
            else
            {
            
            }
        }
        Console.WriteLine("Congrats, You Won!");
    }
}