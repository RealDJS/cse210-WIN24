// Foundation1 source code
// Dennis Skoy
// Mar 2024

// Video Class

class Video
{
    private string title;//title of the video
    private string author;//author of the video
    private int length;//length of the video in seconds
    private List<Comment> comments;//list of comments on the video

    // Constructor
    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        comments = new List<Comment>();
    }

    // Getters
    public string GetTitle() { return title; }
    public string GetAuthor() { return author; }
    public int GetLength() { return length; }
    public List<Comment> GetComments() { return comments; }

    // Setters
    public void SetTitle(string title) { this.title = title; }
    public void SetAuthor(string author) { this.author = author; }
    public void SetLength(int length) { this.length = length; }


    // Methods
    /**ToString: returns title, author, length, and number of comments as a string */
    public override string ToString()
    { return title + " by " + author + " (" + length + " seconds) - " + CountComments() + " comments"; }


    /**AddComment: adds a comment to the video */
    public void AddComment(Comment comment) { comments.Add(comment); }


    /**CountComments: returns the number of comments on the video */
    private int CountComments() { return comments.Count; }


    /**ShowComments: returns all comments on the video */
    public void ShowComments()
    {
        foreach (Comment comment in comments)
        { Console.WriteLine("\t" + comment + "\n"); }
    }
}