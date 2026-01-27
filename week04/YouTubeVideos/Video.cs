using System.Net;

class Video
{
    
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public List<Comment> Comments { 

        get { return _comments; } 
    }

    public Video(string title, string author, int length)
    {
        _title = title; 
        _author = author;
        _length = length; 
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }


    public void Display() {

    Console.WriteLine($"{_title} by {_author} ({_length} seconds)");
    Console.WriteLine($"Comments: {GetCommentCount()}");

    foreach (Comment comment in _comments){

        comment.Display();
    }

    }






































}
