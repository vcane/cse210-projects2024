public class Lecture : Event
{
  private string _speakerName;
  private int _capacity;

  public Lecture(string eventTitle, string description, string date, string time, Address address, string speakerName, int capacity) : base(eventTitle, description, date, time, address)
  {
    _speakerName = speakerName;
    _capacity = capacity;
  }

  public string RenderFullDetailsForLecture()
  {
    return $"""
    {base.RenderStandardDetails()}
    Speaker: {_speakerName}
    Total Capacity: {_capacity}
    """;
  }
}