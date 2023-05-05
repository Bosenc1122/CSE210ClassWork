public class Menu
{
    private Board quoteboard;

    public Menu(Board board)
    {
        quoteboard = board;
    }

    public void Display()
    {
        string response = "";
        string[] options = {"A","S","Q","F","R"};
        while(response!="Q")
        {
            while(options.Contains(response)==false)
            {
                Console.Write("[A]dd quote:\n[S]how quotes\n[F]ind Quote by Author\n[R]andom Quote\n[Q]uit\n\nWhat do you want to do?");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
            }
            switch (response)
            {
                case "Q":
                    Environment.Exit(0);
                    break;
                case "A":
                    Console.WriteLine("Please enter your quote: ");
                    string quote = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Please enter your author: ");
                    string author = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Please enter your source: ");
                    string source = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Please enter your source URl: ");
                    string sourceUrl = Console.ReadLine() ?? String.Empty;

                    quoteboard.AddQuote(new Quote(author,quote,new Source(source, sourceUrl)));
                    break;
                case "S":
                    quoteboard.ShowQuotes();
                    break;
                case "F":
                    Console.WriteLine("Please enter your author: ");
                    author = Console.ReadLine() ?? String.Empty;
                    quoteboard.FindQuotesByAuthor(author);
                    break;
                case "R":
                    quoteboard.GetRandomQuote();
                    break;

            }
            response = "";
        }
    }
}