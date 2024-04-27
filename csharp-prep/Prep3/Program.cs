using System;

class Program
{
  static void Main(string[] args)
  {
    string playAgain = "yes";
    string tryOrTries = "try";

    while (playAgain == "yes")
    {
      int numOfGuesses = 0;
      bool correctGuess = false;
      Random randomGenerator = new Random();
      int magicNum = randomGenerator.Next(1, 101);
      Console.WriteLine($"Magic number: {magicNum}");

      while (correctGuess == false)
      {
        Console.Write("Guess the magic number? ");
        int userNum = int.Parse(Console.ReadLine());

        if (userNum > magicNum)
        {
          Console.WriteLine("Guess lower.");
        }
        else if (userNum < magicNum)
        {
          Console.WriteLine("Guess higher.");
        }
        else
        {
          correctGuess = true;
        }
        numOfGuesses++;
      }

      if (numOfGuesses > 1)
      {
        tryOrTries = "tries";
      }

      Console.WriteLine($"You guessed correctly! It took {numOfGuesses} {tryOrTries}!");
      Console.Write("Do you want to play again? (Enter yes or no) ");
      playAgain = Console.ReadLine();
    }
    Console.WriteLine("Thanks for playing! Come back again.");
  }
}