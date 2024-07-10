public class Event
{
  protected string _eventTitle;
  protected string _description;
  protected string _date;
  protected string _time;
  protected string _eventType;
  protected string _address;

  public Event(string eventTitle, string description, string date, string time, string eventType, Address address)
  {
    _eventTitle = eventTitle;
    _description = description;
    _date = date;
    _time = time;
    _eventType = eventType;
    _address = address.RenderAddress();
  }

  public string RenderStandardDetails()
  {
    return $"""
    Event title: {_eventTitle}
    Event description: {_description}
    Date of event: {_date}
    Address: {_address}
    """;
  }

  public string RenderShortDescription()
  {
    return "";
  }
}