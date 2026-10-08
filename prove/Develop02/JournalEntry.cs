using System.Reflection.Metadata.Ecma335;

class JournalEntry
{
    public string _date;
    
    public string _prompt;

    public string _response;

    Random rand = new Random();

    public void DisplayJournalEntry()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_date}, {_prompt}");
        Console.WriteLine(_response);
    }

    public void CreateJournalEntry()
    {
        string [] prompts =
        {
            "How was your day?",
            "Talk about someone you met.",
            "What is something you enjoyed today?",
            "How did you improve today?",
            "What was your favorite thing you did today?"
        };

        int random = rand.Next(0,5);
        DateTime today = DateTime.Today;
        _date = today.ToString("d");
        _prompt = prompts[random];
        Console.Write($"{_prompt}: ");
        _response = Console.ReadLine();
    }
    
    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }

    public void CreateJournalEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }
}