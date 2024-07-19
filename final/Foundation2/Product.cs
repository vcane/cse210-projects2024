public class Product
{
  private string _productName;
  private string _productId;
  private int _pricePerUnit;
  private int _quantity;

  public Product(string productName, string productId, int pricePerUnit, int quantity)
  {
    _productName = productName;
    _productId = productId;
    _pricePerUnit = pricePerUnit;
    _quantity = quantity;
  }

  public string RenderProductInfo()
  {
    return $"Product Name: {_productName} -- Product Id: {_productId} -- Subtotal: ${CalculateSubtotal()}";
  }

  public int CalculateSubtotal()
  {
    return _pricePerUnit * _quantity;
  }
}