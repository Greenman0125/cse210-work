using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percent?");
        string grade_input=Console.ReadLine();
        float grade=float.Parse(grade_input);
        string letter="TBD";
        if (grade>=90)
        {
            letter="A";
        }

        else if (grade<90&&grade>=80)
        {
            letter="B";
        }

        else if (grade<80&&grade>=70)
        {
            letter="C";
        }

        else if (grade<70&&grade>=60)
        {
            letter="D";
        }

        else 
        {
            letter="F";
        }
        Console.WriteLine(letter);
    }
}