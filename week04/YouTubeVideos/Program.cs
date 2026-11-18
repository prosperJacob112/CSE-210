using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Bake Bread", "Sam Lee", 620);
        video1.AddComment(new Comment("Mia", "This was easy to follow."));
        video1.AddComment(new Comment("Jordan", "I tried this recipe today."));
        video1.AddComment(new Comment("Alex", "Thanks for the tips!"));
        videos.Add(video1);

        Video video2 = new Video("Beginner Guitar Lesson", "Taylor Kim", 845);
        video2.AddComment(new Comment("Chris", "I learned a new chord."));
        video2.AddComment(new Comment("Riley", "Please make another lesson."));
        video2.AddComment(new Comment("Morgan", "Great explanation."));
        videos.Add(video2);

        Video video3 = new Video("Simple Garden Ideas", "Jamie Rivera", 530);
        video3.AddComment(new Comment("Avery", "I like these ideas."));
        video3.AddComment(new Comment("Drew", "This helped my garden."));
        video3.AddComment(new Comment("Casey", "Very useful video."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthSeconds()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(
                    $"{comment.GetCommenterName()}: {comment.GetCommentText()}");
            }

            Console.WriteLine();
        }
    }
}