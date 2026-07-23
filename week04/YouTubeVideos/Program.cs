using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Make Brazilian Cheese Bread", "Cooking with Ana", 512);
        video1.AddComment(new Comment("John", "I tried this recipe and it was amazing!"));
        video1.AddComment(new Comment("Maria", "Greetings from Brazil, this is the real deal."));
        video1.AddComment(new Comment("Kevin", "Mine came out flat, what did I do wrong?"));
        videos.Add(video1);

        Video video2 = new Video("Top 10 Soccer Goals of All Time", "Sports Central", 745);
        video2.AddComment(new Comment("Pedro", "Number 3 should have been number 1 for sure."));
        video2.AddComment(new Comment("Lucas", "Great list but where is Roberto Carlos?"));
        video2.AddComment(new Comment("Emily", "I don't even like soccer and this was fun to watch."));
        video2.AddComment(new Comment("Marcus", "The commentary on the last one gave me chills."));
        videos.Add(video2);

        Video video3 = new Video("Learn C# in 20 Minutes", "Code Academy", 1230);
        video3.AddComment(new Comment("Sarah", "This helped me so much with my homework, thanks!"));
        video3.AddComment(new Comment("Daniel", "Can you make one about classes next?"));
        video3.AddComment(new Comment("Amy", "Nice pacing, not too fast like other tutorials."));
        videos.Add(video3);

        Video video4 = new Video("My Trip to Yellowstone", "Travel Diaries", 903);
        video4.AddComment(new Comment("Rachel", "The geyser footage was incredible."));
        video4.AddComment(new Comment("Tom", "Adding this to my bucket list right now."));
        video4.AddComment(new Comment("Nina", "What camera do you use? The quality is great."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}
