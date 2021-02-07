using System;
using System.Collections.Generic;
using System.Text;

namespace InherUdm
{
    class ImagePost:Post
    {
        public string ImageUrl { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.id = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            this.ImageUrl = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}, {3}", this.id, this.Title, this.SendByUsername, this.ImageUrl);
        }
    }
}
