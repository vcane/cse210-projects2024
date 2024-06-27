public class ChecklistGoal : Goal
{
  private int _timesCompleted;
  private int _totalCount;
  private int _bonusPoints;
  private int _checklistGoalPointValue;

  public ChecklistGoal(string goalNamePrompt, string goalDescriptionPrompt, string goalPointsValuePrompt) : base(goalNamePrompt, goalDescriptionPrompt, goalPointsValuePrompt)
  {
    _timesCompleted = 0;
    _totalCount = 0;
    _bonusPoints = 0;
    _checklistGoalPointValue = 0;
  }
}