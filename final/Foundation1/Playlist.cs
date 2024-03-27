//Foundation1 source code
//Dennis Skoy
//Mar 2024

//Playlist Class

class Playlist
{
    private string name;//name of the playlist
    private List<Video> videos;//list of videos in the playlist

    // Constructor
    public Playlist(string name)
    {
        this.name = name;
        videos = new List<Video>();
    }

    // Getters
    public string GetName() { return name; }
    public List<Video> GetVideos() { return videos; }

    // Setters
    public void SetName(string name) { this.name = name; }


    // Methods
    /**AddVideo: adds a video to the playlist */
    public void AddVideo(Video video) { videos.Add(video); }


    /**ToString: returns title, author, length, and number of comments for each video as a string */
    public void ShowVideos()
    {
        foreach (Video video in videos)//for each video in the playlist
        {
            Console.WriteLine(video.ToString());//display video info
            video.ShowComments();//display comments
        }
    }
}