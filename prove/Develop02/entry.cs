public class Entry
{
  public string _date;
  public string _prompt;
  public string _userResponse;

  public Entry() { }

  public void DisplayEntry()
  {
    Console.WriteLine($"""
    {_date}
    {_prompt}
    {_userResponse}
    
    """);
  }
}