class Program
{
  static void Main(string[] args)
  {
    List<Video> videoLibrary = new List<Video>()
    {
      new Video("Cute Cat Videos", "Virgil Cane", "10"),
      new Video("Dufus the Dog", "Virgil Cane", "13"), // <---Comments intentionally not added to this video
      new Video("Polly the Parrot", "Virgil Cane", "5")
    };

    //intentionally run DisplayVideo to simulate creating videos without comments
    Console.WriteLine("Displaying videos with no comments.....");
    foreach (Video video in videoLibrary)
    {
      video.DisplayVideo();
    }

    //this group simulates people adding comments to the first video in the library
    videoLibrary[0].AddComment(new Comment("Amanda", "I love your cat video!"));
    videoLibrary[0].AddComment(new Comment("Chrissy", "Your cat videos are awesome!"));
    videoLibrary[0].AddComment(new Comment("Emily", "Your cat videos are outstanding!"));

    //this group simulates people adding comments to the second video in the library
    videoLibrary[2].AddComment(new Comment("Sierra", "Meh."));
    videoLibrary[2].AddComment(new Comment("Charles", "Annoying bird!"));
    videoLibrary[2].AddComment(new Comment("Thomas", "The video is too short! I want more Polly the Parrot!"));
    videoLibrary[2].AddComment(new Comment("Anonymous", "Get better videos!!"));

    //intentionally ran a second time to display comments
    Console.WriteLine("Displaying videos after comments added (if any added).....");
    foreach (Video video in videoLibrary)
    {
      video.DisplayVideo();
    }
  }
}