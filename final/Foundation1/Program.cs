using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("First video", "Author1", 120);
        video1.Comments.Add(new Comment("User1", "Great video!"));
        video1.Comments.Add(new Comment("User2", "I liked it too"));
        video1.Comments.Add(new Comment("User3", "Awesome content"));
        videos.Add(video1);

        Video video2 = new Video("Second video", "Author2", 180);
        video2.Comments.Add(new Comment("User4", "Interesting"));
        video2.Comments.Add(new Comment("User5", "Well done"));
        video2.Comments.Add(new Comment("User6", "I learned a lot"));
        videos.Add(video2);

        Video video3 = new Video("Third video", "Author3", 300);
        video3.Comments.Add(new Comment("User7", "Great work"));
        video3.Comments.Add(new Comment("User8", "Keep it up"));
        video3.Comments.Add(new Comment("User9", "Very helpful"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine("- " + comment.Name + ": " + comment.Text);
            }

            Console.WriteLine();
        }
    }
}
