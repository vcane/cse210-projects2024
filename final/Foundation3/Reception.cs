public class Reception : Event
{
  private string _emailAddress;

  public Reception(string eventTitle, string description, string date, string time, Address address, string emailAddress) : base(eventTitle, description, date, time, address)
  {
    _emailAddress = emailAddress;
  }

  public string RenderFullDetailsForReception()
  {
    return $"""
    {base.RenderStandardDetails()}
    To RSVP, please email us at {_emailAddress} with your name and number in your party.
    """;
  }
}