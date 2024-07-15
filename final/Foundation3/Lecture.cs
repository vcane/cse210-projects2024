public class Lecture : Event
{
  private string _speakerName;
  private int _capacity;

  public Lecture(string eventTitle, string description, string date, string time, string eventType, string address, string speakerName, int capacity) : base(eventTitle, description, date, time, eventType, address)
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