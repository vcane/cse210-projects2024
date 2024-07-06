public class Comments
{
  public string _commenterName;
  public string _text;

  public Comments(string commenterName, string text)
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