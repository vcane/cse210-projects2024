public class Address
{
  private string _streetAddress;
  private string _city;
  private string _stateOrProvince;
  private string _zipCode;
  private string _country;

  public Address(string streetAddress, string city, string stateOrProvince, string zipCode, string country)
  {
    _streetAddress = streetAddress;
    _city = city;
    _stateOrProvince = stateOrProvince;
    _zipCode = zipCode;
    _country = country;
  }

  public bool CheckIfCountryIsUS()
  {
    if (_country == "US" || _country == "U.S." || _country == "United States")
    {
      return true;
    }
    return false;
  }

  public string RenderAddress()
  {
    return $"""
    {_streetAddress}
    {_city}, {_stateOrProvince} {_zipCode}
    {_country}
    """;
  }
}