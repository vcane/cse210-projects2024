public class Event
{
  protected string _eventTitle;
  protected string _description;
  protected string _date;
  protected string _time;
  protected string _eventType;
  protected string _address;

  public Event(string eventTitle, string description, string date, string time, string eventType, string address)
  {
    _eventTitle = eventTitle;
    _description = description;
    _date = date;
    _time = time;
    _eventType = eventType;
    _address = address;
  }

  public string RenderStandardDetails()
  {
    return $"""
    Event title: {_eventTitle}
    Event description: {_description}
    Date of event: {_date}
    Time of event: {_time}
    Address: {_address}
    """;
  }

  public string RenderShortDescription()
  {
    return $"""
    Type of event: {_eventType}
    Event title: {_eventTitle}
    Date of event: {_date}    
    """;
  }
}