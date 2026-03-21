/* The Comment class stores the name of the person who commented and the text of their comment.
I made a constructor so I can create a comment in one line instead of setting each field separately. */

class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _text;
    }
}

