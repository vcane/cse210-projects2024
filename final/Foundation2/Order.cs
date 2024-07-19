public class Order
{
  private int _usShippingFee;
  private int _foreignShippingFee;
  private List<Product> _products;
  private Customer _customer;
  //private Address _address;

  public Order(int usShipping, int foreignShippingFee, Customer customer)
  {
    _usShippingFee = usShipping;
    _foreignShippingFee = foreignShippingFee;
    _products = new List<Product>();
    _customer = customer;
    //_address = address;
  }

  public List<Product> GetProductsList()
  {
    return _products;
  }

  public void GeneratePackingLabel(List<Product> productList)
  {
    foreach (Product product in productList)
    {
      Console.WriteLine($"{product.RenderProductInfo()}");
    }
  }

  public string RenderShippingLabel()//Address address, Customer customer
  {
    // return $"""
    // {_customer.GetCustomerName()}
    // {_address.RenderAddress()}
    // """;
    return $"{_customer.RenderCustomerInfo()}";
  }

  public int CalculateTotalCost(List<Product> products) //Customer customer,
  {
    int subtotal = 0;
    foreach (Product product in products)
    {
      subtotal += product.CalculateSubtotal();
    }
    if (_customer.CustomerInUS() == true)
    {
      return _usShippingFee + subtotal;
    }
    else
    {
      return _foreignShippingFee + subtotal;
    }
  }
}