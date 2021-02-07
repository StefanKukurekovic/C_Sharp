using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace InherUdm
{
    class VideoPost : Post
    {
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;
        public string VideoURL { get; set; }
        public int Length { get; set; }

        public VideoPost() { }
        public VideoPost(string title, string sendByUsername, bool isPublic, string videoUrl, int length)
        {
            this.id = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = IsPublic;

            this.VideoURL = videoUrl;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                Console.WriteLine("Playing...");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }

        }

        public void Stop()
        {
            Console.WriteLine("Stopped at {0}", currDuration);
            currDuration = 0;
            timer.Dispose();
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - length: {3} min - by {4}", this.id, this.Title, this.VideoURL, this.Length, this.SendByUsername);
        }
      

    }
}
