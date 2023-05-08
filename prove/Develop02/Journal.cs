public class Journal
{

    List<Prompt> _prompt = new List<Prompt>();

    List<Entry> _entry = new List<Entry>();


     private void NicePrint(string item)
    {
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"{item}");
        Console.WriteLine("--------------------------------");
    }

     public void GetRandomPrompt()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_prompt.Count);
        NicePrint(_prompt[randomNumber].GetPrompt());
    }

    public void ShowEntry()
    {
        foreach (Entry quote in _entry)
        {
           NicePrint(quote.GetEntry());
        }
    }

    public void AddEntry(Entry entry)
    {
        _entry.Add(entry);
    }

    public void AddPrompt(Prompt prompt)
    {
        _prompt.Add(prompt);
    }

    public void FindEntryByDate(string date)
    {
        foreach (Entry entry in _entry)
        {
            if(entry.HasDate(date))
            {
                NicePrint(entry.GetEntry());
            }
        }
    }


}

