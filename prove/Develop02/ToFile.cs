using System.IO; 


class ToFile
{
    public List<JournalEntry> _writeEntries =new List<JournalEntry>();

    
    public void WriteToFIle()
    {
        Console.WriteLine("Please Enter the file name to save to.");
        string filename = Console.ReadLine();
        foreach(JournalEntry entry in _writeEntries)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(entry);
            }
        }
        
        
    }

    public void ReadToFile()
    {
        Console.WriteLine("Please Enter the file name to load from.");
        string filename = Console.ReadLine();
        System.IO.File.ReadAllLines(filename);
    }
}