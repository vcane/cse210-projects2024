public class Customer
{
  private string _customerName;
  private Address _address;

  public Customer(string customerName, Address address)
  {
    _customerName = customerName;
    _address = address;
  }

  public bool CustomerInUS()
  {
    return _address.CheckIfCountryIsUS();
  }

  public string RenderCustomerInfo()
  {
    return $"""
    {_customerName}
    {_address.RenderAddress()}
    """;
  }
}