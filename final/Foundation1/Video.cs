public class Video
{
  public string _title;
  public string _videoCreator;
  public string _length;
  public List<Comment> _commentsList;

  public Video(string title, string videoCreator, string length)
  {
    _title = title;
    _videoCreator = videoCreator;
    _length = length;
    _commentsList = new List<Comment>();
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
      foreach (Comment comment in _commentsList)
      {
        Console.WriteLine(comment.RenderComment() + "\n");
      }
    }
  }

  public int CountComments(List<Comment> commentsList)
  {
    return commentsList.Count;
  }

  public void AddComment(Comment comment)
  {
    _commentsList.Add(comment);
  }
}