public class Fraction
{
  private int _top;
  private int _bottom;

  public Fraction()
  {
    _top = 1;
    _bottom = 1;
  }

  public Fraction(int topNum)
  {
    _top = topNum;
    _bottom = 1;
  }

  public Fraction(int topNum, int botNum)
  {
    _top = topNum;
    _bottom = botNum;
  }

  private string CreateFraction()
  {
    return $"{_top}/{_bottom}";
  }

  private double CalculateDecimal()
  {
    return (double)_top / _bottom;
  }

  public string DisplayFraction()
  {
    return $"Here is the fraction: {CreateFraction()}.";
  }

  public string DisplayDecimal()
  {
    return $"Here is the decimal value: {CalculateDecimal()}";
  }
}