using System;

class Program
{
  static void Main(string[] args)
  {
    //constructor for 1 or 1/1
    Fraction one = new Fraction();

    //constructor for 5 or 5/1
    Fraction five = new Fraction(5);

    //constructor for 3/4 or .75
    Fraction threeFourth = new Fraction(3, 4);

    //constructor for 1/3 or .333333
    Fraction oneThird = new Fraction(1, 3);

    Console.WriteLine("\nDisplaying 1/1 and 1");
    Console.WriteLine(one.DisplayFraction());
    Console.WriteLine(one.DisplayDecimal());

    Console.WriteLine("\nDisplaying 5/1 and 5.");
    Console.WriteLine(five.DisplayFraction());
    Console.WriteLine(five.DisplayDecimal());

    Console.WriteLine("\nDisplaying 3/4 and .75");
    Console.WriteLine(threeFourth.DisplayFraction());
    Console.WriteLine(threeFourth.DisplayDecimal());

    Console.WriteLine("\nDisplaying 1/3 and .333333");
    Console.WriteLine(oneThird.DisplayFraction());
    Console.WriteLine(oneThird.DisplayDecimal() + "\n");
  }
}

/*
Verify that you can call each constructor and that you can retrieve and display the different representations for a few different fractions. For example, you could try:
1
5
3/4
1/3

Sample Output

1/1
1
5/1
5
3/4
0.75
1/3
0.3333333333333333

*/