public class Comment
{
  public string _commenterName;
  public string _text;

  public Comment(string commenterName, string text)
  {
    _commenterName = commenterName;
    _text = text;
  }

  public string RenderComment()
  {
    return $"""
    Commenter name: {_commenterName}
    Comment: {_text}
    """;
  }
}