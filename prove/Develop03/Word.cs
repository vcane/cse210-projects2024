class Word
{
  private string _word;
  private bool _isHidden;

  public Word(string word)
  {
    _word = word;
    char[] chars = _word.ToCharArray();
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
    _isHidden = true;
  }

  //MAY NOT NEED SHOW() CURRENTLY NOT USED ANYWHERE AND DON'T SEE A REASON TO USE

  // public void Show()
  // {
  //   _isHidden = false;
  // }

  public string RenderWord()
  {
    if (_isHidden == false)
    {
      return _word;
    }
    else
    {
      string underScoreWord = "";
      foreach (char letter in _word)
      {
        underScoreWord += '_';
      }
      return underScoreWord;
    }
  }
}