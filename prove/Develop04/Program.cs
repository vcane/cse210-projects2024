using System;

class Program
{
  static void Main(string[] args)
  {
    bool contLoop = true;
    ReflectingActivity reflectingActivity;
    BreathingActivity breathingActivity;
    ListingActivity listingActivity;

    Console.WriteLine("Welcome to the Mindfulness application.");

    while (contLoop == true)
    {
      Console.WriteLine("\nPlease select an option by inputting a number.");
      Console.WriteLine("""
        Here are your options:
          1. Start breathing activity.
          2. Start reflecting activity.
          3. Start listing activity.
          4. Quit the application. 

        """);
      Console.Write("> ");
      string userInput = Console.ReadLine();

      switch (userInput)
      {
        case "1":
          breathingActivity = new BreathingActivity();
          breathingActivity.RunBreathingActivity();
          break;
        case "2":
          reflectingActivity = new ReflectingActivity();
          reflectingActivity.RunReflectingActivity();
          break;
        case "3":
          Console.WriteLine("start listing");
          listingActivity = new ListingActivity();
          listingActivity.RunListingActivity();
          break;
        case "4":
          Console.WriteLine("Quitting application...");
          contLoop = false;
          break;
        default:
          Console.WriteLine("Please select a number 1 - 4.");
          break;
      }
    }
  }
}