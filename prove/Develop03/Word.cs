class Word
{
  private string _originalWord;
  private string _convertedWord;
  private bool _isHidden;

  public Word(string word)
  {
    _originalWord = word;
    _convertedWord = word;
    char[] chars = _originalWord.ToCharArray();
    foreach (char c in chars)
    {
      if (c == '_')
      {
        _isHidden = true;
      }
      else
      {
        _isHidden = false;
      }
    }
  }

  public bool WordHidden()
  {
    return _isHidden;
  }

  public void Hide()
  {
    for (int i = 0; i < _convertedWord.Length; i++)
    {
      _convertedWord = _convertedWord.Replace(_convertedWord[i], '_');
    }
    _isHidden = true;
  }

  public void Show()
  {
    for (int i = 0; i < _convertedWord.Length; i++)
    {
      _convertedWord = _convertedWord.Replace(_convertedWord[i], _originalWord[i]);
    }
    _isHidden = false;
  }

  public string RenderWord()
  {
    return _convertedWord;
  }
}