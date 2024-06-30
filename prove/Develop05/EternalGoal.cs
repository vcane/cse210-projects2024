public class EternalGoal : Goal
{
  //private int _eternalGoalPointValue;

  public EternalGoal() { }

  public EternalGoal(string goalNamePrompt, string goalDescriptionPrompt, string goalPointsValuePrompt) : base(goalNamePrompt, goalDescriptionPrompt, goalPointsValuePrompt)
  {
    //_eternalGoalPointValue = 0;
  }

  public override string Serialize()
  {
    return $"{GetType()}~~{GetGoalName()}~~{GetGoalDescription()}~~{GetGoalPointsValue()}";
  }

  public override void Deserialize(string[] parts)
  {
    _goalName = parts[1];
    _goalDescription = parts[2];
    _goalPointsValue = int.Parse(parts[3]);
  }
}