using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1= new Job();
        Job1._jobTitle="Software Engineer";
        Job1._company="Google";
        Job1._startYear=2020;
        Job1._endYear=2025;

        Job Job2= new Job();
        Job2._jobTitle="Data Analyst";
        Job2._company="NASA";
        Job2._startYear=2012;
        Job2._endYear=2022;

        Resume myResume= new Resume();
        myResume._name="Jeff McJeffery";
        myResume._jobs.Add(Job1);
        myResume._jobs.Add(Job2);
        myResume.Display();
    }
}