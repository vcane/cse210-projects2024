using System;

class Program
{
  static void Main(string[] args)
  {
    static void DisplayWelcome()
    {
      Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
      Console.Write("Please enter your name: ");
      return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
      Console.Write("Please enter your favorite number: ");
      return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
      return number * number;
    }

    static void DisplayResults(string userName, int sqNum)
    {
      Console.WriteLine($"{userName}, the square of your number is {sqNum}.");
    }

    DisplayWelcome();
    DisplayResults(PromptUserName(), SquareNumber(PromptUserNumber()));
  }
}