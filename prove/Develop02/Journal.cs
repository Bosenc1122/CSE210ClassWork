public class Journal
{

    List<Prompt> _prompts = new List<Prompt>();

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
        var randomNumber = random.Next(0,_prompts.Count);
        NicePrint(_prompts[randomNumber].GetPrompt());
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