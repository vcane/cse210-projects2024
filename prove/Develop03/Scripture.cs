class Scripture
{
  private Reference _reference;
  private string _scriptureText;
  private List<Word> _scriptureWords = new List<Word>();


  // single verse scripture
  public Scripture(Reference reference, string scriptureText)
  {
    _reference = reference;
    _scriptureText = scriptureText;
    string[] words = _scriptureText.Split(" ");

    for (int i = 0; i < words.Count(); i++)
    {
      Word word = new Word(words[i]);
      _scriptureWords.Add(word);
    }
  }

  // two verse scripture
  // public Scripture(Reference reference, string scriptureText, string endVerse)
  // {
  //   _reference = reference;
  //   _scriptureText = scriptureText + " " + endVerse;
  //   string[] scriptureWords = _scriptureText.Split(" ");
  //   // foreach (string word in scriptureWords)
  //   // {
  //   //   Console.WriteLine(word);
  //   // }
  // }

  public bool AllWordsHidden()
  {
    bool allWordsHidden = false;
    foreach (Word word in _scriptureWords)
    {
      if (word.WordHidden() == true)
      {
        allWordsHidden = true;
      }
      else
      {
        allWordsHidden = false;
      }
      // else
      // {
      //   allWordsHidden = true;
      // }
    }
    return allWordsHidden;
  }

  public void HideWords()
  {
    //generate random indices for word list
    //grab word from word list and switch from _isHidden = false to _isHidden = true by using Hide()
    Random randNum = new Random();

    for (int i = 0; i < 3; i++)
    {
      _scriptureWords[randNum.Next(0, _scriptureWords.Count())].Hide();
    }
  }

  public string RenderScripture()
  {
    string rendScript = String.Empty;
    foreach (Word word in _scriptureWords)
    {
      rendScript = rendScript + word.RenderWord() + " ";
    }
    return $"{_reference.ReferenceRenderedText()} {rendScript}";
  }

}