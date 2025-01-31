public class Video

public class YouTubeVideos
{
    firstvideo = newvideo[0];
    secondvideo = newvideo[1];
    thirdvideo = newvideo[2];
}

{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Video()
    {
        _title : string(private)
        _length: int(private)
        _author : string(private)
        _comments : List<comment>(private)
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _length = length;
        _author = author;

        _comments = new List<comment>();

        _newComments.Add(title, author, length, comments);
        return newComments
    }
}
