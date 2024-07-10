public class Order
{
  private int _usShippingFee;
  private int _foreignShippingFee;
  private List<Product> _products;
  private Customer _customer;

  public Order(int usShipping, int foreignShippingFee, Customer customer)
  {
    _usShippingFee = usShipping;
    _foreignShippingFee = foreignShippingFee;
    _products = new List<Product>();
    _customer = customer;
  }

  public List<Product> GetProductsList()
  {
    return _products;
  }

  public void GeneratePackingLabel(List<Product> productList)
  {
    foreach (Product product in productList)
    {
      Console.WriteLine($"Product Name: {product.GetProductName()} -- Id: {product.GetProductId()} -- Subtotal: ${product.CalculateSubtotal()}");
    }
  }

  public string RenderShippingLabel(Address address, Customer customer)
  {
    return $"""
    {customer.GetCustomerName()}
    {address.RenderAddress()}
    """;
  }

  public int CalculateTotalCost(Customer customer, List<Product> products)
  {
    int subtotal = 0;
    foreach (Product product in products)
    {
      subtotal += product.CalculateSubtotal();
    }
    if (customer.CustomerInUS() == true)
    {
      return _usShippingFee + subtotal;
    }
    else
    {
      return _foreignShippingFee + subtotal;
    }
  }
}