class Video
{
    /* The Video class stores info about each video and its comments.
    SetVideoDetails lets me set all the main info at once.
    AddComment adds a comment to the list.
    The getter methods let me access the data without directly touching the private fields. */
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> Comments = new List<Comment>();

    public void SetVideoDetails(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public List<Comment> GetComments()
    {
        return Comments;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

}