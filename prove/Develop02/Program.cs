using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu=new Menu();

        Journal myJournal=new Journal();

        ToFile myFile=new ToFile();

       int response = 0;

       while(response !=5)
        {
            
            response=myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    myJournal.CreateEntry();
                    break;
                case 2:
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    Console.WriteLine("Load");
                    //Call ReadFromFile()
                    break;
                case 4:
                    myFile.WriteToFIle();
                    //Call WriteToFIle()
                    break;
            }
        }
    }
}