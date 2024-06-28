public class EternalGoal : Goal
{
  private int _eternalGoalPointValue;


  public EternalGoal(string goalNamePrompt, string goalDescriptionPrompt, string goalPointsValuePrompt) : base(goalNamePrompt, goalDescriptionPrompt, goalPointsValuePrompt)
  {
    _eternalGoalPointValue = 0;
  }

  public override void CreateGoal()
  {
    Console.Write(GetGoalNamePrompt());
    _goalName = Console.ReadLine();
    Console.Write(GetGoalDescriptionPrompt());
    _goalDescription = Console.ReadLine();
    Console.Write(GetGoalPointsValuePrompt());
    _eternalGoalPointValue = int.Parse(Console.ReadLine());
  }
}