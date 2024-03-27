//Foundation1 source code
//Dennis Skoy
//Mar 2024

class Program
{
    static void Main(string[] args)
    {
        // Creates new videos
        Video video = new Video("C# in 100 Seconds", "Bob Tabor", 100);
        Video video2 = new Video("C# Level 2", "Bob Tabor", 256);
        Video video3 = new Video("C# Expert", "Bob Tabor", 480);

        // Add comments to videos
        video.AddComment(new Comment("Alice", "Great video!"));
        video.AddComment(new Comment("Bob", "I learned a lot!"));
        video.AddComment(new Comment("Charlie", "Thanks for sharing!"));

        video2.AddComment(new Comment("Nero15", "Interesting, but I got lost."));
        video2.AddComment(new Comment("Dante49", "I'm a pro now!"));
        video2.AddComment(new Comment("Vergil51", "I already knew this."));

        video3.AddComment(new Comment("JC Denton", "Do you have a single fact to back that up?"));
        video3.AddComment(new Comment("Adam Jensen", "I never asked for this."));
        video3.AddComment(new Comment("Bob Page", "In the end, I will thank you."));
        video3.AddComment(new Comment("Alex Denton", "I am the future."));

        // Create a playlist
        Playlist playlist = new Playlist("C# Programming");

        // Add videos to the playlist
        playlist.AddVideo(video);
        playlist.AddVideo(video2);
        playlist.AddVideo(video3);

        // Display the videos
        Console.WriteLine();
        playlist.ShowVideos();
    }
}