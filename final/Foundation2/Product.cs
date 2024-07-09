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

  public string GetProductName()
  {
    return _productName;
  }

  public string GetProductId()
  {
    return _productId;
  }

  public int CalculateSubtotal()
  {
    return _pricePerUnit * _quantity;
  }
}