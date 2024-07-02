using System;
//VIDEO URL https://video.byui.edu/media/t/1_i8i158nf

/*TODO LIST:
1. still needs logic to prevent recording events that are already complete 
2. the bonus points will not add to the total points when the checklist goal is completed 
3. does not keep the completed status state when loaded from a file
*/

class Program
{
  static void Main(string[] args)
  {
    SimpleGoal sGoal;
    EternalGoal eGoal;
    ChecklistGoal cGoal;
    GoalStorage goalStorage = new GoalStorage();
    Goal goal = new Goal();
    Files files = new Files();

    bool contLoop = true;
    Console.WriteLine("Welcome to the Eternal Quest goal setting program.");

    while (contLoop == true)
    {
      goal.DisplayTotalPoints();

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
          Console.WriteLine("Here is a list of your goals: ");
          goalStorage.DisplayGoalList();
          break;
        case "3":
          files.SaveFile(goalStorage.GetGoalList(), goal.GetTotalPoints());
          break;
        case "4":
          files.LoadFile();
          goalStorage.SetGoalList(files.GetTempGoalList());
          goal.SetTotalPoints(files.GetTempTotalPoints());
          break;
        case "5":
          List<Goal> gList = goalStorage.GetGoalList();
          goal.RecordEvent(gList);
          break;
        case "6":
          Console.WriteLine("Exiting application.....");
          contLoop = false;
          break;
      }
    }
  }
}