using System;

class Program
{
  static void Main(string[] args)
  {
    Goal goal = new Goal("What is the name of your goal?", "What is a short description of it?", "What is the amount of points associated with this goal?");

    bool contLoop = true;
    Console.WriteLine("Welcome to the Eternal Quest goal setting program.");
    goal.DisplayTotalPoints();
    while (contLoop == true)
    {
      Console.WriteLine("""
        Menu options: 
        1. Create New Goal
        2. List Goals
        3. Save Goals
        4. Load Goals
        5. Record Event
        6. Quit        
        """);
      Console.Write("Select a choice: ");
      string userSelection = Console.ReadLine();

      switch (userSelection)
      {
        case "1":
          goal.CreateGoal();
          Console.WriteLine($"Object type: {goal.GetType()}");
          break;
      }
    }
  }
}