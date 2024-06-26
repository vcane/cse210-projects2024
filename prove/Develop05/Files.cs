public class Files
{
  Goal goal = new Goal();
  private string _fileName;
  private int _tempTotalPoints;
  private List<Goal> _tempGoalList = new List<Goal>();
  public Files()
  {
    _fileName = String.Empty;
    _tempTotalPoints = 0;
  }

  public List<Goal> GetTempGoalList()
  {
    return _tempGoalList;
  }

  public int GetTempTotalPoints()
  {
    return _tempTotalPoints;
  }

  public void SaveFile(List<Goal> goalList, int totalPoints)
  {
    Console.WriteLine("The program will save to a text (.txt) file. The .txt extension will be added automatically.");
    Console.Write("Please enter the name of the file. ");
    _fileName = Console.ReadLine() + ".txt";
    Console.WriteLine($"Your goals were saved to a file called {_fileName}.");
    using (StreamWriter outputFile = new StreamWriter(_fileName))
    {
      outputFile.WriteLine($"Total Points~~{totalPoints}");
      foreach (Goal g in goalList)
      {
        string cereal = g.Serialize();
        outputFile.WriteLine(cereal);
      }
    }
  }

  public void LoadFile()
  {
    Console.WriteLine("The program will load a text (.txt) file. The .txt extension will be added automatically to the end of the file name.");
    Console.Write("Please enter the name of the file. ");
    _fileName = Console.ReadLine() + ".txt";
    Console.WriteLine($"Loading your goals from {_fileName}.");

    string[] lines = File.ReadAllLines(_fileName);

    foreach (string line in lines)
    {
      string[] parts = line.Split("~~");

      if (parts[0] == "Total Points")
      {
        _tempTotalPoints = int.Parse(parts[1]);
      }
      else if (parts[0] == "SimpleGoal")
      {
        SimpleGoal sg = new SimpleGoal("What is the name of your goal? ", "What is a short description of it? ", "What is the amount of points associated with this goal? ");
        sg.Deserialize(parts);
        _tempGoalList.Add(sg);
      }
      else if (parts[0] == "EternalGoal")
      {
        EternalGoal eg = new EternalGoal("What is the name of your goal? ", "What is a short description of it? ", "What is the amount of points associated with this goal? ");
        eg.Deserialize(parts);
        _tempGoalList.Add(eg);
      }
      else
      {
        ChecklistGoal cg = new ChecklistGoal("What is the name of your goal? ", "What is a short description of it? ", "What is the amount of points associated with this goal? ", "How many times does this goal need to be accomplished for a bonus? ", "What is the bonus for accomplishing it that many times? ");
        cg.Deserialize(parts);
        _tempGoalList.Add(cg);
      }
    }
  }
}