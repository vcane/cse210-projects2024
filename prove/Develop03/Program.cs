using System;

class Program
{
  static void Main(string[] args)
  {

    List<List<string>> passages = new List<List<string>>();
    List<List<string>> randomScripture = new List<List<string>>();

    List<string> scripture2 = new List<string>()
    {
      "two", "Proverbs~3~:~5~-~6","Trust in the Lord with all thine heart; and lean not unto thine own understanding.", "In all thy ways acknowledge him, and he shall direct thy paths."
    };

    List<string> scripture1 = new List<string>()
    {
      "one", "John~3~:~16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
    };

    passages.Add(scripture1);
    passages.Add(scripture2);

    Random random = new Random();
    int ranIndex = random.Next(0, passages.Count);
    randomScripture.Add(passages[ranIndex]);
    string[] referenceParts = randomScripture[0][1].Split("~");

    if (randomScripture[0][0] == "one")
    {
      Reference reference = new Reference(referenceParts[0], referenceParts[1], referenceParts[3]);
      //Console.WriteLine($"Test reference: {reference.ReferenceRenderedText()}");
    }
    else
    {
      Reference reference = new Reference(referenceParts[0], referenceParts[1], referenceParts[3], referenceParts[5]);
      //Console.WriteLine($"Test reference: {reference.ReferenceRenderedText()}");
    }

    //Word wordTest1 = new Word("____");
    Word wordTest2 = new Word("word");
    // Console.WriteLine($"Test1 isHidden: {wordTest1.WordHidden()}");
    // Console.WriteLine($"Test1 Rendered text: {wordTest1.RenderWord()}");

    Console.WriteLine($"Test2 pre-hide....isHidden: {wordTest2.WordHidden()}");
    Console.WriteLine($"Test2 pre-hide....Rendered text: {wordTest2.RenderWord()}");
    wordTest2.Hide();
    Console.WriteLine($"Test2 Post-hide....isHidden: {wordTest2.WordHidden()}");
    Console.WriteLine($"Test2 Post-hide....rendered text: {wordTest2.RenderWord()}");
    wordTest2.Show();
    Console.WriteLine($"Test2 Post-show....isHidden: {wordTest2.WordHidden()}");
    Console.WriteLine($"Test2 Post-show....rendered text: {wordTest2.RenderWord()}");























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