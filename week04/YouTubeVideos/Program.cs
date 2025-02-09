class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        public Directory directory =  new Directory
        { 
            video1 = new Directory
            video2 = new Directory
            video3 = new Directory
        };

    }
    public class CommentDirectory : Directory
    {
        public Comment comment1 = new Comment
        comment2 = new Comment
        comment3 = new Comment
    }

    public class Author : CommentDirectory
    {
        public string Name { get; set; }
    }       
    public class Video : Author
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class VideoDuration : Video 
    {
        public int Length { get; set; }
    }
    
return (Video, CommentDirectory, VideoDuration);





}

