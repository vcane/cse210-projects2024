public class OutdoorGathering : Event
{
  private string _weatherForecast;

  public OutdoorGathering(string eventTitle, string description, string date, string time, string eventType, string address, string weatherForecast) : base(eventTitle, description, date, time, eventType, address)
  {
    _weatherForecast = weatherForecast;
  }

  public string RenderFullDetailsForOutdoorGathering()
  {
    return $"""
    {base.RenderStandardDetails()}
    The weather forecast is {_weatherForecast}.
    """;
  }
}