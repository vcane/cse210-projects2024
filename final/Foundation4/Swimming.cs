public class Swimming : Activity
{
  private float _numberOfLaps;

  public Swimming(string date, float activityDuration, float numberOfLaps) : base(date, activityDuration)
  {
    _numberOfLaps = numberOfLaps;
  }

  public override float CalculateDistance()
  {
    return (_numberOfLaps * 50) / 1000;
  }

  public override float CalculateSpeed()
  {
    return (CalculateDistance() / _activityDuration) * 60;
  }

  public override float CalculatePace()
  {
    return 60 / CalculateSpeed();
  }
}