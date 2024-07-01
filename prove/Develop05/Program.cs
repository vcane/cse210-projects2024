using System;
//VIDEO URL https://video.byui.edu/media/t/1_i8i158nf
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
            //Console.WriteLine($"Object type: {sGoal.GetType()}");
          }
          else if (userGoalSelection == "2")
          {
            eGoal = new EternalGoal("What is the name of your goal? ", "What is a short description of it? ", "What is the amount of points associated with this goal? ");
            eGoal.CreateGoal();
            goalStorage.AddGoal(eGoal);
            //Console.WriteLine($"Object type: {eGoal.GetType()}");
          }
          else
          {
            cGoal = new ChecklistGoal("What is the name of your goal? ", "What is a short description of it? ", "What is the amount of points associated with this goal? ", "How many times does this goal need to be accomplished for a bonus? ", "What is the bonus for accomplishing it that many times? ");
            cGoal.CreateGoal();
            goalStorage.AddGoal(cGoal);
            //Console.WriteLine($"Object type: {cGoal.GetType()}");
          }
          break;
        case "2":
          Console.WriteLine("Here is a list of your goals: ");
          goalStorage.DisplayGoalList();
          break;
        case "3": //TODO move to File.cs
          // Console.WriteLine("The program will save to a text (.txt) file. The .txt extension will be added automatically.");
          // Console.Write("Please enter the name of the file. ");
          // string fileName = Console.ReadLine() + ".txt";
          // Console.WriteLine($"Your goals were saved to a file called {fileName}.");
          // using (StreamWriter outputFile = new StreamWriter(fileName))
          // {
          //   outputFile.WriteLine($"Total Points~~{goal.GetTotalPoints()}");
          //   foreach (Goal g in goalStorage.GetGoalList())
          //   {
          //     string cereal = g.Serialize();
          //     outputFile.WriteLine(cereal);
          //   }
          // }
          files.SaveFile(goalStorage.GetGoalList());
          break;
        case "4": //TODO move to File.cs
          // Console.WriteLine("The program will load a text (.txt) file. The .txt extension will be added automatically to the end of the file name.");
          // Console.Write("Please enter the name of the file. ");
          // fileName = Console.ReadLine() + ".txt";
          // Console.WriteLine($"Loading your goals from {fileName}.");

          // string[] lines = File.ReadAllLines(fileName);

          // foreach (string line in lines)
          // {
          //   string[] parts = line.Split("~~");

          //   if (parts[0] == "Total Points")
          //   {
          //     goal.SetTotalPoints(int.Parse(parts[1]));
          //   }
          //   else if (parts[0] == "SimpleGoal")
          //   {
          //     SimpleGoal sg = new SimpleGoal("What is the name of your goal? ", "What is a short description of it? ", "What is the amount of points associated with this goal? ");
          //     sg.Deserialize(parts);
          //     goalStorage.AddGoal(sg);
          //   }
          //   else if (parts[0] == "EternalGoal")
          //   {
          //     EternalGoal eg = new EternalGoal("What is the name of your goal? ", "What is a short description of it? ", "What is the amount of points associated with this goal? ");
          //     eg.Deserialize(parts);
          //     goalStorage.AddGoal(eg);
          //   }
          //   else
          //   {
          //     ChecklistGoal cg = new ChecklistGoal("What is the name of your goal? ", "What is a short description of it? ", "What is the amount of points associated with this goal? ", "How many times does this goal need to be accomplished for a bonus? ", "What is the bonus for accomplishing it that many times? ");
          //     cg.Deserialize(parts);
          //     goalStorage.AddGoal(cg);
          //   }
          // }
          // Console.WriteLine($"Total Points: {goal.GetTotalPoints()}");
          files.LoadFile();
          goalStorage.SetGoalList(files.GetTempGoalList());
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