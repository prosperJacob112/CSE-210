public class Reference
{
    private string _book;
    private int _chapter;
    private int _endverse;
    private int _startverse;

    public Reference(string Book, int Chapter, int Verse)
    {
        _book = Book;
        _chapter = Chapter;
        _startverse = Verse;
        _endverse = Verse;
    }

    public Reference(string Book, int Chapter, int startVerse, int endVerse)
    {
        _book = Book;
        _chapter = Chapter;
        _startverse = startVerse;
        _endverse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_startverse == _endverse)
        {
            return $"{_book} {_chapter}:{_startverse}";
        }

        return $"{_book} {_chapter}:{_startverse}-{_endverse}";
    }
}