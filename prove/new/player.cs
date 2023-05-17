public class Player
{

    private string _name;
    private string _position = "";
    private int _jerseyNumber;

    public Player(string name, int jersey, string position)
    {
        _name = name;
        _jerseyNumber = jersey;
        _position = position;
    }

    public Player(string name, int jersey)
    {
        _name = name;
        _jerseyNumber = jersey; 
    }
    public void SetPosition(string position)
    {
        _position = position;
    }

    public string Display()
    {
        return $"{_name}, {_position}, {_jerseyNumber}";
    }
}