using System;
using System.Collections.Generic;
using System.Text;

namespace InherUdm
{
    class Post
    {
        private static int currentPostId;

        // properties
        protected int id { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        // Default constructor

        public Post()
        {
            id = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Stefan Kukurekovic";
        }

        public Post(string title, bool isPublic, string sendByName)
        {
            this.id = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByName;
            this.IsPublic = isPublic;
        }

        protected int GetNextId()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.id, this.Title, this.SendByUsername);
        }

        public void PrintConsole()
        {
            Console.WriteLine("ID: {0} \nTitle: {1} \nUser: {2} \nIs Public: {3}", this.id, this.Title, this.SendByUsername, this.IsPublic);
        }
    }
}
