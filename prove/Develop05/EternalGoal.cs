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

  public override string Serialize()
  {
    return $"{GetType()}~~{GetGoalName()}~~{GetGoalDescription()}~~{_eternalGoalPointValue}"; // maybe should only have point value in Goal Class. Would that be inherited by the derived classes????
  }

  public override void Deserialize(string[] parts)
  {
    //string[] parts = line.Split("~~");
    _goalName = parts[1];
    _goalDescription = parts[2];
    _eternalGoalPointValue = int.Parse(parts[3]);
  }
}