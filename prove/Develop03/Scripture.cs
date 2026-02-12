
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _rand = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(" ");

        foreach (string w in parts)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int count)
    {
        List<Word> visible = new List<Word>();

        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                visible.Add(w);
            }
        }

        for (int i = 0; i < count && visible.Count > 0; i++)
        {
            int index = _rand.Next(visible.Count);
            visible[index].Hide();
            visible.RemoveAt(index);
        }
    }

    public bool AllHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";

        foreach (Word w in _words)
        {
            result += w.GetDisplayText() + " ";
        }

        return result;
    }
}