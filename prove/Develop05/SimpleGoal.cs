public class SimpleGoal : Goal
{
  public SimpleGoal() { }

  public SimpleGoal(string goalNamePrompt, string goalDescriptionPrompt, string goalPointsValuePrompt) : base(goalNamePrompt, goalDescriptionPrompt, goalPointsValuePrompt) { }
  public override string Serialize()
  {
    return $"{GetType()}~~{GetGoalName()}~~{GetGoalDescription()}~~{GetGoalPointsValue()}~~{GetIsComplete()}";
  }

  public override void Deserialize(string[] parts)
  {
    _goalName = parts[1];
    _goalDescription = parts[2];
    _goalPointsValue = int.Parse(parts[3]);
    _isComplete = bool.Parse(parts[4]);
  }
}