using System.IO; 


class ToFile
{
    
    public void WriteToFIle()
    {
        
    
        string filename = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
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