using System.Runtime.CompilerServices;

public class Word
{
    private string _text = "";
    private bool _ishidden = false;

    public Word(string text)
    {
        _text = text;
        _ishidden = false;
    }

    public void Hide()
    {
        _ishidden = true;
    }

    public bool IsHidden()
    {
        return _ishidden;
    }

    public string GetDisplayText()
    {
        if (_ishidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}