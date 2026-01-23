using System.Diagnostics;

public class Scripture
{
    private List<Word> _listOfWords = new List<Word>();
    private Reference _reference;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach(string word in words)
        {
            Word newWord = new Word(word);
            _listOfWords.Add(newWord);
        }
    }

    public void DisplayText()
    {
        Console.WriteLine(_reference.GetReference());
        string text = "";
        foreach(Word word in _listOfWords)
        {
            text += $"{word.GetWord()} ";
        }
        Console.WriteLine(text);
    }
    public void HideRandomWords(int amount)
    {
        for(int i = 0; i < amount; i++)
        {
            bool worked = false;
            while(!worked && !IsCompleteHidden())
            {
                int index = _random.Next(0, _listOfWords.Count);
                if (!_listOfWords[index].IsHidden())
                {
                    _listOfWords[index].Hide();
                    worked = true;
                }  
            }

            
        }
    }
    public bool IsCompleteHidden()
    {
        bool hidden = true;
        foreach(Word word in _listOfWords)
        {
            if (!word.IsHidden())
            {
                hidden = false;
                break;
            }
        }
        return hidden;
    }
}