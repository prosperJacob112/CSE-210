using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordTexts = text.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string wordText in wordTexts)
        {
            _words.Add(new Word(wordText));
        }
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()} {string.Join(" ", displayWords)}";
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = _random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}

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

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }

        return _text;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Reference reference = new Reference("Genesis", 3, 1, 3);

        string text =
            "Now the serpent was more subtil than any beast of the field " +
            "which the LORD God had made. And he said unto the woman, " +
            "Yea, hath God said, Ye shall not eat of every tree of the garden? " +
            "And the woman said unto the serpent, We may eat of the fruit " +
            "of the trees of the garden: But of the fruit of the tree which " +
            "is in the midst of the garden, God hath said, Ye shall not eat " +
            "of it, neither shall ye touch it, lest ye die.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");

            string input = Console.ReadLine();

            if (input != null && input.Trim().Equals(
                    "quit",
                    StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}