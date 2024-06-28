public class ChecklistGoal : Goal
{
  private int _timesCompleted;
  private int _timesToComplete;
  private int _bonusPoints;
  private int _checklistGoalPointValue;
  private string _numberOfTimesToCompletePrompt;
  private string _numberOfBonusPointsPrompt;

  //public ChecklistGoal() { }
  public ChecklistGoal(string goalNamePrompt, string goalDescriptionPrompt, string goalPointsValuePrompt, string numberOfTimeToCompletePrompt, string numberOfBonusPointsPrompt) : base(goalNamePrompt, goalDescriptionPrompt, goalPointsValuePrompt)
  {
    _timesCompleted = 0;
    _timesToComplete = 0;
    _bonusPoints = 0;
    _checklistGoalPointValue = 0;
    _numberOfTimesToCompletePrompt = numberOfTimeToCompletePrompt;
    _numberOfBonusPointsPrompt = numberOfBonusPointsPrompt;
  }

  public string GetNumberOfTimesToCompletePrompt()
  {
    return _numberOfTimesToCompletePrompt;
  }

  public string GetNumberOfBonusPointsPrompt()
  {
    return _numberOfBonusPointsPrompt;
  }

  public override int GetTimesCompleted()
  {
    return _timesCompleted;
  }

  public override int GetTimesToComplete()
  {
    return _timesToComplete;
  }

  public override void CreateGoal()
  {
    Console.Write(GetGoalNamePrompt());
    _goalName = Console.ReadLine();
    Console.Write(GetGoalDescriptionPrompt());
    _goalDescription = Console.ReadLine();
    Console.Write(GetGoalPointsValuePrompt());
    _checklistGoalPointValue = int.Parse(Console.ReadLine());
    Console.Write(GetNumberOfTimesToCompletePrompt());
    _timesToComplete = int.Parse(Console.ReadLine());
    Console.Write(GetNumberOfBonusPointsPrompt());
    _bonusPoints = int.Parse(Console.ReadLine());
  }
}