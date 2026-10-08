using System;

class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        int response = 0;

        while (response != 5)
        {
            response = myMenu.ProcessMenu();
            switch(response)
            {
                case 1:
                    Console.WriteLine("Create");
                    // Call CreateJournalEntry()
                    break;
                case 2:
                    Console.WriteLine("Display");
                    // Call DisplayJorunal()
                    break;
                case 3:
                    Console.WriteLine("Write");
                    //  Call WriteToFile()
                    break;
                case 4:
                    Console.WriteLine("Save");
                    //  ReadFromFile()
                    break;
            }
        }
        // get todays date without the time
        // DateTime today = DateTime.Today;
        // string date = today.ToString("d");
        // Console.WriteLine($"{date}");
    }
}