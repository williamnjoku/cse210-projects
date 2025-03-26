using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Introduction to C#", "John", 600);
        Video v2 = new Video("Object-Oriented Programming", "William", 1200);
        Video v3 = new Video("Advanced C# Features", "Alice Johnson", 900);

        v1._comments.Add(new Comment("Mike", "Great tutorial!"));
        v1._comments.Add(new Comment("Sarah", "This really helped me understand C#. Thanks!"));
        v1._comments.Add(new Comment("David", "Awesome content, keep it up!"));


        v2._comments.Add(new Comment("Emma", "Clear and concise explanation."));
        v2._comments.Add(new Comment("James", "Can you do a video on interfaces?"));
        v2._comments.Add(new Comment("Sophia", "I love how you teach!"));

        v3._comments.Add(new Comment("Liam", "Wow! I didn’t know about delegates before."));
        v3._comments.Add(new Comment("Olivia", "This is so well explained!"));
        v3._comments.Add(new Comment("Noah", "I'm excited to try these features!"));

        List<Video> videos = new List<Video>{v1,v2,v3};
        
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }

    }
}