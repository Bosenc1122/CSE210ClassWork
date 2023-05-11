public class Menu
{
    private Journal myjournal;

    public Menu(Journal journal)
    {
        myjournal = journal;
    }

    public void Display()
    {
        string response = "";
        string[] options = {"A","S","Q","F","R"};
        while(response!="Q")
        {
            while(options.Contains(response)==false)
            {
                Console.Write("[A]dd entry:\n[S]how entrys\n[F]ind Quote by date\n[R]andom Prompt\n[Q]uit\n\nWhat do you want to do?");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
            }
            switch (response)
            {
                case "Q":
                    Environment.Exit(0);
                    break;
                case "A":
                    Console.WriteLine("Please enter the date: ");
                    string date = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Please enter your entry: ");
                    string entry = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Please enter your source: ");
                    
                    myjournal.AddEntry(new Entry(date,entry));
                    break;
                case "S":
                    myjournal.ShowEntry();
                    break;
                case "F":
                    Console.WriteLine("Please enter your date: ");
                    date = Console.ReadLine() ?? String.Empty;
                    myjournal.FindEntryByDate(date);
                    break;
                case "R":
                    myjournal.GetRandomPrompt();
                    break;

            }
            response = "";
        }
    }
}

