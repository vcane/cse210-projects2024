public abstract class Goal
{
  protected string _goalName;
  protected string _goalDescription;
  protected string _goalNamePrompt;
  private string _goalDescriptionPrompt;
  private string _goalPointsValuePrompt;
  private int _goalPointsValue;
  private int _totalPoints;
  private bool _isComplete;


  private SimpleGoal _simpleGoal;
  // private EternalGoal _eternalGoal;
  // private ChecklistGoal _checklistGoal;

  //public Goal() { }
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

  public abstract void CreateGoal();
  // {
  //   // display goal menu
  //   // 1. simple goal
  //   //   create simple goal object
  //   //   display the prompts
  //   //   
  //   //   collect and store user input
  //   //   added to list

  //   // 2. eternal goal
  //   //    ....
  //   Goal goal;
  //   // Console.WriteLine("""
  //   // 1. Simple Goal
  //   // 2. Eternal Goal
  //   // 3. Checklist Goal    
  //   // """);
  //   // Console.Write("Select a type of goal that you want to create. ");
  //   // string userGoalSelection = Console.ReadLine();
  //   // TODO create DisplayGoalMenu() for above and return userSelection......
  //   // TODO create GetUserSelection() return _userSelection;
  //   // TODO create _userSelection member attribute 
  //   // TODO in SimpleGoals class create method to override CreateGoal()

  //   // if (userGoalSelection == "1")
  //   // {
  //   //   goal = new SimpleGoal(_goalNamePrompt, _goalDescriptionPrompt, _goalPointsValuePrompt);

  //   //   //return _simpleGoal;
  //   // }
  //   // else if (userGoalSelection == "2")
  //   // {
  //   //   goal = new EternalGoal(_goalNamePrompt, _goalDescriptionPrompt, _goalPointsValuePrompt);
  //   //   //return _eternalGoal;
  //   // }
  //   // else
  //   // {
  //   //   goal = new ChecklistGoal(_goalNamePrompt, _goalDescriptionPrompt, _goalPointsValuePrompt);
  //   //   //return _checklistGoal;
  //   // }
  //   Console.Write(GetGoalNamePrompt());
  //   _goalName = Console.ReadLine();
  //   Console.Write("\n" + GetGoalDescriptionPrompt());
  //   _goalDescription = Console.ReadLine();
  //   Console.Write("\n" + GetGoalPointsValuePrompt());
  //   _goalPointsValue = int.Parse(Console.ReadLine());
  //   return goal;

  //   //return _eternalGoal; //TODO not correct return NEED to fix!!!!!!!!
  // }
}