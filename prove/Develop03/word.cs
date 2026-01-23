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
        if (!_isHidden)
        {
            string underScoreText = "";
            for(int i = 0; i < _text.Length; i++)
            {
                underScoreText += "_";
            }
            _text = underScoreText;
            _isHidden = true;
        }
    }
    public string GetWord()
    {
        return _text;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
}