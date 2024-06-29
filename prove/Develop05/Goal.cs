public class Goal
{
  protected string _goalName;
  protected string _goalDescription;
  protected string _goalNamePrompt;
  private string _goalDescriptionPrompt;
  private string _goalPointsValuePrompt;
  private string _marker;
  protected string _serialized;
  private int _goalPointsValue;
  private int _totalPoints;
  protected bool _isComplete;


  //private SimpleGoal _simpleGoal;
  // private EternalGoal _eternalGoal;
  // private ChecklistGoal _checklistGoal;

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

  public string GetMarker()
  {
    return _marker;
  }

  public void SetMarker()
  {
    _marker = "X";
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

  public virtual void DisplayTotalPoints()
  {
    Console.WriteLine($"Currently, you have {_totalPoints}.");
  }
  public virtual void CreateGoal() { }

  public void RecordEvent() // TODO need to work on this.......
  {
    GoalStorage gStorage = new GoalStorage();
    gStorage.DisplayGoalList();
    Console.Write("Which goal did you accomplish? ");
    int userInput = int.Parse(Console.ReadLine());
    //if (userInput == )
  }

  //Serialize method
  public virtual string Serialize()
  {
    return ""; //$"{GetType()}~~{_goalName}~~{_goalDescription}~~{_goalPointsValue}";
  }
  //Deserialize method
  public virtual void Deserialize(string[] line)
  {

  }
}