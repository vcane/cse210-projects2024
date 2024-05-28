public class Reference
{
  private string _book = String.Empty;
  private string _chapter = String.Empty;
  private string _verse = String.Empty;
  private string _secondVerse = String.Empty;

  public Reference(string book, string chapter, string verse)
  {
    _book = book;
    _chapter = chapter;
    _verse = verse;
  }

  public Reference(string book, string chapter, string verse, string secondVerse)
  {
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _secondVerse = secondVerse;
  }

  public string ReferenceRenderedText()
  {
    if (_secondVerse == String.Empty)
    {
      return $"{_book} {_chapter}:{_verse}";
    }
    else
    {
      return $"{_book} {_chapter}:{_verse}-{_secondVerse}";
    }
  }
}