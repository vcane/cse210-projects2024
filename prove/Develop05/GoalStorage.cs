public class GoalStorage
{
  private List<Goal> _goalsList = new List<Goal>();

  public GoalStorage() { }

  public List<Goal> GetGoalList()
  {
    return _goalsList;
  }

  public void SetGoalList(List<Goal> goalList)
  {
    _goalsList = goalList;
  }

  public void AddGoal(Goal goal)
  {
    _goalsList.Add(goal);
  }

  public void DisplayGoalList()
  {
    for (int i = 0; i < _goalsList.Count; i++)
    {
      string goalType = new String($"{_goalsList[i].GetType()}");
      if (goalType == "SimpleGoal" || goalType == "EternalGoal")
      {
        Console.WriteLine($"[{_goalsList[i].GetMarker()}] {i + 1}. {_goalsList[i].GetGoalName()} ({_goalsList[i].GetGoalDescription()})");
      }
      else
      {
        Console.WriteLine($"[{_goalsList[i].GetMarker()}] {i + 1}. {_goalsList[i].GetGoalName()} ({_goalsList[i].GetGoalDescription()}) -- Currently completed: {_goalsList[i].GetTimesCompleted()}/{_goalsList[i].GetTimesToComplete()}");
      }
    }
  }
}