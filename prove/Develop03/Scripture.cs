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
    bool allWordsHidden = true;
    foreach (Word word in _scriptureWords)
    {
      if (word.WordHidden() != true)
      {
        allWordsHidden = false;
      }
    }
    return allWordsHidden;
  }

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