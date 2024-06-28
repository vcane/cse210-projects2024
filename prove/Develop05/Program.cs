using System;
//VIDEO URL https://video.byui.edu/media/t/1_i8i158nf
class Program
{
  static void Main(string[] args)
  {
    // Goal goal = new Goal("What is the name of your goal?", "What is a short description of it?", "What is the amount of points associated with this goal?");
    SimpleGoal sGoal;
    EternalGoal eGoal;
    ChecklistGoal cGoal;
    GoalStorage goalStorage = new GoalStorage();

    bool contLoop = true;
    Console.WriteLine("Welcome to the Eternal Quest goal setting program.");
    //goal.DisplayTotalPoints(); //TODO will need to come from another class???
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
          Console.WriteLine();
          Console.WriteLine("""
          1. Simple Goal
          2. Eternal Goal
          3. Checklist Goal    
          """);
          Console.Write("Select a type of goal that you want to create. ");
          string userGoalSelection = Console.ReadLine();
          if (userGoalSelection == "1")
          {
            sGoal = new SimpleGoal("What is the name of your goal? ", "What is a short description of it? ", "What is the amount of points associated with this goal? ");
            sGoal.CreateGoal();
            goalStorage.AddGoal(sGoal);
          }
          else if (userGoalSelection == "2")
          {
            eGoal = new EternalGoal("What is the name of your goal? ", "What is a short description of it? ", "What is the amount of points associated with this goal? ");
            eGoal.CreateGoal();
            goalStorage.AddGoal(eGoal);
          }
          else
          {
            cGoal = new ChecklistGoal("What is the name of your goal? ", "What is a short description of it? ", "What is the amount of points associated with this goal? ", "How many times does this goal need to be accomplished for a bonus? ", "What is the bonus for accomplishing it that many times? ");
            cGoal.CreateGoal();
            goalStorage.AddGoal(cGoal);
          }
          break;
        case "2":
          Console.WriteLine("Listing goals....");
          goalStorage.DisplayGoalList();
          break;
        case "3":
          Console.WriteLine("Saving goals...");
          break;
        case "4":
          Console.WriteLine("Loading goals...");
          break;
        case "5":
          Console.WriteLine("Recording an event....");
          break;
        case "6":
          Console.WriteLine("Exiting application.....");
          contLoop = false;
          break;
      }
    }
  }
}