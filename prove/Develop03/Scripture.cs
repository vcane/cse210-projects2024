class Scripture
{
  private Reference _reference;
  private string _scriptureText;
  private List<Word> _scriptureWords = new List<Word>();

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
    }
    return allWordsHidden;
  }


  // HideOneWord:
  // if all words are hidden, return
  // choose a random word
  // while that random word is not hidden:
  //   choose another random word
  // hide the word (which is not yet hidden)
  // return

  // public void HideOneWord()
  // {

  // }
  public void HideWords()
  {
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