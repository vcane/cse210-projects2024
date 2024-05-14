public class Entry
{
  Prompt prompt = new Prompt();
  public string _date = DateTime.Now.ToShortDateString();
  //public string _prompt; 
  public string _userResponse;

  public string DisplayEntry()
  {
    return $"""
    {_date}
    {prompt.RetrievePrompt()}
    {_userResponse}
    """;
    // Console.WriteLine($"{_date}");
    // Console.WriteLine($"{prompt.RetrievePrompt()}");
    // Console.WriteLine($"{_userResponse}");
  }
}