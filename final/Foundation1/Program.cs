class Program
{
  static void Main(string[] args)
  {
    //adds videos to videoLibrary with comments using the params keyword
    List<Video> videoLibrary = new List<Video>()
    {
      new Video("Cute Cat Videos", "Virgil Cane", "10", new Comments("Amanda", "I love your cat video!"), new Comments("Chrissy", "Your cat videos are awesome!"), new Comments("Emily", "Your cat videos are outstanding!")),
      new Video("Dufus the Dog", "Virgil Cane", "13"),
      new Video("Polly the Parrot", "Virgil Cane", "5", new Comments("Sierra", "Meh."), new Comments("Charles", "Annoying bird!"), new Comments("Thomas", "The video is too short! I want more Polly the Parrot!"), new Comments("Anonymous", "Get better videos!!"))
    };

    // cat video with comments
    // Video video1 = new Video("Cute Cat Videos", "Virgil Cane", "10", new Comments("Amanda", "I love your cat video!"), new Comments("Chrissy", "Your cat videos are awesome!"), new Comments("Emily", "Your cat videos are outstanding!"));
    // Comments comment1 = new Comments("Amanda", "I love your cat video!");
    // Comments comment2 = new Comments("Chrissy", "Your cat videos are awesome!");
    // Comments comment3 = new Comments("Emily", "Your cat videos are outstanding!");
    // video1._commentsList.Add(comment1);
    // video1._commentsList.Add(comment2);
    // video1._commentsList.Add(comment3);

    // dog video with no comments
    //Video video2 = new Video("Dufus the Dog", "Virgil Cane", "13");

    // parrot video with comments
    // Video video3 = new Video("Polly the Parrot", "Virgil Cane", "5", new Comments("Sierra", "Meh."), new Comments("Charles", "Annoying bird!"), new Comments("Thomas", "The video is too short! I want more Polly the Parrot!"), new Comments("Anonymous", "Get better videos!!"));
    // Comments comment4 = new Comments("Sierra", "Meh.");
    // Comments comment5 = new Comments("Charles", "Annoying bird!");
    // Comments comment6 = new Comments("Thomas", "The video is too short! I want more Polly the Parrot!");
    // Comments comment7 = new Comments("Anonymous", "Get better videos!!");
    // video3._commentsList.Add(comment4);
    // video3._commentsList.Add(comment5);
    // video3._commentsList.Add(comment6);
    // video3._commentsList.Add(comment7);

    // videoLibrary.Add(new Video("Cute Cat Videos", "Virgil Cane", "10", new Comments("Amanda", "I love your cat video!"), new Comments("Chrissy", "Your cat videos are awesome!"), new Comments("Emily", "Your cat videos are outstanding!")));
    // videoLibrary.Add(new Video("Dufus the Dog", "Virgil Cane", "13"));
    // videoLibrary.Add(video3);

    foreach (Video video in videoLibrary)
    {
      video.DisplayVideo();
    }
  }
}