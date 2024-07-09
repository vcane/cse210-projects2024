public class Customer
{
  private string _customerName;
  private Address _address;

  public Customer(string customerName, Address address)
  {
    _customerName = customerName;
    _address = address;
  }

  // public bool CustomerInUS(Address address)
  // {
  //   return address.CheckIfCountryIsUS();
  // }

  public void DisplayCustomerInfo()
  {
    Console.WriteLine(_customerName);
    Console.WriteLine(_address.RenderAddress());
  }
}