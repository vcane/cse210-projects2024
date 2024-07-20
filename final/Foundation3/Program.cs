class Program
{
  static void Main(string[] args)
  {
    Lecture lecture = new Lecture("Gravity really pulls you down", "Lecture on gravity", "7/11/22", "10 AM", new Address("123 Main", "Anytown", "KS", "66610"), "Virgil Cane", 1000);

    OutdoorGathering outdoorGathering = new OutdoorGathering("Stargazing event", "Bring your telescope and watch the stars with us.", "7/14/24", "10 pm", new Address("123 Main", "Anytown", "KS", "66610"), "warm with clear skies");

    Reception reception = new Reception("Smith's Wedding Reception", "Join us for Jon and Debbie Smith's wedding reception.", "7/14/23", "7 PM", new Address("123 Main", "Anytown", "KS", "66610"), "joan@joansweddingplanning.com");

    Console.WriteLine($"Virgil's Lecture Short Description: ");
    Console.WriteLine(lecture.RenderShortDescription());

    Console.WriteLine("\nVirgil's Lecture Standard Details:");
    Console.WriteLine(lecture.RenderStandardDetails());

    Console.WriteLine("\nVirgil's Lecture Full Details:");
    Console.WriteLine(lecture.RenderFullDetailsForLecture());

    Console.WriteLine("\nStar Gazing Short Description:");
    Console.WriteLine(outdoorGathering.RenderShortDescription());

    Console.WriteLine("\nStar Gazing Standard Details:");
    Console.WriteLine(outdoorGathering.RenderStandardDetails());

    Console.WriteLine("\nStar Gazing Full Details:");
    Console.WriteLine(outdoorGathering.RenderFullDetailsForOutdoorGathering());

    Console.WriteLine("\nJon and Debbie Smith's Reception Short Description:");
    Console.WriteLine(reception.RenderShortDescription());

    Console.WriteLine("\nJon and Debbie Smith's Reception Standard Details:");
    Console.WriteLine(reception.RenderStandardDetails());

    Console.WriteLine("\nJon and Debbie Smith's Reception Full Details:");
    Console.WriteLine(reception.RenderFullDetailsForReception());
  }
}