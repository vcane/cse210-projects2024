public class SimpleGoal : Goal
{
  private int _simpleGoalPointValue;

  public SimpleGoal(string goalNamePrompt, string goalDescriptionPrompt, string goalPointsValuePrompt) : base(goalNamePrompt, goalDescriptionPrompt, goalPointsValuePrompt)
  {
    _simpleGoalPointValue = 0;
  }

  // public override Goal CreateGoal()
  // {
  //   Goal goal;
  //   return goal;
  // }
}