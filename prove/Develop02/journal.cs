public class Journal
{
  public List<Entry> _journalEntries = new List<Entry>();

  public Journal() { }

  public void AddEntry()
  {
    bool addAnEntry = true;
    string loopAgain = String.Empty;
    int numberOfEntries = 0;
    while (addAnEntry == true)
    {
      Entry journalEntry = new Entry();
      Prompt randoPrompt = new Prompt();

      journalEntry._prompt = randoPrompt.RetrievePrompt();
      Console.WriteLine("\nHere's your prompt.");
      Console.WriteLine(journalEntry._prompt);
      Console.Write("> ");
      journalEntry._userResponse = Console.ReadLine();

      _journalEntries.Add(journalEntry);

      Console.Write("Would you like to enter another entry? ('y' for yes or 'n' for no) ");
      loopAgain = Console.ReadLine().ToLower();
      if (loopAgain == "n" || loopAgain == "no")
      {
        addAnEntry = false;
      }
      numberOfEntries++;
    }
    if (numberOfEntries == 1)
    {
      Console.WriteLine("Thanks for adding an entry.");
    }
    else
    {
      Console.WriteLine($"Thanks for adding {numberOfEntries} entries.");
    }
  }

  public void DisplayJournal()
  {
    foreach (Entry entry in _journalEntries)
    {
      entry.DisplayEntry();
    }
  }

  public void SaveJournal()
  {
    Console.WriteLine("The program will save the journal to a text (.txt) file. The .txt extension will be added automatically.");
    Console.Write("Please enter the name of the file. ");
    string fileName = Console.ReadLine() + ".txt";
    Console.WriteLine($"Your journal was saved to a file called {fileName}.");

    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      foreach (Entry entry in _journalEntries)
      {
        outputFile.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._userResponse}");
      }
    }
  }

  public void LoadJournal()
  {

    Console.WriteLine("The program will load the journal from a text (.txt) file. The .txt extension will be added automatically to the end of the file name.");
    Console.Write("Please enter the name of the file. ");
    string fileName = Console.ReadLine() + ".txt";
    Console.WriteLine($"Loading your journal from {fileName}.");

    string[] lines = File.ReadAllLines(fileName);

    foreach (string line in lines)
    {
      string[] parts = line.Split("~~");

      Entry journalEntry = new Entry();
      journalEntry._date = parts[0];
      journalEntry._prompt = parts[1];
      journalEntry._userResponse = parts[2];

      _journalEntries.Add(journalEntry);
    }
  }
}