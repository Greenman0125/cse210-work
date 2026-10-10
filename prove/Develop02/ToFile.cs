using System.IO; 


class ToFile
{
    public List<JournalEntry> _writeEntries =new List<JournalEntry>();

    
    public void WriteToFIle()
    {
        string filename = @"C:\Users\jmbus\.vscode\CSE 210\cse210-work\prove\Develop02\journal.txt";
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
        string filename = @"C:\Users\jmbus\.vscode\CSE 210\cse210-work\prove\Develop02\journal.txt";
        System.IO.File.ReadAllLines(filename);

    }
}