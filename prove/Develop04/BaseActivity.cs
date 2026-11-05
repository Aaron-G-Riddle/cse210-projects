using System.Runtime.CompilerServices;

class BaseActivity
{
    private int _duration;
    private DateTime _endTime;
    private string _activityName;
    private string _description;
    public BaseActivity()
    {
        _duration = 30; // Replace with call to ObtainDuration();        
    }
    public void StartActivity()
    {
        Console.Write("How long would you like to do this activty? - ");
        ObtainDuration();

    }
    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }
    public bool HasTimerExpired()
    {
        return DateTime.Now > _endTime;
    }
    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for (int i = seconds; i>0; i--)
        {
            Console.Clear();
            Console.WriteLine($"{message} - {i}");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }
    public void RunSpinner(string message, int seconds)
    {
        Console.CursorVisible = false;
        // DateTime now = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        // for (int i = 0; i < seconds; i++)
        while (DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("~");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true;        
    }
    private void ObtainDuration()
    {
        string input = Console.ReadLine();
        int duration = int.Parse(input);
        _duration = duration;
    }
}