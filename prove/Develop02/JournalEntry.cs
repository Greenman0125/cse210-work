class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;


    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);
    }

    public void CreateJournalEntry()
    {
        string [] prompts =
        {
            "How was your day?",
            "Tell me about what happened today.",
            "What's something that went really well today?",
            "Was there anything that happened you wish went differently?",
            "Did you meet anybody new today? What were they like if you did?",
            "What's one thing you got done today?",
            "How have your classes been going recently?"
        };
        
        _date=DateTime.Now.ToString();
        Random rand=new Random();
        int num=rand.Next(0,6);
        _prompt= prompts[num];
        Console.Write($"{_prompt}: ");
        _response=Console.ReadLine();
    }
}