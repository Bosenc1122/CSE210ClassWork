public class Entry
{
    private string _date;
    private string _entry;

    public Entry(string date, string entry)
    {
        _date = date;
        _entry = entry;
    }

     public string GetEntry()
    {
        return $"\"{_date}\"\n{_entry}";
    }
    public bool HasDate(string date)
    {
        if(_date.ToUpper().Contains(date.ToUpper()))
        {
            return true;
        }
        return false;
    }
}