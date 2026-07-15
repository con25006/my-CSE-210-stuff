using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine("This is the Abstraction with YouTube Videos program.");

        // Video 1 and its comments
        
        Comment vid1comment1 = new Comment();
        vid1comment1._commenter = "San Diego Zoo";
        vid1comment1._commentText = "We're so honored that the first ever YouTube video was filmed here!";

        Comment vid1comment2 = new Comment();
        vid1comment2._commenter = "kedsarama";
        vid1comment2._commentText = "Honestly so glad to hear that Jawed agrees that removing dislikes is stupid.";

        Comment vid1comment3 = new Comment();
        vid1comment3._commenter = "jawed";
        vid1comment3._commentText = "Hello";

        List<Comment> commentList1 = new List<Comment>(){vid1comment1,vid1comment2,vid1comment3};

        Video video1 = new Video("Me at the zoo","jawed",19,commentList1);
        
        video1.Display();

        // Video 2 and its comments

        Comment vid2comment1 = new Comment();
        vid2comment1._commenter = "GooTheMighty";
        vid2comment1._commentText = "It never occurred to me until now that the heartbeat in the Telltale Heart\n  was probably just the killer's own heartbeat. He was the one panicked\n  and afraid, in spite of lying to himself.";

        Comment vid2comment2 = new Comment();
        vid2comment2._commenter = "weeklyfont";
        vid2comment2._commentText = "I think it's really worth revisiting Poe and Shakespeare and basically\n  anything else that has been ruined by school when you are older in life.\n  Not only do I think it's easier to appreciate these when you're a bit older,\n  but when you can read them without the pressure of a stupid quiz at the\n  end of it I think anyone would be more receptive.";

        Comment vid2comment3 = new Comment();
        vid2comment3._commenter = "TravTravRA";
        vid2comment3._commentText = "That thumbnail to video transition may be the most unsettling thing that\n  I will forget in about 2 hours then remember while working at the gas\n  station unwillingly that will put me slightly on edge for half the night on YouTube,\n  genuinely amazing concept";

        List<Comment> commentList2 = new List<Comment>(){vid2comment1,vid2comment2,vid2comment3};

        Video video2 = new Video("A Beautiful Horror Game","Vote 4 Holt",8293,commentList2);

        // Video 2 and its comments

        Comment vid3comment1 = new Comment();
        vid3comment1._commenter = "kohav-musar";
        vid3comment1._commentText = "I have never been more stressed in my life seeing a man checking for a typo";

        Comment vid3comment2 = new Comment();
        vid3comment2._commenter = "maxgaming5225";
        vid3comment2._commentText = "This game looks more complicated than running a nuclear reactor";

        Comment vid3comment3 = new Comment();
        vid3comment3._commenter = "saviorbob";
        vid3comment3._commentText = "I can't believe Shrimp Number Eleven was the origami killer";

        List<Comment> commentList3 = new List<Comment>(){vid3comment1,vid3comment2,vid3comment3};

        Video video3 = new Video("The Most Immersive Horror Game Ever Made","Vote 4 Holt",8220,commentList3);
        
        video1.Display();
        video2.Display();
        video3.Display();
    }
}