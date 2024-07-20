public class OutdoorGathering : Event
{
  private string _weatherForecast;

  public OutdoorGathering(string eventTitle, string description, string date, string time, Address address, string weatherForecast) : base(eventTitle, description, date, time, address)
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