public class Running : Activity
{
  private float _distance;

  public Running(string date, float activityDuration, float distance) : base(date, activityDuration)
  {
    _distance = distance;
  }

  public override float CalculateDistance()
  {
    return _distance;
  }

  public override float CalculatePace()
  {
    return _activityDuration / _distance;
  }

  public override float CalculateSpeed()
  {
    return (_distance / _activityDuration) * 60;
  }
}