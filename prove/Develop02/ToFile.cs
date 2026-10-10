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
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
}