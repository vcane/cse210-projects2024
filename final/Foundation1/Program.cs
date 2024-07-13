class Program
{
  static void Main(string[] args)
  {
    List<Video> videoLibrary = new List<Video>();

    // cat video with comments
    Video video1 = new Video("Cute Cat Videos", "Virgil Cane", "10");
    Comments comment1 = new Comments("Amanda", "I love your cat video!");
    Comments comment2 = new Comments("Chrissy", "Your cat videos are awesome!");
    Comments comment3 = new Comments("Emily", "Your cat videos are outstanding!");
    video1._commentsList.Add(comment1);
    video1._commentsList.Add(comment2);
    video1._commentsList.Add(comment3);

    // dog video with no comments
    Video video2 = new Video("Dufus the Dog", "Virgil Cane", "13");

    // parrot video with comments
    Video video3 = new Video("Polly the Parrot", "Virgil Cane", "5");
    Comments comment4 = new Comments("Sierra", "Meh.");
    Comments comment5 = new Comments("Charles", "Annoying bird!");
    Comments comment6 = new Comments("Thomas", "The video is too short! I want more Polly the Parrot!");
    Comments comment7 = new Comments("Anonymous", "Get better videos!!");
    video3._commentsList.Add(comment4);
    video3._commentsList.Add(comment5);
    video3._commentsList.Add(comment6);
    video3._commentsList.Add(comment7);

    videoLibrary.Add(video1);
    videoLibrary.Add(video2);
    videoLibrary.Add(video3);

    foreach (Video video in videoLibrary)
    {
      video.DisplayVideo();
    }
  }
}