public class EternalGoal : Goal
{
  private int _eternalGoalPointValue;


  public EternalGoal(string goalNamePrompt, string goalDescriptionPrompt, string goalPointsValuePrompt) : base(goalNamePrompt, goalDescriptionPrompt, goalPointsValuePrompt)
  {
    _eternalGoalPointValue = 0;
  }
}