public class Address
{
  private string _streetAddress;
  private string _city;
  private string _state;
  private string _zipCode;
  //private string _country;

  public Address(string streetAddress, string city, string state, string zipCode)
  {
    _streetAddress = streetAddress;
    _city = city;
    _state = state;
    _zipCode = zipCode;
    //_country = country;
  }

  // public bool CheckIfCountryIsUS()
  // {
  //   if (_country == "US" || _country == "U.S." || _country == "United States")
  //   {
  //     return true;
  //   }
  //   return false;
  // }

  public string RenderAddress()
  {
    return $"""
    {_streetAddress}, {_city}, {_state} {_zipCode}
    """;
  }
}