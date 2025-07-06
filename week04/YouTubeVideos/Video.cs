using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;

    private List<Comment> comments = new List<Comment>();

    public Video(string titleInput, string authorInput, int lengthInSecondsInput)
    {
        _title = titleInput;
        _author = authorInput;
        _lengthInSeconds = lengthInSecondsInput;
    }

    public void AddComent(Comment comment)
    {
         comments.Add(comment);
    }

    public int GetComentCount()
    {
        return comments.Count();
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}