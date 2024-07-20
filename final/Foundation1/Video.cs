public class Video
{
  public string _title;
  public string _videoCreator;
  public string _length;
  public List<Comments> _commentsList;

  public Video(string title, string videoCreator, string length, params Comments[] commentsList)
  {
    _title = title;
    _videoCreator = videoCreator;
    _length = length;
    _commentsList = new List<Comments>();
    foreach (Comments comment in commentsList)
    {
      _commentsList.Add(comment);
    }
  }

  public void DisplayVideo()
  {
    Console.WriteLine($"""
    Title: {_title}
    Creator: {_videoCreator}
    Length: {_length} minutes
    Number of Comments: {CountComments(_commentsList)}

    """);
    if (CountComments(_commentsList) > 0)
    {
      foreach (Comments comment in _commentsList)
      {
        Console.WriteLine(comment.RenderComment() + "\n");
      }
    }
  }

  public int CountComments(List<Comments> commentsList)
  {
    return commentsList.Count;
  }
}