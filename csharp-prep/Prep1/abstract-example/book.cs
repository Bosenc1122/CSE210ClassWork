public class Book
{
    private string _author;
    private string _name;
    private int _timesRead = 0;
    private bool _available = true;

    public Book(string name, string author)
    {
        _name = name;
        author = author;
    }
}