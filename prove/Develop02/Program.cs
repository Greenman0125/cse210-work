using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Menu myMenu=new Menu();

        Journal myJournal=new Journal();

        ToFile myFile=new ToFile();
        myFile._date="today";
        myFile._prompt="How are you and this is a test?";
        myFile._response="Good, but not really";
        List<ToFile> fixthis= new List<ToFile>();
        fixthis.Add(myFile);

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
                    myFile.ReadToFile();
                    //Call ReadFromFile()
                    break;
                case 4:
                    myFile.WriteToFIle(_writeEntries);
                    //Call WriteToFIle()
                    break;
            }
        }
    }
}