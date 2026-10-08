using System.Reflection.Metadata.Ecma335;

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

    public void CreateEntry()
    {
        // DateTime today = DateTime.Today;
        // string date = today.ToString("d");
        // Console.WriteLine($"{date}");
        _date = DateTime.Now.ToString();
        _prompt = "How was your day?"; // This needs to be randomly itterated at some point
        Console.WriteLine($"{_prompt}: ");
        _response = Console.ReadLine();
    }
    
}