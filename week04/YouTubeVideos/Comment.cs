using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

class Comment {

    private String _commenterName;
    private string _text;

    public Comment (string commenterName, string text)
        {
            _commenterName = commenterName;
            _text = text;

        }

        public void Display()
        {
            Console.WriteLine($"{_commenterName}: {_text}");
        }


}