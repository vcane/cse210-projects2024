public class Event
{
  protected string _eventTitle;
  protected string _description;
  protected string _date;
  protected string _time;
  protected Address _address;

  public Event(string eventTitle, string description, string date, string time, Address address)
  {
    _eventTitle = eventTitle;
    _description = description;
    _date = date;
    _time = time;
    _address = address;
  }

  public string RenderStandardDetails()
  {
    return $"""
    Event title: {_eventTitle}
    Event description: {_description}
    Date of event: {_date}
    Time of event: {_time}
    Address: {_address.RenderAddress()}
    """;
  }

  public string RenderShortDescription()
  {
    return $"""
    Type of event: {GetType()}
    Event title: {_eventTitle}
    Date of event: {_date}    
    """;
  }
}