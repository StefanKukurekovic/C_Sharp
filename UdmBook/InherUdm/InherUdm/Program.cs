using System;

namespace InherUdm
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thank you for birthday wishes, bitches!", true, "xoxo Gossip Girl");
            Post post2 = new Post("Oh btw, tonight party at my place!", false, "xoxo GG");
            post1.PrintConsole();
            post2.PrintConsole();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(post1.ToString());
            Console.WriteLine(post2.ToString());

            ImagePost imgOne = new ImagePost("Check out my new shoes", "Stefan Kuurekovic", "https://images.com/shoes", true);

            Console.WriteLine(imgOne.ToString());
        }
    }
}
