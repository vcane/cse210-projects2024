public class Activity
{
  protected string _date;
  protected float _activityDuration;


  public Activity(string date, float activityDuration)
  {
    _date = date;
    _activityDuration = activityDuration;
  }

  public virtual string SummarizeActivity()
  {
    return $"{_date} {GetType()} ({_activityDuration} min) - Distance: {Math.Round(CalculateDistance(), 1)} km, Speed: {Math.Round(CalculateSpeed(), 1)} kph, Pace: {Math.Round(CalculatePace(), 1)} min per km";
  }

  public virtual float CalculateDistance()
  {
    return -1.0f;
  }

  public virtual float CalculateSpeed()
  {
    return -1.0f;
  }

  public virtual float CalculatePace()
  {
    return -1.0f;
  }
}