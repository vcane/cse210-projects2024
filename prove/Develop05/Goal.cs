public class Goal
{
  protected string _goalName;
  protected string _goalDescription;
  protected string _goalNamePrompt;
  private string _goalDescriptionPrompt;
  private string _goalPointsValuePrompt;
  private string _marker;
  protected int _goalPointsValue;
  private int _totalPoints;
  protected bool _isComplete;

  public Goal() { }

  public Goal(string goalNamePrompt, string goalDescriptionPrompt, string goalPointsValuePrompt)
  {
    _goalName = String.Empty;
    _goalDescription = String.Empty;
    _goalNamePrompt = goalNamePrompt;
    _goalDescriptionPrompt = goalDescriptionPrompt;
    _goalPointsValuePrompt = goalPointsValuePrompt;
    _goalPointsValue = 0;
    _totalPoints = 0;
    _isComplete = false;
    _marker = String.Empty;
  }

  public string GetGoalName()
  {
    return _goalName;
  }

  public string GetGoalDescription()
  {
    return _goalDescription;
  }

  public string GetGoalNamePrompt()
  {
    return _goalNamePrompt;
  }

  public string GetGoalDescriptionPrompt()
  {
    return _goalDescriptionPrompt;
  }

  public string GetGoalPointsValuePrompt()
  {
    return _goalPointsValuePrompt;
  }

  public int GetTotalPoints()
  {
    return _totalPoints;
  }

  public int GetGoalPointsValue()
  {
    return _goalPointsValue;
  }

  public virtual int GetBonusPoints()
  {
    return -1;
  }

  public string GetMarker()
  {
    return _marker;
  }

  public void SetMarker()
  {
    _marker = "X";
  }

  public void SetTotalPoints(int totalPoints)
  {
    _totalPoints = totalPoints;
  }

  public virtual int GetTimesCompleted()
  {
    return -1;
  }

  public virtual int GetTimesToComplete()
  {
    return -1;
  }

  public bool GetIsComplete()
  {
    return _isComplete;
  }

  public void DisplayTotalPoints()
  {
    Console.WriteLine($"Currently, you have {_totalPoints} points.");
  }

  public virtual void CreateGoal()
  {
    Console.Write(GetGoalNamePrompt());
    _goalName = Console.ReadLine();
    Console.Write(GetGoalDescriptionPrompt());
    _goalDescription = Console.ReadLine();
    Console.Write(GetGoalPointsValuePrompt());
    _goalPointsValue = int.Parse(Console.ReadLine());
  }

  public virtual int IncreaseTimesCompleted()
  {
    return -1;
  }

  public void RecordEvent(List<Goal> goalList)
  {
    GoalStorage gStorage = new GoalStorage();
    SimpleGoal sg = new SimpleGoal();
    ChecklistGoal cg = new ChecklistGoal();
    EternalGoal eg = new EternalGoal();
    gStorage.SetGoalList(goalList);
    gStorage.DisplayGoalList();
    Console.Write("Which goal did you accomplish? ");
    int userInput = int.Parse(Console.ReadLine());
    if (goalList[userInput - 1].GetType() == sg.GetType())
    {
      goalList[userInput - 1].SetMarker();
      _totalPoints += goalList[userInput - 1]._goalPointsValue;
      goalList[userInput - 1]._isComplete = true;
    }
    else if (goalList[userInput - 1].GetType() == eg.GetType())
    {
      _totalPoints += goalList[userInput - 1]._goalPointsValue;
    }
    else
    {
      _totalPoints += goalList[userInput - 1]._goalPointsValue;
      goalList[userInput - 1].IncreaseTimesCompleted();
      if (goalList[userInput - 1].GetTimesCompleted() == goalList[userInput - 1].GetTimesToComplete())
      {
        goalList[userInput - 1].SetMarker();
        goalList[userInput - 1]._isComplete = true;
        goalList[userInput - 1]._totalPoints += goalList[userInput - 1].GetBonusPoints();
      }
    }
    Console.WriteLine($"Congratulations, you earned {goalList[userInput - 1]._goalPointsValue} points.");
  }

  public virtual string Serialize()
  {
    return "";
  }

  public virtual void Deserialize(string[] line) { }
}