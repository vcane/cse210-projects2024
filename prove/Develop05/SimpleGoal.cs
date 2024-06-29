public class SimpleGoal : Goal
{
  private int _simpleGoalPointValue;

  public SimpleGoal(string goalNamePrompt, string goalDescriptionPrompt, string goalPointsValuePrompt) : base(goalNamePrompt, goalDescriptionPrompt, goalPointsValuePrompt)
  {
    _simpleGoalPointValue = 0;
  }

  public override void CreateGoal()
  {
    Console.Write(GetGoalNamePrompt());
    _goalName = Console.ReadLine();
    Console.Write(GetGoalDescriptionPrompt());
    _goalDescription = Console.ReadLine();
    Console.Write(GetGoalPointsValuePrompt());
    _simpleGoalPointValue = int.Parse(Console.ReadLine());
  }

  public override string Serialize()
  {
    return $"{GetType()}~~{GetGoalName()}~~{GetGoalDescription()}~~{_simpleGoalPointValue}~~{GetIsComplete()}";
  }

  public override void Deserialize(string[] parts)
  {
    //string[] parts = line.Split("~~");
    _goalName = parts[1];
    _goalDescription = parts[2];
    _simpleGoalPointValue = int.Parse(parts[3]);
    _isComplete = bool.Parse(parts[4]);
  }
}