public class Reception : Event
{
  private string _emailAddress;
  //string eventTitle, string description, string date, string time, string eventType, string address
  public Reception(string eventTitle, string description, string date, string time, string eventType, string address, string emailAddress) : base(eventTitle, description, date, time, eventType, address)
  {
    _emailAddress = emailAddress;
  }


}