using SocialFeed;

public class Program
{
    static void Main(string[] args)
    {
        TextPost a = new TextPost("A", "aaaaa");
        TextPost b = new TextPost("b", "bbbbbb");

        for (int i = 0; i < 3; i++)
        {
            a.Like();
        }

        Console.WriteLine(a.GetDescription());
        Console.WriteLine(a.Likes);
        Console.WriteLine(b.GetDescription());
        Console.WriteLine(b.Likes);
        ImagePost img1 = new ImagePost("c", 3);
        for (int i =0;i<5; i++)
        {
            img1.Like();
        }
        Console.WriteLine(img1.Score());
        Console.WriteLine(img1.GetDescription());
        ImagePost img2 = new ImagePost("D", 15);
        Console.WriteLine(img2.GetDescription());

        PollPost poll1 = new PollPost("E");
        poll1.Like();
        poll1.Like();
        for(int i  =0;i < 4; i++)
        {
            poll1.Vote();
        }
        poll1.Close();
        Console.WriteLine(poll1.Like());
        Console.WriteLine(poll1.Vote());
        Console.WriteLine(poll1.GetDescription());
        Console.WriteLine(poll1.Score());
    }
}