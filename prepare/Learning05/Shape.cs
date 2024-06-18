// Using abstract class and method
public abstract class Shape
{
  private string _color;

  public Shape(string color)
  {
    _color = color;
  }

  public string GetColor()
  {
    return _color;
  }

  public void SetColor(string color)
  {
    _color = color;
  }

  public abstract double GetArea();
}




// Original code using virtual GetArea() method

// public class Shape
// {
//   private string _color;

//   public Shape(string color)
//   {
//     _color = color;
//   }

//   public string GetColor()
//   {
//     return _color;
//   }

//   public void SetColor(string color)
//   {
//     _color = color;
//   }

//   public virtual double GetArea()
//   {
//     return -1;
//   }
// }