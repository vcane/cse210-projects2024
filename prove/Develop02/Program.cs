using System;

class Program
{
  static void Main(string[] args)
  {
    Entry entry = new Entry();
    Prompt prompt = new Prompt();
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
          Console.WriteLine("Saving....");
          journal.SaveJournal();
          break;
        case "3":
          Console.WriteLine("\nLoading...");
          journal.LoadJournal();
          break;
        case "4":
          Console.WriteLine("\nDisplaying....");
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