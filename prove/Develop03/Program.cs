using System;
class Program
{
  static void Main(string[] args)
  {
    bool stopLoop = false;
    string continueProgram = String.Empty;
    string userPassageChoice = String.Empty;

    Reference scriptRef;
    Scripture scrip;
    Random random = new Random();

    List<List<string>> passages = new List<List<string>>();
    List<List<string>> randomScripture = new List<List<string>>();
    List<string> passage1 = new List<string>()
    {
      "one", "Moroni~10~:~5", "And by the power of the Holy Ghost ye may know the truth of all things."
    };

    List<string> passage2 = new List<string>()
    {
      "two", "Proverbs~3~:~5~-~6","Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
    };

    passages.Add(passage1);
    passages.Add(passage2);

    int ranIndex = random.Next(0, passages.Count);
    randomScripture.Add(passages[ranIndex]);

    if (randomScripture[0][0] == "one")
    {
      string[] referenceParts = passages[0][1].Split("~");
      scriptRef = new Reference(referenceParts[0], referenceParts[1], referenceParts[3]);
      scrip = new Scripture(scriptRef, passages[0][2]);
    }

    else
    {
      string[] referenceParts = passages[1][1].Split("~");
      scriptRef = new Reference(referenceParts[0], referenceParts[1], referenceParts[3], referenceParts[5]);
      scrip = new Scripture(scriptRef, passages[1][2]);
    }
    Console.WriteLine(scrip.RenderScripture());
    while (stopLoop == false && continueProgram == String.Empty)
    {
      Console.WriteLine("Hit Enter to hide the words or type quit to end the program.");
      continueProgram = Console.ReadLine();
      if (continueProgram == "quit")
      {
        break;
      }
      Console.Clear();
      scrip.HideWords();
      Console.WriteLine(scrip.RenderScripture());
      if (scrip.AllWordsHidden() == true)
      {
        stopLoop = true;
      }
    }
  }
}