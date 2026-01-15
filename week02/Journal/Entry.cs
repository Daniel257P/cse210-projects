public class Entry
{
  public string _date;
  public string _prompt;    
    public string _entryText;   

    public Entry(string date, string prompt, string entryText)
    {
        _date = date;
        _prompt = prompt;
        _entryText = entryText;
    }
    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_entryText);
    }
}

