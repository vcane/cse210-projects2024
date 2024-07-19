public class Cycling : Activity
{
  private float _speed;

  public Cycling(string date, float activityDuration, float speed) : base(date, activityDuration)
  {
    _speed = speed;
  }

  public override float CalculateDistance()
  {
    return (_speed * _activityDuration) / 60;
  }

  public override float CalculateSpeed()
  {
    return _speed;
  }

  public override float CalculatePace()
  {
    return 60 / _speed;
  }
}