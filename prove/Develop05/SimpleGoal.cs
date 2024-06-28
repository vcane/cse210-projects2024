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
}