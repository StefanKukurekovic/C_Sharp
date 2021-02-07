using System;

namespace InherUdm
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoPost videoPost = new VideoPost("Hey, check my new YouTube video. Hope you like it.", "Stefan Kukurekovic", true, "http://youtube.com/kukabgd/new_year_resolutions", 5);
            videoPost.Play();
            Console.ReadKey();
            videoPost.Stop();
           
        }

        
    }
}
