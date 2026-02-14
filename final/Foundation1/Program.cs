using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();
        Video video4 = new Video();
        video1._title = "How to Chop an Onion";
        video1._author = "Cooking Basics with John";
        video1._length = 120;
        video1._comments = 
        [
            new Comment("JohnSmith1009","Very Useful."),
            new Comment("CantThinkOfAUsername","Would this also work with a 100lb- onion?"),
            new Comment("1234QWERTY","Who doesn't knnow this already"),
            new Comment("TheRealBoiler","Straight to the point - love it")
        ];
        video2._title = "Minecraft Funny Moments part 3";
        video2._author = "ItzCrackerz";
        video2._length = 900;
        video2._comments = 
        [
            new Comment("JohnSmith1009","Very Funny"),
            new Comment("1234QWERTY","5:09 bro really said 'lalalala' :skull:"),
            new Comment("DreamFanz12","Why did bro jump off 2:33"),
            new Comment("DreamFanz13","is he blind? 6:04")
        ];
        video3._title = "The History of Mario";
        video3._author = "Red Cloud";
        video3._length = 2400;
        video3._comments = 
        [
            new Comment("JohnSmith1009","Very Informative"),
            new Comment("NintendoOverXbox","12:26 I thought I new everything about this game, but I guess you learn somehting new everyday"),
            new Comment("ApplePieFan65","Never thought I would be watching a video about the History of Mario at 2am instead of doing my homework"),
            new Comment("DreamFanz12","15:59 LUIGIIII")
        ];
        video4._title = "IDK";
        video4._author = "JohnSmith1009";
        video4._length = 45;
        video4._comments = 
        [
            new Comment("JohnSmith1009","Very ... IDK"),
            new Comment("ApplePieFan65","Is this referncing something?"),
            new Comment("ApplePieFan65","??????????"),
            new Comment("TheRealBoiler","You just earned yourself a like")
        ];

        List <Video> videos = [video1, video2, video3, video4];

        foreach(Video video in videos)
        {
            Console.WriteLine($"\nTitle: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length}");
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach(Comment comment in video._comments)
            {
                Console.WriteLine($"\n{comment._name}:");
                Console.WriteLine($"  “{comment._text}”");
            }
        }
    }
}