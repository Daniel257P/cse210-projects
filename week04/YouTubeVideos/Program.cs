using System;

class Program
{
    static void Main(string[] args)
    {
        
        Video video1 = new Video("My First Video", "Daniel", 120);
        Video video2 = new Video("Learning C#", "Maria", 300); 
        Video video3 = new Video("Travel Vlog", "John", 240);

        video1.Comments.Add(new Comment("Alex", "Great video!"));
        video1.Comments.Add(new Comment("Sam", "Very helpful!")); 
        video1.Comments.Add(new Comment("Luna", "Nice explanation!"));

        video2.Comments.Add(new Comment("Mike", "Awesome tutorial!")); 
        video2.Comments.Add(new Comment("Sara", "I learned a lot")); 
        video2.Comments.Add(new Comment("Leo", "Thanks for sharing")); 

        video3.Comments.Add(new Comment("Nina", "Love this vlog")); 
        video3.Comments.Add(new Comment("Chris", "Cool places!")); 
        video3.Comments.Add(new Comment("Emma", "Amazing shots"));


        List<Video> videos = new List<Video>(); 
        videos.Add(video1); 
        videos.Add(video2); 
        videos.Add(video3);

        foreach (Video video in videos) 
        { 
            video.Display(); Console.WriteLine();
        }

    }
}