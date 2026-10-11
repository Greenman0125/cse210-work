using System.IO; 


class ToFile
{
    public List<JournalEntry> _writeEntries =new List<JournalEntry>();

    public string _date;
    public string _prompt;
    public string _response;
    
    
    public void WriteToFIle(List<JournalEntry> _writeEntries)
    {
        string filename = @"C:\Users\jmbus\.vscode\CSE 210\cse210-work\prove\Develop02\journal.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach(JournalEntry entry in _writeEntries)
                {
                    outputFile.WriteLine(entry._date);
                    outputFile.WriteLine(entry._prompt); 
                    outputFile.WriteLine(entry._response); 
                }
                         
            }
    }

    public void ReadToFile()
    {
        string filename = @"C:\Users\jmbus\.vscode\CSE 210\cse210-work\prove\Develop02\journal.txt";
        System.IO.File.ReadAllLines(filename);

    }
}