class Program
{
  static void Main(string[] args)
  {
    Journal journal = new Journal();
    bool loopAgain = true;

    Console.WriteLine("\nWelcome to your journal!");

    while (loopAgain == true)
    {
      Console.WriteLine("""

        Here are your options:
          1. Create an entry.
          2. Save your journal.
          3. Load a previously saved journal.
          4. Display your journal entries.
          5. Quit the application.
        """);
      Console.Write("Please select one of the options below by its number. ");
      string userSelection = Console.ReadLine();

      switch (userSelection)
      {
        case "1":
          journal.AddEntry();
          break;
        case "2":
          journal.SaveJournal();
          break;
        case "3":
          journal.LoadJournal();
          break;
        case "4":
          journal.DisplayJournal();
          break;
        case "5":
          loopAgain = false;
          Console.WriteLine("\nGoodbye.");
          break;
      }
    }
  }
}