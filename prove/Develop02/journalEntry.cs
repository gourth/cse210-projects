using System;

public class journalEntry
{
    
    public string _entry = "";
    public string _date = "";
    public string _prompt = "";
    

    public journalEntry()
    {

    }

    public int getEntryPrompt()
        {
            Random ran = new Random();
            int prom = ran.Next(5);
            return prom;
        }

    public void displayEntry()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_entry}");

    }

}