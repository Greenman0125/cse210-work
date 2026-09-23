using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percent?");
        string grade_input=Console.ReadLine();
        float grade=float.Parse(grade_input);
        if (grade>=90)
        {
            Console.WriteLine("Congrats, you got an A");
            Console.WriteLine("You passed the class");
        }

        else if (grade<90&&grade>=80)
        {
            Console.WriteLine("Congrats, you got a B");
            Console.WriteLine("You passed the class");
        }

        else if (grade<80&&grade>=70)
        {
            Console.WriteLine("Congrats, you got a C");
            Console.WriteLine("You passed the class");
        }

        else if (grade<70&&grade>=60)
        {
            Console.WriteLine("Well, you got a D...");
            Console.WriteLine("You didn't pass the class, but maybe next time you will.");
        }

        else 
        {
            Console.WriteLine("Well, you got a F...");
            Console.WriteLine("You didn't pass the class, but maybe next time you will.");
        }
    }
}