using System;
//"one", "John~3~:~16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
class Program
{
  static void Main(string[] args)
  {
    bool stopLoop = false;
    string continueProgram = String.Empty;
    string userPassageChoice = String.Empty;

    // declare objects
    Reference scriptRef;
    Scripture scrip;

    List<List<string>> passages = new List<List<string>>();
    // List<List<string>> randomScripture = new List<List<string>>();
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

    Console.WriteLine("Which scripture passage would you like? Please enter 1 for Moroni 10:5 or 2 for Proverbs 3:5-6. ");
    userPassageChoice = Console.ReadLine();

    if (userPassageChoice == "1")
    {
      string[] referenceParts = passages[0][1].Split("~");
      // removed Reference
      scriptRef = new Reference(referenceParts[0], referenceParts[1], referenceParts[3]);
      // removed Scripture
      scrip = new Scripture(scriptRef, passages[0][2]);
      // Console.WriteLine(scrip.RenderScripture());
      // //another while loop to hide all of the words???
      // bool loop = true;
      // while (loop == true)
      // {
      //   Console.WriteLine("Hit Enter to hide the words.");
      //   Console.ReadLine();
      //   Console.Clear();
      //   scrip.HideWords();
      //   Console.WriteLine(scrip.RenderScripture());
      //   if (scrip.AllWordsHidden() == false)
      //   {
      //     loop = false;
      //   }
      // }
    }

    else
    {
      string[] referenceParts = passages[1][1].Split("~");
      //removed Reference
      scriptRef = new Reference(referenceParts[0], referenceParts[1], referenceParts[3], referenceParts[5]);
      //removed Scripture
      scrip = new Scripture(scriptRef, passages[1][2]);
      //Console.WriteLine(scrip.RenderScripture());
    }

    while (stopLoop == false && continueProgram == String.Empty)
    {
      Console.WriteLine(scrip.RenderScripture());
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
      //another while loop to hide all of the words???
      // bool stopLoop = false;
      // while (stopLoop == false)
      // {
      //   Console.WriteLine("Hit Enter to hide the words.");
      //   Console.ReadLine();
      //   Console.Clear();
      //   scrip.HideWords();
      //   Console.WriteLine(scrip.RenderScripture());
      //   if (scrip.AllWordsHidden() == true)
      //   {
      //     stopLoop = true;
      //   }
      // }
      // Console.WriteLine("Hit enter to continue or type q. ");
      //continueProgram = Console.ReadLine();
    }


    // Random random = new Random();
    // int ranIndex = random.Next(0, passages.Count);
    // randomScripture.Add(passages[ranIndex]);
    // string[] referenceParts = randomScripture[0][1].Split("~");

    // if (randomScripture[0][0] == "one")
    // {
    //   Reference scriptRef = new Reference(referenceParts[0], referenceParts[1], referenceParts[3]);
    //   //Console.WriteLine($"Test reference: {scriptRef.ReferenceRenderedText()}");
    //   //Scripture s = new Scripture(scriptRef, scripture1[3]);
    // }
    // else
    // {
    //   Reference scriptRef = new Reference(referenceParts[0], referenceParts[1], referenceParts[3], referenceParts[5]);
    //   //Console.WriteLine($"Test reference: {scriptRef.ReferenceRenderedText()}");
    // }



    // Word wordTest1 = new Word("____");
    // Word wordTest2 = new Word("word");
    // Console.WriteLine($"Test1 isHidden: {wordTest1.WordHidden()}");
    // Console.WriteLine($"Test1 Rendered text: {wordTest1.RenderWord()}");

    // Console.WriteLine($"Test2 pre-hide....isHidden: {wordTest2.WordHidden()}");
    // Console.WriteLine($"Test2 pre-hide....Rendered text: {wordTest2.RenderWord()}");
    // wordTest2.Hide();
    // Console.WriteLine($"Test2 Post-hide....isHidden: {wordTest2.WordHidden()}");
    // Console.WriteLine($"Test2 Post-hide....rendered text: {wordTest2.RenderWord()}");
    // wordTest2.Show();
    // Console.WriteLine($"Test2 Post-show....isHidden: {wordTest2.WordHidden()}");
    // Console.WriteLine($"Test2 Post-show....rendered text: {wordTest2.RenderWord()}");

    // string[] referenceParts1 = scripture1[1].Split("~");
    // Reference r = new Reference(referenceParts1[0], referenceParts1[1], referenceParts1[3]);
    // Console.WriteLine($"Reference 1: {r.ReferenceRenderedText()}");
    // Scripture scripture = new Scripture(r, scripture1[2]);
    // Console.WriteLine();
    // Console.WriteLine();

    // string[] referenceParts2 = scripture2[1].Split("~");
    // Reference r2 = new Reference(referenceParts2[0], referenceParts2[1], referenceParts2[3], referenceParts2[5]);
    // Console.WriteLine($"Reference 2: {r2.ReferenceRenderedText()}");
    // Scripture script2 = new Scripture(r2, scripture2[2], scripture2[3]);

    // List<string> scriptures = new List<string>()
    // {
    //     "Proverbs 3:5-6~~Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
    //     "John 3:16~~For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
    // };

    // for (int i = 0; i < scriptures.Count; i++)
    // {
    //   string reference = scriptures[i].Split("~~")[0];
    //   string scripture = scriptures[i].Split("~~")[1];
    //   Console.WriteLine(reference);
    //   Console.WriteLine(scripture);
    // }
    // string scripture1 = "Proverbs 3:5-6 Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

    // string scripture2 = "John 3:16 For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";


    // List<string> scripture1 = new List<string>()
    //     {
    //         "Proverbs 3:5-6",
    //         "Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
    //         "In all thy ways acknowledge him, and he shall direct thy paths."
    //     };
    // List<string> scripture2 = new List<string>()
    //     {
    //         "John 3:16",
    //         "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
    //     };

    // List<List<string>> passages = new List<List<string>>() { scripture1, scripture2 };
    // List<string> parts = new List<string>();

    // for (int i = 0; i < passages.Count; i++)
    // {
    //   for (int j = 0; j < passages[i].Count; j++)
    //   {
    //     Console.WriteLine(passages[i][j]);
    //   }
    // }

    // foreach (List<string> scripture in passages)
    // {

    // }
    // Dictionary<string, List<string>> passages = new Dictionary<string, List<string>>()
    // {
    //     {"scripture1", scripture1},
    //     {"scripture2", scripture2}
    // };



    // passages.Add("scripture1", scripture1);
    // passages.Add("scripture2", scripture2);
    // passages.Add("scripture1", new List<string>());
    // passages.Add("scripture2", new List<string>());
    // foreach (KeyValuePair<string, List<string>> scripture in passages)
    // {
    //   Console.WriteLine("{0} and {1}", scripture.Key, for(int i = 0; i <= scripture.Value.Count; i++) {});
    // }
  }
}