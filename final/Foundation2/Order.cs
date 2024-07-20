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

  public void GeneratePackingLabel()
  {
    foreach (Product product in _products)
    {
      Console.WriteLine($"{product.RenderProductInfo()}");
    }
  }

  public string RenderShippingLabel()
  {
    return $"{_customer.RenderCustomerInfo()}";
  }

  public int CalculateTotalCost()
  {
    int subtotal = 0;
    foreach (Product product in _products)
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

  public void AddProduct(Product product)
  {
    _products.Add(product);
  }
}