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
          Console.WriteLine("The program will save to a text (.txt) file. The .txt extension will be added automatically.");
          Console.Write("Please enter the name of the file. ");
          string fileName = Console.ReadLine() + ".txt";
          Console.WriteLine($"Your goals were saved to a file called {fileName}.");
          using (StreamWriter outputFile = new StreamWriter(fileName))
          {
            foreach (Goal g in goalStorage.GetGoalList())
            {
              string cereal = g.Serialize();
              Console.WriteLine(cereal);
              outputFile.WriteLine(cereal);
            }
          }
          break;
        case "4":
          Console.WriteLine("Loading goals...");
          Console.WriteLine("The program will load a text (.txt) file. The .txt extension will be added automatically to the end of the file name.");
          Console.Write("Please enter the name of the file. ");
          fileName = Console.ReadLine() + ".txt";
          Console.WriteLine($"Loading your goals from {fileName}.");

          string[] lines = File.ReadAllLines(fileName);

          foreach (string line in lines)
          {
            string[] parts = line.Split("~~");

            if (parts[0] == "SimpleGoal")
            {
              SimpleGoal sg = new SimpleGoal("What is the name of your goal? ", "What is a short description of it? ", "What is the amount of points associated with this goal? ");
              sg.Deserialize(parts);
              goalStorage.AddGoal(sg);
            }
            else if (parts[0] == "EternalGoal")
            {
              EternalGoal eg = new EternalGoal("What is the name of your goal? ", "What is a short description of it? ", "What is the amount of points associated with this goal? ");
              eg.Deserialize(parts);
              goalStorage.AddGoal(eg);
            }
            else
            {
              ChecklistGoal cg = new ChecklistGoal("What is the name of your goal? ", "What is a short description of it? ", "What is the amount of points associated with this goal? ", "How many times does this goal need to be accomplished for a bonus? ", "What is the bonus for accomplishing it that many times? ");
              cg.Deserialize(parts);
              goalStorage.AddGoal(cg);
            }
            // string[] parts = line.Split("~~");

            // if (parts[0] == "SimpleGoal")
            // {
            //   Console.WriteLine($"Simple Goal: {parts[0]}");
            // }
            // else if (parts[0] == "EternalGoal")
            // {
            //   Console.WriteLine($"Eternal Goal: {parts[0]}");
            // }
            // else
            // {
            //   Console.WriteLine($"Checklist Goal: {parts[0]}");
            // }

            // Entry journalEntry = new Entry();
            // journalEntry._date = parts[0];
            // journalEntry._prompt = parts[1];
            // journalEntry._userResponse = parts[2];

            // _journalEntries.Add(journalEntry);
          }
          break;
        case "5":
          Console.WriteLine("Recording an event....");
          goal.RecordEvent(); //TODO....NOT WORKING....it creates a Goal object so it doesn't display the info from the list. Need to get the list
          break;
        case "6":
          Console.WriteLine("Exiting application.....");
          contLoop = false;
          break;
      }
    }
  }
}