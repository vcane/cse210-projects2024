public class MathAssignment : Assignment
{
  private string _textBookSection;
  private string _problems;

  public MathAssignment(string studentName, string topic, string textBookSelection, string problems) : base(studentName, topic)
  {
    _textBookSection = textBookSelection;
    _problems = problems;
  }

  public string GetHomeworkList()
  {
    return $"{_textBookSection} {_problems}";
  }
}