public class Prompt
{
  UsedPrompts oldPrompts = new UsedPrompts();
  public List<string> _prompts = new List<string>
  {
    "What was the strongest emotion that you felt today?",
    "Who was the most interesting person I interacted with today?",

  };
  //public List<string> _usedPrompts = new List<string>();
  public Prompt() { }
  // public string RetrievePrompt()
  // {
  //   Random randomGenerator = new Random();
  //   int promptIndex = randomGenerator.Next(0, _prompts.Count);
  //   return _prompts[promptIndex];
  //   // Potential improvement is to make it so RetrievePrompt doesn't retrieve duplicate prompts
  // }

  public string RetrievePrompt()
  {

    int promptIndex;
    string prompt = String.Empty;
    bool contLoop = true;
    while (contLoop == true)
    {
      Random randomGenerator = new Random();
      promptIndex = randomGenerator.Next(0, _prompts.Count);
      if (oldPrompts._usedPrompts.Contains(_prompts[promptIndex]))
      {
        continue;
      }
      else
      {
        oldPrompts._usedPrompts.Add(_prompts[promptIndex]);
        prompt = _prompts[promptIndex];
        contLoop = false;
      }
    }
    return prompt;
    // Potential improvement is to make it so RetrievePrompt doesn't retrieve duplicate prompts
  }
}

/*
"What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "If I had one thing I could do over today, what would it be?"
*/